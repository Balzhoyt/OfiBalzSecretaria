using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System.Configuration;

namespace ofiBalzh
{
    class Datos
    {
        OleDbConnection cn = new OleDbConnection();
        private string cadena = ConfigurationManager.ConnectionStrings["cadenaAcces"].ToString();


//public OleDbConnection=cn;
public OleDbCommandBuilder cmb = new OleDbCommandBuilder();
        public DataSet ds = new DataSet();
        public OleDbDataAdapter da;
        private string[,] mDatos = null;

        public DataTable ejecutarConsultaSQL(string sql)
        {
            OleDbConnection cn = new OleDbConnection(cadena);
            // using (OleDbConnection cn = new OleDbConnection(cadena))
            //{
            DataTable dt = new DataTable();
            OleDbCommand cmd = new OleDbCommand(sql, cn);
            OleDbDataAdapter adap = new OleDbDataAdapter(cmd);
            adap.Fill(dt);
            return dt;
            //}
        }

        public string[,] ejecutarConsulta(string sql)
        {
            OleDbConnection cn = new OleDbConnection(cadena);
            try
            {
                da = new OleDbDataAdapter(sql, cadena);
                da.Fill(ds);

                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        mDatos = new string[ds.Tables[0].Rows.Count, ds.Tables[0].Columns.Count];
                        for (int fil = 0; fil <= ds.Tables[0].Rows.Count - 1; fil++)
                        {
                            for (int col = 0; col <= ds.Tables[0].Columns.Count - 1; col++)
                            {
                                mDatos[fil, col] = System.Convert.ToString(ds.Tables[0].Rows[fil].ItemArray[col]);
                            }
                        }
                    }
                }

                cn.Close();
            }
            catch
            {
                MessageBox.Show("Error!..de la base de datos", "Error de creacion de documento", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally { cn.Close(); }


            return mDatos;

        }
        public string buscarFolio(string sql)
        {
            string folio = "";
            OleDbConnection cn = new OleDbConnection(cadena);
            try
            {
                cn.Open();
                OleDbCommand com = new OleDbCommand(sql, cn);
                OleDbDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    folio = dr["Folio"].ToString();
                }
                else { folio = ""; }
                dr.Close();
                cn.Close();
            }
            catch
            {
                MessageBox.Show("Error!..de la base de datos", "Error de creacion de documento", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally { cn.Close(); }

            return folio;

        }
        public void ejecutarSQL(string sql)
        {

            OleDbConnection cn = new OleDbConnection(cadena);
            try
            {
                cn.Open();
                OleDbCommand com = new OleDbCommand(sql, cn);
                com.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Error!..de la base de datos", "Error de creacion de documento", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                if (cn != null && cn.State != ConnectionState.Closed) { cn.Close(); }
            }
        }


        public static DataTable LoadDataTable()
        {
            DataTable dt = new DataTable();

            string connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=constancias.accdb; Jet OLEDB:Database Password = micreacion";

            OleDbConnection conn = new OleDbConnection(connectionstring);

            OleDbCommand command = new OleDbCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM Patente";

            OleDbDataAdapter da = new OleDbDataAdapter(command);

            da.Fill(dt);

            return dt;
        }

        public static AutoCompleteStringCollection LoadAutoComplete()
        {
            DataTable dt = LoadDataTable();

            AutoCompleteStringCollection stringCol = new AutoCompleteStringCollection();

            foreach (DataRow row in dt.Rows)
            {
                stringCol.Add(Convert.ToString(row["Nombre"]));
            }

            return stringCol;
        }

    }

}

