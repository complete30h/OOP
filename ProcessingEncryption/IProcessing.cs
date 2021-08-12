using System.Collections.Generic;
using Figures1;

namespace ProcessingEncryption
{
    public interface IProcessing
    {
        string Name { get; set; }
        void Transform(List<Figure> figures);
        List<Figure> Restore();
    }
}
