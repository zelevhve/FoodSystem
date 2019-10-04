

namespace FoodSystem.Model
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Code { get; set; }
        public string UserName { get; set; }
        public override string ToString()
        {
            return $"{Code} - {UserName}";
        }
    }
}
