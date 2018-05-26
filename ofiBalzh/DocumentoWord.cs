
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Core;
using Word = Microsoft.Office.Interop.Word;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace ofiBalzh
    {
        class DocumentoWord
        {
            public Word.Application wordApp;
            public Word.Document aDoc;
            public object missing = Missing.Value;
            public object filename;
            public string msgerror(string e)
            {
                return e;
            }
        public DocumentoWord() { }

        public void RemplazarImagen(string textoReemplazar, string imagenReemplazo)
        {
            //Word.Document documentoActivo = new Word.Document();
            Object nullobj = Type.Missing;
            Object start = 0;
            Object end = aDoc.Characters.Count;

            Word.Range rng = aDoc.Range(ref start, ref end);
            Word.Find fnd = rng.Find;

            fnd.ClearFormatting();

            fnd.Text = textoReemplazar;
            fnd.Forward = true;

            Object linktoFile = false;
            Object SaveWithDoc = true;


            Object replaceOption = Word.WdReplace.wdReplaceOne;
            Object range = Type.Missing;

            fnd.Execute(ref nullobj, ref nullobj, ref nullobj, ref nullobj,
            ref nullobj, ref nullobj, ref nullobj, ref nullobj,
            ref nullobj, ref nullobj, ref replaceOption, ref nullobj,
            ref nullobj, ref nullobj, ref nullobj);

            //Insertamos la imagen en la posicion adecuada
            rng.InlineShapes.AddPicture(imagenReemplazo, ref linktoFile, ref SaveWithDoc, ref range);
        }
        public DocumentoWord(string rutaPlantilla , string rutaNueva,string nombreArchivo)
            {
                try
                {

                     File.Copy(rutaPlantilla, Path.Combine(rutaNueva + nombreArchivo), true);

                    wordApp = new Word.Application();
                    filename = Path.Combine(Application.StartupPath, rutaNueva + nombreArchivo);
                    //
                    if (File.Exists((string)filename))
                    {
                        object readOnly = false;
                        object isVisible = false;
                        wordApp.Visible = false;
                        aDoc = wordApp.Documents.Open(ref filename, ref missing,
                        ref readOnly, ref missing, ref missing, ref missing,
                        ref missing, ref missing, ref missing, ref missing,
                        ref missing, ref isVisible, ref missing, ref missing,
                        ref missing, ref missing);
                        aDoc.Activate();

                    
                    }
                    else
                    {
                        msgerror("El archivo no existe.");
                        //MessageBox.Show("El archivo no existe.”, "Sin archivo”, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    msgerror("error interno." + ex.Message);
                    //MessageBox.Show("Error durante el proceso.Descripcion: ” +ex.Message, "Error Interno”, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           public void AbrirDocumento(string ruta)
            {
                string archivo = ruta;

            Word.Application objWord = (Word.Application)Activator.CreateInstance(Type.GetTypeFromProgID("Word.Application"));
                object missing = System.Reflection.Missing.Value;


                object abrirDoc = archivo;
                object readOnly = false;
                object isVisible = true;

                objWord.Documents.Open(ref abrirDoc, ref missing, ref readOnly, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref isVisible, ref missing, ref missing, ref missing, ref missing);
                objWord.Visible = true;

            }
            public void GuardarDocumento()
            {
                try
                {
                    aDoc.Save();
                }
                catch (Exception ex)
                {
                    msgerror("error " + ex.Message);
                    // MessageBox.Show("Error durante el proceso.Descripcion: ” +ex.Message, "Error Interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            public void CerrarDocumento()
            {
                object saveChanges = Word.WdSaveOptions.wdSaveChanges;
                wordApp.Quit(ref saveChanges, ref missing, ref missing);
            }

            public void BuscarRemplazar(object findText, object replaceText)
            {
                this.BuscarRemplazar(wordApp, findText, replaceText);
           
        }

            public void BuscarRemplazar(Word.Application wordApp, object findText, object replaceText)
            {
                object matchCase = true;
                object matchWholeWord = true;
                object matchWildCards = false;
                object matchSoundsLike = false;
                object matchAllWordForms = false;
                object forward = true;
                object format = false;
                object matchKashida = false;
                object matchDiacritics = false;
                object matchAlefHamza = false;
                object matchControl = false;
                object read_only = false;
                object visible = true;
                object replace = 2;
                object wrap = 1;
                wordApp.Selection.Find.Execute(ref findText, ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundsLike, ref matchAllWordForms,
                ref forward, ref wrap, ref format, ref replaceText, ref replace,
                ref matchKashida, ref matchDiacritics, ref matchAlefHamza, ref matchControl);
            }
        }
    }

