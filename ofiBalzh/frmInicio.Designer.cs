namespace ofiBalzh
{
    partial class frmInicio
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.nUEVOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGenerica = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNuevaConstanciaIdentidad = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPatenteGanadero = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOficiosComision = new System.Windows.Forms.ToolStripMenuItem();
            this.cONFIGURACIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONFIGURARPLANTILLASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPlantillaGenerica = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPlantillaIdentidad = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPlantillaPatenteGanadero = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPlantillaOficioComision = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.Control;
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nUEVOToolStripMenuItem,
            this.cONFIGURACIONToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(1078, 24);
            this.menu.TabIndex = 8;
            this.menu.Text = "menuStrip1";
            // 
            // nUEVOToolStripMenuItem
            // 
            this.nUEVOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGenerica,
            this.mnuNuevaConstanciaIdentidad,
            this.mnuPatenteGanadero,
            this.mnuOficiosComision});
            this.nUEVOToolStripMenuItem.Name = "nUEVOToolStripMenuItem";
            this.nUEVOToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.nUEVOToolStripMenuItem.Text = "NUEVO";
            // 
            // mnuGenerica
            // 
            this.mnuGenerica.Name = "mnuGenerica";
            this.mnuGenerica.Size = new System.Drawing.Size(228, 22);
            this.mnuGenerica.Text = "CONSTANCIA GENERICA";
            this.mnuGenerica.Click += new System.EventHandler(this.mnuGenerica_Click);
            // 
            // mnuNuevaConstanciaIdentidad
            // 
            this.mnuNuevaConstanciaIdentidad.Name = "mnuNuevaConstanciaIdentidad";
            this.mnuNuevaConstanciaIdentidad.Size = new System.Drawing.Size(228, 22);
            this.mnuNuevaConstanciaIdentidad.Text = "CONSTANCIA DE IDENTIDAD";
            this.mnuNuevaConstanciaIdentidad.Click += new System.EventHandler(this.mnuNuevaConstanciaIdentidad_Click);
            // 
            // mnuPatenteGanadero
            // 
            this.mnuPatenteGanadero.Name = "mnuPatenteGanadero";
            this.mnuPatenteGanadero.Size = new System.Drawing.Size(228, 22);
            this.mnuPatenteGanadero.Text = "PATENTE GANADERO";
            this.mnuPatenteGanadero.Click += new System.EventHandler(this.mnuPatenteGanadero_Click_1);
            // 
            // mnuOficiosComision
            // 
            this.mnuOficiosComision.Name = "mnuOficiosComision";
            this.mnuOficiosComision.Size = new System.Drawing.Size(228, 22);
            this.mnuOficiosComision.Text = "OFICIOS DE COMISIÓN";
            this.mnuOficiosComision.Click += new System.EventHandler(this.mnuOficiosComision_Click);
            // 
            // cONFIGURACIONToolStripMenuItem
            // 
            this.cONFIGURACIONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cONFIGURARPLANTILLASToolStripMenuItem});
            this.cONFIGURACIONToolStripMenuItem.Name = "cONFIGURACIONToolStripMenuItem";
            this.cONFIGURACIONToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.cONFIGURACIONToolStripMenuItem.Text = "CONFIGURACION";
            // 
            // cONFIGURARPLANTILLASToolStripMenuItem
            // 
            this.cONFIGURARPLANTILLASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPlantillaGenerica,
            this.mnuPlantillaIdentidad,
            this.mnuPlantillaPatenteGanadero,
            this.mnuPlantillaOficioComision});
            this.cONFIGURARPLANTILLASToolStripMenuItem.Name = "cONFIGURARPLANTILLASToolStripMenuItem";
            this.cONFIGURARPLANTILLASToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.cONFIGURARPLANTILLASToolStripMenuItem.Text = "CONFIGURAR PLANTILLAS";
            // 
            // mnuPlantillaGenerica
            // 
            this.mnuPlantillaGenerica.Name = "mnuPlantillaGenerica";
            this.mnuPlantillaGenerica.Size = new System.Drawing.Size(196, 22);
            this.mnuPlantillaGenerica.Text = "GENERICA";
            this.mnuPlantillaGenerica.Click += new System.EventHandler(this.mnuPlantillaGenerica_Click);
            // 
            // mnuPlantillaIdentidad
            // 
            this.mnuPlantillaIdentidad.Name = "mnuPlantillaIdentidad";
            this.mnuPlantillaIdentidad.Size = new System.Drawing.Size(196, 22);
            this.mnuPlantillaIdentidad.Text = "IDENTIDAD";
            this.mnuPlantillaIdentidad.Click += new System.EventHandler(this.mnuIdentidad_Click);
            // 
            // mnuPlantillaPatenteGanadero
            // 
            this.mnuPlantillaPatenteGanadero.Name = "mnuPlantillaPatenteGanadero";
            this.mnuPlantillaPatenteGanadero.Size = new System.Drawing.Size(196, 22);
            this.mnuPlantillaPatenteGanadero.Text = "PATENTE GANADERO";
            this.mnuPlantillaPatenteGanadero.Click += new System.EventHandler(this.mnuPatenteGanadero_Click);
            // 
            // mnuPlantillaOficioComision
            // 
            this.mnuPlantillaOficioComision.Name = "mnuPlantillaOficioComision";
            this.mnuPlantillaOficioComision.Size = new System.Drawing.Size(196, 22);
            this.mnuPlantillaOficioComision.Text = "OFICIOS DE COMISION";
            this.mnuPlantillaOficioComision.Click += new System.EventHandler(this.mnuPlantillaOficioComision_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 711);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1078, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1078, 733);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menu);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creador de constancias 2.0";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem nUEVOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONFIGURACIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuGenerica;
        private System.Windows.Forms.ToolStripMenuItem mnuNuevaConstanciaIdentidad;
        private System.Windows.Forms.ToolStripMenuItem mnuPatenteGanadero;
        private System.Windows.Forms.ToolStripMenuItem mnuOficiosComision;
        private System.Windows.Forms.ToolStripMenuItem cONFIGURARPLANTILLASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuPlantillaGenerica;
        private System.Windows.Forms.ToolStripMenuItem mnuPlantillaIdentidad;
        private System.Windows.Forms.ToolStripMenuItem mnuPlantillaPatenteGanadero;
        private System.Windows.Forms.ToolStripMenuItem mnuPlantillaOficioComision;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}