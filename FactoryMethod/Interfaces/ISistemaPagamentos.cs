using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Interfaces
{
    public interface ISistemaPagamentos
    {
        void RegistrarPagamentos(Pagamento pagamento);
    }
}
