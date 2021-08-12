using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicLibrary;
using Figures1;

namespace MathPlugin
{
    class PerimeterCalculateEllipse : IMath
    {
        public double Calculate(Figure figure)
        {
            Ellipse figure1 = (Ellipse)figure;
            return ((figure1.Width + figure1.Length) * 3.14);
        }
    }
}
