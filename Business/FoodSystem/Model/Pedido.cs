using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodSystem.Model
{
   public  class Pedido
    {
        public int PedidoId { get; set; }
        public Usuario Usuario { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public PedidoStatus Estado { get; set; }
        public List<PedidoItem> PedidoItem { get; set; }
    }
    public enum PedidoStatus {
        EnCola,
        Procesando,
        Entregado
    }
}
