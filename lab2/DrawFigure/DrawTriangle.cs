using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab2;
using System.Drawing;
using Figures1;

namespace lab2.DrawFigure
{
    class DrawTriangle : IDrawFigure
    {
        private Triangle triangle;
        protected Brush brush;
        protected Pen pen;

        public DrawTriangle(Triangle triangle)
        {
            this.triangle = triangle;
        }
       public void Draw(System.Drawing.Graphics g)
        {
            this.triangle.Color = Color.FromArgb(this.triangle.hexbrush);
            this.brush = new SolidBrush(this.triangle.Color);
            g.FillPolygon(this.brush, new Point[] { this.triangle.Point1, this.triangle.Point2, this.triangle.Point3 });
        }
    }
}
