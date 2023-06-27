using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Globalization;
using System.Net.Http;
using System.Text;
using System.Data;

namespace Registro_Tuberia_SADS
{
    public partial class frmAPIs : Form
    {
        DataTable P_Tuberia_datatable = new DataTable();
        string P_url_fecha = "";
        void Iniciar_tabla_tuberia()
        {
            P_Tuberia_datatable.Columns.Add("T_id_tubo");
            P_Tuberia_datatable.Columns.Add("T_no_tubo");
            P_Tuberia_datatable.Columns.Add("T_no_placa");
            P_Tuberia_datatable.Columns.Add("T_ID_proyecto");
            P_Tuberia_datatable.Columns.Add("T_lote_alambre");
            P_Tuberia_datatable.Columns.Add("T_lote_fundente");
            P_Tuberia_datatable.Columns.Add("T_foliooperador");
            P_Tuberia_datatable.Columns.Add("T_fecha");
            P_Tuberia_datatable.Columns.Add("T_hora");
            P_Tuberia_datatable.Columns.Add("T_hora_db");
            P_Tuberia_datatable.Columns.Add("archivo_excel");
            P_Tuberia_datatable.Columns.Add("Observaciones");

        }

        public void Rellenar_tabla_datos(string url)
        {
            //llena la tabla de datos para tuberia de los registros solicitados por fecha dada
            P_Tuberia_datatable.Rows.Clear();
            try
            {
                
                var output = Consultas.Get_API(url + "?fecha=" + txbFechaaP3.Text);

                List<Tabla_exin> temporal_results = JsonConvert.DeserializeObject<List<Tabla_exin>>(output);
                foreach (var r in temporal_results)
                {
                    P_Tuberia_datatable.Rows.Add(r.T_ID_tubo, r.T_No_tubo, r.T_No_placa, r.T_ID_proyecto, r.T_Lote_alambre,
                    r.T_Lote_fundente, r.T_FolioOperador, r.T_Fecha, r.T_Hora, r.T_Hora_db, r.T_Archivos_excel, r.T_Observaciones);

                }

            }
            catch (Exception err)
            {
                MessageBox.Show("Rellenar tabla:" + err.Message);

            }

        }

        public frmAPIs()
        {
            InitializeComponent();
        }

        private void btnGetProyectos_Click(object sender, EventArgs e)
        {
            
                
                //colocar try ra ver si hay conexion, si no hay recibir y mandar a paantalla 
                //mensaje de error
                try
                {
                                                  
                var output_p = Consultas.Get_API("http://10.10.20.15/backend/api/ar_tProyectos.php?Pro_ID=" + txbIDProyecto.Text);
                    List<proyectos_tabla> results_p = JsonConvert.DeserializeObject<List<proyectos_tabla>>(output_p);
                    foreach (var r in results_p)
                    {
                        lblIDProyecto.Text = r.Pro_ID.ToString();
                        lblNombreProyecto.Text = r.Pro_Nombre;
                        lblOTProyecto.Text = r.Pro_Ordentrabajo;
                        lblAlambreProyecto.Text = r.Pro_Alambre;
                        lblFundenteProyecto.Text = r.Pro_Fundente;
                        lblEspecificacionProyecto.Text = r.Pro_Especificacion;
                        lblDiametroProyecto.Text = r.Pro_Diametro.ToString();
                        lblEspesorProyecto.Text = r.Pro_Espesor.ToString();
                        lblWPSProyecto.Text = r.Pro_WPS;

                    }
                }
                catch (Exception err_proyecto)
                {

                    MessageBox.Show("Error cargar proyecto: " + err_proyecto.Message +
                        "\n CHEQUE CONEXION CON LA BASE DE DATOS.");
                }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var output = Consultas.Get_API("http://10.10.20.15/backend/api/ar_tOperadores.php?Op_Folio=" + txbFolioOperador.Text);

            //operadores_tabla myobj = JsonConvert.DeserializeObject<operadores_tabla>(output.Substring(1, output.Length - 2));
            List<operadores_tabla> results = JsonConvert.DeserializeObject<List<operadores_tabla>>(output);

            if (output != "[]")
            {
                foreach (var r in results)
                {
                    lblIDOperador.Text = r.Op_ID.ToString();
                    lblFolioOperador.Text = r.Op_Folio.ToString();
                    lblNombreOperador.Text = r.Op_Nombre;
                    lblClaveSoldadorOperador.Text = "sc-" + r.Op_Clave_soldador;

                }

            }
            else
            {
                MessageBox.Show("Operador no registrado");
            }
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            string url= "http://10.10.20.15/backend/api/ar_tTuberiaInterna_1.php";
            var content = new StringContent(lblJSON.Text, Encoding.UTF8, "application/json");
            var response = Consultas.Post_API(url, content);
            lblRespuesta.Text = response;
        }

        private void btnJSON_Click(object sender, EventArgs e)
        {
            string id_tubo = "54123", Notubo = "5421", Noplaca = "T12", IDproyecto = "8";
            string Lotealambre = "12/34", Lotefundente = "F1234", Maquina = "INTERNA1", Folio = "554433";
            string fecha_envio = "2022/01/22", hora_envio = "07:50:00 am", hora_db = "2022-01-22 07:50:00", observaciones = "test de datos";
            var cultureInfo = new CultureInfo("de-DE");
            var datos_de_envio = new Tabla_exin
            {
                T_ID_tubo = id_tubo,
                T_No_tubo = Notubo,
                T_No_placa = Noplaca,
                T_ID_proyecto = IDproyecto,
                T_Lote_fundente = Lotefundente,
                T_Lote_alambre = Lotealambre,
                T_Maquina = Maquina,
                T_FolioOperador = Folio,
                T_Fecha = fecha_envio,
                T_Hora = hora_envio,
                T_Hora_db = hora_db,
                T_Archivos_excel="",
                T_Observaciones=observaciones
            };

            //string jsonString = JsonSerializer.Serialize(datos_de_envio);
            var json = JObject.FromObject(datos_de_envio);
            /*
            string valores = "{\"Tin_ID_tubo\":" + id_tubo + ","
                                + "\"Tin_No_tubo\":" + Notubo + ","
                                + "\"Tin_No_placa\":" + Noplaca + ","
                                + "\"Tin_ID_proyecto\":" + IDproyecto + ","
                                + "\"Tin_Lote_alambre\":" + Lotealambre + ","
                                + "\"Tin_Lote_fundente\":" + Lotefundente + ","
                                + "\"Tin_Maquina\":" + Maquina + ","
                                + "\"Tin_Foliooperador\":" + Folio + ","
                                + "\"Tin_Fecha\":" + fecha_envio + ","
                                + "\"Tin_Hora\":" + hora_envio + ","
                                + "\"Tin_Hora_db\":" + hora_db + ","
                                + "\"Tin_Archivos_excel\": \"\","
                                + "\"Tin_Observaciones\":" + observaciones + "}";*/
            lblJSON.Text = json.ToString();
                }

        private void btnConsultaTubo_Click(object sender, EventArgs e)
        {
            string url_tubo = "http://10.10.20.15/backend/api/ar_tTuberiaInterna_1.php";
            string tubo_datos = Consultas.Get_API(url_tubo + "?T_ID_tubo=" + txbIDtubo.Text);
            lblDatosTubo.Text = tubo_datos;

        }

        private void frmAPIs_Load(object sender, EventArgs e)
        {
            cmbMaquina.Items.Add("EXTERNA1");
            cmbMaquina.Items.Add("EXTERNA2");
            cmbMaquina.Items.Add("EXTERNA3");
            cmbMaquina.Items.Add("INTERNA1");
            cmbMaquina.Items.Add("INTERNA2");
            cmbMaquina.Items.Add("INTERNA3");
            Iniciar_tabla_tuberia();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DgvTablatuberia.DataSource = null;
            P_Tuberia_datatable.DefaultView.RowFilter = "T_id_tubo NOT IN (.)";
            P_Tuberia_datatable.Rows.Clear();
            DgvTablatuberia.DataSource = P_Tuberia_datatable;
            
            //P_extra = false;
            //designar a que tabla de soldadura sera guardado el dato del archivo excel
                if (cmbMaquina.Text == "INTERNA1")
                {
                    P_url_fecha = "http://10.10.20.15/backend/api/ar_tTuberiaInterna_1.php";
                }
                else if (cmbMaquina.Text == "INTERNA2")
                {
                    P_url_fecha = "http://10.10.20.15/backend/api/ar_tTuberiaInterna_2.php";
                }
                else if (cmbMaquina.Text == "INTERNA3")
                {
                    P_url_fecha = "http://10.10.20.15/backend/api/ar_tTuberiaInterna_3.php";
                }                 
                else if (cmbMaquina.Text == "EXTERNA1")
                {
                    P_url_fecha = "http://10.10.20.15/backend/api/ar_tTuberiaExterna_1.php";
                }
                else if (cmbMaquina.Text == "EXTERNA2")
                {
                    P_url_fecha = "http://10.10.20.15/backend/api/ar_tTuberiaExterna_2.php";
                }
                else if (cmbMaquina.Text == "EXTERNA3")
                {
                    P_url_fecha = "http://10.10.20.15/backend/api/ar_tTuberiaExterna_3.php";
                }

            Rellenar_tabla_datos(P_url_fecha);
            DgvTablatuberia.DataSource = P_Tuberia_datatable;
        }

        private void btnAsignarfechadb_Click(object sender, EventArgs e)
        {
            int numero_filas = DgvTablatuberia.Rows.Count;

            string id_tubo, hora_db, fecha_envio, hora_envio;
            DateTime hora_db_dt;
            
            for (int i = 0; i < numero_filas - 1; i++)
            {
                id_tubo = DgvTablatuberia.Rows[i].Cells[0].Value.ToString();
                fecha_envio = DgvTablatuberia.Rows[i].Cells[7].Value.ToString();
                hora_envio = DgvTablatuberia.Rows[i].Cells[8].Value.ToString();
                hora_db_dt = Convert.ToDateTime(fecha_envio + " " + hora_envio);
                hora_db = hora_db_dt.ToString("yyyy-MM-dd HH:mm:ss");
                Dictionary<string, string> diccionario = new Dictionary<string, string>
                {
                    {"T_ID_tubo", id_tubo },
                    {"T_Hora_db",hora_db }

                };
                var json = JsonConvert.SerializeObject(diccionario);
                var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                Consultas.Update_API(P_url_fecha,content);
            }
            
        }

        private void btnModificarUno_Click(object sender, EventArgs e)
        {

            int numero_filas = DgvTablatuberia.Rows.Count;
            int i = Convert.ToInt16(txbTuboModificar.Text);
            string id_tubo, hora_db, fecha_envio, hora_envio;
            DateTime hora_db_dt;
            id_tubo = DgvTablatuberia.Rows[i].Cells[0].Value.ToString();
            fecha_envio = DgvTablatuberia.Rows[i].Cells[7].Value.ToString();
            hora_envio = DgvTablatuberia.Rows[i].Cells[8].Value.ToString();
            hora_db_dt = Convert.ToDateTime(fecha_envio + " " + hora_envio);
            hora_db = hora_db_dt.ToString("yyyy-MM-dd HH:mm:ss");
            Dictionary<string, string> diccionario = new Dictionary<string, string>
                {
                    {"T_ID_tubo", id_tubo },
                    {"T_Hora_db",hora_db }

                };
            var json = JsonConvert.SerializeObject(diccionario);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            Consultas.Update_API(P_url_fecha, content);
        }
    }
}
