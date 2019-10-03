
namespace FoodSystem.Model
{
    public class Comida
    {
        public int ComidaId { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public decimal Precio { get; set; }
        public string Receta { get; set; }
        public ComidaStatus Status { get; set; }
    }
    public enum ComidaStatus
    {
        Disponible,
        Agotado
    }
}
