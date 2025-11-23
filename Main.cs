using ColorChanger.Controls;
using ColorChanger.Extensions;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace ColorChanger
{
    public partial class colorChangerMain : Form
    {
        ColorSubstitutionFilter filterData = new ColorSubstitutionFilter();

        private bool Dragging;
        private int xPos;
        private int yPos;

        public colorChangerMain()
        {
            InitializeComponent();

            colorChangerMain_statusStrip.SizingGrip = false;

            this.colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display.MouseWheel += new MouseEventHandler(this.colorChangerGroupBox02PixelBox01_MouseWheel);

            foreach (InterpolationMode value in Enum.GetValues(typeof(InterpolationMode)))
            {
                if (value != InterpolationMode.Invalid)
                {
                    colorChangerMain_panel_imageControl_comboBox_interpolationMode.Items.Add(value);
                }
            }
        }

        /// ColorChanger Mouse Handler 
        private void PixelBoxMouseUpEventHandler(object sender, MouseEventArgs e)
        {
            if (sender is PixelBox)
            {
                PixelBox eventSource = (PixelBox)sender;

                using (Bitmap bmpSource = new Bitmap(eventSource.Width, eventSource.Height))
                {
                    colorChangerMain_groupBox_original_panel_canvas_pixelBox_display.DrawToBitmap(bmpSource, new Rectangle(0, 0, eventSource.Width, eventSource.Height));
                    colorChangerMain_panel_imageControl_panel_originalColorPreview.BackColor = bmpSource.GetPixel(e.X, e.Y);
                }

                ApplyFilter();
            }
        }

        private void colorChangerGroupBox02PixelBox01_MouseWheel(object sender, MouseEventArgs e)
        {
            var pixelBox = (PixelBox)sender;

            if (e.Delta > 0)
            {
                pixelBox.Zoom *= 1.1f; // Zoom in
            }
            else
            {
                pixelBox.Zoom /= 1.1f; // Zoom out
            }

            #region Old Code Removed, But Saved
            /*
            if (e.Delta > 0)
            {

                colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display.Width = colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display.Width + 25;
                colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display.Height = colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display.Height + 25;
            }
            else
            {
                colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display.Width = colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display.Width - 25;
                colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display.Height = colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display.Height - 25;
            }
            */
            #endregion
        }

        private void colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display_MouseMove(object sender, MouseEventArgs e)
        {
            Control c = sender as Control;

            if (Dragging && c != null)
            {
                int maxX = colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display.Size.Width * -1 + colorChangerMain_groupBox_custom_panel_canvas.Size.Width;
                int maxY = colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display.Size.Height * -1 + colorChangerMain_groupBox_custom_panel_canvas.Size.Height;

                int newposLeft = e.X + c.Left - xPos;
                int newposTop = e.Y + c.Top - yPos;

                if (newposTop > 0)
                {
                    newposTop = 0;
                }
                if (newposLeft > 0)
                {
                    newposLeft = 0;
                }
                if (newposLeft < maxX)
                {
                    newposLeft = maxX;
                }
                if (newposTop < maxY)
                {
                    newposTop = maxY;
                }
                c.Top = newposTop;
                c.Left = newposLeft;
            }
        }

        private void colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                Dragging = true;
                xPos = e.X;
                yPos = e.Y;
            }
        }

        /// ColorChanger Button Logic
        private void colorChangerMain_button_loadOriginalImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Specify a Source file name and file path";
            ofd.Filter = "Bitmap Images(*.bmp)|*.bmp"; // |Jpeg Images(*.jpg)|*.jpg|Png Images(*.png)|*.png

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(ofd.FileName);
                Bitmap sourceBitmap = new Bitmap(streamReader.BaseStream);
                streamReader.Close();

                colorChangerMain_groupBox_original_panel_canvas_pixelBox_display.Image = sourceBitmap.Format32bppArgbCopy();

                ApplyFilter();
            }
        }

        private void colorChangerMain_button_replaceOriginalwithCustom_Click(object sender, EventArgs e)
        {
            colorChangerMain_groupBox_original_panel_canvas_pixelBox_display.Image = ((Bitmap)colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display.Image).Format32bppArgbCopy();
        }

        private void colorChangerMain_button_saveCustomImage_Click(object sender, EventArgs e)
        {
            if (colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display.Image != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Specify a file name and file path";
                sfd.Filter = "Bitmap Images(*.bmp)|*.bmp|Png Images(*.png)|*.png";

                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string fileExtension = Path.GetExtension(sfd.FileName).ToUpper();
                    ImageFormat imgFormat = ImageFormat.Png;

                    if (fileExtension == "BMP")
                    {
                        imgFormat = ImageFormat.Bmp;
                    }
                    else if (fileExtension == "PNG")
                    {
                        imgFormat = ImageFormat.Png;
                    }

                    StreamWriter streamWriter = new StreamWriter(sfd.FileName, false);
                    colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display.Image.Save(streamWriter.BaseStream, imgFormat);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
            }
        }

        /// ColorChanger Color Preview
        private void ShowColorDialogButtonClickEventHandler(object sender, EventArgs e)
        {
            using (ColorDialog colorDlg = new ColorDialog())
            {
                colorDlg.AllowFullOpen = true;
                colorDlg.AnyColor = true;
                colorDlg.FullOpen = true;

                if (sender == colorChangerMain_panel_imageControl_button_selectOriginalColor)
                {
                    colorDlg.Color = colorChangerMain_panel_imageControl_panel_originalColorPreview.BackColor;
                }
                else if (sender == colorChangerMain_panel_imageControl_button_selectReplacementColor)
                {
                    colorDlg.Color = colorChangerMain_panel_imageControl_panel_replacementColorPreview.BackColor;
                }

                if (colorDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (sender == colorChangerMain_panel_imageControl_button_selectOriginalColor)
                    {
                        colorChangerMain_panel_imageControl_panel_originalColorPreview.BackColor = colorDlg.Color;
                    }
                    else if (sender == colorChangerMain_panel_imageControl_button_selectReplacementColor)
                    {
                        colorChangerMain_panel_imageControl_panel_replacementColorPreview.BackColor = colorDlg.Color;
                    }

                    ApplyFilter();
                }
            }
        }

        private void colorChangerMain_panel_imageControl_button_selectOriginalColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDlg = new ColorDialog())
            {
                colorDlg.AllowFullOpen = true;
                colorDlg.AnyColor = true;
                colorDlg.FullOpen = true;

                if (sender == colorChangerMain_panel_imageControl_button_selectOriginalColor)
                {
                    colorDlg.Color = colorChangerMain_panel_imageControl_panel_originalColorPreview.BackColor;
                }
                else if (sender == colorChangerMain_panel_imageControl_button_selectReplacementColor)
                {
                    colorDlg.Color = colorChangerMain_panel_imageControl_panel_replacementColorPreview.BackColor;
                }

                if (colorDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (sender == colorChangerMain_panel_imageControl_button_selectOriginalColor)
                    {
                        colorChangerMain_panel_imageControl_panel_originalColorPreview.BackColor = colorDlg.Color;
                    }
                    else if (sender == colorChangerMain_panel_imageControl_button_selectReplacementColor)
                    {
                        colorChangerMain_panel_imageControl_panel_replacementColorPreview.BackColor = colorDlg.Color;
                    }

                    ApplyFilter();
                }
            }
        }

        private void colorChangerMain_panel_imageControl_button_selectReplacementColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDlg = new ColorDialog())
            {
                colorDlg.AllowFullOpen = true;
                colorDlg.AnyColor = true;
                colorDlg.FullOpen = true;

                if (sender == colorChangerMain_panel_imageControl_button_selectOriginalColor)
                {
                    colorDlg.Color = colorChangerMain_panel_imageControl_panel_originalColorPreview.BackColor;
                }
                else if (sender == colorChangerMain_panel_imageControl_button_selectReplacementColor)
                {
                    colorDlg.Color = colorChangerMain_panel_imageControl_panel_replacementColorPreview.BackColor;
                }

                if (colorDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (sender == colorChangerMain_panel_imageControl_button_selectOriginalColor)
                    {
                        colorChangerMain_panel_imageControl_panel_originalColorPreview.BackColor = colorDlg.Color;
                    }
                    else if (sender == colorChangerMain_panel_imageControl_button_selectReplacementColor)
                    {
                        colorChangerMain_panel_imageControl_panel_replacementColorPreview.BackColor = colorDlg.Color;
                    }

                    ApplyFilter();
                }
            }
        }

        /// ColorChanger Image Rendering
        private void colorChangerMain_panel_imageControl_comboBox_interpolationMode_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var mode = (InterpolationMode)(sender as ComboBox).SelectedItem;

            colorChangerMain_groupBox_original_panel_canvas_pixelBox_display.InterpolationMode = mode;
            colorChangerMain_groupBox_original_panel_canvas_pixelBox_display.Invalidate();

            colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display.InterpolationMode = mode;
            colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display.Invalidate();
        }

        private void colorChangerMain_panel_imageControl_button_mirrorCustomImage_Click(object sender, EventArgs e)
        {
            if (colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display.Image != null)
            {
                Image flippedImage = FlipImage.MirrorImage(colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display.Image, true, false);

                colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display.Image.Dispose();
                colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display.Image = flippedImage;

                colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display.Image = colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display.Image;
            }
        }

        private void colorChangerMain_panel_imageControl_trackBar_threshold_ValueChanged(object sender, EventArgs e)
        {
            colorChangerMain_panel_imageControl_label_threshold.Text = "Threshold: " + colorChangerMain_panel_imageControl_trackBar_threshold.Value.ToString() + "%";

            ApplyFilter();
        }

        private void ApplyFilter()
        {
            if (colorChangerMain_groupBox_original_panel_canvas_pixelBox_display.Image != null)
            {
                filterData.SourceColor = colorChangerMain_panel_imageControl_panel_originalColorPreview.BackColor;
                filterData.ThresholdValue = (byte)(255.0f / 100.0f * (float)colorChangerMain_panel_imageControl_trackBar_threshold.Value);
                filterData.NewColor = colorChangerMain_panel_imageControl_panel_replacementColorPreview.BackColor;

                colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display.Image = ((Bitmap)colorChangerMain_groupBox_original_panel_canvas_pixelBox_display.Image).ColorSubstitution(filterData);

                colorChangerMain_panel_imageControl.Enabled = true;
                colorChangerMain_button_saveCustomImage.Enabled = true;
                colorChangerMain_button_replaceOriginalwithCustom.Enabled = true;
            }
        }
    }
}
