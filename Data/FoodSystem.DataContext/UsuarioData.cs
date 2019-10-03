using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodSystem.DataContext
{
    public class UsuarioData 
    {
        public List<Model.Usuario> GetAll()
        {
            using (UsuariosContext db = new UsuariosContext())
            {
                return db.Usuario.ToList();
            }
        }
    }
}
