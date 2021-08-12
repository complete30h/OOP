using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab2.DrawFigure;
using System.Drawing;
using Figures1;

namespace lab2.figureCreator
{
    abstract class FigureCreator
    {
        public abstract Figure FactoryMethod(Point[] arrayPoint, Color Color);
    }
}
