using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Figures1
{
    [Serializable]
   public class Ellipse : Figure
    {
        
        protected Point point1;
        protected Point point2;
        protected int length;
        protected int width;
        public int hexbrush;

        public Ellipse()
        {

        }
         public Ellipse(string Title, Point point1, Point point2, Color Color)
        {
            this.Title = Title;
            this.point1 = point1;
            this.point2 = point2;
            this.Color = Color;
            this.length = Math.Abs(point1.X - point2.X);
            this.width = Math.Abs(point1.Y - point2.Y);
            hexbrush = this.Color.ToArgb();
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

        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        
    }
}
