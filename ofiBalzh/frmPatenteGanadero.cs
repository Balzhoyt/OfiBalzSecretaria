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
    public partial class frmPatenteGanadero: Form
    {
        public frmPatenteGanadero()
        {
            InitializeComponent();
        }

        private void rbTresAños_CheckedChanged(object sender, EventArgs e)
        {
            ponerFechaCaducidad(3);
        }

        private void ponerFechaCaducidad(int años)
        {
            DateTime fecha = DateTime.Now;
       
            switch (años) {

                case 3:
                    dateHasta.Value=fecha.AddYears(3);
                    break;
                case 2:
                    dateHasta.Value = fecha.AddYears(2);
                    break;
                case 1:
                    dateHasta.Value = fecha.AddYears(1);
                    break;
                default:
                    dateHasta.Value = fecha.AddYears(3);
                    break;
            }
        }

        private void rbTresAños_Click(object sender, EventArgs e)
        {
            ponerFechaCaducidad(3);
        }

        private void frmPatenteGanadero_Load(object sender, EventArgs e)
        {
            
            //
            // cargo la lista de items para el autocomplete
            //
            txtNombreSolicitante.AutoCompleteCustomSource = Datos.LoadAutoComplete();
            txtNombreSolicitante.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtNombreSolicitante.AutoCompleteSource = AutoCompleteSource.CustomSource;

            //
            // Cargo los datos del combobox
            //
            //comboBox1.DataSource = Datos.LoadDataTable();
            //comboBox1.DisplayMember = "Nombre";
            //comboBox1.ValueMember = "Id";

            //
            // cargo la lista de items para el autocomplete
            //
            //comboBox1.AutoCompleteCustomSource = Datos.LoadAutoComplete();
            //comboBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            //comboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;


            //poner por default que la vigencia es de tres años
            DateTime fecha = DateTime.Now;
            dateHasta.Value = fecha.AddYears(3);
            try
            {

                //inicializar cargando el folio consecuntivo
                Datos bdfolio = new Datos();
                string sql = "SELECT Patente.Folio,Patente.Libro FROM Patente ORDER BY Patente.ID DESC;";
                string[,] datos = bdfolio.ejecutarConsulta(sql);
                string numFolio = datos.GetValue(0, 0).ToString();
                string Libro = datos.GetValue(0, 1).ToString();
                if (numFolio == "") { numFolio = "0"; }
                txtFolio.Text = (int.Parse(numFolio) + 1).ToString();
                txtFoja.Text = txtFolio.Text;
                txtLibro.Text = Libro;
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo obtener el numero de oficio desde la base de datos", "Error de inicio", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
        }
        private void rbDosAños_CheckedChanged(object sender, EventArgs e)
        {
            ponerFechaCaducidad(2);
        }

        private void rbUnAño_CheckedChanged(object sender, EventArgs e)
        {
            ponerFechaCaducidad(1);
        }

        private void btnCrearPatente_Click(object sender, EventArgs e)
        {
            if (txtNumCredencial.Text == "") { txtNumCredencial.Text = "NO TIENE"; }

            btnCrearPatente.Enabled = false;
            progresoPatente.Visible = true;
            progresoPatente.Value = 30;
            //Se crea el documento a travez de la plantilla y se cambia de nombre del archivo
            //por el nombre del solicitante
            string misDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //string rutaPlantilla = Path.Combine(Application.StartupPath, misDocumentos + "\\OFIBALZH\\Plantillas\\Registro Patente Ganadero.docx");
            string rutaPlantilla = Path.Combine(Application.StartupPath, "Plantillas\\Registro Patente Ganadero.docx");
            string rutaAGuardar = Path.Combine(misDocumentos, "OFICIOS "+DateTime.Now.ToString("yyyy")+"\\SECRETARIA\\REGISTRO PATENTE GANADERO\\");
            string nombreArchivo = txtNombreSolicitante.Text + " " + txtFolio.Text  + ".docx";
            try
            {
                //comprueba si no existe la carpeta y si no existe la crea de acuerdo al tipo de expediente
                if (!Directory.Exists(rutaAGuardar)) { Directory.CreateDirectory(rutaAGuardar); }

                //Si existe la plantilla se crea el documento y si no manda un mensaje de que no se pudo generar
                if (File.Exists(rutaPlantilla))
                {
                    DocumentoWord docWord = new DocumentoWord(rutaPlantilla, rutaAGuardar, nombreArchivo);
                    progresoPatente.Value = 50;
                    //BUSCAR Y REMPLAZA LOS MARCADORES EN LA PLANTILLA
                    docWord.BuscarRemplazar("<REGISTRO_REVALIDACION>", cbRegistroRevalidacion.Text);
                    docWord.BuscarRemplazar("<NOMBRE>", txtNombreSolicitante.Text);
                    docWord.BuscarRemplazar("<EDAD>", txtEdad.Text);
                    docWord.BuscarRemplazar("<DOMICILIO>", txtDomicilio.Text);
                    docWord.BuscarRemplazar("<NOMBRERANCHO>",txtNombreRancho.Text);
                    docWord.BuscarRemplazar("<UBICACIONRANCHO>", txtUbicacionRancho.Text);
                    docWord.BuscarRemplazar("<CREDENCIAL>", txtNumCredencial.Text);
                    docWord.BuscarRemplazar("<SOCIO>", cbSocioLibre.Text);
                    docWord.BuscarRemplazar("<FECHA>", DateTime.Now.Day.ToString()+" de "+ DateTime.Today.ToString("MMMM") + " del " + DateTime.Today.ToString("yyyy"));


                    docWord.BuscarRemplazar("<01>", txtBecerras.Text);
                    docWord.BuscarRemplazar("<02>", txtNovillonas.Text);
                    docWord.BuscarRemplazar("<03>", txtVacas.Text);
                    docWord.BuscarRemplazar("<04>", txtBecerros.Text);
                    docWord.BuscarRemplazar("<05>", txtToretes.Text);
                    docWord.BuscarRemplazar("<06>", txtNovillos.Text);
                    docWord.BuscarRemplazar("<07>", txtToros.Text);
                    docWord.BuscarRemplazar("<08>", txtBueyes.Text);

                    docWord.BuscarRemplazar("<11>", txtPotrancas.Text);
                    docWord.BuscarRemplazar("<12>", txtYeguas.Text);
                    docWord.BuscarRemplazar("<13>", txtPotros.Text);
                    docWord.BuscarRemplazar("<14>", txtCaballos.Text);
                    docWord.BuscarRemplazar("<15>", txtAcemilas.Text);
                    docWord.BuscarRemplazar("<16>", txtMulas.Text);
                    docWord.BuscarRemplazar("<17>", txtAsnos.Text);
                    docWord.BuscarRemplazar("<18>", txtMachos.Text);

                    docWord.BuscarRemplazar("<FOLIO>", txtFolio.Text);
                    docWord.BuscarRemplazar("<FOJA>", txtFoja.Text);
                    docWord.BuscarRemplazar("<LIBRO>", txtLibro.Text);

                    docWord.BuscarRemplazar("<FECHAINICIAL>", dateDesde.Value.ToString("D", CultureInfo.CreateSpecificCulture("es-MX")));
                    docWord.BuscarRemplazar("<FECHAFINAL>", dateHasta.Value.ToString("D", CultureInfo.CreateSpecificCulture("es-MX")));

                    progresoPatente.Value = 80;
                    docWord.GuardarDocumento();
                    progresoPatente.Value = 90;
                    docWord.CerrarDocumento();
                    docWord.AbrirDocumento(rutaAGuardar + "\\" + nombreArchivo);
                    progresoPatente.Value = 95;
                }
                else
                {
                    MessageBox.Show("Asegurese de que exista la plantilla Registro Patente Ganadero.docx en la ruta" + rutaPlantilla, "Archivo no existe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("No se pudo generar el documento", "Error de creacion de documento", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }

            //GURADAR EN LA BASE DE DATOS
           Datos bd = new Datos();
           string sql = "INSERT INTO Patente(Folio,Foja,Libro,Tipo,Nombre,Edad,Domicilio,NombreRancho,DomicilioRancho,NumCredencial,SocioGanadero,Becerras,Novillonas,Vacas,Becerros,Toretes,Novillos,Toros,Bueyes,Potrancas,Yegua,Potros,Caballos,Acemilas,Mulas,Asnos,Machos,FechaInicio,FechaFinal,Certifica1,Certifica2) VALUES ('" + txtFolio.Text + "','" + txtFoja.Text + "','" + txtLibro.Text + "','" + cbRegistroRevalidacion.Text + "','" + txtNombreSolicitante.Text + "','" + txtEdad.Text + "','" + txtDomicilio.Text + "','" + txtNombreRancho.Text + "','" + txtUbicacionRancho.Text + "','" + txtNumCredencial.Text + "','" + cbSocioLibre.Text + "'," + txtBecerras.Text + "," + txtNovillonas.Text + "," + txtVacas.Text + "," + txtBecerros.Text + "," + txtToretes.Text + "," + txtNovillos.Text + "," + txtToros.Text + "," + txtBueyes.Text + "," + txtPotrancas.Text + "," + txtYeguas.Text + "," + txtPotros.Text + "," + txtCaballos.Text + "," + txtAcemilas.Text + "," + txtMulas.Text + "," + txtAsnos.Text + "," + txtMachos.Text + ",'"+dateDesde.Value+"','"+dateHasta.Value+"','"+txtCertifica1.Text+"','"+txtCertifica2.Text+"')";
           bd.ejecutarSQL(sql);
          
            btnCrearPatente.Enabled = true;
            progresoPatente.Value = 100;
            progresoPatente.Visible = false;
            this.Close();
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void txtNumINE_KeyPress(object sender, KeyPressEventArgs e)
        {
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

     

        

        private void txtFolio_Validated(object sender, EventArgs e)
        {
            txtFolio.Text = String.Format("{0:0#}", Int32.Parse(txtFolio.Text));
        }

        private void txtFoja_Validated(object sender, EventArgs e)
        {
            txtFoja.Text = String.Format("{0:0#}", Int32.Parse(txtFoja.Text));
        }

        private void txtLibro_Validated(object sender, EventArgs e)
        {
            txtLibro.Text = String.Format("{0:0#}", Int32.Parse(txtLibro.Text));
        }

        private void txtNombreSolicitante_Validated(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Datos bd = new Datos();
            string SQL = "select * from Patente where Nombre='" + txtNombreSolicitante.Text + "'";
            dt = bd.ejecutarConsultaSQL(SQL);
            if (dt.Rows.Count != 0)
            {

                txtEdad.Text = (int.Parse(dt.Rows[0].ItemArray[6].ToString())+3).ToString();
                txtDomicilio.Text = dt.Rows[0].ItemArray[7].ToString();
                txtNombreRancho.Text = dt.Rows[0].ItemArray[8].ToString();
                txtUbicacionRancho.Text = dt.Rows[0].ItemArray[9].ToString();
                txtNumCredencial.Text = dt.Rows[0].ItemArray[10].ToString();
                cbSocioLibre.Text = dt.Rows[0].ItemArray[11].ToString();
                cbRegistroRevalidacion.Text = "REVALIDACION";
                txtBecerras.Focus();
            }

        }
        private void txtNombreSolicitante_KeyPress(object sender, KeyPressEventArgs e)
        {
            // txtNombreSolicitante.CharacterCasing = CharacterCasing.Upper;
            if (e.KeyChar == (int)Keys.Enter)
            {
               

            }
        }
        private void txtDomicilio_Validated(object sender, EventArgs e)
        {
           
        }

        private void txtNombreRancho_Validated(object sender, EventArgs e)
        {
           
        }

        private void txtUbicacionRancho_Validated(object sender, EventArgs e)
        {

        }

        private void txtEdad_Validated(object sender, EventArgs e)
        {
            
        }

        private void txtEdad_KeyPress_1(object sender, KeyPressEventArgs e)
        {
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

        

       

        private void txtBecerras_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void txtNovillonas_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void txtVacas_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void txtBecerros_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void txtToretes_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void txtNovillos_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void txtToros_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void txtBueyes_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void txtPotrancas_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void txtYeguas_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void txtPotros_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void txtCaballos_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void txtAcemilas_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void txtMulas_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void txtAsnos_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void txtMachos_KeyPress(object sender, KeyPressEventArgs e)
        {
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

       

        private void txtDomicilio_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtDomicilio.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtNombreRancho_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtNombreRancho.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtUbicacionRancho_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtUbicacionRancho.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtBecerras_Validated(object sender, EventArgs e)
        {
            txtBecerras.Text = String.Format("{0:0#}", Int32.Parse(txtBecerras.Text));
        }

        private void txtNovillonas_Validated(object sender, EventArgs e)
        {
           txtNovillonas.Text = String.Format("{0:0#}", Int32.Parse(txtNovillonas.Text));
        }

        private void txtVacas_Validated(object sender, EventArgs e)
        {
            txtVacas.Text = String.Format("{0:0#}", Int32.Parse(txtVacas.Text));
        }

        private void txtBecerros_Validated(object sender, EventArgs e)
        {
            txtBecerros.Text = String.Format("{0:0#}", Int32.Parse(txtBecerros.Text));
        }

        private void txtToretes_Validated(object sender, EventArgs e)
        {
            txtToretes.Text = String.Format("{0:0#}", Int32.Parse(txtToretes.Text));
        }

        private void txtNovillos_Validated(object sender, EventArgs e)
        {
            txtNovillos.Text = String.Format("{0:0#}", Int32.Parse(txtNovillos.Text));
        }

        private void txtToros_Validated(object sender, EventArgs e)
        {
            txtToros.Text = String.Format("{0:0#}", Int32.Parse(txtToros.Text));
        }

        private void txtBueyes_Validated(object sender, EventArgs e)
        {
            txtBueyes.Text = String.Format("{0:0#}", Int32.Parse(txtBueyes.Text));
        }

        private void txtPotrancas_Validated(object sender, EventArgs e)
        {
            txtPotrancas.Text = String.Format("{0:0#}", Int32.Parse(txtPotrancas.Text));
        }

        private void txtYeguas_Validated(object sender, EventArgs e)
        {
            txtYeguas.Text = String.Format("{0:0#}", Int32.Parse(txtYeguas.Text));
        }

        private void txtPotros_Validated(object sender, EventArgs e)
        {
            txtPotros.Text = String.Format("{0:0#}", Int32.Parse(txtPotros.Text));
        }

        private void txtCaballos_Validated(object sender, EventArgs e)
        {
            txtCaballos.Text = String.Format("{0:0#}", Int32.Parse(txtCaballos.Text));
        }

        private void txtAcemilas_Validated(object sender, EventArgs e)
        {
            txtAcemilas.Text = String.Format("{0:0#}", Int32.Parse(txtAcemilas.Text));
        }

        private void txtMulas_Validated(object sender, EventArgs e)
        {
            txtMulas.Text = String.Format("{0:0#}", Int32.Parse(txtMulas.Text));
        }

        private void txtAsnos_Validated(object sender, EventArgs e)
        {
            txtAsnos.Text = String.Format("{0:0#}", Int32.Parse(txtAsnos.Text));
        }

        private void txtMachos_Validated(object sender, EventArgs e)
        {
            txtMachos.Text = String.Format("{0:0#}", Int32.Parse(txtMachos.Text));
        }

        private void txtNumCredencial_Validated(object sender, EventArgs e)
        {
            if (txtNumCredencial.Text == "") { txtNumCredencial.Text = "NO TIENE"; }
        }

        private void btnVerRegistros_Click(object sender, EventArgs e)
        {
            frmReporteFierroQuemador vRegistros = new frmReporteFierroQuemador();
            vRegistros.Show();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReporteMensual_Click(object sender, EventArgs e)
        {
            frmReportes vReporteMensual = new frmReportes();
            vReporteMensual.Show();
        }
    }
}
