using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodSystem.UI
{
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
            ShowData();
        }

        private void ShowData()
        {
            dataGridView1.DataSource = new List<Model.Pedido> {
                new Model.Pedido {
                    PedidoId = 1,
                    Usuario = new Model.Usuario {
                        Code = "10001",
                        UserName = "Joel Gonzales"
                    },
                    Cliente =new Model.Cliente {
                                                Nombre = "Han Solo"
                                                },
                    Fecha = DateTime.Now, Estado = Model.PedidoStatus.Procesando},
                new Model.Pedido {
                    PedidoId = 2,
                    Usuario = new Model.Usuario {
                        Code = "10001",
                        UserName = "Joel Gonzales"
                    },
                    Cliente =new Model.Cliente {
                                                Nombre = "Darth Vader"
                                                },
                    Fecha = DateTime.Now, Estado = Model.PedidoStatus.Procesando},
                new Model.Pedido {
                    PedidoId = 3,
                    Usuario = new Model.Usuario {
                        Code = "10001",
                        UserName = "Joel Gonzales"
                    },
                    Cliente =new Model.Cliente {
                                                Nombre = "Chubacca"
                                                },
                    Fecha = DateTime.Now, Estado = Model.PedidoStatus.Procesando},
                new Model.Pedido {
                    PedidoId = 4,
                    Usuario = new Model.Usuario {
                        Code = "10001",
                        UserName = "Joel Gonzales"
                    },
                    Cliente =new Model.Cliente {
                                                Nombre = "CPTRO"
                                                },
                    Fecha = DateTime.Now, Estado = Model.PedidoStatus.Procesando},
                new Model.Pedido {
                    PedidoId = 5,
                    Usuario = new Model.Usuario {
                        Code = "10001",
                        UserName = "Joel Gonzales"
                    },
                    Cliente =new Model.Cliente {
                                                Nombre = "R2D2"
                                                },
                    Fecha = DateTime.Now, Estado = Model.PedidoStatus.Procesando},
                new Model.Pedido {
                    PedidoId = 6,
                    Usuario = new Model.Usuario {
                        Code = "10001",
                        UserName = "Joel Gonzales"
                    },
                    Cliente =new Model.Cliente {
                                                Nombre = "Leia"
                                                },
                    Fecha = DateTime.Now, Estado = Model.PedidoStatus.Listo},
                new Model.Pedido {
                    PedidoId = 7,
                    Usuario = new Model.Usuario {
                        Code = "10001",
                        UserName = "Joel Gonzales"
                    },
                    Cliente =new Model.Cliente {
                                                Nombre = "Goku"
                                                },
                    Fecha = DateTime.Now, Estado = Model.PedidoStatus.Listo},
                new Model.Pedido {
                    PedidoId = 8,
                    Usuario = new Model.Usuario {
                        Code = "10001",
                        UserName = "Joel Gonzales"
                    },
                    Cliente =new Model.Cliente {
                                                Nombre = "Vegeta"
                                                },
                    Fecha = DateTime.Now, Estado = Model.PedidoStatus.Listo},
            };
        }
    }
}
