using System.Collections.Generic;
namespace atividade_2.Models
{
    public class Pedido
    {

        private List<ItemPedido> ListaDePedidos = new List<ItemPedido>();

        public void AdicionaServico(ItemPedido item)
        {
            ListaDePedidos.Add(item);
        }

        public double TotalizaPedido()
        {
            double total = 0;

            foreach (var Lista in ListaDePedidos)
            {
                total += Lista.quantidade * Lista.valor;
            }

            return total;
        }

        public List<ItemPedido> ListaPedidos()
        {
            return ListaDePedidos;

        }


    }
}