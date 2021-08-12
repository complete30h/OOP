using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using lab2.DrawFigure;
using lab2;
using Figures1;

namespace lab2.figureCreator
{
    class EllipseFigureCreator : FigureCreator
    {
        public override Figure FactoryMethod(System.Drawing.Point[] arrayPoint, Color Color)
        {
            Ellipse ellipse = new Ellipse("Эллипс",arrayPoint[0], arrayPoint[1], Color);
            return ellipse;
        }
    }
}
