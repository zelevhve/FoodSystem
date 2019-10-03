using System;
using System.Collections.Generic;

namespace FoodSystem.Business
{
    public class UsuarioBusiness
    {
        private Contracts.IUsuarioData _usuarioData;
        public UsuarioBusiness(Contracts.IUsuarioData usuarioData)
        {
            if (usuarioData == null)
                throw new ArgumentNullException("IUsuarioData");
            _usuarioData = usuarioData;
        }
        public List<Model.Usuario> GetAll()
        {
            //DataContext.UsuarioData usuarioData = new DataContext.UsuarioData();
            return _usuarioData.GetAll();
        }
    }
}
