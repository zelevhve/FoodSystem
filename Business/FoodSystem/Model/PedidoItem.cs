
namespace FoodSystem.Model
{
    public class PedidoItem
    {
        public int PedidoItemId { get; set; }
        public Pedido Pedido { get; set; }
        public Comida Comida { get; set; }
        public decimal Precio { get; set; }
    }
}
