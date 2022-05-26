
namespace Proyecto_M3
{
    partial class formularioMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formularioMain));
            this.btArchivo = new System.Windows.Forms.Button();
            this.btCargar = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.cbPadre = new System.Windows.Forms.ComboBox();
            this.cbHijo = new System.Windows.Forms.ComboBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbArchivo = new System.Windows.Forms.Label();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.tbResultat = new System.Windows.Forms.TextBox();
            this.lbElementos = new System.Windows.Forms.Label();
            this.lbDatos = new System.Windows.Forms.Label();
            this.menuInformes = new System.Windows.Forms.MenuStrip();
            this.informesM04ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informe1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informe2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informe3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombre_grupo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.menuInformes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btArchivo
            // 
            this.btArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btArchivo.Location = new System.Drawing.Point(442, 129);
            this.btArchivo.Name = "btArchivo";
            this.btArchivo.Size = new System.Drawing.Size(34, 23);
            this.btArchivo.TabIndex = 0;
            this.btArchivo.Text = "...";
            this.btArchivo.UseVisualStyleBackColor = true;
            this.btArchivo.Click += new System.EventHandler(this.btArchivo_Click);
            // 
            // btCargar
            // 
            this.btCargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCargar.Location = new System.Drawing.Point(482, 129);
            this.btCargar.Name = "btCargar";
            this.btCargar.Size = new System.Drawing.Size(71, 23);
            this.btCargar.TabIndex = 1;
            this.btCargar.Text = "Cargar";
            this.btCargar.UseVisualStyleBackColor = true;
            this.btCargar.Click += new System.EventHandler(this.btCargar_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btBuscar.Location = new System.Drawing.Point(442, 159);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(112, 23);
            this.btBuscar.TabIndex = 2;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAgregar.Location = new System.Drawing.Point(442, 189);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(112, 23);
            this.btAgregar.TabIndex = 3;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // cbPadre
            // 
            this.cbPadre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPadre.FormattingEnabled = true;
            this.cbPadre.Location = new System.Drawing.Point(122, 193);
            this.cbPadre.Name = "cbPadre";
            this.cbPadre.Size = new System.Drawing.Size(153, 21);
            this.cbPadre.Sorted = true;
            this.cbPadre.TabIndex = 4;
            this.cbPadre.SelectedIndexChanged += new System.EventHandler(this.cbPadre_SelectedIndexChanged);
            // 
            // cbHijo
            // 
            this.cbHijo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbHijo.FormattingEnabled = true;
            this.cbHijo.Location = new System.Drawing.Point(284, 193);
            this.cbHijo.Name = "cbHijo";
            this.cbHijo.Size = new System.Drawing.Size(153, 21);
            this.cbHijo.Sorted = true;
            this.cbHijo.TabIndex = 5;
            this.cbHijo.SelectedIndexChanged += new System.EventHandler(this.cbHijo_SelectedIndexChanged_1);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(118, 86);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(137, 16);
            this.lbTitulo.TabIndex = 6;
            this.lbTitulo.Text = "Solidarity At Home";
            // 
            // lbArchivo
            // 
            this.lbArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbArchivo.AutoSize = true;
            this.lbArchivo.BackColor = System.Drawing.Color.Transparent;
            this.lbArchivo.Location = new System.Drawing.Point(120, 134);
            this.lbArchivo.Name = "lbArchivo";
            this.lbArchivo.Size = new System.Drawing.Size(46, 13);
            this.lbArchivo.TabIndex = 7;
            this.lbArchivo.Text = "Archivo:";
            // 
            // txtArchivo
            // 
            this.txtArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArchivo.Enabled = false;
            this.txtArchivo.Location = new System.Drawing.Point(172, 132);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(265, 20);
            this.txtArchivo.TabIndex = 10;
            this.txtArchivo.TextChanged += new System.EventHandler(this.txtArchivo_TextChanged);
            // 
            // pbImagen
            // 
            this.pbImagen.BackColor = System.Drawing.Color.Transparent;
            this.pbImagen.Enabled = false;
            this.pbImagen.Image = ((System.Drawing.Image)(resources.GetObject("pbImagen.Image")));
            this.pbImagen.Location = new System.Drawing.Point(122, 11);
            this.pbImagen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(124, 73);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagen.TabIndex = 11;
            this.pbImagen.TabStop = false;
            this.pbImagen.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tbResultat
            // 
            this.tbResultat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbResultat.Location = new System.Drawing.Point(122, 218);
            this.tbResultat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbResultat.Multiline = true;
            this.tbResultat.Name = "tbResultat";
            this.tbResultat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbResultat.Size = new System.Drawing.Size(432, 131);
            this.tbResultat.TabIndex = 12;
            this.tbResultat.TextChanged += new System.EventHandler(this.tbResultat_TextChanged);
            // 
            // lbElementos
            // 
            this.lbElementos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbElementos.AutoSize = true;
            this.lbElementos.BackColor = System.Drawing.Color.Transparent;
            this.lbElementos.Location = new System.Drawing.Point(120, 176);
            this.lbElementos.Name = "lbElementos";
            this.lbElementos.Size = new System.Drawing.Size(59, 13);
            this.lbElementos.TabIndex = 13;
            this.lbElementos.Text = "Elementos:";
            this.lbElementos.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbDatos
            // 
            this.lbDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDatos.AutoSize = true;
            this.lbDatos.BackColor = System.Drawing.Color.Transparent;
            this.lbDatos.Location = new System.Drawing.Point(281, 176);
            this.lbDatos.Name = "lbDatos";
            this.lbDatos.Size = new System.Drawing.Size(38, 13);
            this.lbDatos.TabIndex = 14;
            this.lbDatos.Text = "Datos:";
            // 
            // menuInformes
            // 
            this.menuInformes.BackColor = System.Drawing.SystemColors.Control;
            this.menuInformes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuInformes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informesM04ToolStripMenuItem});
            this.menuInformes.Location = new System.Drawing.Point(0, 0);
            this.menuInformes.Name = "menuInformes";
            this.menuInformes.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuInformes.Size = new System.Drawing.Size(676, 24);
            this.menuInformes.TabIndex = 15;
            this.menuInformes.Text = "menuInformes";
            // 
            // informesM04ToolStripMenuItem
            // 
            this.informesM04ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informe1ToolStripMenuItem,
            this.informe2ToolStripMenuItem,
            this.informe3ToolStripMenuItem});
            this.informesM04ToolStripMenuItem.Name = "informesM04ToolStripMenuItem";
            this.informesM04ToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.informesM04ToolStripMenuItem.Text = "Informes - M04";
            this.informesM04ToolStripMenuItem.Click += new System.EventHandler(this.informesM04ToolStripMenuItem_Click);
            // 
            // informe1ToolStripMenuItem
            // 
            this.informe1ToolStripMenuItem.Name = "informe1ToolStripMenuItem";
            this.informe1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.informe1ToolStripMenuItem.Text = "Informe 1";
            this.informe1ToolStripMenuItem.Click += new System.EventHandler(this.informe1ToolStripMenuItem_Click);
            // 
            // informe2ToolStripMenuItem
            // 
            this.informe2ToolStripMenuItem.Name = "informe2ToolStripMenuItem";
            this.informe2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.informe2ToolStripMenuItem.Text = "Informe 2";
            this.informe2ToolStripMenuItem.Click += new System.EventHandler(this.informe2ToolStripMenuItem_Click);
            // 
            // informe3ToolStripMenuItem
            // 
            this.informe3ToolStripMenuItem.Name = "informe3ToolStripMenuItem";
            this.informe3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.informe3ToolStripMenuItem.Text = "Informe 3";
            // 
            // nombre_grupo
            // 
            this.nombre_grupo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nombre_grupo.AutoSize = true;
            this.nombre_grupo.BackColor = System.Drawing.Color.Transparent;
            this.nombre_grupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_grupo.Location = new System.Drawing.Point(513, 0);
            this.nombre_grupo.Name = "nombre_grupo";
            this.nombre_grupo.Size = new System.Drawing.Size(160, 16);
            this.nombre_grupo.TabIndex = 16;
            this.nombre_grupo.Text = "SubTropical - Grupo 8";
            this.nombre_grupo.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // formularioMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 373);
            this.Controls.Add(this.nombre_grupo);
            this.Controls.Add(this.lbDatos);
            this.Controls.Add(this.lbElementos);
            this.Controls.Add(this.tbResultat);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.txtArchivo);
            this.Controls.Add(this.lbArchivo);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.cbHijo);
            this.Controls.Add(this.cbPadre);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.btCargar);
            this.Controls.Add(this.btArchivo);
            this.Controls.Add(this.menuInformes);
            this.Name = "formularioMain";
            this.Text = "Solidarity At Home - Subtropical";
            this.Load += new System.EventHandler(this.formularioMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.menuInformes.ResumeLayout(false);
            this.menuInformes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btArchivo;
        private System.Windows.Forms.Button btCargar;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.ComboBox cbPadre;
        private System.Windows.Forms.ComboBox cbHijo;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbArchivo;
        private System.Windows.Forms.TextBox txtArchivo;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.TextBox tbResultat;
        private System.Windows.Forms.Label lbElementos;
        private System.Windows.Forms.Label lbDatos;
        private System.Windows.Forms.MenuStrip menuInformes;
        private System.Windows.Forms.ToolStripMenuItem informesM04ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informe1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informe2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informe3ToolStripMenuItem;
        private System.Windows.Forms.Label nombre_grupo;
    }
}

