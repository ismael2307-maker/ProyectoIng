namespace IngEconomica
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.pnlSubMenuAnualidades = new System.Windows.Forms.Panel();
            this.btnAnualidadesDiferidas = new System.Windows.Forms.Button();
            this.btnAnualidadesAnticipadas = new System.Windows.Forms.Button();
            this.btnAnualidadesVencidas = new System.Windows.Forms.Button();
            this.btnAnualidades = new System.Windows.Forms.Button();
            this.pnlSubMenuInteres = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnInteresSimple = new System.Windows.Forms.Button();
            this.btnInteres2 = new System.Windows.Forms.Button();
            this.btnInteres = new System.Windows.Forms.Button();
            this.btnPresentacion = new System.Windows.Forms.PictureBox();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.btnPerpetuas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlSubMenuIndicadores = new System.Windows.Forms.Panel();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.pnlSideMenu.SuspendLayout();
            this.pnlSubMenuAnualidades.SuspendLayout();
            this.pnlSubMenuInteres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPresentacion)).BeginInit();
            this.pnlSubMenuIndicadores.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(235)))), ((int)(((byte)(103)))));
            this.pnlTitulo.Controls.Add(this.btnRestaurar);
            this.pnlTitulo.Controls.Add(this.btnMinimizar);
            this.pnlTitulo.Controls.Add(this.btnMaximizar);
            this.pnlTitulo.Controls.Add(this.btnCerrar);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(1300, 38);
            this.pnlTitulo.TabIndex = 0;
            this.pnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitulo_MouseDown);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(1223, 7);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(25, 25);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1183, 7);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1223, 7);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(25, 25);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1263, 7);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.AutoScroll = true;
            this.pnlSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pnlSideMenu.Controls.Add(this.pnlSubMenuIndicadores);
            this.pnlSideMenu.Controls.Add(this.button1);
            this.pnlSideMenu.Controls.Add(this.pnlSubMenuAnualidades);
            this.pnlSideMenu.Controls.Add(this.btnAnualidades);
            this.pnlSideMenu.Controls.Add(this.pnlSubMenuInteres);
            this.pnlSideMenu.Controls.Add(this.btnInteres);
            this.pnlSideMenu.Controls.Add(this.btnPresentacion);
            this.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 38);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(200, 612);
            this.pnlSideMenu.TabIndex = 1;
            // 
            // pnlSubMenuAnualidades
            // 
            this.pnlSubMenuAnualidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnlSubMenuAnualidades.Controls.Add(this.btnPerpetuas);
            this.pnlSubMenuAnualidades.Controls.Add(this.btnAnualidadesDiferidas);
            this.pnlSubMenuAnualidades.Controls.Add(this.btnAnualidadesAnticipadas);
            this.pnlSubMenuAnualidades.Controls.Add(this.btnAnualidadesVencidas);
            this.pnlSubMenuAnualidades.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuAnualidades.Location = new System.Drawing.Point(0, 275);
            this.pnlSubMenuAnualidades.Name = "pnlSubMenuAnualidades";
            this.pnlSubMenuAnualidades.Size = new System.Drawing.Size(183, 153);
            this.pnlSubMenuAnualidades.TabIndex = 4;
            // 
            // btnAnualidadesDiferidas
            // 
            this.btnAnualidadesDiferidas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnualidadesDiferidas.FlatAppearance.BorderSize = 0;
            this.btnAnualidadesDiferidas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(235)))), ((int)(((byte)(103)))));
            this.btnAnualidadesDiferidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnualidadesDiferidas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnualidadesDiferidas.ForeColor = System.Drawing.Color.LightGray;
            this.btnAnualidadesDiferidas.Location = new System.Drawing.Point(0, 80);
            this.btnAnualidadesDiferidas.Name = "btnAnualidadesDiferidas";
            this.btnAnualidadesDiferidas.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAnualidadesDiferidas.Size = new System.Drawing.Size(183, 40);
            this.btnAnualidadesDiferidas.TabIndex = 2;
            this.btnAnualidadesDiferidas.Text = "Diferidas";
            this.btnAnualidadesDiferidas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnualidadesDiferidas.UseVisualStyleBackColor = true;
            this.btnAnualidadesDiferidas.Click += new System.EventHandler(this.btnAnualidadesDiferidas_Click);
            // 
            // btnAnualidadesAnticipadas
            // 
            this.btnAnualidadesAnticipadas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnualidadesAnticipadas.FlatAppearance.BorderSize = 0;
            this.btnAnualidadesAnticipadas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(235)))), ((int)(((byte)(103)))));
            this.btnAnualidadesAnticipadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnualidadesAnticipadas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnualidadesAnticipadas.ForeColor = System.Drawing.Color.LightGray;
            this.btnAnualidadesAnticipadas.Location = new System.Drawing.Point(0, 40);
            this.btnAnualidadesAnticipadas.Name = "btnAnualidadesAnticipadas";
            this.btnAnualidadesAnticipadas.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAnualidadesAnticipadas.Size = new System.Drawing.Size(183, 40);
            this.btnAnualidadesAnticipadas.TabIndex = 1;
            this.btnAnualidadesAnticipadas.Text = "Anticipadas";
            this.btnAnualidadesAnticipadas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnualidadesAnticipadas.UseVisualStyleBackColor = true;
            this.btnAnualidadesAnticipadas.Click += new System.EventHandler(this.btnAnualidadesAnticipadas_Click);
            // 
            // btnAnualidadesVencidas
            // 
            this.btnAnualidadesVencidas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnualidadesVencidas.FlatAppearance.BorderSize = 0;
            this.btnAnualidadesVencidas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(235)))), ((int)(((byte)(103)))));
            this.btnAnualidadesVencidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnualidadesVencidas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnualidadesVencidas.ForeColor = System.Drawing.Color.LightGray;
            this.btnAnualidadesVencidas.Location = new System.Drawing.Point(0, 0);
            this.btnAnualidadesVencidas.Name = "btnAnualidadesVencidas";
            this.btnAnualidadesVencidas.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAnualidadesVencidas.Size = new System.Drawing.Size(183, 40);
            this.btnAnualidadesVencidas.TabIndex = 0;
            this.btnAnualidadesVencidas.Text = "Vencidas";
            this.btnAnualidadesVencidas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnualidadesVencidas.UseVisualStyleBackColor = true;
            this.btnAnualidadesVencidas.Click += new System.EventHandler(this.btnAnualidadesVencidas_Click);
            // 
            // btnAnualidades
            // 
            this.btnAnualidades.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnualidades.FlatAppearance.BorderSize = 0;
            this.btnAnualidades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(235)))), ((int)(((byte)(103)))));
            this.btnAnualidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnualidades.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnualidades.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAnualidades.Image = ((System.Drawing.Image)(resources.GetObject("btnAnualidades.Image")));
            this.btnAnualidades.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnualidades.Location = new System.Drawing.Point(0, 236);
            this.btnAnualidades.Name = "btnAnualidades";
            this.btnAnualidades.Padding = new System.Windows.Forms.Padding(10, 0, 35, 0);
            this.btnAnualidades.Size = new System.Drawing.Size(183, 39);
            this.btnAnualidades.TabIndex = 3;
            this.btnAnualidades.Text = "Anualidades";
            this.btnAnualidades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnualidades.UseVisualStyleBackColor = true;
            this.btnAnualidades.Click += new System.EventHandler(this.btnAnualidades_Click);
            // 
            // pnlSubMenuInteres
            // 
            this.pnlSubMenuInteres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnlSubMenuInteres.Controls.Add(this.button3);
            this.pnlSubMenuInteres.Controls.Add(this.btnInteresSimple);
            this.pnlSubMenuInteres.Controls.Add(this.btnInteres2);
            this.pnlSubMenuInteres.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuInteres.Location = new System.Drawing.Point(0, 109);
            this.pnlSubMenuInteres.Name = "pnlSubMenuInteres";
            this.pnlSubMenuInteres.Size = new System.Drawing.Size(183, 127);
            this.pnlSubMenuInteres.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(235)))), ((int)(((byte)(103)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.LightGray;
            this.button3.Location = new System.Drawing.Point(0, 80);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(183, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "Interes Compuesto";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnInteresSimple
            // 
            this.btnInteresSimple.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInteresSimple.FlatAppearance.BorderSize = 0;
            this.btnInteresSimple.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(235)))), ((int)(((byte)(103)))));
            this.btnInteresSimple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInteresSimple.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInteresSimple.ForeColor = System.Drawing.Color.LightGray;
            this.btnInteresSimple.Location = new System.Drawing.Point(0, 40);
            this.btnInteresSimple.Name = "btnInteresSimple";
            this.btnInteresSimple.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnInteresSimple.Size = new System.Drawing.Size(183, 40);
            this.btnInteresSimple.TabIndex = 1;
            this.btnInteresSimple.Text = "Interes Simple";
            this.btnInteresSimple.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInteresSimple.UseVisualStyleBackColor = true;
            this.btnInteresSimple.Click += new System.EventHandler(this.btnInteresSimple_Click);
            // 
            // btnInteres2
            // 
            this.btnInteres2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInteres2.FlatAppearance.BorderSize = 0;
            this.btnInteres2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(235)))), ((int)(((byte)(103)))));
            this.btnInteres2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInteres2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInteres2.ForeColor = System.Drawing.Color.LightGray;
            this.btnInteres2.Location = new System.Drawing.Point(0, 0);
            this.btnInteres2.Name = "btnInteres2";
            this.btnInteres2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnInteres2.Size = new System.Drawing.Size(183, 40);
            this.btnInteres2.TabIndex = 0;
            this.btnInteres2.Text = "Interes";
            this.btnInteres2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInteres2.UseVisualStyleBackColor = true;
            this.btnInteres2.Click += new System.EventHandler(this.btnInteres2_Click);
            // 
            // btnInteres
            // 
            this.btnInteres.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInteres.FlatAppearance.BorderSize = 0;
            this.btnInteres.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(235)))), ((int)(((byte)(103)))));
            this.btnInteres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInteres.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInteres.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInteres.Image = ((System.Drawing.Image)(resources.GetObject("btnInteres.Image")));
            this.btnInteres.Location = new System.Drawing.Point(0, 70);
            this.btnInteres.Name = "btnInteres";
            this.btnInteres.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnInteres.Size = new System.Drawing.Size(183, 39);
            this.btnInteres.TabIndex = 1;
            this.btnInteres.Text = "Interes";
            this.btnInteres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInteres.UseVisualStyleBackColor = true;
            this.btnInteres.Click += new System.EventHandler(this.btnInteres_Click);
            // 
            // btnPresentacion
            // 
            this.btnPresentacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPresentacion.Image = global::IngEconomica.Properties.Resources.pngwing1;
            this.btnPresentacion.Location = new System.Drawing.Point(0, 0);
            this.btnPresentacion.Name = "btnPresentacion";
            this.btnPresentacion.Size = new System.Drawing.Size(183, 70);
            this.btnPresentacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPresentacion.TabIndex = 0;
            this.btnPresentacion.TabStop = false;
            this.btnPresentacion.Click += new System.EventHandler(this.btnPresentacion_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(200, 38);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1100, 612);
            this.pnlContenedor.TabIndex = 2;
            this.pnlContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.btnInteresCompuesto_Paint);
            // 
            // btnPerpetuas
            // 
            this.btnPerpetuas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPerpetuas.FlatAppearance.BorderSize = 0;
            this.btnPerpetuas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(235)))), ((int)(((byte)(103)))));
            this.btnPerpetuas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerpetuas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerpetuas.ForeColor = System.Drawing.Color.LightGray;
            this.btnPerpetuas.Location = new System.Drawing.Point(0, 120);
            this.btnPerpetuas.Name = "btnPerpetuas";
            this.btnPerpetuas.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPerpetuas.Size = new System.Drawing.Size(183, 40);
            this.btnPerpetuas.TabIndex = 3;
            this.btnPerpetuas.Text = "Perpetuas";
            this.btnPerpetuas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerpetuas.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(235)))), ((int)(((byte)(103)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(0, 428);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 45, 0);
            this.button1.Size = new System.Drawing.Size(183, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Indicadores";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(235)))), ((int)(((byte)(103)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.LightGray;
            this.button6.Location = new System.Drawing.Point(0, 0);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(183, 40);
            this.button6.TabIndex = 0;
            this.button6.Text = "button1";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(235)))), ((int)(((byte)(103)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.LightGray;
            this.button5.Location = new System.Drawing.Point(0, 40);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(183, 40);
            this.button5.TabIndex = 1;
            this.button5.Text = "button2";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(235)))), ((int)(((byte)(103)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.LightGray;
            this.button4.Location = new System.Drawing.Point(0, 80);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(183, 40);
            this.button4.TabIndex = 2;
            this.button4.Text = "button3";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(235)))), ((int)(((byte)(103)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.LightGray;
            this.button2.Location = new System.Drawing.Point(0, 120);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(183, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "button4";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pnlSubMenuIndicadores
            // 
            this.pnlSubMenuIndicadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnlSubMenuIndicadores.Controls.Add(this.button2);
            this.pnlSubMenuIndicadores.Controls.Add(this.button4);
            this.pnlSubMenuIndicadores.Controls.Add(this.button5);
            this.pnlSubMenuIndicadores.Controls.Add(this.button6);
            this.pnlSubMenuIndicadores.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuIndicadores.Location = new System.Drawing.Point(0, 467);
            this.pnlSubMenuIndicadores.Name = "pnlSubMenuIndicadores";
            this.pnlSubMenuIndicadores.Size = new System.Drawing.Size(183, 164);
            this.pnlSubMenuIndicadores.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlSideMenu);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.pnlSideMenu.ResumeLayout(false);
            this.pnlSubMenuAnualidades.ResumeLayout(false);
            this.pnlSubMenuInteres.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnPresentacion)).EndInit();
            this.pnlSubMenuIndicadores.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Panel pnlSideMenu;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.PictureBox btnPresentacion;
        private System.Windows.Forms.Button btnInteres;
        private System.Windows.Forms.Panel pnlSubMenuInteres;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnInteresSimple;
        private System.Windows.Forms.Button btnInteres2;
        private System.Windows.Forms.Panel pnlSubMenuAnualidades;
        private System.Windows.Forms.Button btnAnualidadesDiferidas;
        private System.Windows.Forms.Button btnAnualidadesAnticipadas;
        private System.Windows.Forms.Button btnAnualidadesVencidas;
        private System.Windows.Forms.Button btnAnualidades;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPerpetuas;
        private System.Windows.Forms.Panel pnlSubMenuIndicadores;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

