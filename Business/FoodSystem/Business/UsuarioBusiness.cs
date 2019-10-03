using System;
using System.Collections.Generic;

namespace FoodSystem.Business
{
    public class UsuarioBusiness
    {

        public List<Model.Usuario> GetAll()
        {
            DataContext.UsuarioData usuarioData = new DataContext.UsuarioData();
            return usuarioData.GetAll();
        }
    }
}
