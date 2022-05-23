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

        public void btArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdArchivo = new OpenFileDialog();
            if (ofdArchivo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("Archivo " + ofdArchivo + " abierto.");
            }
        }

        public void rtbArchivo_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
