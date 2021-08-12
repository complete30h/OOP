using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicLibrary;
using Figures1;

namespace MathPlugin
{
    class AreaCalculateTriangle: IMath
    {
        public double Calculate(Figure figure)
        {
            Triangle figure1 = (Triangle)figure;
            return (figure1.Point1.X * figure1.Point2.Y + figure1.Point2.X * 
                    figure1.Point3.Y + figure1.Point3.X * figure1.Point1.Y
                    - figure1.Point2.X * figure1.Point1.Y - figure1.Point3.X *
                    figure1.Point2.Y - figure1.Point1.X * figure1.Point3.Y);
        }
    }
}
