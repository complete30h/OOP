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
    class DrawRectangle : IDrawFigure
    {
        private Figures1.Rectangle rectangle;
        protected Brush brush;
        protected Pen pen;


        public DrawRectangle(Figures1.Rectangle rectangle)
        {
            this.rectangle = rectangle;
        }
        public void Draw(System.Drawing.Graphics g)
        {
            this.rectangle.Color = Color.FromArgb(this.rectangle.hexbrush);
            this.brush = new SolidBrush(this.rectangle.Color);
            g.FillRectangle(this.brush, this.rectangle.Point1.X, this.rectangle.Point1.Y,
                this.rectangle.Length, this.rectangle.Width);
        }
    }
}

