namespace Registro_Tuberia_SADS
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.tbcPrincipal = new System.Windows.Forms.TabControl();
            this.tbpOperador = new System.Windows.Forms.TabPage();
            this.lblIDp = new System.Windows.Forms.Label();
            this.lblIDproyecto = new System.Windows.Forms.Label();
            this.lblMensajeerror = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblClaveSold = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gpbIngresar = new System.Windows.Forms.GroupBox();
            this.txbFolio = new System.Windows.Forms.TextBox();
            this.lblFolio = new System.Windows.Forms.Label();
            this.lblTituloOperador = new System.Windows.Forms.Label();
            this.tbpTuberia = new System.Windows.Forms.TabPage();
            this.lblDiametro = new System.Windows.Forms.Label();
            this.lblEdiametro = new System.Windows.Forms.Label();
            this.lblMaquina = new System.Windows.Forms.Label();
            this.lblEmaquina = new System.Windows.Forms.Label();
            this.lblEwps = new System.Windows.Forms.Label();
            this.lblWps = new System.Windows.Forms.Label();
            this.txbHora = new System.Windows.Forms.TextBox();
            this.txbFecha = new System.Windows.Forms.TextBox();
            this.lblEspesor = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblTipoFundente = new System.Windows.Forms.Label();
            this.lblTipoalambre = new System.Windows.Forms.Label();
            this.lblOrdentrabajo = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblEfundente = new System.Windows.Forms.Label();
            this.lblEalambre = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.gpbDatossoldadura = new System.Windows.Forms.GroupBox();
            this.txbObservaciones = new System.Windows.Forms.TextBox();
            this.lblEobservaciones = new System.Windows.Forms.Label();
            this.txbNoTubo = new System.Windows.Forms.TextBox();
            this.txbNoPlaca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbLoteAlam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txbLoteFund = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNombreProyecto = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTituloTuberia = new System.Windows.Forms.Label();
            this.lblEspecificacion = new System.Windows.Forms.Label();
            this.tmrFechaHora = new System.Windows.Forms.Timer(this.components);
            this.btnMinimizar2 = new System.Windows.Forms.Button();
            this.btnActivarEdicion = new System.Windows.Forms.Button();
            this.btnAjustes = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSalirOperador = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnCerrar2 = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnDatosTuberia = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnAPIs = new System.Windows.Forms.Button();
            this.tbcPrincipal.SuspendLayout();
            this.tbpOperador.SuspendLayout();
            this.gpbIngresar.SuspendLayout();
            this.tbpTuberia.SuspendLayout();
            this.gpbDatossoldadura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcPrincipal
            // 
            this.tbcPrincipal.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tbcPrincipal.Controls.Add(this.tbpOperador);
            this.tbcPrincipal.Controls.Add(this.tbpTuberia);
            this.tbcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tbcPrincipal.Multiline = true;
            this.tbcPrincipal.Name = "tbcPrincipal";
            this.tbcPrincipal.SelectedIndex = 0;
            this.tbcPrincipal.Size = new System.Drawing.Size(720, 420);
            this.tbcPrincipal.TabIndex = 0;
            this.tbcPrincipal.Enter += new System.EventHandler(this.tbcPrincipal_Enter);
            this.tbcPrincipal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tbcPrincipal_MouseMove);
            // 
            // tbpOperador
            // 
            this.tbpOperador.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbpOperador.Controls.Add(this.btnAPIs);
            this.tbpOperador.Controls.Add(this.btnMinimizar2);
            this.tbpOperador.Controls.Add(this.btnActivarEdicion);
            this.tbpOperador.Controls.Add(this.lblIDp);
            this.tbpOperador.Controls.Add(this.lblIDproyecto);
            this.tbpOperador.Controls.Add(this.lblMensajeerror);
            this.tbpOperador.Controls.Add(this.btnAjustes);
            this.tbpOperador.Controls.Add(this.label8);
            this.tbpOperador.Controls.Add(this.lblClaveSold);
            this.tbpOperador.Controls.Add(this.label6);
            this.tbpOperador.Controls.Add(this.lblNombre);
            this.tbpOperador.Controls.Add(this.pictureBox2);
            this.tbpOperador.Controls.Add(this.gpbIngresar);
            this.tbpOperador.Controls.Add(this.lblTituloOperador);
            this.tbpOperador.Controls.Add(this.btnCerrar2);
            this.tbpOperador.Location = new System.Drawing.Point(4, 4);
            this.tbpOperador.Name = "tbpOperador";
            this.tbpOperador.Padding = new System.Windows.Forms.Padding(3);
            this.tbpOperador.Size = new System.Drawing.Size(682, 412);
            this.tbpOperador.TabIndex = 1;
            this.tbpOperador.Text = "OPERADOR";
            this.tbpOperador.Click += new System.EventHandler(this.tbpOperador_Click);
            this.tbpOperador.Enter += new System.EventHandler(this.tbpOperador_Enter);
            this.tbpOperador.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tbpOperador_MouseMove);
            // 
            // lblIDp
            // 
            this.lblIDp.AutoSize = true;
            this.lblIDp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDp.Location = new System.Drawing.Point(9, 348);
            this.lblIDp.Name = "lblIDp";
            this.lblIDp.Size = new System.Drawing.Size(162, 31);
            this.lblIDp.TabIndex = 16;
            this.lblIDp.Text = "ID proyecto:";
            // 
            // lblIDproyecto
            // 
            this.lblIDproyecto.AutoSize = true;
            this.lblIDproyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDproyecto.Location = new System.Drawing.Point(169, 348);
            this.lblIDproyecto.Name = "lblIDproyecto";
            this.lblIDproyecto.Size = new System.Drawing.Size(68, 31);
            this.lblIDproyecto.TabIndex = 15;
            this.lblIDproyecto.Text = "XXX";
            // 
            // lblMensajeerror
            // 
            this.lblMensajeerror.AutoSize = true;
            this.lblMensajeerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeerror.Location = new System.Drawing.Point(6, 254);
            this.lblMensajeerror.Name = "lblMensajeerror";
            this.lblMensajeerror.Size = new System.Drawing.Size(140, 31);
            this.lblMensajeerror.TabIndex = 14;
            this.lblMensajeerror.Text = "mensaje...";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 31);
            this.label8.TabIndex = 11;
            this.label8.Text = "Nombre:";
            // 
            // lblClaveSold
            // 
            this.lblClaveSold.AutoSize = true;
            this.lblClaveSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveSold.Location = new System.Drawing.Point(177, 105);
            this.lblClaveSold.Name = "lblClaveSold";
            this.lblClaveSold.Size = new System.Drawing.Size(212, 31);
            this.lblClaveSold.TabIndex = 12;
            this.lblClaveSold.Text = "XXXXXXXXXXX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 31);
            this.label6.TabIndex = 9;
            this.label6.Text = "C. Soldador:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(177, 74);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(212, 31);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "XXXXXXXXXXX";
            // 
            // gpbIngresar
            // 
            this.gpbIngresar.Controls.Add(this.txbFolio);
            this.gpbIngresar.Controls.Add(this.btnSalirOperador);
            this.gpbIngresar.Controls.Add(this.lblFolio);
            this.gpbIngresar.Controls.Add(this.btnIngresar);
            this.gpbIngresar.Location = new System.Drawing.Point(4, 154);
            this.gpbIngresar.Name = "gpbIngresar";
            this.gpbIngresar.Size = new System.Drawing.Size(588, 88);
            this.gpbIngresar.TabIndex = 8;
            this.gpbIngresar.TabStop = false;
            // 
            // txbFolio
            // 
            this.txbFolio.Location = new System.Drawing.Point(136, 30);
            this.txbFolio.Name = "txbFolio";
            this.txbFolio.Size = new System.Drawing.Size(120, 31);
            this.txbFolio.TabIndex = 1;
            this.txbFolio.TextChanged += new System.EventHandler(this.txbFolio_TextChanged);
            this.txbFolio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbFolio_KeyPress);
            // 
            // lblFolio
            // 
            this.lblFolio.AutoSize = true;
            this.lblFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolio.Location = new System.Drawing.Point(19, 30);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(81, 31);
            this.lblFolio.TabIndex = 7;
            this.lblFolio.Text = "Folio:";
            this.lblFolio.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblTituloOperador
            // 
            this.lblTituloOperador.AutoSize = true;
            this.lblTituloOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloOperador.Location = new System.Drawing.Point(113, 10);
            this.lblTituloOperador.Name = "lblTituloOperador";
            this.lblTituloOperador.Size = new System.Drawing.Size(336, 39);
            this.lblTituloOperador.TabIndex = 2;
            this.lblTituloOperador.Text = "Datos del Operador";
            // 
            // tbpTuberia
            // 
            this.tbpTuberia.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbpTuberia.Controls.Add(this.btnMinimizar);
            this.tbpTuberia.Controls.Add(this.lblDiametro);
            this.tbpTuberia.Controls.Add(this.lblEdiametro);
            this.tbpTuberia.Controls.Add(this.lblMaquina);
            this.tbpTuberia.Controls.Add(this.lblEmaquina);
            this.tbpTuberia.Controls.Add(this.lblEwps);
            this.tbpTuberia.Controls.Add(this.lblWps);
            this.tbpTuberia.Controls.Add(this.txbHora);
            this.tbpTuberia.Controls.Add(this.txbFecha);
            this.tbpTuberia.Controls.Add(this.lblEspesor);
            this.tbpTuberia.Controls.Add(this.label17);
            this.tbpTuberia.Controls.Add(this.lblTipoFundente);
            this.tbpTuberia.Controls.Add(this.lblTipoalambre);
            this.tbpTuberia.Controls.Add(this.lblOrdentrabajo);
            this.tbpTuberia.Controls.Add(this.label14);
            this.tbpTuberia.Controls.Add(this.lblEfundente);
            this.tbpTuberia.Controls.Add(this.lblEalambre);
            this.tbpTuberia.Controls.Add(this.label11);
            this.tbpTuberia.Controls.Add(this.lblHora);
            this.tbpTuberia.Controls.Add(this.gpbDatossoldadura);
            this.tbpTuberia.Controls.Add(this.label7);
            this.tbpTuberia.Controls.Add(this.lblNombreProyecto);
            this.tbpTuberia.Controls.Add(this.lblFecha);
            this.tbpTuberia.Controls.Add(this.lblTituloTuberia);
            this.tbpTuberia.Controls.Add(this.lblEspecificacion);
            this.tbpTuberia.Controls.Add(this.btnDatosTuberia);
            this.tbpTuberia.Controls.Add(this.pictureBox1);
            this.tbpTuberia.Controls.Add(this.btnCerrar);
            this.tbpTuberia.Location = new System.Drawing.Point(4, 4);
            this.tbpTuberia.Name = "tbpTuberia";
            this.tbpTuberia.Padding = new System.Windows.Forms.Padding(3);
            this.tbpTuberia.Size = new System.Drawing.Size(682, 412);
            this.tbpTuberia.TabIndex = 0;
            this.tbpTuberia.Text = "TUBERIA";
            this.tbpTuberia.Click += new System.EventHandler(this.tbpTuberia_Click);
            this.tbpTuberia.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tbpTuberia_MouseMove);
            // 
            // lblDiametro
            // 
            this.lblDiametro.AutoSize = true;
            this.lblDiametro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiametro.Location = new System.Drawing.Point(499, 175);
            this.lblDiametro.Name = "lblDiametro";
            this.lblDiametro.Size = new System.Drawing.Size(100, 25);
            this.lblDiametro.TabIndex = 27;
            this.lblDiametro.Text = "xxxxxxxx";
            // 
            // lblEdiametro
            // 
            this.lblEdiametro.AutoSize = true;
            this.lblEdiametro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdiametro.Location = new System.Drawing.Point(371, 175);
            this.lblEdiametro.Name = "lblEdiametro";
            this.lblEdiametro.Size = new System.Drawing.Size(104, 25);
            this.lblEdiametro.TabIndex = 30;
            this.lblEdiametro.Text = "Diámetro:";
            // 
            // lblMaquina
            // 
            this.lblMaquina.AutoSize = true;
            this.lblMaquina.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaquina.Location = new System.Drawing.Point(502, 143);
            this.lblMaquina.Name = "lblMaquina";
            this.lblMaquina.Size = new System.Drawing.Size(100, 25);
            this.lblMaquina.TabIndex = 15;
            this.lblMaquina.Text = "xxxxxxxx";
            // 
            // lblEmaquina
            // 
            this.lblEmaquina.AutoSize = true;
            this.lblEmaquina.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmaquina.Location = new System.Drawing.Point(371, 143);
            this.lblEmaquina.Name = "lblEmaquina";
            this.lblEmaquina.Size = new System.Drawing.Size(125, 25);
            this.lblEmaquina.TabIndex = 26;
            this.lblEmaquina.Text = "Máquina:    ";
            // 
            // lblEwps
            // 
            this.lblEwps.AutoSize = true;
            this.lblEwps.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEwps.Location = new System.Drawing.Point(5, 197);
            this.lblEwps.Name = "lblEwps";
            this.lblEwps.Size = new System.Drawing.Size(73, 29);
            this.lblEwps.TabIndex = 34;
            this.lblEwps.Text = "WPS:";
            // 
            // lblWps
            // 
            this.lblWps.AutoSize = true;
            this.lblWps.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWps.Location = new System.Drawing.Point(85, 197);
            this.lblWps.Name = "lblWps";
            this.lblWps.Size = new System.Drawing.Size(101, 29);
            this.lblWps.TabIndex = 33;
            this.lblWps.Text = "xxxxxxxx";
            // 
            // txbHora
            // 
            this.txbHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbHora.Location = new System.Drawing.Point(472, 47);
            this.txbHora.Name = "txbHora";
            this.txbHora.Size = new System.Drawing.Size(127, 31);
            this.txbHora.TabIndex = 32;
            this.txbHora.Text = "hh:mm:ss pp";
            this.txbHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbFecha
            // 
            this.txbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFecha.Location = new System.Drawing.Point(166, 52);
            this.txbFecha.Name = "txbFecha";
            this.txbFecha.Size = new System.Drawing.Size(127, 31);
            this.txbFecha.TabIndex = 31;
            this.txbFecha.Text = "yyyy/MM/dd";
            this.txbFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEspesor
            // 
            this.lblEspesor.AutoSize = true;
            this.lblEspesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspesor.Location = new System.Drawing.Point(105, 172);
            this.lblEspesor.Name = "lblEspesor";
            this.lblEspesor.Size = new System.Drawing.Size(100, 25);
            this.lblEspesor.TabIndex = 29;
            this.lblEspesor.Text = "xxxxxxxx";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(5, 172);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 25);
            this.label17.TabIndex = 28;
            this.label17.Text = "Espesor:";
            // 
            // lblTipoFundente
            // 
            this.lblTipoFundente.AutoSize = true;
            this.lblTipoFundente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoFundente.Location = new System.Drawing.Point(499, 114);
            this.lblTipoFundente.Name = "lblTipoFundente";
            this.lblTipoFundente.Size = new System.Drawing.Size(100, 25);
            this.lblTipoFundente.TabIndex = 24;
            this.lblTipoFundente.Text = "xxxxxxxx";
            // 
            // lblTipoalambre
            // 
            this.lblTipoalambre.AutoSize = true;
            this.lblTipoalambre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoalambre.Location = new System.Drawing.Point(499, 85);
            this.lblTipoalambre.Name = "lblTipoalambre";
            this.lblTipoalambre.Size = new System.Drawing.Size(100, 25);
            this.lblTipoalambre.TabIndex = 23;
            this.lblTipoalambre.Text = "xxxxxxxx";
            // 
            // lblOrdentrabajo
            // 
            this.lblOrdentrabajo.AutoSize = true;
            this.lblOrdentrabajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdentrabajo.Location = new System.Drawing.Point(105, 114);
            this.lblOrdentrabajo.Name = "lblOrdentrabajo";
            this.lblOrdentrabajo.Size = new System.Drawing.Size(100, 25);
            this.lblOrdentrabajo.TabIndex = 22;
            this.lblOrdentrabajo.Text = "xxxxxxxx";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(5, 143);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 25);
            this.label14.TabIndex = 21;
            this.label14.Text = "Esp.:";
            // 
            // lblEfundente
            // 
            this.lblEfundente.AutoSize = true;
            this.lblEfundente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEfundente.Location = new System.Drawing.Point(371, 114);
            this.lblEfundente.Name = "lblEfundente";
            this.lblEfundente.Size = new System.Drawing.Size(134, 25);
            this.lblEfundente.TabIndex = 20;
            this.lblEfundente.Text = "T. Fundente:";
            // 
            // lblEalambre
            // 
            this.lblEalambre.AutoSize = true;
            this.lblEalambre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEalambre.Location = new System.Drawing.Point(371, 85);
            this.lblEalambre.Name = "lblEalambre";
            this.lblEalambre.Size = new System.Drawing.Size(122, 25);
            this.lblEalambre.TabIndex = 19;
            this.lblEalambre.Text = "T. Alambre:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(5, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 25);
            this.label11.TabIndex = 18;
            this.label11.Text = "Orden T. :";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(440, 49);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(103, 29);
            this.lblHora.TabIndex = 9;
            this.lblHora.Text = "hh:mm tt";
            // 
            // gpbDatossoldadura
            // 
            this.gpbDatossoldadura.Controls.Add(this.txbObservaciones);
            this.gpbDatossoldadura.Controls.Add(this.lblEobservaciones);
            this.gpbDatossoldadura.Controls.Add(this.txbNoTubo);
            this.gpbDatossoldadura.Controls.Add(this.txbNoPlaca);
            this.gpbDatossoldadura.Controls.Add(this.label3);
            this.gpbDatossoldadura.Controls.Add(this.txbLoteAlam);
            this.gpbDatossoldadura.Controls.Add(this.label2);
            this.gpbDatossoldadura.Controls.Add(this.label10);
            this.gpbDatossoldadura.Controls.Add(this.btnGuardar);
            this.gpbDatossoldadura.Controls.Add(this.txbLoteFund);
            this.gpbDatossoldadura.Controls.Add(this.label9);
            this.gpbDatossoldadura.Location = new System.Drawing.Point(6, 217);
            this.gpbDatossoldadura.Name = "gpbDatossoldadura";
            this.gpbDatossoldadura.Size = new System.Drawing.Size(660, 187);
            this.gpbDatossoldadura.TabIndex = 17;
            this.gpbDatossoldadura.TabStop = false;
            // 
            // txbObservaciones
            // 
            this.txbObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbObservaciones.Location = new System.Drawing.Point(395, 58);
            this.txbObservaciones.Multiline = true;
            this.txbObservaciones.Name = "txbObservaciones";
            this.txbObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbObservaciones.Size = new System.Drawing.Size(259, 75);
            this.txbObservaciones.TabIndex = 105;
            this.txbObservaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEobservaciones
            // 
            this.lblEobservaciones.AutoSize = true;
            this.lblEobservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEobservaciones.Location = new System.Drawing.Point(392, 24);
            this.lblEobservaciones.Name = "lblEobservaciones";
            this.lblEobservaciones.Size = new System.Drawing.Size(204, 31);
            this.lblEobservaciones.TabIndex = 15;
            this.lblEobservaciones.Text = "Observaciones:";
            // 
            // txbNoTubo
            // 
            this.txbNoTubo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNoTubo.Location = new System.Drawing.Point(156, 146);
            this.txbNoTubo.Name = "txbNoTubo";
            this.txbNoTubo.Size = new System.Drawing.Size(218, 38);
            this.txbNoTubo.TabIndex = 104;
            this.txbNoTubo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbNoTubo.TextChanged += new System.EventHandler(this.txbNoTubo_TextChanged);
            this.txbNoTubo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNoTubo_KeyPress);
            // 
            // txbNoPlaca
            // 
            this.txbNoPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbNoPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNoPlaca.Location = new System.Drawing.Point(156, 102);
            this.txbNoPlaca.Name = "txbNoPlaca";
            this.txbNoPlaca.Size = new System.Drawing.Size(218, 38);
            this.txbNoPlaca.TabIndex = 103;
            this.txbNoPlaca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbNoPlaca.TextChanged += new System.EventHandler(this.txbNoPlaca_TextChanged);
            this.txbNoPlaca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNoPlaca_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "No. Tubo:";
            // 
            // txbLoteAlam
            // 
            this.txbLoteAlam.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLoteAlam.Location = new System.Drawing.Point(156, 58);
            this.txbLoteAlam.Name = "txbLoteAlam";
            this.txbLoteAlam.Size = new System.Drawing.Size(218, 38);
            this.txbLoteAlam.TabIndex = 102;
            this.txbLoteAlam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbLoteAlam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbLoteAlam_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "No. Placa:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 31);
            this.label10.TabIndex = 13;
            this.label10.Text = "Lote Alam:";
            // 
            // txbLoteFund
            // 
            this.txbLoteFund.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLoteFund.Location = new System.Drawing.Point(156, 17);
            this.txbLoteFund.Name = "txbLoteFund";
            this.txbLoteFund.Size = new System.Drawing.Size(218, 38);
            this.txbLoteFund.TabIndex = 101;
            this.txbLoteFund.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 31);
            this.label9.TabIndex = 11;
            this.label9.Text = "Lote Fund:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Proyecto:";
            // 
            // lblNombreProyecto
            // 
            this.lblNombreProyecto.AutoSize = true;
            this.lblNombreProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProyecto.Location = new System.Drawing.Point(105, 85);
            this.lblNombreProyecto.Name = "lblNombreProyecto";
            this.lblNombreProyecto.Size = new System.Drawing.Size(100, 25);
            this.lblNombreProyecto.TabIndex = 10;
            this.lblNombreProyecto.Text = "xxxxxxxx";
            this.lblNombreProyecto.Click += new System.EventHandler(this.lblNombreProyecto_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(135, 49);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(139, 29);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "yyyy/MM/dd";
            // 
            // lblTituloTuberia
            // 
            this.lblTituloTuberia.AutoSize = true;
            this.lblTituloTuberia.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTuberia.Location = new System.Drawing.Point(110, 10);
            this.lblTituloTuberia.Name = "lblTituloTuberia";
            this.lblTituloTuberia.Size = new System.Drawing.Size(339, 39);
            this.lblTituloTuberia.TabIndex = 2;
            this.lblTituloTuberia.Text = "Registro de Tuberia";
            // 
            // lblEspecificacion
            // 
            this.lblEspecificacion.AutoSize = true;
            this.lblEspecificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecificacion.Location = new System.Drawing.Point(105, 143);
            this.lblEspecificacion.Name = "lblEspecificacion";
            this.lblEspecificacion.Size = new System.Drawing.Size(100, 25);
            this.lblEspecificacion.TabIndex = 25;
            this.lblEspecificacion.Text = "xxxxxxxx";
            // 
            // tmrFechaHora
            // 
            this.tmrFechaHora.Tick += new System.EventHandler(this.tmrFechaHora_Tick);
            // 
            // btnMinimizar2
            // 
            this.btnMinimizar2.Image = global::Registro_Tuberia_SADS.Properties.Resources.no_entry;
            this.btnMinimizar2.Location = new System.Drawing.Point(512, 6);
            this.btnMinimizar2.Name = "btnMinimizar2";
            this.btnMinimizar2.Size = new System.Drawing.Size(70, 43);
            this.btnMinimizar2.TabIndex = 101;
            this.btnMinimizar2.UseVisualStyleBackColor = true;
            this.btnMinimizar2.Click += new System.EventHandler(this.btnMinimizar2_Click);
            // 
            // btnActivarEdicion
            // 
            this.btnActivarEdicion.Image = global::Registro_Tuberia_SADS.Properties.Resources.key;
            this.btnActivarEdicion.Location = new System.Drawing.Point(534, 105);
            this.btnActivarEdicion.Name = "btnActivarEdicion";
            this.btnActivarEdicion.Size = new System.Drawing.Size(58, 53);
            this.btnActivarEdicion.TabIndex = 17;
            this.btnActivarEdicion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActivarEdicion.UseVisualStyleBackColor = true;
            this.btnActivarEdicion.Click += new System.EventHandler(this.btnActivarEdicion_Click);
            // 
            // btnAjustes
            // 
            this.btnAjustes.Image = ((System.Drawing.Image)(resources.GetObject("btnAjustes.Image")));
            this.btnAjustes.Location = new System.Drawing.Point(470, 105);
            this.btnAjustes.Name = "btnAjustes";
            this.btnAjustes.Size = new System.Drawing.Size(58, 53);
            this.btnAjustes.TabIndex = 13;
            this.btnAjustes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAjustes.UseVisualStyleBackColor = true;
            this.btnAjustes.Click += new System.EventHandler(this.btnAjustes_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(101, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // btnSalirOperador
            // 
            this.btnSalirOperador.Image = global::Registro_Tuberia_SADS.Properties.Resources.door_out;
            this.btnSalirOperador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalirOperador.Location = new System.Drawing.Point(470, 21);
            this.btnSalirOperador.Name = "btnSalirOperador";
            this.btnSalirOperador.Size = new System.Drawing.Size(100, 54);
            this.btnSalirOperador.TabIndex = 8;
            this.btnSalirOperador.Text = "Salir";
            this.btnSalirOperador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalirOperador.UseVisualStyleBackColor = true;
            this.btnSalirOperador.Click += new System.EventHandler(this.btnSalirOperador_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Image = global::Registro_Tuberia_SADS.Properties.Resources.door_in;
            this.btnIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresar.Location = new System.Drawing.Point(311, 21);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(132, 54);
            this.btnIngresar.TabIndex = 7;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCerrar2
            // 
            this.btnCerrar2.Image = global::Registro_Tuberia_SADS.Properties.Resources.cancel;
            this.btnCerrar2.Location = new System.Drawing.Point(588, 6);
            this.btnCerrar2.Name = "btnCerrar2";
            this.btnCerrar2.Size = new System.Drawing.Size(70, 43);
            this.btnCerrar2.TabIndex = 100;
            this.btnCerrar2.UseVisualStyleBackColor = true;
            this.btnCerrar2.Click += new System.EventHandler(this.btnCerrar2_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Image = global::Registro_Tuberia_SADS.Properties.Resources.no_entry;
            this.btnMinimizar.Location = new System.Drawing.Point(512, 6);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(70, 43);
            this.btnMinimizar.TabIndex = 102;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.Image = global::Registro_Tuberia_SADS.Properties.Resources.disk;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(398, 142);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(158, 39);
            this.btnGuardar.TabIndex = 107;
            this.btnGuardar.Text = " GUARDAR";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnDatosTuberia
            // 
            this.btnDatosTuberia.BackgroundImage = global::Registro_Tuberia_SADS.Properties.Resources.rating_feedback_review_checklist_rate_questionnaire_survey_icon_231920_1_;
            this.btnDatosTuberia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDatosTuberia.Location = new System.Drawing.Point(622, 175);
            this.btnDatosTuberia.Name = "btnDatosTuberia";
            this.btnDatosTuberia.Size = new System.Drawing.Size(44, 39);
            this.btnDatosTuberia.TabIndex = 35;
            this.btnDatosTuberia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDatosTuberia.UseVisualStyleBackColor = true;
            this.btnDatosTuberia.Click += new System.EventHandler(this.btnDatosTuberia_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = global::Registro_Tuberia_SADS.Properties.Resources.cancel;
            this.btnCerrar.Location = new System.Drawing.Point(588, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(70, 43);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAPIs
            // 
            this.btnAPIs.BackgroundImage = global::Registro_Tuberia_SADS.Properties.Resources.business_help_support_service_customer_icon_231900;
            this.btnAPIs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAPIs.Enabled = false;
            this.btnAPIs.Location = new System.Drawing.Point(15, 306);
            this.btnAPIs.Name = "btnAPIs";
            this.btnAPIs.Size = new System.Drawing.Size(44, 39);
            this.btnAPIs.TabIndex = 104;
            this.btnAPIs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAPIs.UseVisualStyleBackColor = true;
            this.btnAPIs.Visible = false;
            this.btnAPIs.Click += new System.EventHandler(this.btnAPIs_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(720, 420);
            this.ControlBox = false;
            this.Controls.Add(this.tbcPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Tuberia";
            this.Activated += new System.EventHandler(this.frmPrincipal_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.Enter += new System.EventHandler(this.frmPrincipal_Enter);
            this.Validated += new System.EventHandler(this.frmPrincipal_Validated);
            this.tbcPrincipal.ResumeLayout(false);
            this.tbpOperador.ResumeLayout(false);
            this.tbpOperador.PerformLayout();
            this.gpbIngresar.ResumeLayout(false);
            this.gpbIngresar.PerformLayout();
            this.tbpTuberia.ResumeLayout(false);
            this.tbpTuberia.PerformLayout();
            this.gpbDatossoldadura.ResumeLayout(false);
            this.gpbDatossoldadura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcPrincipal;
        private System.Windows.Forms.TabPage tbpTuberia;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txbNoTubo;
        private System.Windows.Forms.TextBox txbNoPlaca;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTituloTuberia;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TabPage tbpOperador;
        private System.Windows.Forms.Button btnCerrar2;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txbFolio;
        private System.Windows.Forms.Label lblTituloOperador;
        private System.Windows.Forms.Timer tmrFechaHora;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.GroupBox gpbIngresar;
        private System.Windows.Forms.Label lblFolio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblClaveSold;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSalirOperador;
        private System.Windows.Forms.Button btnAjustes;
        private System.Windows.Forms.TextBox txbLoteAlam;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbLoteFund;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblNombreProyecto;
        private System.Windows.Forms.Label lblMaquina;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblEmaquina;
        private System.Windows.Forms.Label lblEspecificacion;
        private System.Windows.Forms.Label lblTipoFundente;
        private System.Windows.Forms.Label lblTipoalambre;
        private System.Windows.Forms.Label lblOrdentrabajo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblEfundente;
        private System.Windows.Forms.Label lblEalambre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gpbDatossoldadura;
        private System.Windows.Forms.Label lblEdiametro;
        private System.Windows.Forms.Label lblEspesor;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblDiametro;
        private System.Windows.Forms.Label lblMensajeerror;
        private System.Windows.Forms.TextBox txbHora;
        private System.Windows.Forms.TextBox txbFecha;
        private System.Windows.Forms.Label lblIDp;
        private System.Windows.Forms.Label lblIDproyecto;
        private System.Windows.Forms.TextBox txbObservaciones;
        private System.Windows.Forms.Label lblEobservaciones;
        private System.Windows.Forms.Button btnActivarEdicion;
        private System.Windows.Forms.Label lblEwps;
        private System.Windows.Forms.Label lblWps;
        private System.Windows.Forms.Button btnDatosTuberia;
        private System.Windows.Forms.Button btnMinimizar2;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnAPIs;
    }
}

