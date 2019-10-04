
namespace FoodSystem.Model
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string NitCI { get; set; }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
