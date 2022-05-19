namespace atividade_2.Models
{
    public static class Dados
    {
        public static Pedido PedidoAtual { get; set; }
        static Dados()
        {
            PedidoAtual = new Pedido();
        }
    }
}