using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using lab2;
using Figures1;

namespace lab2.DrawFigure
{
    class DrawEllipse : IDrawFigure
    {
        private Ellipse ellipse;
        protected Brush brush;
        protected Pen pen;

        public DrawEllipse(Ellipse ellipse)
        {
            this.ellipse = ellipse;
        }
        public void Draw(System.Drawing.Graphics g)
        {
            this.ellipse.Color = Color.FromArgb(this.ellipse.hexbrush);
            this.brush = new SolidBrush(this.ellipse.Color);
            g.FillEllipse(this.brush, this.ellipse.Point1.X, this.ellipse.Point1.Y,
                this.ellipse.Length, this.ellipse.Width);
        }
    }
}
