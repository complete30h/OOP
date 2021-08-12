using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml.Serialization;


namespace Figures1
{
    [XmlInclude(typeof(Circle))]
    [XmlInclude(typeof(Rectangle))]
    [XmlInclude(typeof(Square))]
    [XmlInclude(typeof(Ellipse))]
    [XmlInclude(typeof(Figure))]
    [XmlInclude(typeof(Triangle))]

    [Serializable]
    public abstract class Figure
    {
        public string Title { get; set; }
        public abstract Point Point1 { get; set; }
        public abstract Point Point2 { get; set; }
        public Color Color { get; set; }


    }
}
