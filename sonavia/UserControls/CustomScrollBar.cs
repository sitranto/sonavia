using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sonavia.UserControls
{
    public partial class CustomScrollBar : UserControl
    {
        public event EventHandler<int> Scroll;

        public int Minimum { get; set; } = 0;
        public int Maximum { get; set; } = 100;
        public int LargeChange { get; set; } = 10;

        private int _value = 0;
        public int Value
        {
            get => _value;
            set
            {
                _value = Math.Max(Minimum, Math.Min(Maximum - LargeChange, value));
                Invalidate();
                Scroll?.Invoke(this, _value);
            }
        }

        private bool isDragging = false;
        private int dragOffset = 0;

        public CustomScrollBar()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint |
                     ControlStyles.OptimizedDoubleBuffer, true);
            Width = 12;
            BackColor = ColorTranslator.FromHtml("#272424");
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var g = e.Graphics;

            // фон
            using var bgBrush = new SolidBrush(BackColor);
            g.FillRectangle(bgBrush, ClientRectangle);

            // ползунок
            Rectangle thumbRect = GetThumbRectangle();
            using var thumbBrush = new SolidBrush(isDragging ? ColorTranslator.FromHtml("#E78A20") : ColorTranslator.FromHtml("#706767"));
            g.FillRectangle(thumbBrush, thumbRect);
        }

        private Rectangle GetThumbRectangle()
        {
            int trackHeight = Height;
            float ratio = (float)LargeChange / (Maximum - Minimum);
            int thumbHeight = Math.Max(30, (int)(trackHeight * ratio));
            float scrollRatio = (float)(Value - Minimum) / (Maximum - Minimum - LargeChange);
            int thumbTop = (int)((trackHeight - thumbHeight) * scrollRatio);

            return new Rectangle(0, thumbTop, Width, thumbHeight);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            var thumbRect = GetThumbRectangle();
            if (thumbRect.Contains(e.Location))
            {
                isDragging = true;
                dragOffset = e.Y - thumbRect.Top;
                Invalidate();
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            isDragging = false;
            Invalidate();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (isDragging)
            {
                int trackHeight = Height;
                int thumbHeight = GetThumbRectangle().Height;
                int newTop = e.Y - dragOffset;
                newTop = Math.Max(0, Math.Min(trackHeight - thumbHeight, newTop));

                float ratio = (float)newTop / (trackHeight - thumbHeight);
                Value = Minimum + (int)((Maximum - Minimum - LargeChange) * ratio);
            }
        }
    }
}

