using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figures1;
using ProcessingEncryption;
using BasicLibrary;

namespace EncryptAdapter
{
    public class Adapter : Encryption, IFormatter
    {
        public string Description
        { get
            {
                return this.Name;
            }
            
        }
        public List<Figure> List { get; set; }

        public void WrapperTransform()
        {
            this.Transform(this.List);
        }

       public List<Figure> WrapperRestore()
        {
            List = this.Restore();
            return List;
        }



    }
}
