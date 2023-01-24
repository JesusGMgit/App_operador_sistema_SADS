using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Globalization;
using System.Net.Http;
using System.Text;

namespace Registro_Tuberia_SADS
{
    public partial class frmAPIs : Form
    {
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
                T_Hora_db = DateTime.ParseExact(hora_db,"yyyy-MM-dd HH:mm:ss",cultureInfo),
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
    }
}
