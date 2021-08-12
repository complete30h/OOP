using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicLibrary;
using Figures1;

namespace MathPlugin
{
    class PerimeterCalculateSquare: IMath
    {
        public double Calculate(Figure figure)
        {
            Square figure1 = (Square)figure;
            return (figure1.Width * 4);
        }
    }
}
