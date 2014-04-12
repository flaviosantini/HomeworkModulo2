using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Interfaces;

namespace FactoryMethod
{
    public class PayPal : ISistemaPagamentos
    {
        public void RegistrarPagamentos(Pagamento pagamento)
        {
            throw new NotImplementedException();
        }
    }
}
