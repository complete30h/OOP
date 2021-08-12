using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicLibrary;
using Figures1;

namespace MathPlugin
{
    class PerimeterCalculateCircle: IMath
    {
        public double Calculate(Figure figure)
        {
            Circle figure1 = (Circle)figure;
            return (figure1.Width * 2 * 3.14);
        }
    }
}
