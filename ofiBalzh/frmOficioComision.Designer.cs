namespace ofiBalzh
{
    partial class frmOficioComision
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dateFecha = new System.Windows.Forms.DateTimePicker();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.progreso = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOficio = new System.Windows.Forms.TextBox();
            this.lblOficio = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.txtAcompañantes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(100, 64);
            this.txtNombre.MaxLength = 500;
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(345, 28);
            this.txtNombre.TabIndex = 2;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(489, 111);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(120, 13);
            this.lblFecha.TabIndex = 143;
            this.lblFecha.Text = "FECHA DE LA SALIDA:";
            // 
            // dateFecha
            // 
            this.dateFecha.Location = new System.Drawing.Point(492, 134);
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.Size = new System.Drawing.Size(202, 20);
            this.dateFecha.TabIndex = 4;
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(643, 12);
            this.txtAño.MaxLength = 4;
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(48, 20);
            this.txtAño.TabIndex = 140;
            this.txtAño.Text = "2016";
            this.txtAño.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 138;
            this.label2.Text = "LUGAR A DONDE ACUDIRA:";
            // 
            // progreso
            // 
            this.progreso.Location = new System.Drawing.Point(-5, 446);
            this.progreso.Margin = new System.Windows.Forms.Padding(2);
            this.progreso.Name = "progreso";
            this.progreso.Size = new System.Drawing.Size(782, 12);
            this.progreso.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progreso.TabIndex = 137;
            this.progreso.Tag = "";
            this.progreso.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 134;
            this.label1.Text = "PARA:";
            // 
            // txtOficio
            // 
            this.txtOficio.Location = new System.Drawing.Point(608, 12);
            this.txtOficio.MaxLength = 4;
            this.txtOficio.Name = "txtOficio";
            this.txtOficio.Size = new System.Drawing.Size(34, 20);
            this.txtOficio.TabIndex = 133;
            this.txtOficio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblOficio
            // 
            this.lblOficio.AutoSize = true;
            this.lblOficio.Location = new System.Drawing.Point(506, 15);
            this.lblOficio.Name = "lblOficio";
            this.lblOficio.Size = new System.Drawing.Size(96, 13);
            this.lblOficio.TabIndex = 132;
            this.lblOficio.Text = "OFICIO NUMERO:";
            // 
            // btnCrear
            // 
            this.btnCrear.Image = global::ofiBalzh.Properties.Resources.Document_Microsoft_Word_Icon_32;
            this.btnCrear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCrear.Location = new System.Drawing.Point(456, 386);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(235, 45);
            this.btnCrear.TabIndex = 8;
            this.btnCrear.Text = "CREAR ";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txtMotivo
            // 
            this.txtMotivo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivo.Location = new System.Drawing.Point(100, 244);
            this.txtMotivo.MaxLength = 500;
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(593, 60);
            this.txtMotivo.TabIndex = 6;
            // 
            // txtAcompañantes
            // 
            this.txtAcompañantes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcompañantes.Location = new System.Drawing.Point(100, 335);
            this.txtAcompañantes.MaxLength = 500;
            this.txtAcompañantes.Multiline = true;
            this.txtAcompañantes.Name = "txtAcompañantes";
            this.txtAcompañantes.Size = new System.Drawing.Size(594, 36);
            this.txtAcompañantes.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 146;
            this.label3.Text = "SE HACE ACOMPAÑAR DE:";
            // 
            // txtLugar
            // 
            this.txtLugar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLugar.Location = new System.Drawing.Point(100, 189);
            this.txtLugar.MaxLength = 500;
            this.txtLugar.Multiline = true;
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(593, 28);
            this.txtLugar.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 149;
            this.label4.Text = "MOTIVO DE LA VISITA:";
            // 
            // txtCargo
            // 
            this.txtCargo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargo.Location = new System.Drawing.Point(100, 127);
            this.txtCargo.MaxLength = 500;
            this.txtCargo.Multiline = true;
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(345, 27);
            this.txtCargo.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 111);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 150;
            this.label5.Text = "CARGO:";
            // 
            // frmOficioComision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 455);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLugar);
            this.Controls.Add(this.txtAcompañantes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dateFecha);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progreso);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOficio);
            this.Controls.Add(this.lblOficio);
            this.Name = "frmOficioComision";
            this.Text = "OFICIO DE COMISIÓN";
            this.Load += new System.EventHandler(this.frmOficioComision_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dateFecha;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progreso;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOficio;
        private System.Windows.Forms.Label lblOficio;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.TextBox txtAcompañantes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label label5;
    }
}