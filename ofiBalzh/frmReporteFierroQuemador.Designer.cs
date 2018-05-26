namespace ofiBalzh
{
    partial class frmReporteFierroQuemador
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
            this.dwvPatente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dwvPatente)).BeginInit();
            this.SuspendLayout();
            // 
            // dwvPatente
            // 
            this.dwvPatente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dwvPatente.Location = new System.Drawing.Point(46, 45);
            this.dwvPatente.Name = "dwvPatente";
            this.dwvPatente.Size = new System.Drawing.Size(835, 391);
            this.dwvPatente.TabIndex = 0;
            // 
            // frmReporteFierroQuemador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 484);
            this.Controls.Add(this.dwvPatente);
            this.Name = "frmReporteFierroQuemador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmReporteFierroQuemador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dwvPatente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dwvPatente;
    }
}