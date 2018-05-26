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
    public partial class frmGenerica : Form
    {
        public frmGenerica()
        {
            InitializeComponent();
        }

        private void cmbExpediente_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtExpediente.Text = (int.Parse(cmbExpediente.SelectedIndex.ToString())+1).ToString();
        }

        private void frmGenerica_Load(object sender, EventArgs e)
        {

            //busca el folio que le corresponde
            try
            {
                txtAño.Text = DateTime.Now.ToString("yyyy");
                Datos bdfolio = new Datos();
                string sql = "SELECT Folio FROM Oficio ORDER BY Id DESC";
                string numFolio = bdfolio.buscarFolio(sql);
                if (numFolio == ""){ numFolio = "0";}
                txtOficio.Text = (int.Parse(numFolio) + 1).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo obtener el numero de oficio desde la base de datos", "Error de inicio", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
        }

        private void btnCrearPatente_Click(object sender, EventArgs e)
        {
            btnCrear.Enabled = false;
            progreso.Visible = true;
            progreso.Value = 30;
            //Se crea el documento a travez de la plantilla y se cambia de nombre del archivo
            //por el nombre del solicitante
       //string rutaPlantilla = Path.Combine(Application.StartupPath, "Plantillas\\Generica.docx");
            
            string misDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //// string rutaPlantilla = "C:\\OFIBALZH\\Plantillas\\Generica.docx";
            string rutaPlantilla = Path.Combine(Application.StartupPath, "Plantillas\\Generica.docx");
            string rutaAGuardar = Path.Combine(misDocumentos, "OFICIOS " + DateTime.Now.ToString("yyyy") + "\\"+cmbExpediente.Text+"\\");
            string nombreArchivo = txtAsunto.Text + " " +txtOficio.Text + ".docx";

            try
            {
                //comprueba si no existe la carpeta y si no existe la crea de acuerdo al tipo de expediente
                if (!Directory.Exists(rutaAGuardar)) { Directory.CreateDirectory(rutaAGuardar); }

                //Si existe la plantilla se crea el documento y si no manda un mensaje de que no se pudo generar
                if (File.Exists(rutaPlantilla)) {
                    DocumentoWord docWord = new DocumentoWord(rutaPlantilla, rutaAGuardar, nombreArchivo);
                    progreso.Value = 50;
                    //BUSCAR Y REMPLAZA LOS MARCADORES EN LA PLANTILLA
                    docWord.BuscarRemplazar("<OFICIO>", txtOficio.Text);
                    docWord.BuscarRemplazar("<AÑO>", txtAño.Text);
                    docWord.BuscarRemplazar("<FECHA>", DateTime.Today.ToString("D", CultureInfo.CreateSpecificCulture("es-MX")));
                    docWord.BuscarRemplazar("<EXPEDIENTE>", txtExpediente.Text);
                    docWord.BuscarRemplazar("<A QUIEN>", txtA.Text);
                    docWord.BuscarRemplazar("<ASUNTO>", txtAsunto.Text);
                    docWord.BuscarRemplazar("<CONTENIDO>", txtContenido.Text);
                    progreso.Value = 80;
                    docWord.GuardarDocumento();
                    progreso.Value = 90;
                    docWord.CerrarDocumento();
                    docWord.AbrirDocumento(rutaAGuardar + "\\" + nombreArchivo);
                    progreso.Value = 95;
                }
                else { MessageBox.Show("Asegurese de que exista la plantilla Generica.docx en la ruta" + rutaPlantilla, "Archivo no existe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
            }
            catch
            {
                MessageBox.Show("No se pudo generar el documento", "Error de creacion de documento", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            //GURADAR EN LA BASE DE DATOS
                Datos bd = new Datos();
                string sql = "INSERT INTO  Oficio (Folio,Expediente,tipo,fecha) VALUES( " + txtOficio.Text + ",'" + txtExpediente.Text + "','" + cmbExpediente.Text+ "','" + dateFecha.Value + "' )";
                bd.ejecutarSQL(sql);
               

            //Termina el proceso
            btnCrear.Enabled = true;
            progreso.Value = 100;
            progreso.Visible = false;
            this.Close();
        }

        private void txtOficio_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }



        /// <summary>
        /// Metodo para que los texbox solo permitan numeros
        /// </summary>
        /// <param name="e"></param>
        private static void soloNumeros(KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }
        }

        private void txtAño_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void txtExpediente_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
            txtA.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtAsunto_TextChanged(object sender, EventArgs e)
        {
            txtAsunto.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
