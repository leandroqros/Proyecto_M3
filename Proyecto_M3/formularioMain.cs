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
            List<string> categorias = new List<string>();
            string elementName;
            string linia;

            linia = "  ";

            using (StreamReader sr = new StreamReader(nom_arxiu))
            {
                while(linia != null)
                {
                    if(linia[0] != ' ' && linia[1] != '/')
                    {
                        elementName = GetElementName(linia);

                        categorias.Add(elementName);
                    }

                    linia = sr.ReadLine();
                }   
            }

            categorias.Remove("SolidarityAtHome");

            for (int i = 0; i < categorias.Count; i++)
            {
                cbPadre.Items.Add(categorias[i]);
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

        /*private List<string> GetElementName()
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
        }*/

        private string GetElementName(string linia)
        {
            int comptador;
            char caracter;
            string elementName;

            comptador = 0;
            elementName = "";
            caracter = ' ';

            linia = linia.Trim();

            while(caracter != '>')
            {
                caracter = linia[comptador];

                if (caracter != '<' && caracter != '>')
                {
                    elementName += caracter;
                }

                comptador++;
            }

            return elementName;
        }

        private string GetElementData(string linia)
        {
            bool data, final;
            int comptador;
            char caracter;
            string elementData;

            data = false;
            final = true;
            comptador = 0;
            caracter = ' ';
            elementData = "";

            linia = linia.Trim();

            while (final)
            {
                caracter = linia[comptador];

                if(caracter == '<' && data)
                {
                    final = false;
                    data = false;
                }

                if(caracter == '>')
                {
                    data = true;
                }

                if(data && caracter != '>')
                {
                    elementData += caracter;
                }

                comptador++;
            }

            return elementData;
        }
    }
}