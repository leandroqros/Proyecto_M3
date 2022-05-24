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

        public void rtbArchivo_TextChanged(object sender, EventArgs e)
        {
            
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
            List<string> elements = new List<string>();

            elements = GetElementName();

            for(int i = 0; i < elements.Count; i++)
            {
                cbPadre.Items.Add(elements[i]);
            }
            
            /*string linia;

            using (StreamReader sr = new StreamReader(nom_arxiu))
            {
                for (int i = 0; i < 10; i++)
                {
                    linia = sr.ReadLine();

                    cbPadre.Items.Add(linia);
                }
            }*/
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
            string linia, nombre;
            List<string> elements = new List<string>();

            nombre = "";
            linia = "";

            using (StreamReader sr = new StreamReader(nom_arxiu))
            {
                while(linia != null)
                {
                    nombre = "";

                    linia = sr.ReadLine();
                    
                    if (linia == "<Hosts>" || linia == "<Foods>" || linia == "<Refugees>" || linia == "<FoodsDelivered>")
                    {
                        nombre = linia;

                        nombre = replaceCaracter(nombre, '<', ' ');

                        nombre = replaceCaracter(nombre, '>', ' ');

                        nombre.Trim();

                        elements.Add(nombre);
                    }
                }
            }
            return elements;
        }
    }
}