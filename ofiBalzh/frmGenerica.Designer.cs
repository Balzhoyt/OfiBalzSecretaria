namespace ofiBalzh
{
    partial class frmGenerica
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
            this.txtOficio = new System.Windows.Forms.TextBox();
            this.lblOficio = new System.Windows.Forms.Label();
            this.txtContenido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.progreso = new System.Windows.Forms.ProgressBar();
            this.txtExpediente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.cmbExpediente = new System.Windows.Forms.ComboBox();
            this.dateFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtOficio
            // 
            this.txtOficio.Location = new System.Drawing.Point(575, 21);
            this.txtOficio.MaxLength = 4;
            this.txtOficio.Name = "txtOficio";
            this.txtOficio.Size = new System.Drawing.Size(34, 20);
            this.txtOficio.TabIndex = 118;
            this.txtOficio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOficio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOficio_KeyPress);
            // 
            // lblOficio
            // 
            this.lblOficio.AutoSize = true;
            this.lblOficio.Location = new System.Drawing.Point(473, 24);
            this.lblOficio.Name = "lblOficio";
            this.lblOficio.Size = new System.Drawing.Size(96, 13);
            this.lblOficio.TabIndex = 117;
            this.lblOficio.Text = "OFICIO NUMERO:";
            // 
            // txtContenido
            // 
            this.txtContenido.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContenido.Location = new System.Drawing.Point(109, 183);
            this.txtContenido.Margin = new System.Windows.Forms.Padding(4);
            this.txtContenido.MaxLength = 3000;
            this.txtContenido.Multiline = true;
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.Size = new System.Drawing.Size(550, 193);
            this.txtContenido.TabIndex = 109;
            this.txtContenido.Text = "El que suscribe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 120;
            this.label1.Text = "ASUNTO:";
            // 
            // txtAsunto
            // 
            this.txtAsunto.Location = new System.Drawing.Point(423, 73);
            this.txtAsunto.MaxLength = 100;
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(236, 20);
            this.txtAsunto.TabIndex = 121;
            this.txtAsunto.Text = "EL QUE SE INDICA";
            this.txtAsunto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAsunto.TextChanged += new System.EventHandler(this.txtAsunto_TextChanged);
            // 
            // btnCrear
            // 
            this.btnCrear.Image = global::ofiBalzh.Properties.Resources.Document_Microsoft_Word_Icon_32;
            this.btnCrear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCrear.Location = new System.Drawing.Point(423, 392);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(235, 45);
            this.btnCrear.TabIndex = 122;
            this.btnCrear.Text = "CREAR ";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrearPatente_Click);
            // 
            // progreso
            // 
            this.progreso.Location = new System.Drawing.Point(-3, 451);
            this.progreso.Margin = new System.Windows.Forms.Padding(2);
            this.progreso.Name = "progreso";
            this.progreso.Size = new System.Drawing.Size(782, 12);
            this.progreso.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progreso.TabIndex = 123;
            this.progreso.Tag = "";
            this.progreso.Visible = false;
            // 
            // txtExpediente
            // 
            this.txtExpediente.Location = new System.Drawing.Point(628, 47);
            this.txtExpediente.MaxLength = 3;
            this.txtExpediente.Name = "txtExpediente";
            this.txtExpediente.Size = new System.Drawing.Size(30, 20);
            this.txtExpediente.TabIndex = 125;
            this.txtExpediente.Text = "2";
            this.txtExpediente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtExpediente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExpediente_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 124;
            this.label2.Text = "EXPEDIENTE:";
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(610, 21);
            this.txtAño.MaxLength = 4;
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(48, 20);
            this.txtAño.TabIndex = 126;
            this.txtAño.Text = "2016";
            this.txtAño.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAño.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAño_KeyPress);
            // 
            // cmbExpediente
            // 
            this.cmbExpediente.FormattingEnabled = true;
            this.cmbExpediente.Items.AddRange(new object[] {
            "PRESIDENCIA MUNICIPAL",
            "SECRETARIA",
            "SINDICATURA",
            "REGIDURIA",
            "TESORERIA MUNICIPAL",
            "GOBERNADOR DEL ESTADO",
            "SEFIPLAN",
            "H. CONGRESO DEL ESTADO",
            "SESIONES DE CABILDO",
            "SOLICITUDES RECIBIDAS A PARTICULARES",
            "COMANDANCIA DE POLICIA",
            "ESTADISTICA DE DEGUELLO VACUNO",
            "OFICIOS DE COMISION",
            "FIERROS QUEMADORES",
            "CONTRALORIA MUNICIPAL",
            "OBRAS PUBLICAS",
            "DIF MUNICIPAL",
            "JURIDICO",
            "PROTECCION CIVIL",
            "PERMISOS DE BAILES Y ANUENCIAS",
            "SECRETARIA DE GOB",
            "SECRETARIA DE SALUD",
            "SECRETARIA DE COMUNICACIONES Y TRASPORTES",
            "EDUCACION Y CULTURA",
            "ORFIS",
            "OPORTUNIDADES",
            "RECURSOS HUMANOS",
            "FOMENTO AGROPECUARIO",
            "CERTIFICACIONES",
            "JUNTA MUNICIPAL DE RECLUTAMIENTO",
            "SOLICITUDES DE ESCUELAS",
            "SINDICATOS DE EMPLEADOS MUNICIPALES",
            "SOLICITUDES DIRECCIONES INTERNAS",
            "SEDESOL",
            "SALON SOCIAL",
            "NOMBRAMIENTOS",
            "COMUDE",
            "SUBSECRETARIA DE GOBIERMO",
            "PARQUE VEHICULAR",
            "ECOLOGIA Y MEDIO AMBIENTE",
            "CATASTRO MUNICIPAL",
            "PLANTILLA DE PERSONAL",
            "INVENTARIO",
            "SEDENA",
            "DIF ESTATAL",
            "TRANSITO DEL ESTADO",
            "SEP",
            "INVEDEM",
            "CFE",
            "OBLIGACIONES Y RESPONSABILIDADES",
            "MATERIAL INVENTARIABLE",
            "SEV",
            "EDITOS",
            "JEM",
            "SSP",
            "IVAI",
            "ICATVER",
            "CENTRO DE SALUD, JURISDICCION SANITARIA",
            "ESPACIOS EDUCATIVOS",
            "REGISTRO CIVIL",
            "ESPACIOS EDUCATIVOS",
            "SEDATU",
            "SECTUR",
            "JUNTA DE MEJORAS",
            "INE",
            "STPS",
            "DESTRABA/SAT",
            "SAE",
            "CONVENIOS"});
            this.cmbExpediente.Location = new System.Drawing.Point(423, 47);
            this.cmbExpediente.Name = "cmbExpediente";
            this.cmbExpediente.Size = new System.Drawing.Size(204, 21);
            this.cmbExpediente.TabIndex = 127;
            this.cmbExpediente.Text = "SECRETARIA";
            this.cmbExpediente.SelectedIndexChanged += new System.EventHandler(this.cmbExpediente_SelectedIndexChanged);
            // 
            // dateFecha
            // 
            this.dateFecha.Location = new System.Drawing.Point(158, 392);
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.Size = new System.Drawing.Size(200, 20);
            this.dateFecha.TabIndex = 128;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(106, 395);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(45, 13);
            this.lblFecha.TabIndex = 129;
            this.lblFecha.Text = "FECHA:";
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(109, 121);
            this.txtA.MaxLength = 500;
            this.txtA.Multiline = true;
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(294, 55);
            this.txtA.TabIndex = 130;
            this.txtA.Text = "A QUIEN CORRESPONDA";
            this.txtA.TextChanged += new System.EventHandler(this.txtA_TextChanged);
            // 
            // frmGenerica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 465);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dateFecha);
            this.Controls.Add(this.cmbExpediente);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.txtExpediente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progreso);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtAsunto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOficio);
            this.Controls.Add(this.lblOficio);
            this.Controls.Add(this.txtContenido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmGenerica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  GENERADOR DE DOCUMENTOS DIVERSOS";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmGenerica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtOficio;
        private System.Windows.Forms.Label lblOficio;
        private System.Windows.Forms.TextBox txtContenido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.ProgressBar progreso;
        private System.Windows.Forms.TextBox txtExpediente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.ComboBox cmbExpediente;
        private System.Windows.Forms.DateTimePicker dateFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtA;
    }
}