using Microsoft.Reporting.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneradorCertificados
{
    public partial class Form1 : Form
    {
        string name = null;
        string file = null;
        string namesalida = null;
        string filesalida = null;
        ArrayList listado = new ArrayList();//guarda el flujo de datos
        string directorio;
        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionproyectoid);
        System.Drawing.Color Barcolor = System.Drawing.Color.Blue;
        string url = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void btnExaminar_Click_1(object sender, EventArgs e)
        {

            abrirarchivo.FileName = "";
            if (ListaProyecto.Text != "")
            {
                if (abrirarchivo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    name = abrirarchivo.SafeFileNames[0];
                    file = abrirarchivo.FileNames[0];
                    txtRutaEntrada.Text = "\"" + file + "\"";
                    btnRutaSalida.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show(this, "Seleccione Un Proyecto");
            }
        }
        private void btnRutaSalida_Click_1(object sender, EventArgs e)
        {
            //guardararchivo.Title = "Guardar Archivo en ...";
            //guardararchivo.RestoreDirectory = true;
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string salida = folderBrowserDialog1.SelectedPath;
                filesalida = folderBrowserDialog1.SelectedPath;
                ////////////////////////77
                //FileInfo fi = new FileInfo(guardararchivo.FileName);//obtiene informacion hacer de la ruta del archivo
                //filesalida = fi.DirectoryName;
                //namesalida = fi.Name;

                //string salida = filesalida+ "\\" + namesalida;
                // MessageBox.Show(this,""+salida);


                //directorio = guardararchivo.FileName;
                txtRutaSalida.Text += "\"" + salida + "\"";
            }
            if (txtRutaSalida.Text != "")
            {
                btnReporte.Enabled = true;
            }

        }
        private void clear()
        {
            this.file = null;
            this.name = null;
            txtRutaEntrada.Clear();
            txtRutaSalida.Clear();
            btnExaminar.Enabled = true;
            btnRutaSalida.Enabled = false;
            btnReporte.Enabled = false;
            mostrar1.Text = "";
            listado.Clear();
            conexion.Close();

        }
        private bool leer_archivo(string file)
        {
            bool resultado;
            string cadena;
            if (file == null || file.Equals(""))
            {
                MessageBox.Show(this, "Seleccione un archivo.");
                resultado = false;
            }
            else
            {
                resultado = true;
                Stream ArchivoAbierto = null;

                try
                {
                    ArchivoAbierto = File.OpenRead(this.file);//abrir archivo

                    var reader = new StreamReader(ArchivoAbierto);//canal de lectura
                    int lineno = 1;
                    //Un máximo d
                    while (lineno <= 600000 && !reader.EndOfStream)
                    {

                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        if (lineno >= 1)
                        {
                            cadena = values[0];
                            listado.Add(cadena);
                        }
                        lineno++;
                    }
                    reader.Close();
                    ArchivoAbierto.Close();

                }
                catch (Exception ex)
                { throw ex; }
            }
            return resultado;
        }
        private void btnReporte_Click(object sender, EventArgs e)
        {
            string var2;
            //try
            //{
            if (leer_archivo(this.file))
            {
                btnExaminar.Enabled = false;
                BarraProcesos.Value = 10;
                btnRutaSalida.Enabled = false;

                ReportteSalida.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;//
                ReportteSalida.ServerReport.ReportServerUrl = new Uri("http://www.samaltamira.net/ReportServer/");
                Reporte();

                if (url.Length > 0)
                {

                    ReportteSalida.ServerReport.ReportPath = @"/" + url;//direccion de la consulta de responder

                    NetworkCredential myCred = new NetworkCredential("Administrator@steelgo.com", "5T33lt3c2016@", "");
                    ReportteSalida.ServerReport.ReportServerCredentials.NetworkCredentials = myCred;

                    BarraProcesos.Value = 20;
                    mostrar1.Text = "PROCESANDO";
                    int len = listado.Count;
                    int maxleng = 200;
                    int ultimocilo = len % maxleng;
                    int ciclos = ultimocilo == 0 ? (len / maxleng) : (len / maxleng) + 1;
                    ultimocilo = ultimocilo == 0 ? maxleng : ultimocilo;
                    string sincoma = "";
                    // MessageBox.Show(this, "-+++-" + ultimocilo);
                    //MessageBox.Show(this, "-+++-" + ciclos);

                    for (int i = 0; i < ciclos; i++)
                    {
                        var2 = "";
                        //int var1 = 0;
                        int limite = ciclos == 1 ? ultimocilo : i == ciclos - 1 ? ultimocilo : maxleng;
                        // MessageBox.Show(this, "*****+" + limite);    
                        for (int j = 0; j < limite; j++)
                        {
                            // MessageBox.Show(this, "--"+(j + i * maxleng));
                            var2 += listado[j + i * maxleng] + ",";

                        }
                        sincoma = var2.TrimEnd(',');
                        string salida = namesalida + "_" + (i + 1) + ".pdf";

                        this.OpSalidaArchivo(sincoma, salida, i);
                    }
                    btnReporte.Enabled = false;
                    BarraProcesos.Value = 100;
                    MessageBox.Show("Se termino la generación de certificados.");
                    clear();
                    BarraProcesos.Value = 0;


                }
                else
                    
                    {
                        MessageBox.Show(this, "Error no existe Reporte Solicitado ");
                        BarraProcesos.Enabled = false;
                        btnReporte.Enabled = false;
                        BarraProcesos.Value = 0;
                        clear();
                        BarraProcesos.Value = 0;
                    }


            }
            else
            {
                MessageBox.Show(this, "Verifique Formato del archivo ");
                BarraProcesos.Enabled = false;
                btnReporte.Enabled = false;
                BarraProcesos.Value = 0;
                clear();
                BarraProcesos.Value = 0;

            }

        }
        //catch (Exception xe)
        //{
        //    MessageBox.Show(this, "Error de lectura Verifique su archivo, que tenga el formato correcto" );
        //    BarraProcesos.Enabled = false;
        //    btnReporte.Enabled = false;
        //    BarraProcesos.Value = 0;
        //    clear();
        //    BarraProcesos.Value = 0;
        //}
        //}
        private void Form1_Load(object sender, EventArgs e) 
        {

            LlenarComboProyecto();
        }

        private void BarraProcesos_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
        }

        private void OpSalidaArchivo(String sincoma, String nombreArchivo, int i)
        {//metodo que interactua con el reporte
            Warning[] warnings = null;
            string filetype = string.Empty;
            string[] streamIds = null;
            string exportType = "PDF";
            string mimeType = string.Empty;
            string encoding = string.Empty;
            string extension = string.Empty;
            //MessageBox.Show(this, "prueba dato" + ListaProyecto.SelectedValue.ToString());
            String[] ListaNumerosControl = sincoma.Split(',');
            foreach (var NumControlActual in ListaNumerosControl)
            {
                List<ReportParameter> parametros = new List<ReportParameter>();
                parametros.Add(new ReportParameter("ProyectoID", ListaProyecto.SelectedValue.ToString()));
                parametros.Add(new ReportParameter("NumeroControl", NumControlActual));
                this.ReportteSalida.ServerReport.SetParameters(parametros);
                this.ReportteSalida.RefreshReport();

                filetype = exportType == "" ? "" : exportType;
                byte[] bytes = ReportteSalida.ServerReport.Render(filetype, null, // deviceinfo not needed for csv
               out mimeType, out encoding, out extension, out streamIds, out warnings);

                FileStream fs = new FileStream(filesalida + "\\" + NumControlActual + ".pdf", FileMode.OpenOrCreate);

                fs.Write(bytes, 0, bytes.Length);
                fs.Close();
                BarraProcesos.Value = (i + 10);
            }
            ///////////////////////
           // List<ReportParameter> parametros = new List<ReportParameter>();
           // parametros.Add(new ReportParameter("ProyectoID", ListaProyecto.SelectedValue.ToString()));
           // parametros.Add(new ReportParameter("NumeroControl", sincoma));
           // this.ReportteSalida.ServerReport.SetParameters(parametros);
           // this.ReportteSalida.RefreshReport();

           // filetype = exportType == "" ? "" : exportType;
           // byte[] bytes = ReportteSalida.ServerReport.Render(filetype, null, // deviceinfo not needed for csv
           //out mimeType, out encoding, out extension, out streamIds, out warnings);

           // FileStream fs = new FileStream(filesalida + "\\" + nombreArchivo, FileMode.OpenOrCreate);

           // fs.Write(bytes, 0, bytes.Length);
           // fs.Close();
           // BarraProcesos.Value = (i + 10);

            // clear();
        }
        public void LlenarComboProyecto()
        {

            conexion.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select ProyectoID,Nombre from UrlCertificadoBk", conexion);
            da.Fill(ds, "Proyecto");
            ListaProyecto.DataSource = ds.Tables[0].DefaultView;
            ListaProyecto.ValueMember = "ProyectoID";
            ListaProyecto.DisplayMember = "Nombre";
            conexion.Close();
            btnExaminar.Enabled = true;
        }
        public string Reporte()
        {

            SqlCommand com = new SqlCommand("Rpt_ReporteProyectoCertificadoBk", conexion);
            com.CommandType = CommandType.StoredProcedure;
            SqlParameter p = com.Parameters.Add("@ProyectoID", SqlDbType.Int);
            p.Value = Convert.ToInt32(ListaProyecto.SelectedValue.ToString());


            SqlParameter result = new SqlParameter("@retorno", SqlDbType.VarChar, 100);
            result.Direction = ParameterDirection.Output;
            com.Parameters.Add(result);



            conexion.Open();
            com.ExecuteNonQuery();
            url = Convert.ToString(result.SqlValue.ToString());
            conexion.Close();

            return url;
        }

        private void ListaProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }//interaccion con reporte
    }

}