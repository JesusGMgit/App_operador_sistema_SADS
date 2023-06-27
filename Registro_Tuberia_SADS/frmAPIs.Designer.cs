namespace Registro_Tuberia_SADS
{
    partial class frmAPIs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbcTablas = new System.Windows.Forms.TabControl();
            this.tbpProyecto = new System.Windows.Forms.TabPage();
            this.lblWPSProyecto = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblEspecificacionProyecto = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblOTProyecto = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblFundenteProyecto = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblAlambreProyecto = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblEspesorProyecto = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDiametroProyecto = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNombreProyecto = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIDProyecto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbIDProyecto = new System.Windows.Forms.TextBox();
            this.btnGetProyectos = new System.Windows.Forms.Button();
            this.tbpOperadores = new System.Windows.Forms.TabPage();
            this.lblClaveSoldadorOperador = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblFolioOperador = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblNombreOperador = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblIDOperador = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txbFolioOperador = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.btnJSON = new System.Windows.Forms.Button();
            this.lblJSON = new System.Windows.Forms.Label();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblDatosTubo = new System.Windows.Forms.Label();
            this.txbIDtubo = new System.Windows.Forms.TextBox();
            this.btnConsultaTubo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.txbFechaaP3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbMaquina = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DgvTablatuberia = new System.Windows.Forms.DataGridView();
            this.btnAsignarfechadb = new System.Windows.Forms.Button();
            this.btnModificarUno = new System.Windows.Forms.Button();
            this.txbTuboModificar = new System.Windows.Forms.TextBox();
            this.tbcTablas.SuspendLayout();
            this.tbpProyecto.SuspendLayout();
            this.tbpOperadores.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTablatuberia)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcTablas
            // 
            this.tbcTablas.Controls.Add(this.tbpProyecto);
            this.tbcTablas.Controls.Add(this.tbpOperadores);
            this.tbcTablas.Controls.Add(this.tabPage1);
            this.tbcTablas.Controls.Add(this.tabPage2);
            this.tbcTablas.Controls.Add(this.tabPage3);
            this.tbcTablas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcTablas.Location = new System.Drawing.Point(0, 0);
            this.tbcTablas.Margin = new System.Windows.Forms.Padding(4);
            this.tbcTablas.Name = "tbcTablas";
            this.tbcTablas.SelectedIndex = 0;
            this.tbcTablas.Size = new System.Drawing.Size(729, 450);
            this.tbcTablas.TabIndex = 0;
            // 
            // tbpProyecto
            // 
            this.tbpProyecto.Controls.Add(this.lblWPSProyecto);
            this.tbpProyecto.Controls.Add(this.label18);
            this.tbpProyecto.Controls.Add(this.lblEspecificacionProyecto);
            this.tbpProyecto.Controls.Add(this.label10);
            this.tbpProyecto.Controls.Add(this.lblOTProyecto);
            this.tbpProyecto.Controls.Add(this.label12);
            this.tbpProyecto.Controls.Add(this.lblFundenteProyecto);
            this.tbpProyecto.Controls.Add(this.label14);
            this.tbpProyecto.Controls.Add(this.lblAlambreProyecto);
            this.tbpProyecto.Controls.Add(this.label16);
            this.tbpProyecto.Controls.Add(this.lblEspesorProyecto);
            this.tbpProyecto.Controls.Add(this.label8);
            this.tbpProyecto.Controls.Add(this.lblDiametroProyecto);
            this.tbpProyecto.Controls.Add(this.label6);
            this.tbpProyecto.Controls.Add(this.lblNombreProyecto);
            this.tbpProyecto.Controls.Add(this.label4);
            this.tbpProyecto.Controls.Add(this.lblIDProyecto);
            this.tbpProyecto.Controls.Add(this.label1);
            this.tbpProyecto.Controls.Add(this.txbIDProyecto);
            this.tbpProyecto.Controls.Add(this.btnGetProyectos);
            this.tbpProyecto.Location = new System.Drawing.Point(4, 27);
            this.tbpProyecto.Margin = new System.Windows.Forms.Padding(4);
            this.tbpProyecto.Name = "tbpProyecto";
            this.tbpProyecto.Padding = new System.Windows.Forms.Padding(4);
            this.tbpProyecto.Size = new System.Drawing.Size(721, 419);
            this.tbpProyecto.TabIndex = 0;
            this.tbpProyecto.Text = "Proyectos";
            this.tbpProyecto.UseVisualStyleBackColor = true;
            // 
            // lblWPSProyecto
            // 
            this.lblWPSProyecto.AutoSize = true;
            this.lblWPSProyecto.Location = new System.Drawing.Point(156, 359);
            this.lblWPSProyecto.Name = "lblWPSProyecto";
            this.lblWPSProyecto.Size = new System.Drawing.Size(54, 18);
            this.lblWPSProyecto.TabIndex = 19;
            this.lblWPSProyecto.Text = "label17";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(24, 359);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 18);
            this.label18.TabIndex = 18;
            this.label18.Text = "WPS";
            // 
            // lblEspecificacionProyecto
            // 
            this.lblEspecificacionProyecto.AutoSize = true;
            this.lblEspecificacionProyecto.Location = new System.Drawing.Point(156, 308);
            this.lblEspecificacionProyecto.Name = "lblEspecificacionProyecto";
            this.lblEspecificacionProyecto.Size = new System.Drawing.Size(46, 18);
            this.lblEspecificacionProyecto.TabIndex = 17;
            this.lblEspecificacionProyecto.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 18);
            this.label10.TabIndex = 16;
            this.label10.Text = "especificacion";
            // 
            // lblOTProyecto
            // 
            this.lblOTProyecto.AutoSize = true;
            this.lblOTProyecto.Location = new System.Drawing.Point(195, 109);
            this.lblOTProyecto.Name = "lblOTProyecto";
            this.lblOTProyecto.Size = new System.Drawing.Size(54, 18);
            this.lblOTProyecto.TabIndex = 15;
            this.lblOTProyecto.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(156, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 18);
            this.label12.TabIndex = 14;
            this.label12.Text = "OT:";
            // 
            // lblFundenteProyecto
            // 
            this.lblFundenteProyecto.AutoSize = true;
            this.lblFundenteProyecto.Location = new System.Drawing.Point(383, 234);
            this.lblFundenteProyecto.Name = "lblFundenteProyecto";
            this.lblFundenteProyecto.Size = new System.Drawing.Size(54, 18);
            this.lblFundenteProyecto.TabIndex = 13;
            this.lblFundenteProyecto.Text = "label13";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(295, 234);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 18);
            this.label14.TabIndex = 12;
            this.label14.Text = "fundente";
            // 
            // lblAlambreProyecto
            // 
            this.lblAlambreProyecto.AutoSize = true;
            this.lblAlambreProyecto.Location = new System.Drawing.Point(383, 197);
            this.lblAlambreProyecto.Name = "lblAlambreProyecto";
            this.lblAlambreProyecto.Size = new System.Drawing.Size(54, 18);
            this.lblAlambreProyecto.TabIndex = 11;
            this.lblAlambreProyecto.Text = "label15";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(295, 197);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 18);
            this.label16.TabIndex = 10;
            this.label16.Text = "alambre";
            // 
            // lblEspesorProyecto
            // 
            this.lblEspesorProyecto.AutoSize = true;
            this.lblEspesorProyecto.Location = new System.Drawing.Point(112, 234);
            this.lblEspesorProyecto.Name = "lblEspesorProyecto";
            this.lblEspesorProyecto.Size = new System.Drawing.Size(46, 18);
            this.lblEspesorProyecto.TabIndex = 9;
            this.lblEspesorProyecto.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "Espesor";
            // 
            // lblDiametroProyecto
            // 
            this.lblDiametroProyecto.AutoSize = true;
            this.lblDiametroProyecto.Location = new System.Drawing.Point(112, 197);
            this.lblDiametroProyecto.Name = "lblDiametroProyecto";
            this.lblDiametroProyecto.Size = new System.Drawing.Size(46, 18);
            this.lblDiametroProyecto.TabIndex = 7;
            this.lblDiametroProyecto.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Diametro";
            // 
            // lblNombreProyecto
            // 
            this.lblNombreProyecto.AutoSize = true;
            this.lblNombreProyecto.Location = new System.Drawing.Point(112, 157);
            this.lblNombreProyecto.Name = "lblNombreProyecto";
            this.lblNombreProyecto.Size = new System.Drawing.Size(46, 18);
            this.lblNombreProyecto.TabIndex = 5;
            this.lblNombreProyecto.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre:";
            // 
            // lblIDProyecto
            // 
            this.lblIDProyecto.AutoSize = true;
            this.lblIDProyecto.Location = new System.Drawing.Point(67, 109);
            this.lblIDProyecto.Name = "lblIDProyecto";
            this.lblIDProyecto.Size = new System.Drawing.Size(46, 18);
            this.lblIDProyecto.TabIndex = 3;
            this.lblIDProyecto.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // txbIDProyecto
            // 
            this.txbIDProyecto.Location = new System.Drawing.Point(27, 23);
            this.txbIDProyecto.Name = "txbIDProyecto";
            this.txbIDProyecto.Size = new System.Drawing.Size(147, 24);
            this.txbIDProyecto.TabIndex = 1;
            // 
            // btnGetProyectos
            // 
            this.btnGetProyectos.Location = new System.Drawing.Point(194, 20);
            this.btnGetProyectos.Name = "btnGetProyectos";
            this.btnGetProyectos.Size = new System.Drawing.Size(252, 30);
            this.btnGetProyectos.TabIndex = 0;
            this.btnGetProyectos.Text = "BUSCAR";
            this.btnGetProyectos.UseVisualStyleBackColor = true;
            this.btnGetProyectos.Click += new System.EventHandler(this.btnGetProyectos_Click);
            // 
            // tbpOperadores
            // 
            this.tbpOperadores.Controls.Add(this.lblClaveSoldadorOperador);
            this.tbpOperadores.Controls.Add(this.label15);
            this.tbpOperadores.Controls.Add(this.lblFolioOperador);
            this.tbpOperadores.Controls.Add(this.label19);
            this.tbpOperadores.Controls.Add(this.lblNombreOperador);
            this.tbpOperadores.Controls.Add(this.label21);
            this.tbpOperadores.Controls.Add(this.lblIDOperador);
            this.tbpOperadores.Controls.Add(this.label23);
            this.tbpOperadores.Controls.Add(this.txbFolioOperador);
            this.tbpOperadores.Controls.Add(this.button1);
            this.tbpOperadores.Location = new System.Drawing.Point(4, 27);
            this.tbpOperadores.Margin = new System.Windows.Forms.Padding(4);
            this.tbpOperadores.Name = "tbpOperadores";
            this.tbpOperadores.Padding = new System.Windows.Forms.Padding(4);
            this.tbpOperadores.Size = new System.Drawing.Size(721, 419);
            this.tbpOperadores.TabIndex = 1;
            this.tbpOperadores.Text = "Operadores";
            this.tbpOperadores.UseVisualStyleBackColor = true;
            // 
            // lblClaveSoldadorOperador
            // 
            this.lblClaveSoldadorOperador.AutoSize = true;
            this.lblClaveSoldadorOperador.Location = new System.Drawing.Point(240, 303);
            this.lblClaveSoldadorOperador.Name = "lblClaveSoldadorOperador";
            this.lblClaveSoldadorOperador.Size = new System.Drawing.Size(46, 18);
            this.lblClaveSoldadorOperador.TabIndex = 25;
            this.lblClaveSoldadorOperador.Text = "label7";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(112, 303);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 18);
            this.label15.TabIndex = 24;
            this.label15.Text = "Clave Soldador:";
            // 
            // lblFolioOperador
            // 
            this.lblFolioOperador.AutoSize = true;
            this.lblFolioOperador.Location = new System.Drawing.Point(200, 266);
            this.lblFolioOperador.Name = "lblFolioOperador";
            this.lblFolioOperador.Size = new System.Drawing.Size(46, 18);
            this.lblFolioOperador.TabIndex = 23;
            this.lblFolioOperador.Text = "label5";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(112, 266);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(45, 18);
            this.label19.TabIndex = 22;
            this.label19.Text = "Folio:";
            // 
            // lblNombreOperador
            // 
            this.lblNombreOperador.AutoSize = true;
            this.lblNombreOperador.Location = new System.Drawing.Point(200, 226);
            this.lblNombreOperador.Name = "lblNombreOperador";
            this.lblNombreOperador.Size = new System.Drawing.Size(46, 18);
            this.lblNombreOperador.TabIndex = 21;
            this.lblNombreOperador.Text = "label3";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(112, 226);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(66, 18);
            this.label21.TabIndex = 20;
            this.label21.Text = "Nombre:";
            // 
            // lblIDOperador
            // 
            this.lblIDOperador.AutoSize = true;
            this.lblIDOperador.Location = new System.Drawing.Point(155, 178);
            this.lblIDOperador.Name = "lblIDOperador";
            this.lblIDOperador.Size = new System.Drawing.Size(46, 18);
            this.lblIDOperador.TabIndex = 19;
            this.lblIDOperador.Text = "label2";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(112, 178);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(26, 18);
            this.label23.TabIndex = 18;
            this.label23.Text = "ID:";
            // 
            // txbFolioOperador
            // 
            this.txbFolioOperador.Location = new System.Drawing.Point(115, 92);
            this.txbFolioOperador.Name = "txbFolioOperador";
            this.txbFolioOperador.Size = new System.Drawing.Size(147, 24);
            this.txbFolioOperador.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 30);
            this.button1.TabIndex = 16;
            this.button1.Text = "BUSCAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblRespuesta);
            this.tabPage1.Controls.Add(this.btnJSON);
            this.tabPage1.Controls.Add(this.lblJSON);
            this.tabPage1.Controls.Add(this.btnConvertir);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(721, 419);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Location = new System.Drawing.Point(56, 200);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(46, 18);
            this.lblRespuesta.TabIndex = 20;
            this.lblRespuesta.Text = "label2";
            this.lblRespuesta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnJSON
            // 
            this.btnJSON.Location = new System.Drawing.Point(24, 47);
            this.btnJSON.Name = "btnJSON";
            this.btnJSON.Size = new System.Drawing.Size(252, 33);
            this.btnJSON.TabIndex = 19;
            this.btnJSON.Text = "BUSCAR";
            this.btnJSON.UseVisualStyleBackColor = true;
            this.btnJSON.Click += new System.EventHandler(this.btnJSON_Click);
            // 
            // lblJSON
            // 
            this.lblJSON.AutoSize = true;
            this.lblJSON.Location = new System.Drawing.Point(467, 38);
            this.lblJSON.Name = "lblJSON";
            this.lblJSON.Size = new System.Drawing.Size(46, 18);
            this.lblJSON.TabIndex = 18;
            this.lblJSON.Text = "label2";
            this.lblJSON.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(24, 122);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(252, 30);
            this.btnConvertir.TabIndex = 17;
            this.btnConvertir.Text = "BUSCAR";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.lblDatosTubo);
            this.tabPage2.Controls.Add(this.txbIDtubo);
            this.tabPage2.Controls.Add(this.btnConsultaTubo);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(721, 419);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblDatosTubo
            // 
            this.lblDatosTubo.AutoSize = true;
            this.lblDatosTubo.Location = new System.Drawing.Point(57, 267);
            this.lblDatosTubo.Name = "lblDatosTubo";
            this.lblDatosTubo.Size = new System.Drawing.Size(46, 18);
            this.lblDatosTubo.TabIndex = 2;
            this.lblDatosTubo.Text = "label2";
            // 
            // txbIDtubo
            // 
            this.txbIDtubo.Location = new System.Drawing.Point(187, 66);
            this.txbIDtubo.Name = "txbIDtubo";
            this.txbIDtubo.Size = new System.Drawing.Size(100, 24);
            this.txbIDtubo.TabIndex = 1;
            // 
            // btnConsultaTubo
            // 
            this.btnConsultaTubo.Location = new System.Drawing.Point(57, 129);
            this.btnConsultaTubo.Name = "btnConsultaTubo";
            this.btnConsultaTubo.Size = new System.Drawing.Size(192, 72);
            this.btnConsultaTubo.TabIndex = 0;
            this.btnConsultaTubo.Text = "buscar tubo";
            this.btnConsultaTubo.UseVisualStyleBackColor = true;
            this.btnConsultaTubo.Click += new System.EventHandler(this.btnConsultaTubo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "No de tubo";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txbTuboModificar);
            this.tabPage3.Controls.Add(this.btnModificarUno);
            this.tabPage3.Controls.Add(this.btnAsignarfechadb);
            this.tabPage3.Controls.Add(this.DgvTablatuberia);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.cmbMaquina);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.txbFechaaP3);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(721, 419);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "FECHA:";
            // 
            // txbFechaaP3
            // 
            this.txbFechaaP3.Location = new System.Drawing.Point(136, 64);
            this.txbFechaaP3.Name = "txbFechaaP3";
            this.txbFechaaP3.Size = new System.Drawing.Size(141, 24);
            this.txbFechaaP3.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(296, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "BUSCAR TUBOS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbMaquina
            // 
            this.cmbMaquina.FormattingEnabled = true;
            this.cmbMaquina.Location = new System.Drawing.Point(136, 20);
            this.cmbMaquina.Name = "cmbMaquina";
            this.cmbMaquina.Size = new System.Drawing.Size(141, 26);
            this.cmbMaquina.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "MAQUINA:";
            // 
            // DgvTablatuberia
            // 
            this.DgvTablatuberia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTablatuberia.Location = new System.Drawing.Point(8, 88);
            this.DgvTablatuberia.Name = "DgvTablatuberia";
            this.DgvTablatuberia.Size = new System.Drawing.Size(678, 174);
            this.DgvTablatuberia.TabIndex = 5;
            // 
            // btnAsignarfechadb
            // 
            this.btnAsignarfechadb.Location = new System.Drawing.Point(71, 319);
            this.btnAsignarfechadb.Name = "btnAsignarfechadb";
            this.btnAsignarfechadb.Size = new System.Drawing.Size(156, 33);
            this.btnAsignarfechadb.TabIndex = 6;
            this.btnAsignarfechadb.Text = "MODIFICAR TODOS";
            this.btnAsignarfechadb.UseVisualStyleBackColor = true;
            this.btnAsignarfechadb.Click += new System.EventHandler(this.btnAsignarfechadb_Click);
            // 
            // btnModificarUno
            // 
            this.btnModificarUno.Location = new System.Drawing.Point(484, 342);
            this.btnModificarUno.Name = "btnModificarUno";
            this.btnModificarUno.Size = new System.Drawing.Size(156, 33);
            this.btnModificarUno.TabIndex = 7;
            this.btnModificarUno.Text = "MODIFICAR UNO";
            this.btnModificarUno.UseVisualStyleBackColor = true;
            this.btnModificarUno.Click += new System.EventHandler(this.btnModificarUno_Click);
            // 
            // txbTuboModificar
            // 
            this.txbTuboModificar.Location = new System.Drawing.Point(484, 302);
            this.txbTuboModificar.Name = "txbTuboModificar";
            this.txbTuboModificar.Size = new System.Drawing.Size(141, 24);
            this.txbTuboModificar.TabIndex = 8;
            // 
            // frmAPIs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 450);
            this.Controls.Add(this.tbcTablas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAPIs";
            this.Text = "frmAPIs";
            this.Load += new System.EventHandler(this.frmAPIs_Load);
            this.tbcTablas.ResumeLayout(false);
            this.tbpProyecto.ResumeLayout(false);
            this.tbpProyecto.PerformLayout();
            this.tbpOperadores.ResumeLayout(false);
            this.tbpOperadores.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTablatuberia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcTablas;
        private System.Windows.Forms.TabPage tbpProyecto;
        private System.Windows.Forms.Label lblWPSProyecto;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblEspecificacionProyecto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblOTProyecto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblFundenteProyecto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblAlambreProyecto;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblEspesorProyecto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDiametroProyecto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNombreProyecto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblIDProyecto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbIDProyecto;
        private System.Windows.Forms.Button btnGetProyectos;
        private System.Windows.Forms.TabPage tbpOperadores;
        private System.Windows.Forms.Label lblClaveSoldadorOperador;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblFolioOperador;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblNombreOperador;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblIDOperador;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txbFolioOperador;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblJSON;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Button btnJSON;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txbIDtubo;
        private System.Windows.Forms.Button btnConsultaTubo;
        private System.Windows.Forms.Label lblDatosTubo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbMaquina;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txbFechaaP3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DgvTablatuberia;
        private System.Windows.Forms.Button btnAsignarfechadb;
        private System.Windows.Forms.Button btnModificarUno;
        private System.Windows.Forms.TextBox txbTuboModificar;
    }
}