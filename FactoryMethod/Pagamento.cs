using System.Collections.Generic;
using System.Linq;

namespace FactoryMethod
{
    public class Pagamento
    {
        public string Cpf { get; set; }
        public string Cidade { get; set; }
        public decimal Icms { get; set; }
        public string Uf { get; set; }
        public decimal ValorTotal { get; set; }
        public List<Item> Itens { get; protected set; }

        public Pagamento()
        {
            Itens = new List<Item>();
        }

        public void AdicionarItem(Item item)
        {
            Itens.Add(item);
            ValorTotal = Itens.Sum(itens => itens.Valor);
            CalcularIcms();
        }

        public void CalcularIcms()
        {
            Icms = ValorTotal*(decimal) 0.10;
        }

        public void ProcessarPagamento(FabricaDeSistemasDePagamento.TipoDeSistemaDePagamento tipoDeSistemaDePagamento)
        {
            var fabricaDeSistemaDePagamento = new FabricaDeSistemasDePagamento();
            var sistemaPagamento = fabricaDeSistemaDePagamento.CriarSistemaPagamentos(tipoDeSistemaDePagamento);
            
            sistemaPagamento.RegistrarPagamentos(this);
        }


    }
}
