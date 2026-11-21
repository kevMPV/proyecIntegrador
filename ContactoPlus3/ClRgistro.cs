using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactosPlus
{
    internal class ClRgistro
    {
        public string nombre { get; set; }
        public string apellido { get; set; }

        public ClRgistro(string nombre,string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public String Show()
        {
            return $"{this.nombre},{this.apellido}";
        }
    }
}
