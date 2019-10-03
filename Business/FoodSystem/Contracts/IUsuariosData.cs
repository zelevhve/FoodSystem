using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodSystem.Contracts
{
    public interface IUsuariosData
    {
        List<Model.Usuario> GetAll();
    }
}
