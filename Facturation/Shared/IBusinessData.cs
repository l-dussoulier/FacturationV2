using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturation.Shared
{
    public interface IBusinessData
    {
        List<Facture> lesFactures { get; }
    }
}
