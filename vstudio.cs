using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ColorChanger.Controls
{
    [ToolboxBitmap(typeof(PictureBox))]
    public class PixelBox : PictureBox
    {
        private float _zoom = 1.0f;
        private int _offsetX = 0;
        private int _offsetY = 0;

        [Category("Behavior")]
        [DefaultValue(1.0f)]
        public float Zoom
        {
            get => _zoom;
            set
            {
                _zoom = Math.Max(0.1f, value);
                Invalidate();
            }
        }

        [Category("Behavior")]
        [DefaultValue(0)]
        public int OffsetX { get => _offsetX; set { _offsetX = value; Invalidate(); } }

        [Category("Behavior")]
        [DefaultValue(0)]
        public int OffsetY { get => _offsetY; set { _offsetY = value; Invalidate(); } }

        public PixelBox()
        {
            InterpolationMode = InterpolationMode.Default;
            SizeMode = PictureBoxSizeMode.Zoom;
        }

        [Category("Behavior")]
        [DefaultValue(InterpolationMode.Default)]
        public InterpolationMode InterpolationMode { get; set; }

        protected override void OnPaint(PaintEventArgs pe)
        {
            pe.Graphics.InterpolationMode = InterpolationMode;
            pe.Graphics.ScaleTransform(_zoom, _zoom);
            pe.Graphics.TranslateTransform(_offsetX, _offsetY);
            base.OnPaint(pe);
        }
    }
}
