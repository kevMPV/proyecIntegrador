namespace componentelogin
{
    partial class UserControl1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cardLogin = new Panel();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            chkRecordar = new CheckBox();
            linkOlvido = new LinkLabel();
            btnLogin = new Button();
            pbLogo = new PictureBox();
            cardLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // cardLogin
            // 
            cardLogin.BackColor = Color.White;
            cardLogin.BorderStyle = BorderStyle.FixedSingle;
            cardLogin.Controls.Add(pbLogo);
            cardLogin.Controls.Add(lblTitulo);
            cardLogin.Controls.Add(lblSubtitulo);
            cardLogin.Controls.Add(lblUsuario);
            cardLogin.Controls.Add(txtUsuario);
            cardLogin.Controls.Add(lblPassword);
            cardLogin.Controls.Add(txtPassword);
            cardLogin.Controls.Add(chkRecordar);
            cardLogin.Controls.Add(linkOlvido);
            cardLogin.Controls.Add(btnLogin);
            cardLogin.Location = new Point(3, 3);
            cardLogin.Name = "cardLogin";
            cardLogin.Size = new Size(550, 520);
            cardLogin.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitulo.Location = new Point(150, 50);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(218, 45);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Iniciar Sesión";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 11F);
            lblSubtitulo.ForeColor = Color.DimGray;
            lblSubtitulo.Location = new Point(70, 110);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(330, 20);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Ingrese sus credenciales para acceder al sistema.";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblUsuario.Location = new Point(50, 170);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(63, 20);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 12F);
            txtUsuario.Location = new Point(50, 200);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(450, 29);
            txtUsuario.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPassword.Location = new Point(50, 270);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(88, 20);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Contraseña";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(50, 300);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(450, 29);
            txtPassword.TabIndex = 5;
            // 
            // chkRecordar
            // 
            chkRecordar.AutoSize = true;
            chkRecordar.Location = new Point(50, 360);
            chkRecordar.Name = "chkRecordar";
            chkRecordar.Size = new Size(132, 19);
            chkRecordar.TabIndex = 6;
            chkRecordar.Text = "Recordar mi usuario";
            // 
            // linkOlvido
            // 
            linkOlvido.AutoSize = true;
            linkOlvido.Location = new Point(320, 360);
            linkOlvido.Name = "linkOlvido";
            linkOlvido.Size = new Size(128, 15);
            linkOlvido.TabIndex = 7;
            linkOlvido.TabStop = true;
            linkOlvido.Text = "¿Olvidó su contraseña?";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 102, 255);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(50, 420);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(450, 50);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Iniciar Sesión";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.logologistica;
            pbLogo.Location = new Point(415, 50);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(100, 108);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 9;
            pbLogo.TabStop = false;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cardLogin);
            Name = "UserControl1";
            Size = new Size(559, 528);
            cardLogin.ResumeLayout(false);
            cardLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel cardLogin;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblUsuario;
        private TextBox txtUsuario;
        private Label lblPassword;
        private TextBox txtPassword;
        private CheckBox chkRecordar;
        private LinkLabel linkOlvido;
        private Button btnLogin;
        private PictureBox pbLogo;
    }
}
