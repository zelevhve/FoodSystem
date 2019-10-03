using System;
using System.Collections.Generic;
using System.Linq;

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
            return _usuarioData.GetAll().ToList();
        }
        public Model.Usuario Save(Model.Usuario entity)
        {
            return _usuarioData.Save(entity);
        }
        public void Delete(Model.Usuario entity) {
            _usuarioData.Delete(entity);
        }
        public Model.Usuario GetById(int id) {
            return _usuarioData.GetById(id);
        }
    }
}
