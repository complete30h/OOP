using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figures1;
using BasicLibrary;
using System.Xml.Serialization;
using Newtonsoft.Json;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace XmlToJson
{
    public class Transformer : IFormatter
    {
        public string Description { get; set; } = "XMLToJSON";
        string xmlstring;
        private static XmlSerializer xml;
        public void Transform(List<Figure> figures)
        {
            using (FileStream fileStream = new FileStream(@"D:\2.xml", FileMode.Open))
            {
                byte[] buffer = new byte[fileStream.Length];
                fileStream.Read(buffer, 0, buffer.Length);
                xmlstring = Encoding.Default.GetString(buffer);
            }

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xmlstring);

            string jsonString = JsonConvert.SerializeXmlNode(xmlDocument);
            using (FileStream fileStream = new FileStream(@"D:\Json.json", FileMode.Create))
            {
                byte[] buffer = Encoding.Default.GetBytes(jsonString);
                fileStream.Write(buffer, 0, buffer.Length);
            }
        }
        public List<Figure> Restore()
        {
            string jsonString;
            using (FileStream fileStream = new FileStream(@"D:\Json.json", FileMode.Open))
            {

                byte[] buffer;
                buffer = new byte[fileStream.Length];
                fileStream.Read(buffer, 0, buffer.Length);
                jsonString = Encoding.Default.GetString(buffer);
            }
            XNode xNode = JsonConvert.DeserializeXNode(jsonString);
            string xmlString = xNode.ToString();
            byte[] buffer1 = Encoding.Default.GetBytes(xmlString);
            MemoryStream Stream = new MemoryStream(buffer1);
            xml = new XmlSerializer(typeof(List<Figure>));
            List<Figure> figures = (List<Figure>)xml.Deserialize(Stream);
            Stream.Close();

            return figures;
        }
    
    }   
 }
