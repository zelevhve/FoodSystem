using System;
using System.Collections.Generic;

namespace FoodSystem.Business
{
    public class UsuarioBusiness
    {
        private Contracts.IUsuarioData _usuarioData;
        public UsuarioBusiness(Contracts.IUsuarioData usuarioData)
        {
            _usuarioData = usuarioData ?? throw new ArgumentNullException("IUsuarioData");
        }
        public List<Model.Usuario> GetAll()
        {
            //DataContext.UsuarioData usuarioData = new DataContext.UsuarioData();
            return _usuarioData.GetAll();
        }
    }
}
