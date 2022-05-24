
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
            this.btArchivo = new System.Windows.Forms.Button();
            this.btCargar = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.cbPadre = new System.Windows.Forms.ComboBox();
            this.cbHijo = new System.Windows.Forms.ComboBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbArchivo = new System.Windows.Forms.Label();
            this.rtbDocSalida = new System.Windows.Forms.RichTextBox();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btArchivo
            // 
            this.btArchivo.Location = new System.Drawing.Point(597, 133);
            this.btArchivo.Margin = new System.Windows.Forms.Padding(4);
            this.btArchivo.Name = "btArchivo";
            this.btArchivo.Size = new System.Drawing.Size(61, 28);
            this.btArchivo.TabIndex = 0;
            this.btArchivo.Text = "...";
            this.btArchivo.UseVisualStyleBackColor = true;
            this.btArchivo.Click += new System.EventHandler(this.btArchivo_Click);
            // 
            // btCargar
            // 
            this.btCargar.Location = new System.Drawing.Point(667, 133);
            this.btCargar.Margin = new System.Windows.Forms.Padding(4);
            this.btCargar.Name = "btCargar";
            this.btCargar.Size = new System.Drawing.Size(139, 28);
            this.btCargar.TabIndex = 1;
            this.btCargar.Text = "Cargar";
            this.btCargar.UseVisualStyleBackColor = true;
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(597, 170);
            this.btBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(208, 28);
            this.btBuscar.TabIndex = 2;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(597, 207);
            this.btAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(208, 28);
            this.btAgregar.TabIndex = 3;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            // 
            // cbPadre
            // 
            this.cbPadre.FormattingEnabled = true;
            this.cbPadre.Location = new System.Drawing.Point(231, 172);
            this.cbPadre.Margin = new System.Windows.Forms.Padding(4);
            this.cbPadre.Name = "cbPadre";
            this.cbPadre.Size = new System.Drawing.Size(160, 24);
            this.cbPadre.TabIndex = 4;
            // 
            // cbHijo
            // 
            this.cbHijo.FormattingEnabled = true;
            this.cbHijo.Location = new System.Drawing.Point(411, 172);
            this.cbHijo.Margin = new System.Windows.Forms.Padding(4);
            this.cbHijo.Name = "cbHijo";
            this.cbHijo.Size = new System.Drawing.Size(160, 24);
            this.cbHijo.TabIndex = 5;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(233, 79);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(149, 20);
            this.lbTitulo.TabIndex = 6;
            this.lbTitulo.Text = "Solidarity At Home";
            // 
            // lbArchivo
            // 
            this.lbArchivo.AutoSize = true;
            this.lbArchivo.Location = new System.Drawing.Point(227, 139);
            this.lbArchivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbArchivo.Name = "lbArchivo";
            this.lbArchivo.Size = new System.Drawing.Size(59, 17);
            this.lbArchivo.TabIndex = 7;
            this.lbArchivo.Text = "Archivo:";
            // 
            // rtbDocSalida
            // 
            this.rtbDocSalida.Location = new System.Drawing.Point(231, 265);
            this.rtbDocSalida.Margin = new System.Windows.Forms.Padding(4);
            this.rtbDocSalida.Name = "rtbDocSalida";
            this.rtbDocSalida.Size = new System.Drawing.Size(573, 160);
            this.rtbDocSalida.TabIndex = 9;
            this.rtbDocSalida.Text = "";
            // 
            // txtArchivo
            // 
            this.txtArchivo.Enabled = false;
            this.txtArchivo.Location = new System.Drawing.Point(296, 137);
            this.txtArchivo.Margin = new System.Windows.Forms.Padding(4);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(275, 22);
            this.txtArchivo.TabIndex = 10;
            this.txtArchivo.TextChanged += new System.EventHandler(this.txtArchivo_TextChanged);
            // 
            // formularioMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtArchivo);
            this.Controls.Add(this.rtbDocSalida);
            this.Controls.Add(this.lbArchivo);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.cbHijo);
            this.Controls.Add(this.cbPadre);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.btCargar);
            this.Controls.Add(this.btArchivo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formularioMain";
            this.Text = "Solidarity At Home - Subtropical";
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
        private System.Windows.Forms.RichTextBox rtbDocSalida;
        private System.Windows.Forms.TextBox txtArchivo;
    }
}

