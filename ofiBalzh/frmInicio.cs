using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ofiBalzh
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
            
    }

      

        private void btnConstanciaIdentidad_Click(object sender, EventArgs e)
        {
            frmIdentidad Identidad = new frmIdentidad();
            Identidad.Show();
        }

        private void mnuIdentidad_Click(object sender, EventArgs e)
        {
            AbrirPlantilla("Identidad.docx");
        }
        /// <summary>
        /// Metodo para abrir la plantilla de los documentos a generar
        /// </summary>
        /// <param name="rutaPlantilla"></param>
        private static void AbrirPlantilla(string nombrePlantilla)
        {
            string rutaPlantilla = Path.Combine(Application.StartupPath, "Plantillas\\" + nombrePlantilla);
            if (File.Exists(rutaPlantilla))
            {
                DocumentoWord docWord = new DocumentoWord();
                docWord.AbrirDocumento(rutaPlantilla);
            }
            else
            {
                MessageBox.Show("La plantilla no existe", "Archivo no existe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void mnuNuevaConstanciaIdentidad_Click(object sender, EventArgs e)
        {
            frmIdentidad vIdentidad = new frmIdentidad();
            vIdentidad.Show();
        }

        private void btnPatenteGanadero_Click(object sender, EventArgs e)
        {
            frmPatenteGanadero vPatenteGanadero = new frmPatenteGanadero();
            vPatenteGanadero.Show();
        }

        private void mnuPatenteGanadero_Click(object sender, EventArgs e)
        {
               AbrirPlantilla("Registro Patente Ganadero.docx");
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            frmmenuGrafico vMenuGrafico = new frmmenuGrafico();
            vMenuGrafico.MdiParent = this;
            vMenuGrafico.WindowState = FormWindowState.Maximized;
            vMenuGrafico.Show();

          
        }

        private void mnuPatenteGanadero_Click_1(object sender, EventArgs e)
        {
            frmPatenteGanadero vPatenteGanadero = new frmPatenteGanadero();
            vPatenteGanadero.Show();
        }

        private void mnuGenerica_Click(object sender, EventArgs e)
        {
            frmGenerica vGenerica = new frmGenerica();
            vGenerica.Show();
        }

        private void mnuPlantillaGenerica_Click(object sender, EventArgs e)
        {
              AbrirPlantilla("Generica.docx");
        }

        private void mnuPlantillaOficioComision_Click(object sender, EventArgs e)
        {
            AbrirPlantilla("Oficio de Comisión.docx");
        }

        private void mnuOficiosComision_Click(object sender, EventArgs e)
        {
            frmOficioComision vOficioComision = new frmOficioComision();
            vOficioComision.Show();
        }
    }
}
 