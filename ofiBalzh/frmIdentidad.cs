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
using System.Diagnostics;
using System.Globalization;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing.Imaging;

namespace ofiBalzh
{
    public partial class frmIdentidad : Form
    {
        private string foto;
        public frmIdentidad()
        {
            InitializeComponent();
            
        }

        private void btnCrearOficio_Click(object sender, EventArgs e)
        {
            btnCrearOficio.Enabled = false;
            progreso.Visible = true;
            progreso.Value = 30;
            
            //Se crea el documento a travez de la plantilla y se cambia de nombre del archivo
    
            string misDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string rutaPlantilla = Path.Combine(Application.StartupPath, "Plantillas\\Identidad.docx");
            string rutaAGuardar = Path.Combine(misDocumentos, "OFICIOS " + DateTime.Now.ToString("yyyy") + "\\SECRETARIA\\CONSTANCIAS DE IDENTIDAD\\");
            string nombreArchivo = txtNombre.Text +" "+ txtOficio.Text+ ".docx";
                 string rutaFoto = Path.Combine(misDocumentos, "OFICIOS " + DateTime.Now.ToString("yyyy") + "\\SECRETARIA\\CONSTANCIAS DE IDENTIDAD\\fotos\\");
                 if (!Directory.Exists(rutaFoto)) { Directory.CreateDirectory(rutaFoto); }
                 foto = rutaFoto + txtNombre.Text + ".jpg";
                guardarfoto();   
                // pictureBox1.Image.Save(foto, ImageFormat.Jpeg);

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
                   // string foto = openFileDialog1.FileName;
                    string texto = "FOTO";
                    if (foto != "") { docWord.RemplazarImagen(texto, foto); }

                    docWord.BuscarRemplazar("<NUM_OFICIO>", txtOficio.Text);
                    docWord.BuscarRemplazar("<FECHA>", DateTime.Today.ToString("D", CultureInfo.CreateSpecificCulture("es-MX")));
                    docWord.BuscarRemplazar("<NOMBRE>", this.txtNombre.Text);
                    docWord.BuscarRemplazar("<DOMICILIO>", this.txtDomicilio.Text);
                    docWord.BuscarRemplazar("<COMPROBANTES>", this.txtComprobantes.Text);
                    docWord.BuscarRemplazar("<CERTIFICA>", this.txtCertifica.Text);
                    progreso.Value = 80;
                    docWord.GuardarDocumento();
                    progreso.Value = 90;
                    docWord.CerrarDocumento();
                    docWord.AbrirDocumento(rutaAGuardar + "\\" + nombreArchivo);
                    progreso.Value = 95;
                }
                else
                {
                    MessageBox.Show("Asegurese de que exista la plantilla Identidad.docx en la ruta" + rutaPlantilla, "Archivo no existe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }

            catch
            {
                MessageBox.Show("No se pudo generar el documento", "Error de creacion de documento", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            //GURADAR EN LA BASE DE DATOS
                Datos bd = new Datos();
                string sql = "INSERT INTO  Identidad (Folio,nombre,domicilio,fecha,certifica) VALUES( " + txtOficio.Text + ",'" + txtNombre.Text + "','" + txtDomicilio.Text + "','" + dateExpedicion.Value + "','" + txtCertifica.Text + "')";
                bd.ejecutarSQL(sql);
                string sql2 = "INSERT INTO OFICIO (Folio, Expediente,Tipo,Fecha) VALUES ('" + txtOficio.Text + "','2','SECRETARIA','" + dateExpedicion.Value+ "')";
                bd.ejecutarSQL(sql2);
           
            //termina el proceso
            btnCrearOficio.Enabled = true;
            progreso.Value = 100;
            progreso.Visible = false;
            this.Close();

        }

        private void frmIdentidad_Load(object sender, EventArgs e)
        {
            //busca el folio que le corresponde
            try
            {
                txtAño.Text = DateTime.Now.ToString("yyyy");
                Datos bdfolio = new Datos();
                string sql = "SELECT Folio FROM Identidad ORDER BY Id DESC";
                string numFolio = bdfolio.buscarFolio(sql);
                if (numFolio == "") { numFolio = "0"; }
                txtOficio.Text = (int.Parse(numFolio) + 1).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo obtener el numero de oficio desde la base de datos", "Error de inicio", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
        }

        private void frmIdentidad_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ponerfotoArchivo();
        }

        private void ponerfotoArchivo()
        {
            try
            {
                //openFileDialog1.Filter = "Archivos de Imagen|*.jpg ; *.png";
                openFileDialog1.Filter = "Buscar foto de tipo (*.jpg)|*.jpg|Buscar foto de tipo (*.png)|*.png";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    foto = openFileDialog1.FileName;

                    pictureBox1.Image = Image.FromFile(foto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido" + ex);
            }
        }

        #region eventos que cambian a mayusculas los controles
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            txtNombre.CharacterCasing = CharacterCasing.Upper;
        }
        private void txtDomicilio_TextChanged(object sender, EventArgs e)
        {
            txtDomicilio.CharacterCasing = CharacterCasing.Upper;
        }
        private void txtComprobantes_TextChanged(object sender, EventArgs e)
        {
            txtComprobantes.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtCertifica_TextChanged(object sender, EventArgs e)
        {
            txtCertifica.CharacterCasing = CharacterCasing.Upper;
        }
      

        private void txtNumeroOficio_KeyPress(object sender, KeyPressEventArgs e)
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
        #endregion

      

        private bool camaraParada = false;
        private bool ExistenDispositivos = false;
        private FilterInfoCollection DispositivosDeVideo;
        private VideoCaptureDevice FuenteDeVideo = null;
        public void CargarDispositivos(FilterInfoCollection Dispositivos)

        {
           // for (int i = 0; i < Dispositivos.Count; i++)

              //  cboDispositivos.Items.Add(Dispositivos[i].Name.ToString());
            //cboDispositivos es nuestro combobox

            //cboDispositivos.Text = cboDispositivos.Items[0].ToString();

        }
        public void BuscarDispositivos()

        {

            DispositivosDeVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (DispositivosDeVideo.Count == 0) { 

                ExistenDispositivos = false;
                 MessageBox.Show("No se detectó ninguna  camara web, intente conectarlo en otro puerto USB");
            }
            else

            {

                ExistenDispositivos = true;

                CargarDispositivos(DispositivosDeVideo);

            }

        }
        public void TerminarFuenteDeVideo()

        {
            if (!(FuenteDeVideo == null))

                if (FuenteDeVideo.IsRunning)

                {

                    FuenteDeVideo.SignalToStop();

                    FuenteDeVideo = null;

                }

        }
        private void video_NuevoFrame(object sender, NewFrameEventArgs eventArgs)
        {
           
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = Imagen;
 
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
     }
        public Rectangle recorte;
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && camaraParada == true && encuadro == true)
            {
                
                pictureBox1.Refresh();
                Bitmap imagen2 = new Bitmap(300, 250);
                Graphics lienzo = Graphics.FromImage(imagen2);
                int A = e.X - 65;
                int B = e.Y - 85;
                int C = 130;
                int D = 170;
                try
                {


                    Pen cropPen = new Pen(Color.Red, 3);
                    cropPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    //Cursor = System.Windows.Forms.Cursors.Cross;

                    recorte = new Rectangle(A, B, C, D);
                    pictureBox1.CreateGraphics().DrawRectangle(cropPen, recorte);
                    lienzo.DrawImage(pictureBox1.Image, 0, 0, recorte, GraphicsUnit.Pixel);
                    // this.pictureBox2.Image = imagen2;
                }
                catch (Exception)
                {
                    MessageBox.Show("Surgio un Error, faltan elegir las coordenadas", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        bool encuadro = false;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
            BuscarDispositivos();
            if (ExistenDispositivos)
            {
                if (camaraParada == false)
                {
                    FuenteDeVideo = new VideoCaptureDevice(DispositivosDeVideo[0].MonikerString);
                    FuenteDeVideo.NewFrame += new NewFrameEventHandler(video_NuevoFrame);
                    FuenteDeVideo.Start();
                    camaraParada = true;
                    txtMSG.Text = "Cuando este listo, de un clic para tomar la foto";
                }
                else
                {
                   if(encuadro == false){ 
                    TerminarFuenteDeVideo();
                    Pen cropPen = new Pen(Color.Red, 3);
                    cropPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    Rectangle recorte = new Rectangle(80, 15, 130, 170);
                    pictureBox1.CreateGraphics().DrawRectangle(cropPen, recorte);
                    encuadro = true;
                        txtMSG.Text= "Puede mover el cuadro rojo para centrar mejor la captura y recortar la foto a tamaño infantil"; 


                        //camaraParada = false;
                        // guardarfoto();
                    }
                }

            }
        }

        private void guardarfoto()
        {
            Image fotorec;
            fotorec = Imagenes.recortarImagen(pictureBox1.Image, recorte);
            pictureBox1.Image = fotorec;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image.Save(foto, ImageFormat.Jpeg);
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            
        }

       
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
          

        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
           // if (camaraParada == true)
           // {
           //     Pen cropPen = new Pen(Color.Red, 3);
           // cropPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
           // Rectangle recorte = new Rectangle(80, 15, 130, 170);
           //pictureBox1.CreateGraphics().DrawRectangle(cropPen, recorte);


           //     TerminarFuenteDeVideo();
           //     //camaraParada = false;
           //     string misDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
           //     string rutaFoto = Path.Combine(misDocumentos, "OFICIOS " + DateTime.Now.ToString("yyyy") + "\\SECRETARIA\\CONSTANCIAS DE IDENTIDAD\\fotos\\");
           //     if (!Directory.Exists(rutaFoto)) { Directory.CreateDirectory(rutaFoto); }
           //     foto = rutaFoto + txtNombre.Text + ".jpg";
           //     pictureBox1.Image.Save(foto, ImageFormat.Jpeg);
           // }
        }

        private void btnCamaraWeb_Click(object sender, EventArgs e)
        {
            camaraParada = false;
            encuadro = false;
            BuscarDispositivos();
            if (ExistenDispositivos)
            {
                if (camaraParada == false)
                {
                    FuenteDeVideo = new VideoCaptureDevice(DispositivosDeVideo[0].MonikerString);
                    FuenteDeVideo.NewFrame += new NewFrameEventHandler(video_NuevoFrame);
                    FuenteDeVideo.Start(); camaraParada = true;
                    txtMSG.Text = "Cuando este listo, de un clic para tomar la foto";


                }
            }
            }
        }
    }

   



