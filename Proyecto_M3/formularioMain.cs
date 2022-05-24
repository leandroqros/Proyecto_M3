using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_M3
{
    public partial class formularioMain : Form
    {
        string nom_arxiu;

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
                    /*MessageBox.Show("Archivo " + ofdArchivo.FileName + " abierto.");*/
                }
                ruta = ofdArchivo.FileName;
            }
            txtArchivo.Text = ruta;

            nom_arxiu = ruta;
        }

        private void txtArchivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tbResultat_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCargar_Click(object sender, EventArgs e)
        {
            List<string> elementos = new List<string>();

            /*string linia;

            using (StreamReader sr = new StreamReader(nom_arxiu))
            {
                linia = sr.ReadLine();

            }*/

            elementos = GetElementName();
            
            for (int i = 0; i < elementos.Count; i++)
            {
                cbPadre.Items.Add(elementos[i]);
            }
        }

        private void cbPadre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public string replaceCaracter(string paraula, char original, char fi)
        {
            string bonaparaula;
            int longitud, i;
            char caracter;

            longitud = paraula.Length;

            bonaparaula = "";
            for (i = 0; i < longitud; i++)
            {
                caracter = paraula[i];

                if (caracter != original)
                {
                    bonaparaula += caracter;
                }
                else
                {
                    bonaparaula += fi;
                }
            }

            return bonaparaula;
        }

        private List<string> GetElementName()
        {
            List<string> elementos = new List<string>();

            using (StreamReader sr = new StreamReader(nom_arxiu))
            {
                string linia;
                char first, second;

                linia = "  ";
                first = ' ';
                second = ' ';

                while (linia != null)
                {
                    first = linia[0];
                    second = linia[1];

                    if (first == '<' && second != '/')
                    {
                        linia = replaceCaracter(linia, '<', ' ');
                        linia = replaceCaracter(linia, '>', ' ');
                        linia = linia.Trim();
                        elementos.Add(linia);
                    }
                    linia = sr.ReadLine();
                }

                elementos.Remove("SolidarityAtHome");

                return elementos;
            }
        }
    }
}