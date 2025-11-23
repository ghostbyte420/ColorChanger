namespace ColorChanger
{
    partial class colorChangerMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            colorChangerMain_groupBox_original_panel_canvas = new Panel();
            colorChangerMain_groupBox_original_panel_canvas_pixelBox_display = new ColorChanger.Controls.PixelBox();
            colorChangerMain_groupBox_original = new GroupBox();
            colorChangerMain_panel_imageControl = new Panel();
            colorChangerMain_panel_imageControl_label_threshold = new Label();
            colorChangerMain_panel_imageControl_trackBar_threshold = new TrackBar();
            colorChangerMain_panel_imageControl_button_mirrorCustomImage = new Button();
            colorChangerMain_panel_imageControl_button_selectReplacementColor = new Button();
            colorChangerMain_panel_imageControl_button_selectOriginalColor = new Button();
            colorChangerMain_panel_imageControl_panel_replacementColorPreview = new Panel();
            colorChangerMain_panel_imageControl_panel_originalColorPreview = new Panel();
            colorChangerMain_panel_imageControl_label_interpolationMode = new Label();
            colorChangerMain_panel_imageControl_comboBox_interpolationMode = new ComboBox();
            colorChangerMain_groupBox_custom = new GroupBox();
            colorChangerMain_groupBox_custom_panel_canvas = new Panel();
            colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display = new ColorChanger.Controls.PixelBox();
            colorChangerMain_statusStrip = new StatusStrip();
            colorChangerMain_statusStrip_label_version = new ToolStripStatusLabel();
            colorChangerMain_statusStrip_label_lastUpdated = new ToolStripStatusLabel();
            colorChangerMain_button_loadOriginalImage = new Button();
            colorChangerMain_button_saveCustomImage = new Button();
            colorChangerMain_button_replaceOriginalwithCustom = new Button();
            colorChangerMain_groupBox_original_panel_canvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)colorChangerMain_groupBox_original_panel_canvas_pixelBox_display).BeginInit();
            colorChangerMain_groupBox_original.SuspendLayout();
            colorChangerMain_panel_imageControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)colorChangerMain_panel_imageControl_trackBar_threshold).BeginInit();
            colorChangerMain_groupBox_custom.SuspendLayout();
            colorChangerMain_groupBox_custom_panel_canvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display).BeginInit();
            colorChangerMain_statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // colorChangerMain_groupBox_original_panel_canvas
            // 
            colorChangerMain_groupBox_original_panel_canvas.Controls.Add(colorChangerMain_groupBox_original_panel_canvas_pixelBox_display);
            colorChangerMain_groupBox_original_panel_canvas.Location = new Point(7, 24);
            colorChangerMain_groupBox_original_panel_canvas.Name = "colorChangerMain_groupBox_original_panel_canvas";
            colorChangerMain_groupBox_original_panel_canvas.Size = new Size(233, 220);
            colorChangerMain_groupBox_original_panel_canvas.TabIndex = 0;
            // 
            // colorChangerMain_groupBox_original_panel_canvas_pixelBox_display
            // 
            colorChangerMain_groupBox_original_panel_canvas_pixelBox_display.Dock = DockStyle.Fill;
            colorChangerMain_groupBox_original_panel_canvas_pixelBox_display.Location = new Point(0, 0);
            colorChangerMain_groupBox_original_panel_canvas_pixelBox_display.Name = "colorChangerMain_groupBox_original_panel_canvas_pixelBox_display";
            colorChangerMain_groupBox_original_panel_canvas_pixelBox_display.Size = new Size(233, 220);
            colorChangerMain_groupBox_original_panel_canvas_pixelBox_display.TabIndex = 0;
            colorChangerMain_groupBox_original_panel_canvas_pixelBox_display.TabStop = false;
            // 
            // colorChangerMain_groupBox_original
            // 
            colorChangerMain_groupBox_original.Controls.Add(colorChangerMain_groupBox_original_panel_canvas);
            colorChangerMain_groupBox_original.Font = new Font("Comic Sans MS", 11F);
            colorChangerMain_groupBox_original.Location = new Point(7, 10);
            colorChangerMain_groupBox_original.Name = "colorChangerMain_groupBox_original";
            colorChangerMain_groupBox_original.Size = new Size(246, 252);
            colorChangerMain_groupBox_original.TabIndex = 1;
            colorChangerMain_groupBox_original.TabStop = false;
            colorChangerMain_groupBox_original.Text = "Original Image";
            // 
            // colorChangerMain_panel_imageControl
            // 
            colorChangerMain_panel_imageControl.Controls.Add(colorChangerMain_panel_imageControl_label_threshold);
            colorChangerMain_panel_imageControl.Controls.Add(colorChangerMain_panel_imageControl_trackBar_threshold);
            colorChangerMain_panel_imageControl.Controls.Add(colorChangerMain_panel_imageControl_button_mirrorCustomImage);
            colorChangerMain_panel_imageControl.Controls.Add(colorChangerMain_panel_imageControl_button_selectReplacementColor);
            colorChangerMain_panel_imageControl.Controls.Add(colorChangerMain_panel_imageControl_button_selectOriginalColor);
            colorChangerMain_panel_imageControl.Controls.Add(colorChangerMain_panel_imageControl_panel_replacementColorPreview);
            colorChangerMain_panel_imageControl.Controls.Add(colorChangerMain_panel_imageControl_panel_originalColorPreview);
            colorChangerMain_panel_imageControl.Controls.Add(colorChangerMain_panel_imageControl_label_interpolationMode);
            colorChangerMain_panel_imageControl.Controls.Add(colorChangerMain_panel_imageControl_comboBox_interpolationMode);
            colorChangerMain_panel_imageControl.Location = new Point(260, 20);
            colorChangerMain_panel_imageControl.Name = "colorChangerMain_panel_imageControl";
            colorChangerMain_panel_imageControl.Size = new Size(225, 240);
            colorChangerMain_panel_imageControl.TabIndex = 2;
            // 
            // colorChangerMain_panel_imageControl_label_threshold
            // 
            colorChangerMain_panel_imageControl_label_threshold.AutoSize = true;
            colorChangerMain_panel_imageControl_label_threshold.Font = new Font("Comic Sans MS", 9.5F);
            colorChangerMain_panel_imageControl_label_threshold.Location = new Point(56, 218);
            colorChangerMain_panel_imageControl_label_threshold.Name = "colorChangerMain_panel_imageControl_label_threshold";
            colorChangerMain_panel_imageControl_label_threshold.Size = new Size(73, 18);
            colorChangerMain_panel_imageControl_label_threshold.TabIndex = 8;
            colorChangerMain_panel_imageControl_label_threshold.Text = "Threshold:";
            // 
            // colorChangerMain_panel_imageControl_trackBar_threshold
            // 
            colorChangerMain_panel_imageControl_trackBar_threshold.Location = new Point(5, 186);
            colorChangerMain_panel_imageControl_trackBar_threshold.Maximum = 100;
            colorChangerMain_panel_imageControl_trackBar_threshold.Minimum = 1;
            colorChangerMain_panel_imageControl_trackBar_threshold.Name = "colorChangerMain_panel_imageControl_trackBar_threshold";
            colorChangerMain_panel_imageControl_trackBar_threshold.Size = new Size(216, 45);
            colorChangerMain_panel_imageControl_trackBar_threshold.TabIndex = 7;
            colorChangerMain_panel_imageControl_trackBar_threshold.Value = 1;
            colorChangerMain_panel_imageControl_trackBar_threshold.ValueChanged += colorChangerMain_panel_imageControl_trackBar_threshold_ValueChanged;
            // 
            // colorChangerMain_panel_imageControl_button_mirrorCustomImage
            // 
            colorChangerMain_panel_imageControl_button_mirrorCustomImage.Font = new Font("Comic Sans MS", 9F);
            colorChangerMain_panel_imageControl_button_mirrorCustomImage.Location = new Point(63, 150);
            colorChangerMain_panel_imageControl_button_mirrorCustomImage.Name = "colorChangerMain_panel_imageControl_button_mirrorCustomImage";
            colorChangerMain_panel_imageControl_button_mirrorCustomImage.Size = new Size(158, 30);
            colorChangerMain_panel_imageControl_button_mirrorCustomImage.TabIndex = 6;
            colorChangerMain_panel_imageControl_button_mirrorCustomImage.Text = "Mirror Custom Image";
            colorChangerMain_panel_imageControl_button_mirrorCustomImage.UseVisualStyleBackColor = true;
            colorChangerMain_panel_imageControl_button_mirrorCustomImage.Click += colorChangerMain_panel_imageControl_button_mirrorCustomImage_Click;
            // 
            // colorChangerMain_panel_imageControl_button_selectReplacementColor
            // 
            colorChangerMain_panel_imageControl_button_selectReplacementColor.Font = new Font("Comic Sans MS", 9F);
            colorChangerMain_panel_imageControl_button_selectReplacementColor.Location = new Point(64, 110);
            colorChangerMain_panel_imageControl_button_selectReplacementColor.Name = "colorChangerMain_panel_imageControl_button_selectReplacementColor";
            colorChangerMain_panel_imageControl_button_selectReplacementColor.Size = new Size(158, 30);
            colorChangerMain_panel_imageControl_button_selectReplacementColor.TabIndex = 5;
            colorChangerMain_panel_imageControl_button_selectReplacementColor.Text = "Select Replacement Color";
            colorChangerMain_panel_imageControl_button_selectReplacementColor.UseVisualStyleBackColor = true;
            colorChangerMain_panel_imageControl_button_selectReplacementColor.Click += colorChangerMain_panel_imageControl_button_selectReplacementColor_Click;
            // 
            // colorChangerMain_panel_imageControl_button_selectOriginalColor
            // 
            colorChangerMain_panel_imageControl_button_selectOriginalColor.Font = new Font("Comic Sans MS", 9F);
            colorChangerMain_panel_imageControl_button_selectOriginalColor.Location = new Point(64, 68);
            colorChangerMain_panel_imageControl_button_selectOriginalColor.Name = "colorChangerMain_panel_imageControl_button_selectOriginalColor";
            colorChangerMain_panel_imageControl_button_selectOriginalColor.Size = new Size(158, 30);
            colorChangerMain_panel_imageControl_button_selectOriginalColor.TabIndex = 4;
            colorChangerMain_panel_imageControl_button_selectOriginalColor.Text = "Select Color To Replace";
            colorChangerMain_panel_imageControl_button_selectOriginalColor.UseVisualStyleBackColor = true;
            colorChangerMain_panel_imageControl_button_selectOriginalColor.Click += colorChangerMain_panel_imageControl_button_selectOriginalColor_Click;
            // 
            // colorChangerMain_panel_imageControl_panel_replacementColorPreview
            // 
            colorChangerMain_panel_imageControl_panel_replacementColorPreview.Location = new Point(5, 111);
            colorChangerMain_panel_imageControl_panel_replacementColorPreview.Name = "colorChangerMain_panel_imageControl_panel_replacementColorPreview";
            colorChangerMain_panel_imageControl_panel_replacementColorPreview.Size = new Size(53, 27);
            colorChangerMain_panel_imageControl_panel_replacementColorPreview.TabIndex = 3;
            // 
            // colorChangerMain_panel_imageControl_panel_originalColorPreview
            // 
            colorChangerMain_panel_imageControl_panel_originalColorPreview.Location = new Point(5, 69);
            colorChangerMain_panel_imageControl_panel_originalColorPreview.Name = "colorChangerMain_panel_imageControl_panel_originalColorPreview";
            colorChangerMain_panel_imageControl_panel_originalColorPreview.Size = new Size(53, 27);
            colorChangerMain_panel_imageControl_panel_originalColorPreview.TabIndex = 2;
            // 
            // colorChangerMain_panel_imageControl_label_interpolationMode
            // 
            colorChangerMain_panel_imageControl_label_interpolationMode.AutoSize = true;
            colorChangerMain_panel_imageControl_label_interpolationMode.BackColor = Color.Transparent;
            colorChangerMain_panel_imageControl_label_interpolationMode.Font = new Font("Comic Sans MS", 9.5F);
            colorChangerMain_panel_imageControl_label_interpolationMode.Location = new Point(49, 14);
            colorChangerMain_panel_imageControl_label_interpolationMode.Name = "colorChangerMain_panel_imageControl_label_interpolationMode";
            colorChangerMain_panel_imageControl_label_interpolationMode.Size = new Size(125, 18);
            colorChangerMain_panel_imageControl_label_interpolationMode.TabIndex = 1;
            colorChangerMain_panel_imageControl_label_interpolationMode.Text = "Interpolation Mode";
            // 
            // colorChangerMain_panel_imageControl_comboBox_interpolationMode
            // 
            colorChangerMain_panel_imageControl_comboBox_interpolationMode.FormattingEnabled = true;
            colorChangerMain_panel_imageControl_comboBox_interpolationMode.Location = new Point(4, 34);
            colorChangerMain_panel_imageControl_comboBox_interpolationMode.Name = "colorChangerMain_panel_imageControl_comboBox_interpolationMode";
            colorChangerMain_panel_imageControl_comboBox_interpolationMode.Size = new Size(217, 23);
            colorChangerMain_panel_imageControl_comboBox_interpolationMode.TabIndex = 0;
            colorChangerMain_panel_imageControl_comboBox_interpolationMode.SelectionChangeCommitted += colorChangerMain_panel_imageControl_comboBox_interpolationMode_SelectionChangeCommitted;
            // 
            // colorChangerMain_groupBox_custom
            // 
            colorChangerMain_groupBox_custom.Controls.Add(colorChangerMain_groupBox_custom_panel_canvas);
            colorChangerMain_groupBox_custom.Font = new Font("Comic Sans MS", 11F);
            colorChangerMain_groupBox_custom.Location = new Point(492, 10);
            colorChangerMain_groupBox_custom.Name = "colorChangerMain_groupBox_custom";
            colorChangerMain_groupBox_custom.Size = new Size(246, 252);
            colorChangerMain_groupBox_custom.TabIndex = 3;
            colorChangerMain_groupBox_custom.TabStop = false;
            colorChangerMain_groupBox_custom.Text = "Custom Image";
            // 
            // colorChangerMain_groupBox_custom_panel_canvas
            // 
            colorChangerMain_groupBox_custom_panel_canvas.Controls.Add(colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display);
            colorChangerMain_groupBox_custom_panel_canvas.Location = new Point(7, 24);
            colorChangerMain_groupBox_custom_panel_canvas.Name = "colorChangerMain_groupBox_custom_panel_canvas";
            colorChangerMain_groupBox_custom_panel_canvas.Size = new Size(233, 220);
            colorChangerMain_groupBox_custom_panel_canvas.TabIndex = 0;
            // 
            // colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display
            // 
            colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display.Dock = DockStyle.Fill;
            colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display.Location = new Point(0, 0);
            colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display.Name = "colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display";
            colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display.Size = new Size(233, 220);
            colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display.TabIndex = 0;
            colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display.TabStop = false;
            colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display.MouseDown += colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display_MouseDown;
            colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display.MouseMove += colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display_MouseMove;
            colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display.MouseUp += colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display_MouseUp;
            // 
            // colorChangerMain_statusStrip
            // 
            colorChangerMain_statusStrip.Font = new Font("Segoe UI", 11F);
            colorChangerMain_statusStrip.Items.AddRange(new ToolStripItem[] { colorChangerMain_statusStrip_label_version, colorChangerMain_statusStrip_label_lastUpdated });
            colorChangerMain_statusStrip.Location = new Point(0, 304);
            colorChangerMain_statusStrip.Name = "colorChangerMain_statusStrip";
            colorChangerMain_statusStrip.Size = new Size(745, 24);
            colorChangerMain_statusStrip.SizingGrip = false;
            colorChangerMain_statusStrip.TabIndex = 4;
            colorChangerMain_statusStrip.Text = "statusStrip1";
            // 
            // colorChangerMain_statusStrip_label_version
            // 
            colorChangerMain_statusStrip_label_version.Font = new Font("Segoe UI", 10F);
            colorChangerMain_statusStrip_label_version.Margin = new Padding(15, 3, 360, 2);
            colorChangerMain_statusStrip_label_version.Name = "colorChangerMain_statusStrip_label_version";
            colorChangerMain_statusStrip_label_version.Size = new Size(184, 19);
            colorChangerMain_statusStrip_label_version.Text = "version 5.0  |  Build 112225a";
            // 
            // colorChangerMain_statusStrip_label_lastUpdated
            // 
            colorChangerMain_statusStrip_label_lastUpdated.Font = new Font("Segoe UI", 10F);
            colorChangerMain_statusStrip_label_lastUpdated.Name = "colorChangerMain_statusStrip_label_lastUpdated";
            colorChangerMain_statusStrip_label_lastUpdated.Size = new Size(172, 19);
            colorChangerMain_statusStrip_label_lastUpdated.Text = "Last Updated: 11/22/2025";
            // 
            // colorChangerMain_button_loadOriginalImage
            // 
            colorChangerMain_button_loadOriginalImage.Font = new Font("Segoe UI", 9.5F);
            colorChangerMain_button_loadOriginalImage.Location = new Point(14, 265);
            colorChangerMain_button_loadOriginalImage.Name = "colorChangerMain_button_loadOriginalImage";
            colorChangerMain_button_loadOriginalImage.Size = new Size(233, 33);
            colorChangerMain_button_loadOriginalImage.TabIndex = 5;
            colorChangerMain_button_loadOriginalImage.Text = "Load Original Image";
            colorChangerMain_button_loadOriginalImage.UseVisualStyleBackColor = true;
            colorChangerMain_button_loadOriginalImage.Click += colorChangerMain_button_loadOriginalImage_Click;
            // 
            // colorChangerMain_button_saveCustomImage
            // 
            colorChangerMain_button_saveCustomImage.Font = new Font("Segoe UI", 9.5F);
            colorChangerMain_button_saveCustomImage.Location = new Point(499, 265);
            colorChangerMain_button_saveCustomImage.Name = "colorChangerMain_button_saveCustomImage";
            colorChangerMain_button_saveCustomImage.Size = new Size(233, 33);
            colorChangerMain_button_saveCustomImage.TabIndex = 6;
            colorChangerMain_button_saveCustomImage.Text = "Save Custom Image";
            colorChangerMain_button_saveCustomImage.UseVisualStyleBackColor = true;
            colorChangerMain_button_saveCustomImage.Click += colorChangerMain_button_saveCustomImage_Click;
            // 
            // colorChangerMain_button_replaceOriginalwithCustom
            // 
            colorChangerMain_button_replaceOriginalwithCustom.Font = new Font("Segoe UI", 9.5F);
            colorChangerMain_button_replaceOriginalwithCustom.Location = new Point(257, 265);
            colorChangerMain_button_replaceOriginalwithCustom.Name = "colorChangerMain_button_replaceOriginalwithCustom";
            colorChangerMain_button_replaceOriginalwithCustom.Size = new Size(233, 33);
            colorChangerMain_button_replaceOriginalwithCustom.TabIndex = 7;
            colorChangerMain_button_replaceOriginalwithCustom.Text = "← Replace Original with Custom";
            colorChangerMain_button_replaceOriginalwithCustom.UseVisualStyleBackColor = true;
            colorChangerMain_button_replaceOriginalwithCustom.Click += colorChangerMain_button_replaceOriginalwithCustom_Click;
            // 
            // colorChangerMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 328);
            Controls.Add(colorChangerMain_button_replaceOriginalwithCustom);
            Controls.Add(colorChangerMain_button_saveCustomImage);
            Controls.Add(colorChangerMain_button_loadOriginalImage);
            Controls.Add(colorChangerMain_statusStrip);
            Controls.Add(colorChangerMain_groupBox_custom);
            Controls.Add(colorChangerMain_panel_imageControl);
            Controls.Add(colorChangerMain_groupBox_original);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "colorChangerMain";
            Text = "Color Changer";
            colorChangerMain_groupBox_original_panel_canvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)colorChangerMain_groupBox_original_panel_canvas_pixelBox_display).EndInit();
            colorChangerMain_groupBox_original.ResumeLayout(false);
            colorChangerMain_panel_imageControl.ResumeLayout(false);
            colorChangerMain_panel_imageControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)colorChangerMain_panel_imageControl_trackBar_threshold).EndInit();
            colorChangerMain_groupBox_custom.ResumeLayout(false);
            colorChangerMain_groupBox_custom_panel_canvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display).EndInit();
            colorChangerMain_statusStrip.ResumeLayout(false);
            colorChangerMain_statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel colorChangerMain_groupBox_original_panel_canvas;
        private Controls.PixelBox colorChangerMain_groupBox_original_panel_canvas_pixelBox_display;
        private GroupBox colorChangerMain_groupBox_original;
        private Panel colorChangerMain_panel_imageControl;
        private Panel colorChangerMain_panel_imageControl_panel_replacementColorPreview;
        private Panel colorChangerMain_panel_imageControl_panel_originalColorPreview;
        private Label colorChangerMain_panel_imageControl_label_interpolationMode;
        private ComboBox colorChangerMain_panel_imageControl_comboBox_interpolationMode;
        private Button colorChangerMain_panel_imageControl_button_selectReplacementColor;
        private Button colorChangerMain_panel_imageControl_button_selectOriginalColor;
        private Button colorChangerMain_panel_imageControl_button_mirrorCustomImage;
        private Label colorChangerMain_panel_imageControl_label_threshold;
        private TrackBar colorChangerMain_panel_imageControl_trackBar_threshold;
        private GroupBox colorChangerMain_groupBox_custom;
        private Panel colorChangerMain_groupBox_custom_panel_canvas;
        private Controls.PixelBox colorChangerMain_groupBox_custom_panel_canvas_pixelBox_display;
        private StatusStrip colorChangerMain_statusStrip;
        private ToolStripStatusLabel colorChangerMain_statusStrip_label_version;
        private ToolStripStatusLabel colorChangerMain_statusStrip_label_lastUpdated;
        private Button colorChangerMain_button_loadOriginalImage;
        private Button colorChangerMain_button_saveCustomImage;
        private Button colorChangerMain_button_replaceOriginalwithCustom;
    }
}