using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactosPlus.ApplicationCore.DTOs;

namespace ContactosPlus.ApplicationCore.UseCases
{
    internal class clListaDePagos
    {
        List<clPago> pagos = new List<clPago>();

        public void Add(int fecha_de_pago, string forma_de_pago, int cantidad)
        {
            pagos.Add(new clPago(fecha_de_pago, forma_de_pago, cantidad));
        }

        public void Show()
        {
            pagos.ForEach(x => MessageBox.Show(x.Show()));
        }
    }
}
