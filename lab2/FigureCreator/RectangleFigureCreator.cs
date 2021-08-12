using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab2;
using System.Drawing;
using lab2.DrawFigure;
using Figures1;


namespace lab2.figureCreator
{
    class RectangleFigureCreator : FigureCreator
    {
        public override Figure FactoryMethod(System.Drawing.Point[] arrayPoint, Color Color)
        {
            Figures1.Rectangle rectangle = new Figures1.Rectangle("Прямоугольник",arrayPoint[0], arrayPoint[1], Color);
            return rectangle;
        }
    }
}
