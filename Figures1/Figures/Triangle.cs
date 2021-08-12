using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Figures1
{
    [Serializable]
   public class Triangle : Figure
    {
        private Point point1;
        private Point point2;
        private Point point3;
        public int hexbrush;

        public Triangle()
        {

        }


        public Triangle(string Title,Point point1, Point point2, Point point3, Color Color)
        {
            this.Title = Title;
            this.point1 = point1;
            this.point2 = point2;
            this.point3 = point3;
            this.Color = Color;
            hexbrush = Color.ToArgb();
        }



        public override Point Point1
        {
            get
            {
                return point1;
            }
            set
            {
                point1 = value;
            }
        }

        public override Point Point2
        {
            get
            {
                return point2;
            }
            set
            {
                point2 = value;
            }
        }

        public Point Point3
        {
            get { return point3; }
            set { point3 = value; }
        }

       
    }
}

