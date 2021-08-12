using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicLibrary;
using Figures1;

namespace MathPlugin
{
    class AreaCalculateEllipse : IMath
    {
        public double Calculate(Figure figure)
        {
            Ellipse figure1 = (Ellipse)figure;
            return (figure1.Length * figure1.Width * 3.14);
        }
    }
}
