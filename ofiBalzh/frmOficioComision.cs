using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ofiBalzh
{
    public partial class frmOficioComision : Form
    {
        public frmOficioComision()
        {
            InitializeComponent();
        }

        private void frmOficioComision_Load(object sender, EventArgs e)
        {
             //busca el folio que le corresponde
            try
            {
                txtAño.Text = DateTime.Now.ToString("yyyy");
                Datos bdfolio = new Datos();
                string sql = "SELECT Folio FROM OficioComision ORDER BY Id DESC";
                string numFolio = bdfolio.buscarFolio(sql);
                if (numFolio == "") { numFolio = "0"; }
                txtOficio.Text = (int.Parse(numFolio) + 1).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo obtener el numero de oficio desde la base de datos", "Error de inicio", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            btnCrear.Enabled = false;
            progreso.Visible = true;
            progreso.Value = 30;
            //Se crea el documento a travez de la plantilla y se cambia de nombre del archivo
            //por el nombre del solicitante
            string misDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string rutaPlantilla = Path.Combine(Application.StartupPath, "Plantillas\\Oficio de Comisión.docx");
            string rutaAGuardar = Path.Combine(misDocumentos, "OFICIOS " + DateTime.Now.ToString("yyyy") + "\\PRESIDENCIA\\OFICIOS DE COMISIÓN\\");
            string nombreArchivo = txtNombre.Text + " " + txtOficio.Text + ".docx";

            try
            {
                //comprueba si no existe la carpeta y si no existe la crea de acuerdo al tipo de expediente
                if (!Directory.Exists(rutaAGuardar)) { Directory.CreateDirectory(rutaAGuardar); }

                //Si existe la plantilla se crea el documento y si no manda un mensaje de que no se pudo generar
                if (File.Exists(rutaPlantilla))
                {
                    DocumentoWord docWord = new DocumentoWord(rutaPlantilla, rutaAGuardar, nombreArchivo);
                    progreso.Value = 50;
                    //BUSCAR Y REMPLAZA LOS MARCADORES EN LA PLANTILLA
                    docWord.BuscarRemplazar("<OFICIO>", txtOficio.Text);
                    docWord.BuscarRemplazar("<AÑO>", txtAño.Text);
                    docWord.BuscarRemplazar("<FECHA>",DateTime.Today.ToString("D", CultureInfo.CreateSpecificCulture("es-MX")));
                    docWord.BuscarRemplazar("<CARGO>", txtCargo.Text);
                    docWord.BuscarRemplazar("<COMISIONADO>",txtNombre.Text);
                    docWord.BuscarRemplazar("<CARGO>", txtCargo.Text);
                    docWord.BuscarRemplazar("<FECHA_DE_COMISION>", dateFecha.Value.ToString("D", CultureInfo.CreateSpecificCulture("es-MX")));
                    docWord.BuscarRemplazar("<LUGAR>", txtLugar.Text);
                    docWord.BuscarRemplazar("<PROPOSITO>",txtMotivo.Text);
                    docWord.BuscarRemplazar("<ACOMPAÑANTES>", txtAcompañantes.Text);
                    progreso.Value = 80;
                    docWord.GuardarDocumento();
                    progreso.Value = 90;
                    docWord.CerrarDocumento();
                    docWord.AbrirDocumento(rutaAGuardar + "\\" + nombreArchivo);
                    progreso.Value = 95;
                }
                else
                {
                    MessageBox.Show("Asegurese de que exista la Plantilla Oficio de Comisión.docx en la ruta" + rutaPlantilla, "Archivo no existe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }

            catch
            {
                MessageBox.Show("No se pudo generar el documento", "Error de creacion de documento", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }

            //GURADAR EN LA BASE DE DATOS
            Datos bd = new Datos();

           // dateFecha.CustomFormat = "ddd dd MMM yyyy";

            string sql = "INSERT INTO  OficioComision (Folio,Nombre,Cargo,Fecha,Lugar,Motivo,Acompañantes) VALUES( " + txtOficio.Text + ",'" + txtNombre.Text + "','" + txtCargo.Text + "','" + dateFecha.Value + "','" + txtLugar.Text + "','" + txtMotivo.Text + "','" + txtAcompañantes.Text + "')";
            bd.ejecutarSQL(sql);
            string sql2 = "INSERT INTO OFICIO (Folio, Expediente,Tipo,Fecha) VALUES ('" + txtOficio.Text + "','13','PRESIDENCIA','" + dateFecha.Value + "')";
            bd.ejecutarSQL(sql2);

            //Termina el proceso
            btnCrear.Enabled = true;
            progreso.Value = 100;
            progreso.Visible = false;
            this.Close();
        }
    }
}
