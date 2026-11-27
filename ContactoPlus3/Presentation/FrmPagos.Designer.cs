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
            btnPagar = new Button();
            btnCancelar = new Button();
            btnMostrarPagos = new Button();
            pnlCorreo = new Panel();
            txtPago = new TextBox();
            lblIconoCorreo = new Label();
            lblCorreo = new Label();
            panel1 = new Panel();
            label1 = new Label();
            cbFormaDePago = new ComboBox();
            label2 = new Label();
            panel2 = new Panel();
            txtCantidad = new TextBox();
            label3 = new Label();
            lblCantidad = new Label();
            pnlCorreo.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Times New Roman", 24F);
            lblTitulo.ForeColor = Color.FromArgb(25, 25, 25);
            lblTitulo.Location = new Point(32, 24);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(230, 36);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Pagos de clientes";
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.FromArgb(245, 245, 245);
            btnPagar.Font = new Font("Times New Roman", 13.5F);
            btnPagar.ForeColor = Color.FromArgb(25, 25, 25);
            btnPagar.Location = new Point(111, 400);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(114, 30);
            btnPagar.TabIndex = 10;
            btnPagar.Text = "pagar";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(245, 245, 245);
            btnCancelar.Font = new Font("Times New Roman", 13.5F);
            btnCancelar.ForeColor = Color.FromArgb(25, 25, 25);
            btnCancelar.Location = new Point(249, 400);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(111, 30);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "canselar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnMostrarPagos
            // 
            btnMostrarPagos.BackColor = Color.FromArgb(245, 245, 245);
            btnMostrarPagos.Font = new Font("Times New Roman", 13.5F);
            btnMostrarPagos.ForeColor = Color.FromArgb(25, 25, 25);
            btnMostrarPagos.Location = new Point(386, 400);
            btnMostrarPagos.Name = "btnMostrarPagos";
            btnMostrarPagos.Size = new Size(147, 30);
            btnMostrarPagos.TabIndex = 12;
            btnMostrarPagos.Text = "Mostrar Pagos";
            btnMostrarPagos.UseVisualStyleBackColor = false;
            // 
            // pnlCorreo
            // 
            pnlCorreo.BackColor = Color.White;
            pnlCorreo.BorderStyle = BorderStyle.FixedSingle;
            pnlCorreo.Controls.Add(txtPago);
            pnlCorreo.Controls.Add(lblIconoCorreo);
            pnlCorreo.Location = new Point(32, 135);
            pnlCorreo.Name = "pnlCorreo";
            pnlCorreo.Size = new Size(535, 38);
            pnlCorreo.TabIndex = 14;
            // 
            // txtPago
            // 
            txtPago.BorderStyle = BorderStyle.None;
            txtPago.Font = new Font("Segoe UI", 10F);
            txtPago.Location = new Point(45, 9);
            txtPago.Name = "txtPago";
            txtPago.Size = new Size(478, 18);
            txtPago.TabIndex = 1;
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
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 10F);
            lblCorreo.ForeColor = Color.FromArgb(45, 45, 45);
            lblCorreo.Location = new Point(32, 108);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(109, 19);
            lblCorreo.TabIndex = 13;
            lblCorreo.Text = "1.Fecha de Pago";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cbFormaDePago);
            panel1.Location = new Point(32, 233);
            panel1.Name = "panel1";
            panel1.Size = new Size(535, 38);
            panel1.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 11F);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(8, 7);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "✉";
            // 
            // cbFormaDePago
            // 
            cbFormaDePago.FormattingEnabled = true;
            cbFormaDePago.Location = new Point(54, 7);
            cbFormaDePago.Name = "cbFormaDePago";
            cbFormaDePago.Size = new Size(462, 23);
            cbFormaDePago.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.FromArgb(45, 45, 45);
            label2.Location = new Point(32, 206);
            label2.Name = "label2";
            label2.Size = new Size(115, 19);
            label2.TabIndex = 15;
            label2.Text = "2.Forma De Pago";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtCantidad);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(32, 320);
            panel2.Name = "panel2";
            panel2.Size = new Size(535, 38);
            panel2.TabIndex = 18;
            // 
            // txtCantidad
            // 
            txtCantidad.BorderStyle = BorderStyle.None;
            txtCantidad.Font = new Font("Segoe UI", 10F);
            txtCantidad.Location = new Point(38, 9);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(485, 18);
            txtCantidad.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 11F);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(8, 7);
            label3.Name = "label3";
            label3.Size = new Size(24, 20);
            label3.TabIndex = 0;
            label3.Text = "✉";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 10F);
            lblCantidad.ForeColor = Color.FromArgb(45, 45, 45);
            lblCantidad.Location = new Point(32, 289);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(75, 19);
            lblCantidad.TabIndex = 17;
            lblCantidad.Text = "3.Cantidad";
            // 
            // FrmPagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 236, 230);
            ClientSize = new Size(588, 458);
            Controls.Add(lblCantidad);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(pnlCorreo);
            Controls.Add(lblCorreo);
            Controls.Add(btnMostrarPagos);
            Controls.Add(btnCancelar);
            Controls.Add(btnPagar);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmPagos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pagos de clientes";
            Load += FrmPagos_Load;
            pnlCorreo.ResumeLayout(false);
            pnlCorreo.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnMostrarPagos;
        private Panel pnlCorreo;
        private TextBox txtPago;
        private Label lblIconoCorreo;
        private Label lblCorreo;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private ComboBox cbFormaDePago;
        private Panel panel2;
        private TextBox txtCantidad;
        private Label label3;
        private Label lblCantidad;
    }
}