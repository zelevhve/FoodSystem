
namespace FoodSystem.Model
{
    public class Comprobante
    {
        public int ComprobanteId { get; set; }
        public Usuario Usuario { get; set; }
        public Cliente  Cliente { get; set; }
        public Pedido Pedido { get; set; }
        public string Nombre { get; set; }
        public string NIT { get; set; }
        public decimal Total { get; set; }
    }
}
