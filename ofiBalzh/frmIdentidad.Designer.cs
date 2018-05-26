namespace ofiBalzh
{
    partial class frmIdentidad
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOficio = new System.Windows.Forms.TextBox();
            this.dateExpedicion = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtComprobantes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCertifica = new System.Windows.Forms.TextBox();
            this.progreso = new System.Windows.Forms.ProgressBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnCamaraWeb = new System.Windows.Forms.Button();
            this.btnDesdeArchivo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCrearOficio = new System.Windows.Forms.Button();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.txtMSG = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE DEL SOLICITANTE:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(36, 99);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(481, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(36, 159);
            this.txtDomicilio.Margin = new System.Windows.Forms.Padding(4);
            this.txtDomicilio.Multiline = true;
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(481, 57);
            this.txtDomicilio.TabIndex = 3;
            this.txtDomicilio.TextChanged += new System.EventHandler(this.txtDomicilio_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DOMICILIO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(534, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "OFICIO NUMERO:";
            // 
            // txtOficio
            // 
            this.txtOficio.Location = new System.Drawing.Point(657, 9);
            this.txtOficio.Name = "txtOficio";
            this.txtOficio.Size = new System.Drawing.Size(53, 20);
            this.txtOficio.TabIndex = 10;
            this.txtOficio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroOficio_KeyPress);
            // 
            // dateExpedicion
            // 
            this.dateExpedicion.Location = new System.Drawing.Point(479, 38);
            this.dateExpedicion.Name = "dateExpedicion";
            this.dateExpedicion.Size = new System.Drawing.Size(282, 20);
            this.dateExpedicion.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 241);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "PRUEBAS PRESENTADAS:";
            // 
            // txtComprobantes
            // 
            this.txtComprobantes.Location = new System.Drawing.Point(36, 262);
            this.txtComprobantes.Margin = new System.Windows.Forms.Padding(4);
            this.txtComprobantes.Multiline = true;
            this.txtComprobantes.Name = "txtComprobantes";
            this.txtComprobantes.Size = new System.Drawing.Size(481, 36);
            this.txtComprobantes.TabIndex = 4;
            this.txtComprobantes.TextChanged += new System.EventHandler(this.txtComprobantes_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(175, 241);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(232, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "(acta de nacimiento,recibo de luz, testigos, etc.)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(95, 138);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "(calle, numero, colonia, localidad )";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(184, 78);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "(Nombre y apellidos )";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 319);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "CERTIFICA:";
            // 
            // txtCertifica
            // 
            this.txtCertifica.Location = new System.Drawing.Point(35, 340);
            this.txtCertifica.Margin = new System.Windows.Forms.Padding(4);
            this.txtCertifica.Name = "txtCertifica";
            this.txtCertifica.Size = new System.Drawing.Size(361, 20);
            this.txtCertifica.TabIndex = 8;
            this.txtCertifica.Text = "DR. JOSE LUIS CUBAS HERNÁNDEZ";
            this.txtCertifica.TextChanged += new System.EventHandler(this.txtCertifica_TextChanged);
            // 
            // progreso
            // 
            this.progreso.Location = new System.Drawing.Point(0, 423);
            this.progreso.Name = "progreso";
            this.progreso.Size = new System.Drawing.Size(913, 15);
            this.progreso.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progreso.TabIndex = 21;
            this.progreso.Tag = "";
            this.progreso.Visible = false;
            // 
            // btnCamaraWeb
            // 
            this.btnCamaraWeb.Image = global::ofiBalzh.Properties.Resources.Hardware_Webcam_Icon_48;
            this.btnCamaraWeb.Location = new System.Drawing.Point(848, 78);
            this.btnCamaraWeb.Name = "btnCamaraWeb";
            this.btnCamaraWeb.Size = new System.Drawing.Size(49, 48);
            this.btnCamaraWeb.TabIndex = 24;
            this.btnCamaraWeb.UseVisualStyleBackColor = true;
            this.btnCamaraWeb.Click += new System.EventHandler(this.btnCamaraWeb_Click);
            // 
            // btnDesdeArchivo
            // 
            this.btnDesdeArchivo.Image = global::ofiBalzh.Properties.Resources.Folder_my_pictures_Icon_48;
            this.btnDesdeArchivo.Location = new System.Drawing.Point(848, 132);
            this.btnDesdeArchivo.Name = "btnDesdeArchivo";
            this.btnDesdeArchivo.Size = new System.Drawing.Size(49, 48);
            this.btnDesdeArchivo.TabIndex = 5;
            this.btnDesdeArchivo.UseVisualStyleBackColor = true;
            this.btnDesdeArchivo.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::ofiBalzh.Properties.Resources.foto;
            this.pictureBox1.Location = new System.Drawing.Point(537, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 270);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            this.pictureBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDoubleClick);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // btnCrearOficio
            // 
            this.btnCrearOficio.Image = global::ofiBalzh.Properties.Resources.Document_Microsoft_Word_Icon_32;
            this.btnCrearOficio.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCrearOficio.Location = new System.Drawing.Point(595, 372);
            this.btnCrearOficio.Name = "btnCrearOficio";
            this.btnCrearOficio.Size = new System.Drawing.Size(235, 45);
            this.btnCrearOficio.TabIndex = 7;
            this.btnCrearOficio.Text = "CREAR CONSTANCIA";
            this.btnCrearOficio.UseVisualStyleBackColor = true;
            this.btnCrearOficio.Click += new System.EventHandler(this.btnCrearOficio_Click);
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(713, 9);
            this.txtAño.MaxLength = 2;
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(48, 20);
            this.txtAño.TabIndex = 129;
            this.txtAño.Text = "2016";
            this.txtAño.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMSG
            // 
            this.txtMSG.BackColor = System.Drawing.SystemColors.Menu;
            this.txtMSG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMSG.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMSG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtMSG.Location = new System.Drawing.Point(540, 340);
            this.txtMSG.Multiline = true;
            this.txtMSG.Name = "txtMSG";
            this.txtMSG.ReadOnly = true;
            this.txtMSG.Size = new System.Drawing.Size(290, 26);
            this.txtMSG.TabIndex = 130;
            this.txtMSG.Text = "De un clic en la imagen o en el boton de Camara Web para empezar la captura";
            this.txtMSG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmIdentidad
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(904, 439);
            this.Controls.Add(this.txtMSG);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.btnCamaraWeb);
            this.Controls.Add(this.btnDesdeArchivo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progreso);
            this.Controls.Add(this.txtCertifica);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtComprobantes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCrearOficio);
            this.Controls.Add(this.dateExpedicion);
            this.Controls.Add(this.txtOficio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmIdentidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSTANCIA DE IDENTIDAD";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmIdentidad_FormClosed);
            this.Load += new System.EventHandler(this.frmIdentidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOficio;
        private System.Windows.Forms.DateTimePicker dateExpedicion;
        private System.Windows.Forms.Button btnCrearOficio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtComprobantes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCertifica;
        private System.Windows.Forms.ProgressBar progreso;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDesdeArchivo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnCamaraWeb;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.TextBox txtMSG;
    }
}

