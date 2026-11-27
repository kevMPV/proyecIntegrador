using ContactosPlus.Presentation;
using ContactosPlus.Shared;

namespace ContactosPlus
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }



        private void userControl11_ValidarTexto_1(object sender, string e)
        {
            this.Hide();//oculta la ventana actual
            frmRegistros obj = new frmRegistros(this);//se crea una instancia de la siguiente ventana

            obj.ShowDialog();//muestra la segunda ventana en pantalla

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            userControl11.MiUsuario = "administrador";
            userControl11.MiContrasennia = "password123";
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }
    }
}
       


      
      




