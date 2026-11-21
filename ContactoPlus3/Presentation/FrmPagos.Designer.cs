namespace ContactosPlus.Presentation
{
    partial class FrmPagos
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
            lblTitulo = new Label();
            picAvatar = new PictureBox();
            lblClienteNombre = new Label();
            txtMensualidad = new TextBox();
            txtMetodoPagoHeader = new TextBox();
            txtMesesHeader = new TextBox();
            cmbMetodoPago = new ComboBox();
            cmbMeses = new ComboBox();
            lblMonto = new Label();
            txtMonto = new TextBox();
            btnPagar = new Button();
            btnCancelar = new Button();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Times New Roman", 24F);
            lblTitulo.ForeColor = Color.FromArgb(25, 25, 25);
            lblTitulo.Location = new Point(45, 38);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(230, 36);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Pagos de clientes";
            // 
            // picAvatar
            // 
            picAvatar.BackColor = Color.FromArgb(238, 68, 56);
            picAvatar.Location = new Point(32, 130);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(96, 96);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 1;
            picAvatar.TabStop = false;
            // 
            // lblClienteNombre
            // 
            lblClienteNombre.AutoSize = true;
            lblClienteNombre.Font = new Font("Times New Roman", 14.25F);
            lblClienteNombre.ForeColor = Color.FromArgb(30, 30, 30);
            lblClienteNombre.Location = new Point(142, 138);
            lblClienteNombre.Name = "lblClienteNombre";
            lblClienteNombre.Size = new Size(110, 21);
            lblClienteNombre.TabIndex = 2;
            lblClienteNombre.Text = "Alexei Garcia";
            // 
            // txtMensualidad
            // 
            txtMensualidad.BackColor = Color.White;
            txtMensualidad.BorderStyle = BorderStyle.FixedSingle;
            txtMensualidad.Font = new Font("Segoe UI", 11F);
            txtMensualidad.ForeColor = Color.FromArgb(40, 40, 40);
            txtMensualidad.Location = new Point(135, 185);
            txtMensualidad.Name = "txtMensualidad";
            txtMensualidad.ReadOnly = true;
            txtMensualidad.Size = new Size(138, 27);
            txtMensualidad.TabIndex = 3;
            txtMensualidad.Text = " Mensualidad";
            // 
            // txtMetodoPagoHeader
            // 
            txtMetodoPagoHeader.BackColor = Color.White;
            txtMetodoPagoHeader.BorderStyle = BorderStyle.FixedSingle;
            txtMetodoPagoHeader.Font = new Font("Segoe UI", 11F);
            txtMetodoPagoHeader.ForeColor = Color.FromArgb(40, 40, 40);
            txtMetodoPagoHeader.Location = new Point(293, 188);
            txtMetodoPagoHeader.Name = "txtMetodoPagoHeader";
            txtMetodoPagoHeader.ReadOnly = true;
            txtMetodoPagoHeader.Size = new Size(178, 27);
            txtMetodoPagoHeader.TabIndex = 4;
            txtMetodoPagoHeader.Text = " Metodo de Pago";
            // 
            // txtMesesHeader
            // 
            txtMesesHeader.BackColor = Color.White;
            txtMesesHeader.BorderStyle = BorderStyle.FixedSingle;
            txtMesesHeader.Font = new Font("Segoe UI", 11F);
            txtMesesHeader.ForeColor = Color.FromArgb(40, 40, 40);
            txtMesesHeader.Location = new Point(502, 188);
            txtMesesHeader.Name = "txtMesesHeader";
            txtMesesHeader.ReadOnly = true;
            txtMesesHeader.Size = new Size(178, 27);
            txtMesesHeader.TabIndex = 5;
            txtMesesHeader.Text = " Meses";
            // 
            // cmbMetodoPago
            // 
            cmbMetodoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMetodoPago.Font = new Font("Segoe UI", 11F);
            cmbMetodoPago.FormattingEnabled = true;
            cmbMetodoPago.Items.AddRange(new object[] { "tarjeta", "efectivo", "transferencia" });
            cmbMetodoPago.Location = new Point(293, 228);
            cmbMetodoPago.Name = "cmbMetodoPago";
            cmbMetodoPago.Size = new Size(178, 28);
            cmbMetodoPago.TabIndex = 6;
            // 
            // cmbMeses
            // 
            cmbMeses.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMeses.Font = new Font("Segoe UI", 11F);
            cmbMeses.FormattingEnabled = true;
            cmbMeses.Items.AddRange(new object[] { "1", "3", "6", "12" });
            cmbMeses.Location = new Point(496, 228);
            cmbMeses.Name = "cmbMeses";
            cmbMeses.Size = new Size(178, 28);
            cmbMeses.TabIndex = 7;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Font = new Font("Times New Roman", 17.25F);
            lblMonto.ForeColor = Color.FromArgb(20, 20, 20);
            lblMonto.Location = new Point(344, 286);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(73, 26);
            lblMonto.TabIndex = 8;
            lblMonto.Text = "Monto";
            // 
            // txtMonto
            // 
            txtMonto.BackColor = Color.FromArgb(236, 236, 236);
            txtMonto.BorderStyle = BorderStyle.FixedSingle;
            txtMonto.Font = new Font("Segoe UI", 11.5F);
            txtMonto.ForeColor = Color.FromArgb(135, 135, 135);
            txtMonto.Location = new Point(482, 282);
            txtMonto.Name = "txtMonto";
            txtMonto.ReadOnly = true;
            txtMonto.Size = new Size(178, 28);
            txtMonto.TabIndex = 9;
            txtMonto.Text = " $300";
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.FromArgb(245, 245, 245);
            btnPagar.Font = new Font("Times New Roman", 13.5F);
            btnPagar.ForeColor = Color.FromArgb(25, 25, 25);
            btnPagar.Location = new Point(242, 355);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(114, 30);
            btnPagar.TabIndex = 10;
            btnPagar.Text = "pagar";
            btnPagar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(245, 245, 245);
            btnCancelar.Font = new Font("Times New Roman", 13.5F);
            btnCancelar.ForeColor = Color.FromArgb(25, 25, 25);
            btnCancelar.Location = new Point(378, 355);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(108, 30);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "canselar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(245, 245, 245);
            btnGuardar.Font = new Font("Times New Roman", 13.5F);
            btnGuardar.ForeColor = Color.FromArgb(25, 25, 25);
            btnGuardar.Location = new Point(514, 355);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(108, 30);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FrmPagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 236, 230);
            ClientSize = new Size(735, 425);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(btnPagar);
            Controls.Add(txtMonto);
            Controls.Add(lblMonto);
            Controls.Add(cmbMeses);
            Controls.Add(cmbMetodoPago);
            Controls.Add(txtMesesHeader);
            Controls.Add(txtMetodoPagoHeader);
            Controls.Add(txtMensualidad);
            Controls.Add(lblClienteNombre);
            Controls.Add(picAvatar);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmPagos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pagos de clientes";
            Load += FrmPagos_Load;
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Label lblClienteNombre;
        private System.Windows.Forms.TextBox txtMensualidad;
        private System.Windows.Forms.TextBox txtMetodoPagoHeader;
        private System.Windows.Forms.TextBox txtMesesHeader;
        private System.Windows.Forms.ComboBox cmbMetodoPago;
        private System.Windows.Forms.ComboBox cmbMeses;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
    }
}