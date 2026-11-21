using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactosPlus.Presentation
{
    public partial class frmRegistros : Form
    {
        public frmRegistros()
        {
            InitializeComponent();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length > 0)
            {
                if (txtApellido.Text.Length > 0)
                {
                    //Guardar usando agregacion
                }
                else
                {
                    MessageBox.Show("Escribe tu apellido completo");
                }
            }
            else
            {
                MessageBox.Show("Escribe tu nombre completo");
            }
            
        }
    }
}
