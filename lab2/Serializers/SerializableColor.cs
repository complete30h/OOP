using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab2.Serializers
{
    [System.Serializable]
    public class SerializableColor
    {

        public int[] colorStore = new int[4] { 100, 0, 255, 255 };

        // get { return new Color(colorStore[0],colorStore[1],colorStore[2],colorStore[3]); }
        // set { colorStore = new float[4] { value.r, value.g, value.b, value.a }; }


        //  public static implicit operator Color(SerializableColor instance)

        // return instance.Color;


        // public static implicit operator SerializableColor(Color color)

        //  return new SerializableColor { Color = color };

    }
}
