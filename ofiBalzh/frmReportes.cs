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
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
            dateDesde.Text = "01/"+DateTime.Now.Month+"/" + DateTime.Now.ToString("yyyy");
            dateHasta.Value = fecha.Date;
            txtAño.Text = DateTime.Now.ToString("yyyy");
            try
            {
                //txtAño.Text = DateTime.Now.ToString("yyyy");
                Datos bdfolio = new Datos();
                string sql = "SELECT Folio FROM Oficio ORDER BY Id DESC";
                string numFolio = bdfolio.buscarFolio(sql);
                if (numFolio == "") { numFolio = "0"; }
                txtOficio.Text = (int.Parse(numFolio) + 1).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo obtener el numero de folio desde la base de datos", "Error de inicio", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }


        }

       
        private void dateHasta_ValueChanged(object sender, EventArgs e)
        {
            string mesHasta = dateHasta.Value.ToString("MMMM");
            cmbFecha.Text = mesHasta;
            string mes = dateHasta.Value.Month.ToString();
            dateDesde.Text = "01/" + mes+"/"+dateHasta.Value.Year.ToString();
        }
        private void cmbFecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            int mes=cmbFecha.SelectedIndex+1;
            int dia = DateTime.DaysInMonth(DateTime.Now.Year,mes);
            string fecha=dia+"/"+mes+"/"+dateHasta.Value.Year.ToString();
            dateHasta.Value = Convert.ToDateTime(fecha);
            
            
        }
        private void dateDesde_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbGenerarReporte_Click(object sender, EventArgs e)
        {

            cmbGenerarReporte.Enabled = false;

            //DataTable datosT = new DataTable();
            string fechaDesde = dateDesde.Value.ToString("MM/dd/yyyy");
            string fechaHasta = dateHasta.Value.ToString("MM/dd/yyyy");
            if ((dateHasta.Value.Month == 2) && (dateHasta.Value.Day == 29)) { fechaHasta = "03/01/" + dateHasta.Value.Year.ToString(); }
            string[,] datos ;
            Datos bd = new Datos();
            string sql = "SELECT Patente.Folio, Patente.Libro, Patente.FechaInicio";
                    sql += " FROM Patente ";
                    sql += " WHERE(((Patente.FechaInicio) Between #" + fechaDesde + "# And #" + fechaHasta + "#))";
                     sql += " ORDER BY Patente.Folio";
             datos = bd.ejecutarConsulta(sql);

           
            string mes = cmbFecha.Text;
            if (datos != null)
            {
                string mesT="";
                string fecha =datos.GetValue(0,2).ToString();
                DateTime dt = Convert.ToDateTime(fecha);
                
                switch (dt.Month.ToString()) {
                    case "1":mesT = "ENERO";break;
                    case "2": mesT = "FEBRERO"; break;
                    case "3": mesT = "MARZO"; break;
                    case "4": mesT = "ABRIL"; break;
                    case "5": mesT = "MAYO"; break;
                    case "6": mesT = "JUNIO"; break;
                    case "7": mesT = "JULIO"; break;
                    case "8": mesT = "AGOSTO"; break;
                    case "9": mesT = "SEPTIEMBRE"; break;
                    case "10": mesT = "OCTUBRE"; break;
                    case "11": mesT = "NOVIEMBRE"; break;
                    case "12": mesT = "DICIEMBRE"; break;
                }

                int max = datos.GetLength(0);
                int folioInicio = int.Parse(datos.GetValue(0, 0).ToString());
                int folioFinal = int.Parse(datos.GetValue(max - 1, 0).ToString());
                int libro = int.Parse(datos.GetValue(0, 1).ToString());
                lblResultado.Text = max + " copias de patentes, foliadas del No. " + folioInicio + " al No. " + folioFinal + " ,del libro numero " + libro;
                CrearDocumento(max,folioInicio, folioFinal, libro, mesT);
                progreso.Visible = false;
                this.Close();

            }
            else { MessageBox.Show("No hay registros para el mes de " + mes); }
            
            //Termina el proceso
            cmbGenerarReporte.Enabled = true;
            progreso.Value = 100;
        }

        private void CrearDocumento(int total,int folioInicio,int folioFinal,int libro,string mes)
        {
            
             progreso.Value = 30;
            //Se crea el documento a travez de la plantilla y se cambia de nombre del archivo
            //por el nombre del solicitante
            string misDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string rutaPlantilla = Path.Combine(Application.StartupPath, "Plantillas\\Reporte Mensual Patente.docx");
            string rutaAGuardar = Path.Combine(misDocumentos, "OFICIOS " + DateTime.Now.ToString("yyyy") + "\\PRESIDENCIA MUNICIPAL\\REPORTE MENSUAL PATENTE\\");
            string nombreArchivo = "Reporte Patente "+ mes + ".docx";
            
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
                    docWord.BuscarRemplazar("<FECHA>", DateTime.Today.ToString("D", CultureInfo.CreateSpecificCulture("es-MX")));
                    docWord.BuscarRemplazar("<AÑO>",txtAño.Text);
                    docWord.BuscarRemplazar("<EXPEDIENTE>",001);
                    docWord.BuscarRemplazar("<TOTAL>", total);
                    docWord.BuscarRemplazar("<FOLIO1>", folioInicio);
                    docWord.BuscarRemplazar("<FOLIO2>", folioFinal);
                    docWord.BuscarRemplazar("<LIBRO>", libro);
                    docWord.BuscarRemplazar("<MES>", mes);

                    progreso.Value = 80;
                    docWord.GuardarDocumento();
                    progreso.Value = 90;
                    docWord.CerrarDocumento();
                    docWord.AbrirDocumento(rutaAGuardar + "\\" + nombreArchivo);
                    progreso.Value = 95;
                }
                else
                {
                    MessageBox.Show("Asegurese de que exista la plantilla Reporte Ganadero Patente.docx en la ruta" + rutaPlantilla, "Archivo no existe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }

            catch
            {
                MessageBox.Show("No se pudo generar el documento", "Error de creacion de documento", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }

            //GURADAR EN LA BASE DE DATOS
            if (txtOficio.Text != "")
            {
                Datos bd = new Datos();
                string sql = "INSERT INTO  Oficio (Folio,Expediente,Tipo,Fecha) VALUES( " + txtOficio.Text + ",'1','PRESIDENCIA MUNICIPAL','" + DateTime.Now.ToString() + "' )";
                bd.ejecutarSQL(sql);
            }
            else
            {
                MessageBox.Show("No se pudo guardar en la base de datos, faltó el numero de folio", "Error de creacion de documento", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

    
    }

    

}
