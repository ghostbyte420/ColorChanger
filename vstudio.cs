using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ColorChanger.Controls
{
    [ToolboxBitmap(typeof(PictureBox))]
    public class PixelBox : PictureBox
    {
        private float _zoom = 1.0f;
        [Category("Behavior")]
        [DefaultValue(1.0f)]
        public float Zoom
        {
            get => _zoom;
            set
            {
                _zoom = Math.Max(0.1f, value); // Prevent zooming out too much
                Invalidate();
            }
        }

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
            base.OnPaint(pe);
        }
    }
}