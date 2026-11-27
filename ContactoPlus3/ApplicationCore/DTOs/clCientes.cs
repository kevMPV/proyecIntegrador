using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactosPlus.ApplicationCore.DTOs
{
    internal class clCientes
    {
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string correo { get; set; }
        public int telefono { get; set; }
        public int numero_de_cliente { get; set; }
        public int id_cliente { get; set; }


        public clCientes(string nombre,string apellidos,string correo,int telefono,int numero_de_cliente,int id_cliente)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.correo = correo;
            this.telefono = telefono;
            this.numero_de_cliente = numero_de_cliente;
            this.id_cliente = id_cliente;
            
        }

        public String Show()
        {
            return $"{this.nombre},{this.apellidos},{this.correo},{this.telefono},{this.numero_de_cliente},{this.id_cliente},";
        }
    }
}
