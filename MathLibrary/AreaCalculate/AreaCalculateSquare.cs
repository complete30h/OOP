using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicLibrary;
using Figures1;

namespace MathPlugin
{
    public class AreaCalculateSquare : IMath
    {
        public double Calculate(Figure figure)
        {
            Square figure1 = (Square)figure;
            return (figure1.Length * figure1.Width);
        }
    }
}
