using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicLibrary;
using Figures1;

namespace MathPlugin
{
    class PerimeterCalculateRectangle: IMath
    {
        public double Calculate(Figure figure)
        {
            Rectangle figure1 = (Rectangle)figure;
            return (figure1.Width * 2 + figure1.Length * 2);
        }
    }
}
