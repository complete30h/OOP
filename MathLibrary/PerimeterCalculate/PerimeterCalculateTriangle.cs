using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicLibrary;
using Figures1;

namespace MathPlugin
{
    class PerimeterCalculateTriangle : IMath
    {
       public double Calculate(Figure figure)
        {
            Triangle figure1 = (Triangle)figure;
            var side1 = Math.Sqrt(Math.Pow((figure1.Point1.X - figure1.Point2.X), 2) + Math.Pow((figure1.Point1.Y - figure1.Point2.Y), 2));
            var side2 = Math.Sqrt(Math.Pow((figure1.Point2.X - figure1.Point3.X), 2) + Math.Pow((figure1.Point2.Y - figure1.Point3.Y), 2));
            var side3 = Math.Sqrt(Math.Pow((figure1.Point3.X - figure1.Point1.X), 2) + Math.Pow((figure1.Point3.Y - figure1.Point1.Y), 2));
            return (side1 + side2 + side3);
        }
    }
}
