namespace ContactosPlus
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            panelIzquierdo = new Panel();
            pictureBox2 = new PictureBox();
            lblVersion = new Label();
            lblSistema = new Label();
            lblApp = new Label();
            panelDerecho = new Panel();
            userControl11 = new componentelogin.UserControl1();
            panelIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelDerecho.SuspendLayout();
            SuspendLayout();
            // 
            // panelIzquierdo
            // 
            panelIzquierdo.BackColor = Color.FromArgb(5, 24, 61);
            panelIzquierdo.Controls.Add(pictureBox2);
            panelIzquierdo.Controls.Add(lblVersion);
            panelIzquierdo.Controls.Add(lblSistema);
            panelIzquierdo.Controls.Add(lblApp);
            panelIzquierdo.Dock = DockStyle.Left;
            panelIzquierdo.Location = new Point(0, 0);
            panelIzquierdo.Name = "panelIzquierdo";
            panelIzquierdo.Size = new Size(420, 700);
            panelIzquierdo.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.aludec;
            pictureBox2.Location = new Point(55, 71);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(286, 182);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.ForeColor = Color.Gainsboro;
            lblVersion.Location = new Point(25, 650);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(99, 19);
            lblVersion.TabIndex = 0;
            lblVersion.Text = "Versión 1.1.0.0";
            // 
            // lblSistema
            // 
            lblSistema.AutoSize = true;
            lblSistema.Font = new Font("Segoe UI", 16F);
            lblSistema.ForeColor = Color.FromArgb(80, 170, 255);
            lblSistema.Location = new Point(55, 320);
            lblSistema.Name = "lblSistema";
            lblSistema.Size = new Size(279, 30);
            lblSistema.TabIndex = 1;
            lblSistema.Text = "Aludec Automoción México";
            // 
            // lblApp
            // 
            lblApp.AutoSize = true;
            lblApp.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblApp.ForeColor = Color.White;
            lblApp.Location = new Point(25, 265);
            lblApp.Name = "lblApp";
            lblApp.Size = new Size(338, 45);
            lblApp.TabIndex = 2;
            lblApp.Text = "Gestión de Contactos";
            // 
            // panelDerecho
            // 
            panelDerecho.BackColor = Color.FromArgb(245, 246, 250);
            panelDerecho.Controls.Add(userControl11);
            panelDerecho.Dock = DockStyle.Fill;
            panelDerecho.Location = new Point(420, 0);
            panelDerecho.Name = "panelDerecho";
            panelDerecho.Size = new Size(780, 700);
            panelDerecho.TabIndex = 0;
            // 
            // userControl11
            // 
            userControl11.fondo = Color.White;
            userControl11.Location = new Point(101, 37);
            userControl11.MiContrasennia = "";
            userControl11.miLogo = (Image)resources.GetObject("userControl11.miLogo");
            userControl11.MiUsuario = "";
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(559, 600);
            userControl11.TabIndex = 0;
            userControl11.ValidarTexto += userControl11_ValidarTexto_1;
            userControl11.Load += userControl11_Load;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 700);
            Controls.Add(panelDerecho);
            Controls.Add(panelIzquierdo);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de Sesión";
            Load += frmLogin_Load;
            panelIzquierdo.ResumeLayout(false);
            panelIzquierdo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelDerecho.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelIzquierdo;
        private System.Windows.Forms.Panel panelDerecho;

        private System.Windows.Forms.Label lblApp;
        private System.Windows.Forms.Label lblSistema;
        private System.Windows.Forms.Label lblVersion;
        private PictureBox pictureBox2;
        private componentelogin.UserControl1 userControl11;
    }
}
