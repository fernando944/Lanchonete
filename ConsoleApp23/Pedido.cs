using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    public class Pedido
    {
        public int NumeroPedido;
        List<Pedido> fazerpedidos = new List<Pedido>();

        public string Nomeparaopedido { get; set; }
        public double Precoparaopedido { get; set; }


        double total = 0;
        public double Total (double Preco)
        {
            return Preco + total;
        }

     
    }
}
