namespace ofiBalzh
{
    partial class frmReportes
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
            this.cmbGenerarReporte = new System.Windows.Forms.Button();
            this.dateDesde = new System.Windows.Forms.DateTimePicker();
            this.dateHasta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFecha = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.progreso = new System.Windows.Forms.ProgressBar();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.txtOficio = new System.Windows.Forms.TextBox();
            this.lblOficio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbGenerarReporte
            // 
            this.cmbGenerarReporte.Image = global::ofiBalzh.Properties.Resources.Document_Microsoft_Word_Icon_32;
            this.cmbGenerarReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmbGenerarReporte.Location = new System.Drawing.Point(288, 185);
            this.cmbGenerarReporte.Name = "cmbGenerarReporte";
            this.cmbGenerarReporte.Size = new System.Drawing.Size(170, 45);
            this.cmbGenerarReporte.TabIndex = 0;
            this.cmbGenerarReporte.Text = "Generar Reporte";
            this.cmbGenerarReporte.UseVisualStyleBackColor = true;
            this.cmbGenerarReporte.Click += new System.EventHandler(this.cmbGenerarReporte_Click);
            // 
            // dateDesde
            // 
            this.dateDesde.Location = new System.Drawing.Point(52, 88);
            this.dateDesde.Name = "dateDesde";
            this.dateDesde.Size = new System.Drawing.Size(200, 20);
            this.dateDesde.TabIndex = 1;
            this.dateDesde.ValueChanged += new System.EventHandler(this.dateDesde_ValueChanged);
            // 
            // dateHasta
            // 
            this.dateHasta.Location = new System.Drawing.Point(258, 88);
            this.dateHasta.Name = "dateHasta";
            this.dateHasta.Size = new System.Drawing.Size(200, 20);
            this.dateHasta.TabIndex = 2;
            this.dateHasta.ValueChanged += new System.EventHandler(this.dateHasta_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Se generará el reporte del mes de:";
            // 
            // cmbFecha
            // 
            this.cmbFecha.FormattingEnabled = true;
            this.cmbFecha.Items.AddRange(new object[] {
            "ENERO",
            "FEBRERO",
            "MARZO",
            "ABRIL",
            "MAYO",
            "JUNIO",
            "JULIO",
            "AGOSTO",
            "SEPTIEMBRE",
            "OCTUBRE",
            "NOVIEMBRE",
            "DICIEMBRE"});
            this.cmbFecha.Location = new System.Drawing.Point(234, 122);
            this.cmbFecha.Name = "cmbFecha";
            this.cmbFecha.Size = new System.Drawing.Size(224, 21);
            this.cmbFecha.TabIndex = 4;
            this.cmbFecha.SelectedIndexChanged += new System.EventHandler(this.cmbFecha_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Desde la fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hasta la fecha:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(49, 151);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 7;
            // 
            // progreso
            // 
            this.progreso.Location = new System.Drawing.Point(-1, 258);
            this.progreso.Margin = new System.Windows.Forms.Padding(2);
            this.progreso.Name = "progreso";
            this.progreso.Size = new System.Drawing.Size(520, 10);
            this.progreso.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progreso.TabIndex = 124;
            this.progreso.Tag = "";
            this.progreso.Visible = false;
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(410, 15);
            this.txtAño.MaxLength = 4;
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(48, 20);
            this.txtAño.TabIndex = 129;
            this.txtAño.Text = "2016";
            this.txtAño.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOficio
            // 
            this.txtOficio.Location = new System.Drawing.Point(375, 15);
            this.txtOficio.MaxLength = 4;
            this.txtOficio.Name = "txtOficio";
            this.txtOficio.Size = new System.Drawing.Size(34, 20);
            this.txtOficio.TabIndex = 128;
            this.txtOficio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblOficio
            // 
            this.lblOficio.AutoSize = true;
            this.lblOficio.Location = new System.Drawing.Point(273, 18);
            this.lblOficio.Name = "lblOficio";
            this.lblOficio.Size = new System.Drawing.Size(96, 13);
            this.lblOficio.TabIndex = 127;
            this.lblOficio.Text = "OFICIO NUMERO:";
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 265);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.txtOficio);
            this.Controls.Add(this.lblOficio);
            this.Controls.Add(this.progreso);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateHasta);
            this.Controls.Add(this.dateDesde);
            this.Controls.Add(this.cmbGenerarReporte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GENERAR REPORTE MENSUAL";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmReportes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmbGenerarReporte;
        private System.Windows.Forms.DateTimePicker dateDesde;
        private System.Windows.Forms.DateTimePicker dateHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.ProgressBar progreso;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.TextBox txtOficio;
        private System.Windows.Forms.Label lblOficio;
    }
}