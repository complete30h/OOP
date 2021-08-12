using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Figures1
{
    [Serializable]
    public class Square : Rectangle
    {
        public Square()
        {

        }
        public Square(string Title,Point point1, Point point2, Color Color) : base(Title,point1, point2, Color)
        {
            this.width = Math.Abs(point1.X - point2.X);
            hexbrush = this.Color.ToArgb();
        }
    }
}
