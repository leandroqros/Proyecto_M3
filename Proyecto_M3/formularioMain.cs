using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_M3
{
    public partial class formularioMain : Form
    {
        public formularioMain()
        {
            InitializeComponent();
        }

        private void btArchivo_Click(object sender, EventArgs e)
        {
            string ruta;
            using (OpenFileDialog ofdArchivo = new OpenFileDialog())
            {
                ofdArchivo.InitialDirectory = "C:\\";
                ofdArchivo.Filter = "xml files (*.xml)|*.xml";

                if (ofdArchivo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    MessageBox.Show("Archivo " + ofdArchivo.FileName + " abierto.");
                }
                ruta = ofdArchivo.FileName;
            }
            txtArchivo.Text = ruta;
        }

        public void rtbArchivo_TextChanged(object sender, EventArgs e)
        {
            //rtbArchivo.Text = ofdArchivo.Filename;
        }
    }
}
