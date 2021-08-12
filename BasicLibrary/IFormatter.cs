using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figures1;

namespace BasicLibrary
{
    public interface IFormatter
    {
        string Description { get; }

        void Transform(List<Figure> figures);
        List<Figure> Restore();
    }
}
