using System.Collections.Generic;
using System.Linq;

namespace FoodSystem.DataContext
{
    public class UsuarioData : Contracts.IUsuarioData
    {
        public List<Model.Usuario> GetAll()
        {
            using (UsuarioContext db = new UsuarioContext())
            {
                return db.Usuario.ToList();
            }
        }
    }
}
