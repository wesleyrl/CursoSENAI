using System;
using Projeto.Entities;
using Projeto.Entities.Enums;

namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int status;

            Console.WriteLine("Informe qual o produto:");
            string prod = Console.ReadLine();

            Console.WriteLine("Informe quantidade desejada:");
            int qtd = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor do produto:");
            double valor = double.Parse(Console.ReadLine());

            Produtos produto = new Produtos(prod,qtd,valor);

            Console.WriteLine(produto);

            do
            {
                Console.WriteLine("Informe o status do produto: \n 0 - Pedido Realizado \n 1 - Pedido Aceito \n 2 - Pedido Em Producao \n 3 - Saiu Para Entrega \n 4 - Entregue");
                status = int.Parse(Console.ReadLine());
                produto.Status(status);
                Console.WriteLine(produto.PedidoStatus);

            } while (status != 4);

            Console.WriteLine(produto);
        }
    }
}
