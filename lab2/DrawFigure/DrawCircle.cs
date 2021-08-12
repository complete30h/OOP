using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Figures1;

namespace lab2.DrawFigure
{
    class DrawCircle : IDrawFigure
    {
        private Circle circle;
        protected Brush brush;
        protected Pen pen;

        public DrawCircle(Circle circle)
        {
            this.circle = circle;
        }
        public void Draw(System.Drawing.Graphics g)
        {
            this.circle.Color = Color.FromArgb(this.circle.hexbrush);
            this.brush = new SolidBrush(this.circle.Color);
            g.FillEllipse(this.brush, this.circle.Point1.X, this.circle.Point1.Y,
                this.circle.Length, this.circle.Width);
        }
    }
}
