using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactosPlus.ApplicationCore.DTOs;
namespace ContactosPlus.ApplicationCore.UseCases
{
    internal class clListaClientes
    {
        List<clCientes> clientes = new List<clCientes>();

        public void Add(string nombre, string apellidos, string correo, int telefono, int numero_de_cliente, int id_cliente)
        {
            clientes.Add(new clCientes(nombre, apellidos, correo, telefono, numero_de_cliente, id_cliente));
        }

        public void Show()
        {
            clientes.ForEach(x => MessageBox.Show(x.Show()));

        }

    }
}
