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
    public partial class frmReporteFierroQuemador : Form
    {
        public frmReporteFierroQuemador()
        {
            InitializeComponent();
        }

        private void datosBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void frmReporteFierroQuemador_Load(object sender, EventArgs e)
        {
            Datos cargarDatos = new Datos();
            dwvPatente.DataSource = cargarDatos.ejecutarConsultaSQL("select * from Patente order by id DESC");
        }
    }
}
