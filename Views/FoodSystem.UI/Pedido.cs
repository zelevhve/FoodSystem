using System.Collections.Generic;
using System.Linq;

namespace FoodSystem.UI
{
    public partial class Pedido : Container
    {
        public Pedido()
        {
            InitializeComponent();
            GetData();
        }
        public void GetData()
        {
            Business.UsuarioBusiness business = Resolve<Business.UsuarioBusiness>();
            
            business.Save(new Model.Usuario {
                Code = "10000101",
                UserName = "Darth Vader"
            });

            List<Model.Usuario> Usuarios = business.GetAll();
            var selected = Usuarios.FirstOrDefault();
            selected.UserName = "Han Solo";
            business.Save(selected);
            Usuarios = business.GetAll();
            business.Delete(selected);
            Usuarios = business.GetAll();
        }
    }
}
