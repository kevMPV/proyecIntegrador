namespace ContactosPlus.Presentation
{
    partial class frmRegistros
    {
        private System.ComponentModel.IContainer components = null;

        // Etiquetas principales
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblTelefono;

        // Contenedores para simular el estilo moderno de las cajas
        private System.Windows.Forms.Panel pnlNombre;
        private System.Windows.Forms.Panel pnlApellido;
        private System.Windows.Forms.Panel pnlCorreo;
        private System.Windows.Forms.Panel pnlTelefono;

        // Campos de texto
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtTelefono;

        // Etiquetas para los iconos
        private System.Windows.Forms.Label lblIconoCorreo;
        private System.Windows.Forms.Label lblIconoTelefono;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            lblNombreCompleto = new Label();
            lblCorreo = new Label();
            lblTelefono = new Label();
            pnlNombre = new Panel();
            txtNombre = new TextBox();
            pnlApellido = new Panel();
            txtApellidos = new TextBox();
            pnlCorreo = new Panel();
            txtCorreo = new TextBox();
            lblIconoCorreo = new Label();
            pnlTelefono = new Panel();
            txtTelefono = new TextBox();
            lblIconoTelefono = new Label();
            btnGuardar = new Button();
            panel1 = new Panel();
            txtNumeroDeCliente = new TextBox();
            label1 = new Label();
            lblNumeroDeCliente = new Label();
            panel2 = new Panel();
            txtId_cliente = new TextBox();
            label3 = new Label();
            lblId_Cliente = new Label();
            lbnMostrarClientes = new Button();
            btnPagos = new Button();
            pnlNombre.SuspendLayout();
            pnlApellido.SuspendLayout();
            pnlCorreo.SuspendLayout();
            pnlTelefono.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombreCompleto
            // 
            lblNombreCompleto.AutoSize = true;
            lblNombreCompleto.Font = new Font("Segoe UI", 10F);
            lblNombreCompleto.ForeColor = Color.FromArgb(45, 45, 45);
            lblNombreCompleto.Location = new Point(30, 25);
            lblNombreCompleto.Name = "lblNombreCompleto";
            lblNombreCompleto.Size = new Size(135, 19);
            lblNombreCompleto.TabIndex = 0;
            lblNombreCompleto.Text = "1. Nombre completo";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 10F);
            lblCorreo.ForeColor = Color.FromArgb(45, 45, 45);
            lblCorreo.Location = new Point(30, 125);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(136, 19);
            lblCorreo.TabIndex = 3;
            lblCorreo.Text = "2. Correo electrónico";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 10F);
            lblTelefono.ForeColor = Color.FromArgb(45, 45, 45);
            lblTelefono.Location = new Point(30, 225);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(147, 19);
            lblTelefono.TabIndex = 5;
            lblTelefono.Text = "3. Número de teléfono";
            // 
            // pnlNombre
            // 
            pnlNombre.BackColor = Color.White;
            pnlNombre.BorderStyle = BorderStyle.FixedSingle;
            pnlNombre.Controls.Add(txtNombre);
            pnlNombre.Location = new Point(30, 52);
            pnlNombre.Name = "pnlNombre";
            pnlNombre.Size = new Size(260, 38);
            pnlNombre.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Font = new Font("Segoe UI", 10F);
            txtNombre.Location = new Point(10, 9);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre de pila";
            txtNombre.Size = new Size(238, 18);
            txtNombre.TabIndex = 0;
            // 
            // pnlApellido
            // 
            pnlApellido.BackColor = Color.White;
            pnlApellido.BorderStyle = BorderStyle.FixedSingle;
            pnlApellido.Controls.Add(txtApellidos);
            pnlApellido.Location = new Point(305, 52);
            pnlApellido.Name = "pnlApellido";
            pnlApellido.Size = new Size(260, 38);
            pnlApellido.TabIndex = 2;
            // 
            // txtApellidos
            // 
            txtApellidos.BorderStyle = BorderStyle.None;
            txtApellidos.Font = new Font("Segoe UI", 10F);
            txtApellidos.Location = new Point(10, 9);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.PlaceholderText = "Apellidos";
            txtApellidos.Size = new Size(238, 18);
            txtApellidos.TabIndex = 0;
            // 
            // pnlCorreo
            // 
            pnlCorreo.BackColor = Color.White;
            pnlCorreo.BorderStyle = BorderStyle.FixedSingle;
            pnlCorreo.Controls.Add(txtCorreo);
            pnlCorreo.Controls.Add(lblIconoCorreo);
            pnlCorreo.Location = new Point(30, 152);
            pnlCorreo.Name = "pnlCorreo";
            pnlCorreo.Size = new Size(535, 38);
            pnlCorreo.TabIndex = 4;
            // 
            // txtCorreo
            // 
            txtCorreo.BorderStyle = BorderStyle.None;
            txtCorreo.Font = new Font("Segoe UI", 10F);
            txtCorreo.Location = new Point(36, 9);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(485, 18);
            txtCorreo.TabIndex = 1;
            // 
            // lblIconoCorreo
            // 
            lblIconoCorreo.AutoSize = true;
            lblIconoCorreo.Font = new Font("Segoe UI Symbol", 11F);
            lblIconoCorreo.ForeColor = Color.DimGray;
            lblIconoCorreo.Location = new Point(8, 7);
            lblIconoCorreo.Name = "lblIconoCorreo";
            lblIconoCorreo.Size = new Size(24, 20);
            lblIconoCorreo.TabIndex = 0;
            lblIconoCorreo.Text = "✉";
            // 
            // pnlTelefono
            // 
            pnlTelefono.BackColor = Color.White;
            pnlTelefono.BorderStyle = BorderStyle.FixedSingle;
            pnlTelefono.Controls.Add(txtTelefono);
            pnlTelefono.Controls.Add(lblIconoTelefono);
            pnlTelefono.Location = new Point(30, 252);
            pnlTelefono.Name = "pnlTelefono";
            pnlTelefono.Size = new Size(535, 38);
            pnlTelefono.TabIndex = 6;
            // 
            // txtTelefono
            // 
            txtTelefono.BorderStyle = BorderStyle.None;
            txtTelefono.Font = new Font("Segoe UI", 10F);
            txtTelefono.Location = new Point(36, 9);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(485, 18);
            txtTelefono.TabIndex = 1;
            // 
            // lblIconoTelefono
            // 
            lblIconoTelefono.AutoSize = true;
            lblIconoTelefono.Font = new Font("Segoe UI Symbol", 11F);
            lblIconoTelefono.ForeColor = Color.DimGray;
            lblIconoTelefono.Location = new Point(8, 7);
            lblIconoTelefono.Name = "lblIconoTelefono";
            lblIconoTelefono.Size = new Size(22, 20);
            lblIconoTelefono.TabIndex = 0;
            lblIconoTelefono.Text = "✆";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(398, 486);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 23);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "GuardarCliente";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtNumeroDeCliente);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(30, 340);
            panel1.Name = "panel1";
            panel1.Size = new Size(535, 38);
            panel1.TabIndex = 9;
            // 
            // txtNumeroDeCliente
            // 
            txtNumeroDeCliente.BorderStyle = BorderStyle.None;
            txtNumeroDeCliente.Font = new Font("Segoe UI", 10F);
            txtNumeroDeCliente.Location = new Point(36, 9);
            txtNumeroDeCliente.Name = "txtNumeroDeCliente";
            txtNumeroDeCliente.Size = new Size(485, 18);
            txtNumeroDeCliente.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 11F);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(8, 7);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 0;
            label1.Text = "✆";
            // 
            // lblNumeroDeCliente
            // 
            lblNumeroDeCliente.AutoSize = true;
            lblNumeroDeCliente.Font = new Font("Segoe UI", 10F);
            lblNumeroDeCliente.ForeColor = Color.FromArgb(45, 45, 45);
            lblNumeroDeCliente.Location = new Point(30, 313);
            lblNumeroDeCliente.Name = "lblNumeroDeCliente";
            lblNumeroDeCliente.Size = new Size(137, 19);
            lblNumeroDeCliente.TabIndex = 8;
            lblNumeroDeCliente.Text = "4.Numero De Cliente";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtId_cliente);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(30, 420);
            panel2.Name = "panel2";
            panel2.Size = new Size(535, 38);
            panel2.TabIndex = 11;
            // 
            // txtId_cliente
            // 
            txtId_cliente.BorderStyle = BorderStyle.None;
            txtId_cliente.Font = new Font("Segoe UI", 10F);
            txtId_cliente.Location = new Point(36, 9);
            txtId_cliente.Name = "txtId_cliente";
            txtId_cliente.Size = new Size(485, 18);
            txtId_cliente.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 11F);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(8, 7);
            label3.Name = "label3";
            label3.Size = new Size(22, 20);
            label3.TabIndex = 0;
            label3.Text = "✆";
            // 
            // lblId_Cliente
            // 
            lblId_Cliente.AutoSize = true;
            lblId_Cliente.Font = new Font("Segoe UI", 10F);
            lblId_Cliente.ForeColor = Color.FromArgb(45, 45, 45);
            lblId_Cliente.Location = new Point(30, 393);
            lblId_Cliente.Name = "lblId_Cliente";
            lblId_Cliente.Size = new Size(78, 19);
            lblId_Cliente.TabIndex = 10;
            lblId_Cliente.Text = "4.Id Cliente";
            // 
            // lbnMostrarClientes
            // 
            lbnMostrarClientes.Location = new Point(115, 486);
            lbnMostrarClientes.Name = "lbnMostrarClientes";
            lbnMostrarClientes.Size = new Size(123, 23);
            lbnMostrarClientes.TabIndex = 12;
            lbnMostrarClientes.Text = "MostrarClientes";
            lbnMostrarClientes.UseVisualStyleBackColor = true;
            lbnMostrarClientes.Click += lbnMostrarClientes_Click;
            // 
            // btnPagos
            // 
            btnPagos.Location = new Point(264, 486);
            btnPagos.Name = "btnPagos";
            btnPagos.Size = new Size(109, 23);
            btnPagos.TabIndex = 13;
            btnPagos.Text = "pagos";
            btnPagos.UseVisualStyleBackColor = true;
            btnPagos.Click += btnPagos_Click;
            // 
            // frmRegistros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(600, 521);
            Controls.Add(btnPagos);
            Controls.Add(lbnMostrarClientes);
            Controls.Add(panel2);
            Controls.Add(lblId_Cliente);
            Controls.Add(panel1);
            Controls.Add(lblNumeroDeCliente);
            Controls.Add(btnGuardar);
            Controls.Add(pnlTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(pnlCorreo);
            Controls.Add(lblCorreo);
            Controls.Add(pnlApellido);
            Controls.Add(pnlNombre);
            Controls.Add(lblNombreCompleto);
            Name = "frmRegistros";
            Text = "Formulario de Registro";
            FormClosed += frmRegistros_FormClosed;
            pnlNombre.ResumeLayout(false);
            pnlNombre.PerformLayout();
            pnlApellido.ResumeLayout(false);
            pnlApellido.PerformLayout();
            pnlCorreo.ResumeLayout(false);
            pnlCorreo.PerformLayout();
            pnlTelefono.ResumeLayout(false);
            pnlTelefono.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Panel panel1;
        private TextBox txtNumeroDeCliente;
        private Label label1;
        private Label lblNumeroDeCliente;
        private Panel panel2;
        private TextBox txtId_cliente;
        private Label label3;
        private Label lblId_Cliente;
        private Button lbnMostrarClientes;
        private Button btnPagos;
    }
}