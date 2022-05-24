
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
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btArchivo
            // 
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
            this.btBuscar.Location = new System.Drawing.Point(442, 159);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(112, 23);
            this.btBuscar.TabIndex = 2;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(442, 189);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(112, 23);
            this.btAgregar.TabIndex = 3;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            // 
            // cbPadre
            // 
            this.cbPadre.FormattingEnabled = true;
            this.cbPadre.Location = new System.Drawing.Point(123, 159);
            this.cbPadre.Name = "cbPadre";
            this.cbPadre.Size = new System.Drawing.Size(153, 21);
            this.cbPadre.TabIndex = 4;
            this.cbPadre.SelectedIndexChanged += new System.EventHandler(this.cbPadre_SelectedIndexChanged);
            // 
            // cbHijo
            // 
            this.cbHijo.FormattingEnabled = true;
            this.cbHijo.Location = new System.Drawing.Point(284, 159);
            this.cbHijo.Name = "cbHijo";
            this.cbHijo.Size = new System.Drawing.Size(153, 21);
            this.cbHijo.TabIndex = 5;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(120, 86);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(119, 16);
            this.lbTitulo.TabIndex = 6;
            this.lbTitulo.Text = "Solidarity At Home";
            // 
            // lbArchivo
            // 
            this.lbArchivo.AutoSize = true;
            this.lbArchivo.Location = new System.Drawing.Point(120, 134);
            this.lbArchivo.Name = "lbArchivo";
            this.lbArchivo.Size = new System.Drawing.Size(46, 13);
            this.lbArchivo.TabIndex = 7;
            this.lbArchivo.Text = "Archivo:";
            // 
            // txtArchivo
            // 
            this.txtArchivo.Enabled = false;
            this.txtArchivo.Location = new System.Drawing.Point(172, 132);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(265, 20);
            this.txtArchivo.TabIndex = 10;
            this.txtArchivo.TextChanged += new System.EventHandler(this.txtArchivo_TextChanged);
            // 
            // pbImagen
            // 
            this.pbImagen.Enabled = false;
            this.pbImagen.Image = ((System.Drawing.Image)(resources.GetObject("pbImagen.Image")));
            this.pbImagen.Location = new System.Drawing.Point(122, 11);
            this.pbImagen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(110, 73);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagen.TabIndex = 11;
            this.pbImagen.TabStop = false;
            this.pbImagen.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tbResultat
            // 
            this.tbResultat.Enabled = false;
            this.tbResultat.Location = new System.Drawing.Point(122, 218);
            this.tbResultat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbResultat.Multiline = true;
            this.tbResultat.Name = "tbResultat";
            this.tbResultat.Size = new System.Drawing.Size(432, 131);
            this.tbResultat.TabIndex = 12;
            this.tbResultat.TextChanged += new System.EventHandler(this.tbResultat_TextChanged);
            // 
            // formularioMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 373);
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
            this.Name = "formularioMain";
            this.Text = "Solidarity At Home - Subtropical";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
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
    }
}

