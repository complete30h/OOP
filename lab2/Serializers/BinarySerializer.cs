using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using lab2.DrawFigure;
using Figures1;

namespace lab2.Serializers
{
    class BinarySerializer
    {
        private static readonly string Filename = @"D:\1.dat";
        private static BinaryFormatter binForm;

        public static void Serialize(List<Figure> figureList)
        {
            if (File.Exists(Filename))
                File.Delete(Filename);

            using (FileStream fs = new FileStream(Filename, FileMode.Create))
            {
                binForm = new BinaryFormatter();
                binForm.Serialize(fs, figureList);
            }
        }

        public static List<Figure> Deserialize()
        {
            List<Figure> figureList;

            if (File.Exists(Filename))
            {
                using (FileStream fs = new FileStream(Filename, FileMode.Open))
                {
                    binForm = new BinaryFormatter();
                    figureList = (List<Figure>)binForm.Deserialize(fs);
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
  