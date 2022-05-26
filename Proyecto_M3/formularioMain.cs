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
        bool hay_archivo;

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
                    hay_archivo = true;
                }
                else
                {
                    MessageBox.Show("Archivo no encontrado.");
                    hay_archivo = false;
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
            cbPadre.Items.Clear();
            string elementName, elementData;
            string linia;
            bool guardarFullName_Hosts, guardarFullName_Refugees, guardarDescFood_Foods;

            linia = "  ";
            elementName = "";
            guardarFullName_Hosts = false;
            guardarFullName_Refugees = false;
            guardarDescFood_Foods = false;
            if (hay_archivo == true)
            {
                using (StreamReader sr = new StreamReader(nom_arxiu))
                {
                    if (categorias.Count <= cbPadre.Items.Count)
                    {

                        while (linia != "</SolidarityAtHome>")
                        {

                            if (linia[0] != ' ' && linia[1] != '/')
                            {
                                categorias.Add(elementName);
                            }

                            if (elementName == "Host")
                            {
                                guardarFullName_Hosts = true;
                            }

                            if (guardarFullName_Hosts && elementName == "FullName")
                            {
                                elementData = GetElementData(linia);
                                FullName_Hosts.Add(elementData);
                                guardarFullName_Hosts = false;
                            }

                            if (elementName == "/Foods" && guardarDescFood_Foods)
                            {
                                guardarDescFood_Foods = false;
                            }

                            if (elementName == "Foods")
                            {
                                guardarDescFood_Foods = true;
                            }

                            if (guardarDescFood_Foods && elementName == "DescFood")
                            {
                                elementData = GetElementData(linia);
                                DescFood_Foods.Add(elementData);

                            }

                            if (elementName == "Refugees")
                            {
                                guardarFullName_Refugees = true;
                            }

                            if (guardarFullName_Refugees && elementName == "FullName")
                            {
                                elementData = GetElementData(linia);
                                FullName_Refugees.Add(elementData);
                                
                            }

                            if (elementName == "/Refugees" && guardarFullName_Refugees)
                            {
                                guardarFullName_Refugees = false;
                            }

                            if (elementName == "DeliveryNote")
                            {
                                elementData = GetElementData(linia);
                                DeliveryNote_FoodsDelivered.Add(elementData);
                            }

                            linia = sr.ReadLine();

                            elementName = GetElementName(linia);
                        }
                    }
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
            cbHijo.Items.Clear();
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

            while (caracter != '>')
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

                if (caracter == '<' && data)
                {
                    final = false;
                    data = false;
                }

                if (caracter == '>')
                {
                    data = true;
                }

                if (data && caracter != '>')
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

        private void btBuscar_Click(object sender, EventArgs e)
        {
            string SEPARADOR = "----------------------------------";

            string elementName, elementData, linia, deliveryNote_actual, deliveryDate_actual, hostName_actual, price_actual, hostName_refugee;
            bool foodsDelivered_okey, foodDelivered_okey, hosts_okey;

            linia = "  ";
            elementName = "";
            foodsDelivered_okey = false;
            foodDelivered_okey = false;
            hosts_okey = false;
            hostName_refugee = "";

            if (hay_archivo)
            {
                using (StreamReader sr = new StreamReader(nom_arxiu))
                {
                    using (FileStream fs = new FileStream("dades.txt", FileMode.Create, FileAccess.ReadWrite))
                    {
                        fs.Seek(0, SeekOrigin.End);

                        StreamWriter sw = new StreamWriter(fs);

                        tbResultat.Clear();
                        tbResultat.AppendText("START SEARCH" + "\r\n");
                        sw.WriteLine("START SEARCH");
                        sw.WriteLine(SEPARADOR);
                        sw.WriteLine("CATEGORIA: " + cbPadre.Text);
                        sw.WriteLine("ELEMENT: " + cbHijo.Text);
                        switch (cbPadre.Text)
                        {
                            case "Hosts":

                                while (linia != "<FoodsDelivered>")
                                {
                                    linia = sr.ReadLine();
                                }

                                foodsDelivered_okey = true;

                                while (foodsDelivered_okey)
                                {
                                    linia = sr.ReadLine();
                                    elementName = GetElementName(linia);

                                    if (elementName == "FoodDelivered")
                                    {

                                        linia = sr.ReadLine();

                                        deliveryNote_actual = GetElementData(linia);

                                        linia = sr.ReadLine();

                                        deliveryDate_actual = GetElementData(linia);

                                        linia = sr.ReadLine();

                                        hostName_actual = GetElementData(linia);

                                        linia = sr.ReadLine();

                                        price_actual = GetElementData(linia);

                                        if (cbHijo.Text == hostName_actual)
                                        {

                                            tbResultat.AppendText(SEPARADOR + "\r\n");
                                            sw.WriteLine(SEPARADOR);
                                            tbResultat.AppendText("DELIVERY NOTE: " + deliveryNote_actual + "\r\n");
                                            sw.WriteLine("DELIVERY NOTE: " + deliveryNote_actual);
                                            tbResultat.AppendText("DELIVERY DATE: " + deliveryDate_actual + "\r\n");
                                            sw.WriteLine("DELIVERY DATE: " + deliveryDate_actual);
                                            tbResultat.AppendText("TOTAL COST: " + price_actual + "\r\n");
                                            sw.WriteLine("TOTAL COST: " + price_actual);
                                            tbResultat.AppendText(SEPARADOR + "\r\n");
                                            sw.WriteLine(SEPARADOR);
                                        }

                                    }
                                    if (linia == "</FoodsDelivered>")
                                    {
                                        foodsDelivered_okey = false;
                                    }

                                }

                                break;

                            case "Foods":

                                while (linia != "<FoodsDelivered>")
                                {
                                    linia = sr.ReadLine();
                                }

                                foodsDelivered_okey = true;

                                while (foodsDelivered_okey)
                                {
                                    linia = sr.ReadLine();
                                    elementName = GetElementName(linia);

                                    if (elementName == "FoodDelivered")
                                    {
                                        foodDelivered_okey = true;

                                        linia = sr.ReadLine();

                                        deliveryNote_actual = GetElementData(linia);

                                        linia = sr.ReadLine();

                                        deliveryDate_actual = GetElementData(linia);

                                        linia = sr.ReadLine();
                                        linia = sr.ReadLine();

                                        price_actual = GetElementData(linia);

                                        while (foodDelivered_okey)
                                        {
                                            linia = sr.ReadLine();

                                            elementName = GetElementName(linia);


                                            if (elementName == "DescFood")
                                            {
                                                elementData = GetElementData(linia);
                                                if (elementData == cbHijo.Text)
                                                {
                                                    tbResultat.AppendText(SEPARADOR + "\r\n");
                                                    tbResultat.AppendText("DELIVERY NOTE: " + deliveryNote_actual + "\r\n");
                                                    tbResultat.AppendText("DELIVERY DATE: " + deliveryDate_actual + "\r\n");
                                                    tbResultat.AppendText("TOTAL COST: " + price_actual + "\r\n");
                                                    tbResultat.AppendText(SEPARADOR + "\r\n");

                                                    foodDelivered_okey = false;
                                                }
                                            }
                                            if (GetElementName(linia) == "/Items")
                                            {
                                                foodDelivered_okey = false;
                                            }
                                        }
                                    }
                                    if (linia == "</FoodsDelivered>")
                                    {
                                        foodsDelivered_okey = false;
                                    }
                                }


                                break;

                            case "Refugees":

                                while (linia != "<Hosts>")
                                {
                                    linia = sr.ReadLine();
                                }

                                hosts_okey = true;

                                while (hosts_okey)
                                {
                                    linia = sr.ReadLine();
                                    elementName = GetElementName(linia);

                                    if (elementName == "Host")
                                    {
                                        linia = sr.ReadLine();

                                        hostName_actual = GetElementData(linia);

                                        elementName = GetElementName(linia);

                                        while (elementName != "/Host")
                                        {

                                            if (elementName == "FullName")
                                            {
                                                elementData = GetElementData(linia);
                                                if (elementData == cbHijo.Text)
                                                {
                                                    hostName_refugee = hostName_actual;
                                                    hosts_okey = false;
                                                }
                                            }

                                            linia = sr.ReadLine();
                                            elementName = GetElementName(linia);
                                        }
                                    }
                                    if (elementName == "/Hosts")
                                    {
                                        hosts_okey = false;
                                    }
                                }

                                while (linia != "<FoodsDelivered>")
                                {
                                    linia = sr.ReadLine();
                                }

                                foodsDelivered_okey = true;

                                while (foodsDelivered_okey)
                                {
                                    linia = sr.ReadLine();
                                    elementName = GetElementName(linia);

                                    if (elementName == "FoodDelivered")
                                    {

                                        linia = sr.ReadLine();

                                        deliveryNote_actual = GetElementData(linia);

                                        linia = sr.ReadLine();

                                        deliveryDate_actual = GetElementData(linia);

                                        linia = sr.ReadLine();

                                        hostName_actual = GetElementData(linia);

                                        linia = sr.ReadLine();

                                        price_actual = GetElementData(linia);

                                        if (hostName_actual == hostName_refugee)
                                        {
                                            tbResultat.AppendText(SEPARADOR + "\r\n");
                                            tbResultat.AppendText("DELIVERY NOTE: " + deliveryNote_actual + "\r\n");
                                            tbResultat.AppendText("DELIVERY DATE: " + deliveryDate_actual + "\r\n");
                                            tbResultat.AppendText("TOTAL COST: " + price_actual + "\r\n");
                                            tbResultat.AppendText(SEPARADOR + "\r\n");
                                        }
                                    }
                                    if (linia == "</FoodsDelivered>")
                                    {
                                        foodsDelivered_okey = false;
                                    }
                                }

                                break;

                            case "FoodsDelivered":

                                while (linia != "<FoodsDelivered>")
                                {
                                    linia = sr.ReadLine();
                                }

                                foodsDelivered_okey = true;

                                while (foodsDelivered_okey)
                                {
                                    linia = sr.ReadLine();
                                    elementName = GetElementName(linia);

                                    if (elementName == "FoodDelivered")
                                    {

                                        linia = sr.ReadLine();

                                        deliveryNote_actual = GetElementData(linia);

                                        linia = sr.ReadLine();

                                        deliveryDate_actual = GetElementData(linia);

                                        linia = sr.ReadLine();
                                        linia = sr.ReadLine();

                                        price_actual = GetElementData(linia);

                                        if (cbHijo.Text == deliveryNote_actual)
                                        {
                                            tbResultat.AppendText(SEPARADOR + "\r\n");
                                            tbResultat.AppendText("DELIVERY NOTE: " + deliveryNote_actual + "\r\n");
                                            tbResultat.AppendText("DELIVERY DATE: " + deliveryDate_actual + "\r\n");
                                            tbResultat.AppendText("TOTAL COST: " + price_actual + "\r\n");
                                            tbResultat.AppendText(SEPARADOR + "\r\n");
                                        }
                                    }
                                    if (linia == "</FoodsDelivered>")
                                    {
                                        foodsDelivered_okey = false;
                                    }

                                }

                                break;
                        }
                        tbResultat.AppendText("END SEARCH" + "\r\n");
                        sw.WriteLine("END SEARCH");
                        tbResultat.AppendText(SEPARADOR + "\r\n");
                        sw.WriteLine(SEPARADOR);

                        sr.Close();
                        sw.Close();
                    }
                }
                
            }
        }

        private void formularioMain_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void informe1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*CrystalReport1 crystalReport1 = new CrystalReport1();

            CrystalReport1.ReportSource = crystalReport1;*/
            formulario_Informe1 informe1 = new formulario_Informe1();

            informe1.Show();
        }

        private void informesM04ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void cbHijo_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            tbResultat.Clear();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}