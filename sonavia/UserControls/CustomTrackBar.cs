using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace sonavia.UserControls
{
    public partial class CustomTrackBar : UserControl
    {
        public new event EventHandler? Scroll;

        public CustomTrackBar()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
        }

        private int _value = 0;
        private int _maximum = 100;
        private bool _isDragging = false;
        private readonly Color _progressColor = ColorTranslator.FromHtml("#E78A20");
        private readonly Color _bgColor = ColorTranslator.FromHtml("#272424");

        public int Value
        {
            get => _value;
            set
            {
                int clamped = Math.Max(0, Math.Min(value, _maximum));
                if (_value != clamped)
                {
                    _value = clamped;
                    Invalidate();
                    if (_isDragging)
                    {
                        OnScroll();
                    }
                }
            }
        }

        public int Maximum
        {
            get => _maximum;
            set { _maximum = Math.Max(1, value); Invalidate(); }
        }

        protected virtual void OnScroll()
        {
            Scroll?.Invoke(this, EventArgs.Empty);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            _isDragging = true;
            SetValueFromMouse(e.X);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                SetValueFromMouse(e.X);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            _isDragging = false;
        }

        private void SetValueFromMouse(int mouseX)
        {
            Value = (int)((mouseX / (float)Width) * Maximum);
        }

        private static GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new();
            int diameter = radius * 2;

            if (diameter > rect.Height) diameter = rect.Height;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int height = Height;
            int width = Width;

            int barHeight = 6;
            int radius = barHeight;
            float percent = Value / (float)Maximum;

            int y = (height - barHeight) / 2;
            int x_progress = (int)(percent * width);

            Rectangle bgRect = new(0, y, width, barHeight);
            Rectangle progressRect = new(0, y, x_progress, barHeight);


            using var bgBrush = new SolidBrush(_bgColor);
            using var progressBrush = new SolidBrush(_progressColor);

            using var bgPath = GetRoundedRectPath(bgRect, radius);
            using var progressPath = GetRoundedRectPath(progressRect, radius);

            g.FillPath(bgBrush, bgPath);

            if (x_progress > 0)
            {
                g.FillPath(progressBrush, progressPath);
            }
        }
    }
}
