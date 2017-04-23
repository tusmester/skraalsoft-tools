using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skraalsoft.Tools.Parallel
{
    public interface ITreeElement
    {
        IEnumerable<ITreeElement> Children { get; }
        bool IsContainer { get; }
    }
}
