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
        List<string> categorias = new List<string>();
        List<string> FullName_Hosts = new List<string>();
        List<string> DescFood_Foods = new List<string>();
        List<string> FullName_Refugees = new List<string>();
        List<string> DeliveryNote_FoodsDelivered = new List<string>();
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
                } else
                {
                    MessageBox.Show("Archivo no encontrado.");
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
            string elementName, elementData;
            string linia;
            bool guardarFullName_Hosts, guardarFullName_Refugees, guardarDescFood_Foods;

            linia = "  ";
            elementName = "";
            guardarFullName_Hosts = false;
            guardarFullName_Refugees = false;
            guardarDescFood_Foods = false;

            using (StreamReader sr = new StreamReader(nom_arxiu))
            {
                while(linia != "</SolidarityAtHome>")
                {
                    if(linia[0] != ' ' && linia[1] != '/')
                    {
                        categorias.Add(elementName);
                    }

                    if(elementName == "Host")
                    {
                        guardarFullName_Hosts = true;
                    }

                    if(guardarFullName_Hosts && elementName == "FullName")
                    {
                        elementData = GetElementData(linia);
                        FullName_Hosts.Add(elementData);
                        guardarFullName_Hosts = false;
                    }

                    if(elementName == "/Foods" && guardarDescFood_Foods)
                    {
                        guardarDescFood_Foods = false;
                    }

                    if(elementName == "Foods")
                    {
                        guardarDescFood_Foods = true;
                    }

                    if(guardarDescFood_Foods && elementName == "DescFood")
                    {
                        elementData = GetElementData(linia);
                        DescFood_Foods.Add(elementData);
                    
                    }

                    if(elementName == "Refugee")
                    {
                        guardarFullName_Refugees = true;
                    }

                    if(guardarFullName_Refugees && elementName == "FullName")
                    {
                        elementData = GetElementData(linia);
                        FullName_Refugees.Add(elementData);
                        guardarFullName_Refugees = false;
                    }

                    if(elementName == "DeliveryNote")
                    {
                        elementData = GetElementData(linia);
                        DeliveryNote_FoodsDelivered.Add(elementData);
                    }

                    linia = sr.ReadLine();

                    elementName = GetElementName(linia);
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

            switch (cbPadre.Text)
            {
                case "Hosts":
                    for (int i = 0; i < FullName_Hosts.Count; i++)
                    {
                        cbHijo.Items.Add(FullName_Hosts[i]);
                    }
                    break;

                case "Foods":
                    for (int i = 0; i < DescFood_Foods.Count; i++)
                    {
                        cbHijo.Items.Add(DescFood_Foods[i]);
                    }
                    break;

                case "Refugees":
                    for (int i = 0; i < FullName_Refugees.Count; i++)
                    {
                        cbHijo.Items.Add(FullName_Refugees[i]);
                    }
                    break;

                case "FoodsDelivered":
                    for (int i = 0; i < DeliveryNote_FoodsDelivered.Count; i++)
                    {
                        cbHijo.Items.Add(DeliveryNote_FoodsDelivered[i]);
                    }
                    break;
            }
        }

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

        private void cbHijo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}