using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodSystem.WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetData();
        }
        public void GetData() {

            Business.UsuarioBusiness business = new Business.UsuarioBusiness();
            List<Model.Usuario> Usuarios = business.GetAll();

        }


    }
}
