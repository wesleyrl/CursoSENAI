using Projeto.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;



namespace Projeto.Entities
{
    class Produtos
    {
        public string Produto { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }
        public double ValorTotal { get; private set; }
        

        public EstadoPedido PedidoStatus { get; set; }

        public Produtos(string produto, int quantidade, double valor)
        {
            Produto = produto;
            Quantidade = quantidade;
            Valor = valor;
            ValorTotal = SomaValorTotal();
        }
        public override string ToString()
        {
            return $"Produto {Produto} - Quantidade {Quantidade} - Valor: {Valor} Total: {ValorTotal.ToString("F2")} Status do pedido {PedidoStatus}";
        }

        public double SomaValorTotal()
        {
            return Valor * Quantidade;
        }

        public void Status(int status)
        {
            PedidoStatus = (EstadoPedido)status;
        }


    }

   
}
