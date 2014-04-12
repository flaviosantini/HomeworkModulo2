using FactoryMethod;

namespace HomeworkModulo2
{
    class Program
    {
        static void Main(string[] args)
        {
            var pagamento = new Pagamento
            {
                Cpf = "173.240.458-55",
                Cidade = "São Paulo",
                Uf = "SP"
            };

            var item = new Item
            {
                Codigo = 1,
                Descricao = "Teste",
                Quantidade = 2,
                Valor = (decimal) 22.34
            };

            pagamento.AdicionarItem(item);

            pagamento.ProcessarPagamento(FabricaDeSistemasDePagamento.TipoDeSistemaDePagamento.PagSeguro);
        }
    }
}
