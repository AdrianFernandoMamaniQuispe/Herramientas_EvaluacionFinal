namespace EvaluacionFinal
{
    partial class frmFactura
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNpago = new System.Windows.Forms.TextBox();
            this.txtSumt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnGestionarv = new System.Windows.Forms.Button();
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.txtNfact = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIgv = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnObtener = new System.Windows.Forms.Button();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRsocial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNpago
            // 
            this.txtNpago.Location = new System.Drawing.Point(858, 532);
            this.txtNpago.Name = "txtNpago";
            this.txtNpago.ReadOnly = true;
            this.txtNpago.Size = new System.Drawing.Size(124, 20);
            this.txtNpago.TabIndex = 57;
            // 
            // txtSumt
            // 
            this.txtSumt.Location = new System.Drawing.Point(858, 480);
            this.txtSumt.Name = "txtSumt";
            this.txtSumt.ReadOnly = true;
            this.txtSumt.Size = new System.Drawing.Size(124, 20);
            this.txtSumt.TabIndex = 55;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(771, 534);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 54;
            this.label12.Text = "Neto Pago:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(771, 510);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 53;
            this.label11.Text = "IGV 18% ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(771, 485);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "Suma Total";
            // 
            // btnSalir
            // 
            this.btnSalir.AllowDrop = true;
            this.btnSalir.BackColor = System.Drawing.Color.LightBlue;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(340, 489);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(107, 40);
            this.btnSalir.TabIndex = 51;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.AllowDrop = true;
            this.btnConsultar.BackColor = System.Drawing.Color.LightBlue;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Location = new System.Drawing.Point(179, 489);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(134, 40);
            this.btnConsultar.TabIndex = 50;
            this.btnConsultar.Text = "Consultar Comprobante";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnGestionarv
            // 
            this.btnGestionarv.AllowDrop = true;
            this.btnGestionarv.BackColor = System.Drawing.Color.LightBlue;
            this.btnGestionarv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarv.Location = new System.Drawing.Point(25, 489);
            this.btnGestionarv.Name = "btnGestionarv";
            this.btnGestionarv.Size = new System.Drawing.Size(134, 40);
            this.btnGestionarv.TabIndex = 49;
            this.btnGestionarv.Text = "Gestionar Compras\r\n";
            this.btnGestionarv.UseVisualStyleBackColor = false;
            this.btnGestionarv.Click += new System.EventHandler(this.btnGestionarv_Click);
            // 
            // dgvCompras
            // 
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.Location = new System.Drawing.Point(25, 144);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.Size = new System.Drawing.Size(960, 318);
            this.dgvCompras.TabIndex = 48;
            // 
            // txtNfact
            // 
            this.txtNfact.Location = new System.Drawing.Point(106, 56);
            this.txtNfact.Name = "txtNfact";
            this.txtNfact.Size = new System.Drawing.Size(108, 20);
            this.txtNfact.TabIndex = 21;
            this.txtNfact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNfact_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "FACTURA No.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(43, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "RUC No. ";
            // 
            // txtIgv
            // 
            this.txtIgv.Location = new System.Drawing.Point(858, 506);
            this.txtIgv.Name = "txtIgv";
            this.txtIgv.ReadOnly = true;
            this.txtIgv.Size = new System.Drawing.Size(124, 20);
            this.txtIgv.TabIndex = 56;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNfact);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(752, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 93);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.AllowDrop = true;
            this.btnRegistrar.BackColor = System.Drawing.Color.LightBlue;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Location = new System.Drawing.Point(628, 97);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(102, 25);
            this.btnRegistrar.TabIndex = 46;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(550, 101);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(62, 20);
            this.txtCantidad.TabIndex = 45;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(434, 100);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(52, 20);
            this.txtPrecio.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(388, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Precio:";
            // 
            // btnObtener
            // 
            this.btnObtener.Location = new System.Drawing.Point(342, 99);
            this.btnObtener.Name = "btnObtener";
            this.btnObtener.Size = new System.Drawing.Size(40, 23);
            this.btnObtener.TabIndex = 41;
            this.btnObtener.Text = "...";
            this.btnObtener.UseVisualStyleBackColor = true;
            this.btnObtener.Click += new System.EventHandler(this.btnObtener_Click);
            // 
            // cmbProductos
            // 
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Location = new System.Drawing.Point(152, 99);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(182, 21);
            this.cmbProductos.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Seleccionar Producto:";
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(152, 73);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(224, 20);
            this.dtFecha.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(492, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Fecha:";
            // 
            // txtRsocial
            // 
            this.txtRsocial.Location = new System.Drawing.Point(152, 47);
            this.txtRsocial.Name = "txtRsocial";
            this.txtRsocial.Size = new System.Drawing.Size(273, 20);
            this.txtRsocial.TabIndex = 36;
            this.txtRsocial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRsocial_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Razón Social:";
            // 
            // txtCodc
            // 
            this.txtCodc.Location = new System.Drawing.Point(152, 21);
            this.txtCodc.Name = "txtCodc";
            this.txtCodc.Size = new System.Drawing.Size(94, 20);
            this.txtCodc.TabIndex = 32;
            this.txtCodc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodc_KeyPress);
            this.txtCodc.Leave += new System.EventHandler(this.txtCodc_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Código Cliente:";
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 566);
            this.ControlBox = false;
            this.Controls.Add(this.txtNpago);
            this.Controls.Add(this.txtSumt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnGestionarv);
            this.Controls.Add(this.dgvCompras);
            this.Controls.Add(this.txtIgv);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnObtener);
            this.Controls.Add(this.cmbProductos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRsocial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodc);
            this.Controls.Add(this.label1);
            this.Name = "frmFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.frmFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNpago;
        private System.Windows.Forms.TextBox txtSumt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnGestionarv;
        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.TextBox txtNfact;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIgv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnObtener;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRsocial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodc;
        private System.Windows.Forms.Label label1;
    }
}