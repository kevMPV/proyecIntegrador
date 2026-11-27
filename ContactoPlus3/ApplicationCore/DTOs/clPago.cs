using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactosPlus.ApplicationCore.DTOs
{
    internal class clPago
    {
        public int fecha_de_pago { get; set; }
        public string forma_de_pago { get; set; }
        public int cantidad { get; set; }



        public clPago(int fecha_de_pago, string forma_de_pago, int cantidad)
        {
            this.fecha_de_pago = fecha_de_pago;
            this.forma_de_pago = forma_de_pago;
            this.cantidad = cantidad;
        }

        public String Show()
        {
            return $"{this.fecha_de_pago},{this.forma_de_pago},{this.cantidad}";
        }
        
    }
 
}
