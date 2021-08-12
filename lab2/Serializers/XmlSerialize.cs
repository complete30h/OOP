using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Drawing;
using Figures1;

namespace lab2.Serializers
{
    class XmlSerialize
        {
            private static readonly string Filename = @"D:\2.xml";
            private static XmlSerializer xml;
            public static void Serialize(List<Figure> figureList)
            {
                if (File.Exists(Filename))
                    File.Delete(Filename);

                using (FileStream fs = new FileStream(Filename, FileMode.Create))
                {
                    xml = new XmlSerializer(typeof(List<Figure>));
                    xml.Serialize(fs, figureList);
                }
            }

            public static List<Figure> Deserialize()
            {
                List<Figure> figureList;

                if (File.Exists(Filename))
                {
                    using (FileStream fs = new FileStream(Filename, FileMode.Open))
                    {
                        xml = new XmlSerializer(typeof(List<Figure>));
                        figureList = (List<Figure>)xml.Deserialize(fs);
                    }

                }
                else
                {
                    figureList = new List<Figure>();
                }

                return figureList;
            }

        }
}
