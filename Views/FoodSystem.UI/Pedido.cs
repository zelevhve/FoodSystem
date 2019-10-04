using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace FoodSystem.UI
{
    public partial class Pedido : Container
    {

        public Pedido()
        {
            InitializeComponent();
            GetData();
        }
        private decimal _balance = 0m;
        public void GetData()
        {
            Business.UsuarioBusiness business = Resolve<Business.UsuarioBusiness>();

            business.Save(new Model.Usuario
            {
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

//            ColumnHeader col1 = new ColumnHeader();
//            var comida1 = new Model.Comida { Nombre = "Combo1", Precio = 25 };
//            col1.Text = "Nombre";
//            col1.TextAlign = HorizontalAlignment.Left;
//            ////col1.Width = 150;

//            ColumnHeader col2 = new ColumnHeader();

//            col1.Text = "Precio";
//            col1.TextAlign = HorizontalAlignment.Left;
//            col1.Width = 150;

//            listView1.Columns.Add(col1);
//            listView1.Columns.Add(col2);

//var comida2 = new Model.Comida { Nombre = "Combo1", Precio = 25 };

//            listView1.BeginUpdate();
//            var lv1 = new ListViewItem(comida1.Nombre);
//            lv1.SubItems.Add(comida1.Precio.ToString());
//            listView1.Items.Add(lv1);
//            listView1.EndUpdate();
//            listView1.HideSelection = false;
//            listView1.MultiSelect = true;

//            listView1.ItemCheck += ListView1_ItemCheck;

            checkedListBox1.Items.Add(new Model.Comida { Nombre = "Combo2", Precio = 35 }, false);
            checkedListBox1.Items.Add(new Model.Comida { Nombre = "Combo3", Precio = 45 }, false);
            checkedListBox1.Items.Add(new Model.Comida { Nombre = "Porcion Papas", Precio = 10 }, false);
            checkedListBox1.Items.Add(new Model.Comida { Nombre = "Porcion Postre Arroz con leche", Precio = 5 }, false);
            checkedListBox1.Items.Add(new Model.Comida { Nombre = "Porcion Platanito", Precio = 10 }, false);
            checkedListBox1.Items.Add(new Model.Comida { Nombre = "Porcion Arroz", Precio = 7 }, false);


            checkedListBox1.ItemCheck += CheckedListBox1_ItemCheck;
        }



        //private void ListView1_ItemCheck(object sender, ItemCheckEventArgs e)
        //{
        //    if (e.CurrentValue == CheckState.Unchecked)
        //    {
        //        _balance += decimal.Parse(
        //            listView1.Items[e.Index].SubItems[1].Text);
        //    }
        //    else if ((e.CurrentValue == CheckState.Checked))
        //    {
        //        _balance -= decimal.Parse(
        //            listView1.Items[e.Index].SubItems[1].Text);
        //    }

        //    // Output the price to TextBox1.
        //    label1.Text = _balance.ToString("es-Bo");
        //}

        private void CheckedListBox1_ItemCheck(object sender, System.Windows.Forms.ItemCheckEventArgs e)
        {
            if (e.CurrentValue == CheckState.Checked)
            {
                _balance = _balance - 25;
                label1.Text = _balance.ToString();
            }
            if (e.CurrentValue == CheckState.Unchecked)
            {
                _balance = _balance + 25;
                label1.Text = _balance.ToString();
            }

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            var pedidos = new Pedidos();
            pedidos.Show();
        }
    }
}
