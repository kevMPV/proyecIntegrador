using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactosPlus.ApplicationCore.UseCases;
namespace ContactosPlus.Presentation
{
    public partial class frmRegistros : Form
    {
        private frmLogin pantalla;
        public frmRegistros(frmLogin pantalla)
        {
            this.pantalla = pantalla;


            InitializeComponent();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {

        }


        clListaClientes clientes = new clListaClientes();
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Valida(txtNombre, "Escribe tu nombre"))
            {
                if (Valida(txtApellidos, "Escribe tus apellidos"))
                {
                    if (Valida(txtCorreo, "Ingresa tu correo"))
                    {
                        if (Valida(txtTelefono, "Ingresa tu telefono"))
                        {
                            if (Valida(txtNumeroDeCliente, "Ingresa tu numero de cliente"))
                            {
                                if (Valida(txtId_cliente, "Ingresa tu id "))
                                {

                                    clientes.Add(
                                        txtNombre.Text,
                                        txtApellidos.Text,
                                        txtCorreo.Text,
                                        Convert.ToInt32(txtTelefono.Text),
                                        Convert.ToInt32(txtNumeroDeCliente.Text),
                                        Convert.ToInt32(txtId_cliente.Text)
                                        );

                                    MessageBox.Show("Cliente Registrado");

                                    txtNombre.Clear();
                                    txtApellidos.Clear();
                                    txtCorreo.Clear();
                                    txtTelefono.Clear();
                                    txtNumeroDeCliente.Clear();
                                    txtId_cliente.Clear();
                                    txtNombre.Focus();
                                }
                            }

                        }
                    }
                }
            }
        }

        public bool Valida(TextBox componente, string error)
        {
            if (componente.Text.Length > 0)
                return true;
            else
            {
                MessageBox.Show(error);
                componente.Focus();
                return false;
            }
        }

        private void frmRegistros_FormClosed(object sender, FormClosedEventArgs e)
        {
            pantalla.Show();
        }

        private void lbnMostrarClientes_Click(object sender, EventArgs e)
        {
            clientes.Show();
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            FrmPagos pagos = new FrmPagos();
            pagos.ShowDialog();
        }
    }
}
