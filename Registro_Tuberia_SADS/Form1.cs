using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.IO;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Linq;
using System.Globalization;

namespace Registro_Tuberia_SADS
{
    public partial class frmPrincipal : Form
    {
        //Variable para las solicitudes o consultas a al servidor 
        private static readonly HttpClient cliente = new HttpClient();
        public int var_temporal;
        public string p_fecha_guardar, path_archivo_txt,p_formato_hora, p_hora_registro;
        public bool p_tubo_repetido=false;
        public char[] p_permitidas_tubo_placa = { '-', '0','1', '2', '3', '4', '5', '6', '7', '8', '9', (char)Keys.Back };
        public char[] p_permitidas_lote_alambre = { '/','-', '0', '1','2', '3', '4', '5', '6', '7', '8', '9', (char)Keys.Back };
        //Directory.GetCurrentDirectory() @"C:\"

        public frmPrincipal()
        {
            InitializeComponent();
        }

        #region funciones para API REST con la db del SADS
        //funcion parar mandar las consultas a la API echa en php en el servidor o host
       /* public string GetApiData(string url)
        {
            string responseString = "";
            try
            {
                var response = cliente.GetStringAsync(url);
                responseString = response.Result;

            }
            catch (Exception err)
            {
                MessageBox.Show("error_conexion: "+err.Message);

            }
            return responseString;
        }*/

        public void insertApiData_tubo(string url,string id_tubo)
        {
            
            p_fecha_guardar= DateTime.Now.ToString("dd/MM/yyyy");
            string fecha_envio, hora_envio, hora_db;
            DateTime hora_db_dt;
            if ((txbHora.Enabled==true)&&(txbFecha.Enabled==true))
            {
                fecha_envio = txbFecha.Text;
                hora_envio = txbHora.Text;

            }
            else
            {
                fecha_envio = p_fecha_guardar;
                hora_envio = p_hora_registro.Replace(".","");
            }
            
            hora_db_dt = Convert.ToDateTime(fecha_envio+" "+ hora_envio);
            hora_db = hora_db_dt.ToString("yyyy-MM-dd HH:mm:ss");
            try
            {
                var values = new Dictionary<string, string>
                {
                    { "T_id_tubo", id_tubo },
                    { "T_no_tubo", txbNoTubo.Text },
                    { "T_no_placa", txbNoPlaca.Text },
                    { "T_ID_proyecto", lblIDproyecto.Text},
                    { "T_lote_alambre", txbLoteAlam.Text },
                    { "T_lote_fundente", txbLoteFund.Text },
                    { "T_maquina", lblMaquina.Text },
                    { "T_foliooperador", txbFolio.Text },
                    { "T_fecha", fecha_envio},
                    { "T_hora", hora_envio },
                    { "T_hora_db", hora_db},
                    { "Archivos_excel", ""},
                    { "T_observaciones",txbObservaciones.Text }

                };

                //var content = new FormUrlEncodedContent(values);
                //var response = cliente.PostAsync(url, content);

                var cultureInfo = new CultureInfo("de-DE");
                var datos_de_envio = new Tabla_exin
                {
                    T_ID_tubo = id_tubo,
                    T_No_tubo = txbNoTubo.Text,
                    T_No_placa = txbNoPlaca.Text,
                    T_ID_proyecto = lblIDproyecto.Text,
                    T_Lote_fundente = txbLoteFund.Text,
                    T_Lote_alambre = txbLoteAlam.Text,
                    T_Maquina = lblMaquina.Text,
                    T_FolioOperador = txbFolio.Text,
                    T_Fecha = fecha_envio,
                    T_Hora = hora_envio,
                    T_Hora_db = DateTime.ParseExact(hora_db, "yyyy-MM-dd HH:mm:ss", cultureInfo),
                    T_Archivos_excel = "",
                    T_Observaciones = txbObservaciones.Text
                };


                var json = JObject.FromObject(datos_de_envio);
                var content = new StringContent(json.ToString(), Encoding.UTF8, "application/json");
                var response = Consultas.Post_API(url, content);

            }
            catch (Exception err)
            {
                MessageBox.Show("Error en enviar a BD, se guardo respaldo en PC\n error: "+err.Message);

            }
            
        }

        //funcion para saber si hay datos del tubo a registrados
        //si no hay se hace registro nuevo
        //si hay se envia a la tabla estra
        void registro_tuberia(string urlb, string urlm, string urle, string id_tubo)
        {
            //revisar si ya existe fue registrado el tubo

            string tubo_datos;
            //insertApiData_tubo(urlm, id_tubo);

            tubo_datos = Consultas.Get_API(urlb + id_tubo);
            lblIDproyecto.Text = tubo_datos;
         
            if ((tubo_datos != "[] "))
            {
                insertApiData_tubo(urle, id_tubo);
            }
            else
            {
                insertApiData_tubo(urlm, id_tubo);
            }
            
        }

        //Respaldo que realiza antes de enviar los datos a la API
        //Si la conexion falla el respaldo guarda los datos del tubo
        public void archivo_txt_respaldo()
        {
            string fecha_envio_txt,hora_envio_txt;
            p_fecha_guardar = DateTime.Now.ToString("dd/MM/yyyy");
            if ((txbHora.Enabled == true) && (txbFecha.Enabled == true))
            {
                fecha_envio_txt = txbFecha.Text;
                hora_envio_txt = txbHora.Text;

            }
            else
            {
                fecha_envio_txt = p_fecha_guardar;
                hora_envio_txt = p_hora_registro.Replace(".", "");
            }
            string linea_encabezado = "ID_tubo,No_tubo,No_placa,ID_proyecto,Maquina,"+
                                      "Lote_alambre,Lote_fundente,"+
                                       "Folio_operador,Fecha,Hora,Observaciones";

            string linea_registro =  txbNoPlaca.Text + txbNoTubo.Text + "," +
                                  txbNoTubo.Text + "," +
                                  txbNoPlaca.Text + "," +
                                  lblIDproyecto.Text + "," +
                                  lblMaquina.Text + "," +
                                  txbLoteAlam.Text + "," +
                                  txbLoteFund.Text + "," +
                                  txbFolio.Text + "," +
                                  fecha_envio_txt + "," +
                                  hora_envio_txt + "," +
                                  txbObservaciones.Text;
               
            path_archivo_txt = @"C:\\Users\\Public\\Respaldo_registro_Maquina_" + lblMaquina.Text + "_v2.txt";

            if (!File.Exists(path_archivo_txt))
            {
                // Create a file to write to.
                using (StreamWriter c_archivo = File.CreateText(path_archivo_txt))
                {
                    c_archivo.WriteLine(linea_encabezado);
                    c_archivo.WriteLine(linea_registro);
                    c_archivo.Close();
                }
            }
            else
            {
                using (StreamWriter e_archivo = new StreamWriter(path_archivo_txt, true))
                {
                    e_archivo.WriteLine(linea_registro); //se agrega información al documento

                    e_archivo.Close();
                }
            }
        }


        #endregion

        #region funcinalidades de formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void tbcPrincipal_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void tbpOperador_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void tbpTuberia_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        void Orientacion_vertical()
        {
            //pestañas 
            this.Width = 600;
            this.StartPosition = FormStartPosition.WindowsDefaultLocation;
            tbcPrincipal.Width = 590;
            tbcPrincipal.Location = new Point(6, 2);
            //pestaña Operador
            lblFolio.Location = new Point(2, 30);
            txbFolio.Location = new Point(100, 30);
            btnIngresar.Location = new Point(265, 21);
            btnSalirOperador.Location = new Point(425, 21);
            gpbIngresar.Width = 530;
            btnAjustes.Location = new Point(420, 105);
            btnActivarEdicion.Location = new Point(485, 105);
            btnCerrar2.Location = new Point(475, 6);
            btnMinimizar2.Location = new Point(405, 6);
            lblIDp.Location = new Point(9, 390);
            lblIDproyecto.Location = new Point(169, 390);
            Font fuente = new Font(lblTituloOperador.Font.FontFamily, 24);
            lblTituloOperador.Font = fuente;
            //pestaña tuberia
            btnCerrar.Location = new Point(475, 6);
            btnMinimizar.Location = new Point(405, 6);
            lblTituloTuberia.Font = fuente;
            btnDatosTuberia.Location = new Point(475, 250);
            lblHora.Location = new Point(380, 49);
            txbHora.Location = new Point(412, 49);
            lblEalambre.Location = new Point(5, 226);
            lblTipoalambre.Location = new Point(130, 226);
            lblEfundente.Location = new Point(5, 251);
            lblTipoFundente.Location = new Point(130, 251);
            lblEmaquina.Location = new Point(5, 201);
            lblMaquina.Location = new Point(105, 201);
            lblEdiametro.Location = new Point(285, 172);
            lblDiametro.Location = new Point(411, 172);
            lblEwps.Location = new Point(5, 278);
            lblWps.Location = new Point(85, 278);
            gpbDatossoldadura.Location = new Point(6, 305);
            gpbDatossoldadura.Width = 540;
            gpbDatossoldadura.Height = 280;
            txbObservaciones.Width = 235;
            txbObservaciones.Location = new Point(156, 200);
            lblEobservaciones.Location = new Point(7, 197);
            lblEobservaciones.Text = "Obs. :";
            btnGuardar.Location = new Point(390, 120);
            btnGuardar.Height = 75;
            btnGuardar.Width = 138;
            btnGuardar.ImageAlign = ContentAlignment.TopCenter;
            btnGuardar.TextAlign = ContentAlignment.BottomCenter;

        }

        void Orientacion_horizontal()
        {
            //pestañas 
            this.Width = 720;
            this.StartPosition = FormStartPosition.CenterScreen;
            tbcPrincipal.Width = 710;
            tbcPrincipal.Location = new Point(10, 2);
            //pestaña Operador
            lblFolio.Location = new Point(19, 30);
            txbFolio.Location = new Point(136, 30);
            btnIngresar.Location = new Point(311, 21);
            btnSalirOperador.Location = new Point(470, 21);
            gpbIngresar.Width = 588;
            btnAjustes.Location = new Point(470, 105);
            btnActivarEdicion.Location = new Point(534, 105);
            btnCerrar2.Location = new Point(588, 6);
            btnMinimizar2.Location = new Point(512, 6);
            lblIDp.Location = new Point(9, 348);
            lblIDproyecto.Location = new Point(169, 348);
            Font fuente = new Font(lblTituloOperador.Font.FontFamily, 26);
            lblTituloOperador.Font = fuente;
            //lblTituloOperador.Font = new System.Drawing.Font(lblTituloOperador.Font, FontStyle.Bold);
            //pestaña tuberia
            btnCerrar.Location = new Point(588, 6);
            btnMinimizar.Location = new Point(512, 6);
            lblTituloTuberia.Font = fuente;
            btnDatosTuberia.Location = new Point(622, 175);
            lblHora.Location = new Point(440, 49);
            txbHora.Location = new Point(472, 49);
            lblEalambre.Location = new Point(371, 85);
            lblTipoalambre.Location = new Point(499, 85);
            lblEfundente.Location = new Point(371, 114);
            lblTipoFundente.Location = new Point(499, 114);
            lblEmaquina.Location = new Point(371, 146);
            lblMaquina.Location = new Point(499, 146);
            lblEdiametro.Location = new Point(371, 175);
            lblDiametro.Location = new Point(499, 175);
            lblEwps.Location = new Point(5, 197);
            lblWps.Location = new Point(85, 197);
            gpbDatossoldadura.Location = new Point(6, 217);
            gpbDatossoldadura.Width = 660;
            txbObservaciones.Width = 259;
            txbObservaciones.Location = new Point(395, 58);
            lblEobservaciones.Location = new Point(392, 24);
            lblEobservaciones.Text = "Observaciones:";
            btnGuardar.Location = new Point(398, 142);
            btnGuardar.Height = 39;
            btnGuardar.Width = 158;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
        }

        #endregion

        #region funciones para iniciar formulario y pestañas
        void Desabilitar_tuberia()
        {

            gpbDatossoldadura.Enabled = false;

        }

        void Iniciar_formulario()
        {
            p_formato_hora = Properties.Settings.Default.Gformato_hora;
            tmrFechaHora.Enabled = true;
            lblMaquina.Text = Properties.Settings.Default.Gmaquina;
            lblNombreProyecto.Text = Properties.Settings.Default.Gproyecto;
            string orientacion = Properties.Settings.Default.Gfrmp_orientacion;

            Cargar_datos_proyectos();
            btnGuardar.Enabled = false;
            this.Height = 300;
            tbcPrincipal.Height = 295;
            tbcPrincipal.Location = new Point(6, 5);
            Desabilitar_tuberia();
            btnActivarEdicion.Visible = false;
            btnActivarEdicion.Enabled = false;
            btnDatosTuberia.Visible = false;
            txbFecha.Enabled = false;
            txbFecha.Visible = false;
            txbHora.Enabled = false;
            txbHora.Visible = false;
            txbFolio.Enabled = true;
            txbFolio.Text = "";
            btnIngresar.Enabled = true;
            btnAjustes.Enabled = true;
            lblNombre.Text = "XXXXXXXXXXXXXXX";
            lblClaveSold.Text = "XXXXXXXXXXX";
            lblMensajeerror.Text = "Ingrese Folio";
            if (orientacion == "VERTICAL")
            {
                Orientacion_vertical();
            }else
            {
                Orientacion_horizontal();
            }
            txbFolio.Select();
        }

        
        void Habilitar_tuberia()
        {
            gpbDatossoldadura.Enabled = true;
            btnDatosTuberia.Visible = true;
        }

        

        void Cargar_datos_proyectos()
        {
            string nombre_proyecto = lblNombreProyecto.Text;
            Properties.Settings.Default.Gproyecto = nombre_proyecto;
            
            if (nombre_proyecto!="")
            {
                int po = nombre_proyecto.IndexOf("-");
                lblIDproyecto.Text = nombre_proyecto.Substring(0, po);
                //colocar try ra ver si hay conexion, si no hay recibir y mandar a paantalla 
                //mensaje de error
                try
                {
                    var output_p = Consultas.Get_API("http://10.10.20.15/backend/api/ar_tProyectos.php?Pro_ID=" + lblIDproyecto.Text);
                    List<proyectos_tabla> results_p = JsonConvert.DeserializeObject<List<proyectos_tabla>>(output_p);
                    foreach (var r in results_p)
                    {
                        lblNombreProyecto.Text = r.Pro_Nombre;
                        lblOrdentrabajo.Text = r.Pro_Ordentrabajo;
                        lblTipoalambre.Text = r.Pro_Alambre;
                        lblTipoFundente.Text = r.Pro_Fundente;
                        lblEspecificacion.Text = r.Pro_Especificacion;
                        lblDiametro.Text = r.Pro_Diametro.ToString();
                        lblEspesor.Text = r.Pro_Espesor.ToString();
                        lblWps.Text = r.Pro_WPS;

                    }
                }
                catch (Exception err_proyecto)
                {

                    MessageBox.Show("Error cargar proyecto: " + err_proyecto.Message+
                        "\n CHEQUE CONEXION CON LA BASE DE DATOS." );
                }
                
            }
            
        }
        //rutina de cerrar
        void cerrar_botones()
        {
            DialogResult r = MessageBox.Show("¿Esta seguro que quiere salir?",
                "Registro de Tuberia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (r == DialogResult.Yes)
            {
                
                Properties.Settings.Default.Gmaquina = lblMaquina.Text;
                Properties.Settings.Default.Gproyecto = lblIDproyecto.Text+"-"+ lblNombreProyecto.Text;
                Properties.Settings.Default.Gordentrabajo = lblIDproyecto.Text + "-" + lblOrdentrabajo.Text;
                Properties.Settings.Default.Gformato_hora = p_formato_hora;
                Properties.Settings.Default.Save();
                this.Close();
            }
        }

        #endregion

        private void txbNoPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            //agregar pra solo letras y numeros

        }

        private void txbNoTubo_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!p_permitidas_tubo_placa.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
           
            
        }

        private void txbFolio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btnIngresar.PerformClick();
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                
                e.Handled = true;
            }

            
        }

        private void txbLoteAlam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!p_permitidas_lote_alambre.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Iniciar_formulario();
            //<a href="https://www.flaticon.com/free-icons/minus" title="minus icons">Minus icons created by Aldo Cervantes - Flaticon</a>
            //<a href="https://www.flaticon.com/free-icons/cross" title="cross icons">Cross icons created by Freepik - Flaticon</a>
        }

        private void tmrFechaHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
            p_hora_registro= DateTime.Now.ToString("hh:mm:ss tt");
            if (p_formato_hora=="24horas")
            {
                lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            }
            
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        
        private void frmPrincipal_Activated(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Gcp == true)
            {
                string orientacion = Properties.Settings.Default.Gfrmp_orientacion;
                if(orientacion=="VERTICAL")
                {

                    Orientacion_vertical();
                    
                }
                else
                {
                    Orientacion_horizontal();
                    
                }
                lblNombreProyecto.Text = Properties.Settings.Default.Gproyecto;
                Cargar_datos_proyectos();
                lblMaquina.Text = Properties.Settings.Default.Gmaquina;
                p_formato_hora = Properties.Settings.Default.Gformato_hora;
                Properties.Settings.Default.Gcp = false;
            }
            
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Gmaquina = lblMaquina.Text;
        }

        //_________________________________________________________________
        #region funciones de lso botones
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            cerrar_botones();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var_temporal = 1;
            if ((txbLoteAlam.Text != "") && (txbLoteFund.Text != "") && (txbNoPlaca.Text != "") && (txbNoTubo.Text != ""))
            {

                string no_placa_g = txbNoPlaca.Text.Replace("-", "");
                string no_tubo_g = txbNoTubo.Text.Replace("-", "");
                string id_tubo = no_placa_g + no_tubo_g, urlb, urlm, urle;
                //crear archivo de texto
                archivo_txt_respaldo();

                string opcion_maquina = lblMaquina.Text;

                switch (opcion_maquina)
                {
                    case "INTERNA1":
                        //revisar si ya existe fue registrado el tubo
                        urlb = "http://10.10.20.15/api/internas/rq_tTuberiaInterna_1.php?tubo=";
                        //urlm = "http://10.10.20.15/api/internas/rq_tTuberiaInterna_1.php";
                        urlm = "http://10.10.20.15/backend/api/ar_tTuberiaInterna_1.php";
                        urle = "http://10.10.20.15/api/internas/rq_tTuberiaInterna_extra.php";
                        registro_tuberia(urlb, urlm, urle, id_tubo);
                        break;
                    case "INTERNA2":
                        urlb = "http://10.10.20.15/api/internas/rq_tTuberiaInterna_2.php?tubo=";
                        //urlm = "http://10.10.20.15/api/internas/rq_tTuberiaInterna_2.php";
                        urlm = "http://10.10.20.15/backend/api/ar_tTuberiaInterna_2.php";
                        urle = "http://10.10.20.15/api/internas/rq_tTuberiaInterna_extra.php";
                        registro_tuberia(urlb, urlm, urle, id_tubo);
                        break;
                    case "INTERNA3":
                        urlb = "http://10.10.20.15/api/internas/rq_tTuberiaInterna_3.php?tubo=";
                        //urlm = "http://10.10.20.15/api/internas/rq_tTuberiaInterna_3.php";
                        urlm = "http://10.10.20.15/backend/api/ar_tTuberiaInterna_3.php";
                        urle = "http://10.10.20.15/api/internas/rq_tTuberiaInterna_extra.php";
                        registro_tuberia(urlb, urlm, urle, id_tubo);
                        break;
                    case "EXTERNA1":
                        urlb = "http://10.10.20.15/api/externas/rq_tTuberiaExterna_1.php?tubo=";
                        //urlm = "http://10.10.20.15/api/externas/rq_tTuberiaExterna_1.php";
                        urlm = "http://10.10.20.15/backend/api/ar_tTuberiaExterna_1.php";
                        urle = "http://10.10.20.15/api/externas/rq_tTuberiaExterna_extra.php";
                        registro_tuberia(urlb, urlm, urle, id_tubo);
                        break;
                    case "EXTERNA2":
                        urlb = "http://10.10.20.15/api/externas/rq_tTuberiaExterna_2.php?tubo=";
                        //urlm = "http://10.10.20.15/api/externas/rq_tTuberiaExterna_2.php";
                        urlm = "http://10.10.20.15/backend/api/ar_tTuberiaExterna_2.php";
                        urle = "http://10.10.20.15/api/externas/rq_tTuberiaExterna_extra.php";
                        registro_tuberia(urlb, urlm, urle, id_tubo);
                        break;
                    case "EXTERNA3":
                        urlb = "http://10.10.20.15/api/externas/rq_tTuberiaExterna_3.php?tubo=";
                        //urlm = "http://10.10.20.15/api/externas/rq_tTuberiaExterna_3.php";
                        urlm = "http://10.10.20.15/backend/api/ar_tTuberiaExterna_3.php";
                        urle = "http://10.10.20.15/api/externas/rq_tTuberiaExterna_extra.php";
                        registro_tuberia(urlb, urlm, urle, id_tubo);
                        break;

                    default:
                        break;
                }


                txbNoPlaca.Text = "";
                txbNoTubo.Text = "";
                txbObservaciones.Text = "";
            }
            else
            {
                MessageBox.Show("Dejo sin llenar un cuadro de texto");
            }

        }

        private void btnCerrar2_Click(object sender, EventArgs e)
        {
            cerrar_botones();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            var output = Consultas.Get_API("http://10.10.20.15/api/rq_tOperadores.php?id=" + txbFolio.Text);

            List<operadores_tabla> results = JsonConvert.DeserializeObject<List<operadores_tabla>>(output);

            if ((output != "[]") && (txbFolio.Text != ""))
            {
                foreach (var r in results)
                {
                    lblNombre.Text = r.Op_Nombre;
                    lblClaveSold.Text = "sc-" + r.Op_Clave_soldador;

                }

                if (lblNombreProyecto.Text != "")
                {

                    //Cargar_datos_proyectos();

                    btnIngresar.Enabled = false;
                    txbFolio.Enabled = false;
                    btnAjustes.Enabled = false;
                    btnGuardar.Enabled = true;
                    Habilitar_tuberia();
                    lblMensajeerror.Text = "Hablitada pestaña de registro de Tuberia";

                }
                else
                {
                    MessageBox.Show("Proyecto no configurado");
                    lblMensajeerror.Text = "Pulse el engrane y configure proyecto y maquina,\n despues de nuevo pulse ingresar";
                }

                if (Properties.Settings.Default.Gfrmp_orientacion == "VERTICAL")
                {
                    this.Height = 600;
                    tbcPrincipal.Height = 595;
                    tbcPrincipal.Location = new Point(6, 2);
                }
                else
                {
                    this.Height = 420;
                    tbcPrincipal.Height = 415;
                    tbcPrincipal.Location = new Point(6, 2);
                }


            }
            else
            {
                MessageBox.Show("Operador no registrado");
                lblMensajeerror.Text = "Folio no registrado";
            }

            if (txbFolio.Text == "554433")
            {
                btnActivarEdicion.Enabled = true;
                btnActivarEdicion.Visible = true;
                btnAPIs.Enabled = true;
                btnAPIs.Visible = true;

            }
            else
            {
                btnActivarEdicion.Enabled = false;
                btnActivarEdicion.Visible = false;
                btnAPIs.Enabled = false;
                btnAPIs.Visible = false;
            }
        }
        private void btnSalirOperador_Click(object sender, EventArgs e)
        {

            Iniciar_formulario();
        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            //groupBox1.Enabled = false;
            //btnCerrar2.Enabled = false;
            //tbcPrincipal.Enabled = false;
            frmAjustes frm = new frmAjustes();
            frm.ShowDialog();
        }
        private void btnDatosTuberia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proyecto: " + lblNombreProyecto.Text + "\n" +
                            "Orden de trabajo: " + lblOrdentrabajo.Text + "\n" +
                            "Especificacion: " + lblEspecificacion.Text + ".\n" +
                            "Espesor: " + lblEspesor.Text + "\n" +
                            "Diametro: " + lblDiametro.Text + "\n" +
                            "Tipo de alambre: " + lblTipoalambre.Text + "\n" +
                            "Tipo de fundente: " + lblTipoFundente.Text + "\n" +
                            "Maquina: " + lblMaquina.Text + "\n" +
                            "WPS: " + lblWps.Text);
        }


        private void btnMinimizar2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnActivarEdicion_Click(object sender, EventArgs e)
        {
            if ((txbFecha.Enabled == false) && (txbHora.Enabled == false))
            {
                txbFecha.Enabled = true;
                txbFecha.Visible = true;
                txbHora.Enabled = true;
                txbHora.Visible = true;
                lblFecha.Visible = false;
                lblHora.Visible = false;
            }
            else
            {
                txbFecha.Enabled = false;
                txbFecha.Visible = false;
                txbHora.Enabled = false;
                txbHora.Visible = false;
                lblFecha.Visible = true;
                lblHora.Visible = true;
            }

        }
        #endregion

        #region funciones no usadas y que si borro no sirve formulario
        private void frmPrincipal_Validated(object sender, EventArgs e)
        {
            
        }

        private void frmPrincipal_Enter(object sender, EventArgs e)
        {
            
        }

        

        private void lblNombreProyecto_Click(object sender, EventArgs e)
        {

        }

        private void txbFolio_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbpOperador_Click(object sender, EventArgs e)
        {
            
        }

        private void tbpTuberia_Click(object sender, EventArgs e)
        {
            
        }

        private void txbNoPlaca_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbpOperador_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnAPIs_Click(object sender, EventArgs e)
        {
            frmAPIs frm = new frmAPIs();
            frm.ShowDialog();
        }

        private void tbcPrincipal_Enter(object sender, EventArgs e)
        {
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txbNoTubo_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

       



    }
}
