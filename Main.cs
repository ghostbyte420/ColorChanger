using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

using ColorChanger.Controls;
using ColorChanger.Extensions;

namespace ColorChanger
{
    public partial class colorChangerMain : Form
    {
        ColorSubstitutionFilter filterData = new ColorSubstitutionFilter();
        private bool Dragging;
        private int xPos;
        private int yPos;
        private Bitmap originalImage;

        public colorChangerMain()
        {
            InitializeComponent();
            colorChangerMain_statusStrip.SizingGrip = false;
            this.colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display.MouseWheel += new MouseEventHandler(this.colorChangerGroupBox02PixelBox01_MouseWheel);
            this.colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display.MouseDown += new MouseEventHandler(this.colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display_MouseDown);
            this.colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display.MouseMove += new MouseEventHandler(this.colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display_MouseMove);
            this.colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display.MouseUp += new MouseEventHandler(this.colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display_MouseUp);

            foreach (InterpolationMode value in Enum.GetValues(typeof(InterpolationMode)))
            {
                if (value != InterpolationMode.Invalid)
                {
                    colorChangerMain_panel_imageControl_comboBox_interpolationMode.Items.Add(value);
                }
            }
        }

        private void ResetView()
        {
            colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display.OffsetX = 0;
            colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display.OffsetY = 0;
            colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display.Zoom = 1.0f;
            colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display.Invalidate();
        }

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
                pixelBox.Zoom *= 1.1f;
            }
            else
            {
                pixelBox.Zoom /= 1.1f;
            }
            pixelBox.Invalidate();
        }

        private void colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                int deltaX = e.X - xPos;
                int deltaY = e.Y - yPos;

                // Update the offset directly
                colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display.OffsetX += deltaX;
                colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display.OffsetY += deltaY;

                // Update the starting position for the next movement
                xPos = e.X;
                yPos = e.Y;

                colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display.Invalidate();
            }
        }

        private void colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
            colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display.Cursor = Cursors.Default;
        }

        private void colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                ResetView();
            }
            else if (e.Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control)
            {
                Dragging = true;
                xPos = e.X;
                yPos = e.Y;
                colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display.Cursor = Cursors.SizeAll;
            }
        }

        private void colorChangerMain_button_loadOriginalImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Specify a Source file name and file path";
            ofd.Filter = "Bitmap Images(*.bmp)|*.bmp";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(ofd.FileName);
                originalImage = new Bitmap(streamReader.BaseStream);
                streamReader.Close();
                colorChangerMain_groupBox_original_panel_canvas_pixelBox_display.Image = originalImage.Format32bppArgbCopy();
                ResetView();
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
            ShowColorDialogButtonClickEventHandler(colorChangerMain_panel_imageControl_button_selectOriginalColor, e);
        }

        private void colorChangerMain_panel_imageControl_button_selectReplacementColor_Click(object sender, EventArgs e)
        {
            ShowColorDialogButtonClickEventHandler(colorChangerMain_panel_imageControl_button_selectReplacementColor, e);
        }

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
                colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display.Invalidate();
            }
        }

        private void colorChangerMain_panel_imageControl_trackBar_threshold_ValueChanged(object sender, EventArgs e)
        {
            colorChangerMain_statusStrip_label_imageThreshold.Text = "Image Threshold: " + colorChangerMain_panel_imageControl_trackBar_threshold.Value.ToString() + "%";
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
