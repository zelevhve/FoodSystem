using System.Collections.Generic;

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
            List<Model.Usuario> Usuario = business.GetAll();

        }
    }
}
