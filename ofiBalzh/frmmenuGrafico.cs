using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ofiBalzh
{
    public partial class frmmenuGrafico : Form
    {
        public frmmenuGrafico()
        {
            InitializeComponent();
        }

        private void pnlInicio_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmmenuGrafico_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void btnPatenteGanadero_Click(object sender, EventArgs e)
        {
            frmPatenteGanadero vpatenteGanadero = new frmPatenteGanadero();
            vpatenteGanadero.Show();
        }

        private void btnConstanciaIdentidad_Click(object sender, EventArgs e)
        {
            frmIdentidad vIdentidad = new frmIdentidad();
            vIdentidad.Show();
        }

        private void btnConstanciaGenerica_Click(object sender, EventArgs e)
        {
            frmGenerica vGenerica = new frmGenerica();
            vGenerica.Show();
        }

        private void btnReporteMensual_Click(object sender, EventArgs e)
        {
            frmReportes vReporteGanadero = new frmReportes();
            vReporteGanadero.Show();
        }

        private void btnOficioComisión_Click(object sender, EventArgs e)
        {
            frmOficioComision vOficioComision = new frmOficioComision();
            vOficioComision.Show();
        }
    }
}
