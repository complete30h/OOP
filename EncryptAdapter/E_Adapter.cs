using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProcessingEncryption;
using Figures1;


namespace EncryptAdapter
{
   public class E_Adapter : IAdapter
    {
       public List<Figure> FigureList { get; set; }

         Encryption Encrypt = new Encryption();
        
       public string name
        {
            get
            {
                return Encrypt.Name;
            }
            set
            {

            }
        }


        public void WrapperTransform()
        {
            Encrypt.Transform(FigureList);
        }
        public List<Figure> WrapperRestore()
        {
            List<Figure> res = Encrypt.Restore();
            return res;
        }

    }
}
