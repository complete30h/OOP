using lab2.DrawFigure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab2;
using Figures1;

namespace lab2.figureCreator
{
    class TriangleFigureCreator : FigureCreator 
    {
        public override Figure FactoryMethod(System.Drawing.Point[] arrayPoint, Color Color)
        {
            Triangle triangle = new Triangle("Треугольник",arrayPoint[0], arrayPoint[1], arrayPoint[2], Color);
            return triangle;
        }
    }
}
