using System.ComponentModel;

namespace componentelogin
{
    public partial class UserControl1 : UserControl
    {
        [Category("IEDEP")]
        [Description("Cambia el logo de la empresa")]
        public Image? miLogo{
            get => pbLogo.Image;
            set => pbLogo.Image =value;
        }

        [Category("IEDEP")]
        [Description("Asignar o extrar usuario para el acceso al Login")]
        public string? MiUsuario { get; set; }

        [Category("IEDEP")]
        [Description("Asignar o extrar contarseña para el acceso al Login")]
        public string? MiContrasennia { get; set; }

        [Category("IEDEP")]
        [Description("Cambia el color del panel")]
        public Color fondo
        {
            get => cardLogin.BackColor;
            set => cardLogin.BackColor = value;
        }

        //esto es para crear eventos en el rayito
        [Category("IEDEP")]
        [Description("Extrae el usuario ingresado por el cliente")]
        public event EventHandler<string>? ValidarTexto;


        public UserControl1()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string pass = txtPassword.Text.Trim();
            

            if (usuario.Length > 0)
            {

                if (pass.Length > 0)
                {
                    if (usuario.CompareTo(this.MiUsuario)==0 && pass.CompareTo(this.MiContrasennia)==0 )
                    {
                        // Abrimos la siguiente ventana (FrmDirectorioTelefonico)
                        // MisFunciones.mensajeAlerta("Bienvenido al sistemas");
                        //Este código dispara el evento
                      

                        txtUsuario.Clear();
                        txtPassword.Clear();

                        //this.Hide();// ocultar login
                       
                        ValidarTexto?.Invoke(this, usuario);
                    }
                    else
                    {
                        MisFunciones.mensajeAlerta("Verifica tus datos");
                        txtUsuario.Text = "";
                        txtPassword.Text = "";
                        txtUsuario.Focus();
                    }
                }
                else
                {
                    MisFunciones.mensajeAlerta("Agrega tu contraseña");
                    txtPassword.Focus();
                }
            }
            else
            {
                MisFunciones.mensajeAlerta("Agrega tu usuario");
                txtUsuario.Focus();
            }
        }
    }
}
