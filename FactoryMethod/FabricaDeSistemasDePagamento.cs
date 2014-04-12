using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Interfaces;

namespace FactoryMethod
{
    public class FabricaDeSistemasDePagamento
    {

        public ISistemaPagamentos CriarSistemaPagamentos(TipoDeSistemaDePagamento tipoDeSistemaDePagamento)
        {
            switch (tipoDeSistemaDePagamento)
            {
                case TipoDeSistemaDePagamento.PagSeguro:
                    return (new PagSeguro());
                case TipoDeSistemaDePagamento.Paypal:
                    return (new PayPal());
                default: throw new Exception("Sistema de Pagamento não existe");
            }
        }

        public enum TipoDeSistemaDePagamento
        {
            Paypal,
            PagSeguro
        }

    }


}
