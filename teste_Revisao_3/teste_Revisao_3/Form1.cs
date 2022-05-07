using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace teste_Revisao_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Fich = "musicas.xml";

            XmlDocument FicheiroXML = new XmlDocument();
            string a = textBox1.Text;
            FicheiroXML.Load(Fich);
            foreach (XmlNode no in FicheiroXML.SelectNodes("//musica"))
            {
                if (a.Equals(no.Attributes[0].Value) == true)
                {
                    XmlNode t = FicheiroXML.SelectSingleNode("musicas/musica[@nome='" + a + "']");
                    t.ParentNode.RemoveChild(t);
                    FicheiroXML.Save(Fich);
                }


            }
            ler();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                string n1 = Convert.ToString(selectedRow.Cells["Música"].Value);
                string n2 = Convert.ToString(selectedRow.Cells["Autor"].Value);
                string n3 = Convert.ToString(selectedRow.Cells["Estilo"].Value);
                string n4 = Convert.ToString(selectedRow.Cells["Link"].Value);
                textBox1.Text = n1;
                textBox2.Text = n2;
                textBox3.Text = n3;
                textBox4.Text = n4;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string Fich = "musicas.xml";
            dataGridView1.AllowUserToAddRows = false;
            if (File.Exists(Fich) == false)
            {
                XmlTextWriter FicheiroXml = new XmlTextWriter(Fich, System.Text.Encoding.UTF8);
                FicheiroXml.WriteStartDocument(true);
                FicheiroXml.Formatting = Formatting.Indented;
                FicheiroXml.Indentation = 2;
                FicheiroXml.WriteStartElement("musicas");
                FicheiroXml.WriteEndDocument();
                FicheiroXml.Close();

            }
            ler();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string Fich = "musicas.xml";
            if (textBox1.Text!="" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "") { 
            XmlDocument Ficheiroxml = new XmlDocument();
            Ficheiroxml.Load(Fich);
                string a = textBox1.Text;
                int i = 0;
                foreach (XmlNode no in Ficheiroxml.SelectNodes("//musica"))
                {
                    if (a.Equals(no.Attributes[0].Value) == true)
                    {
                        i = 1;
                        break;
                    }
                }
                if (i == 1)
                {
                    MessageBox.Show("Musica com o nome igual");
                }
                else
                {
            XmlElement musica = Ficheiroxml.CreateElement("musica");
            XmlAttribute nome = Ficheiroxml.CreateAttribute("nome");
            XmlAttribute  autor = Ficheiroxml.CreateAttribute("autor");
            XmlAttribute estilo = Ficheiroxml.CreateAttribute("estilo");
            XmlAttribute link = Ficheiroxml.CreateAttribute("link");
            nome.InnerText = textBox1.Text;
            autor.InnerText = textBox2.Text;
            estilo.InnerText = textBox3.Text;
            link.InnerText = textBox4.Text;
            musica.Attributes.Append(nome);
            musica.Attributes.Append(autor);
            musica.Attributes.Append(estilo);
            musica.Attributes.Append(link);
            Ficheiroxml.DocumentElement.AppendChild(musica);
            Ficheiroxml.Save(Fich);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                }
                
            }
            ler();
          
        }
        void ler()
        {
            string Fich = "musicas.xml";
            if (File.Exists(Fich) == true)
            {

                XmlDocument FicheiroXML = new XmlDocument();

                FicheiroXML.Load(Fich);
                dataGridView1.Rows.Clear();
                foreach (XmlNode no in FicheiroXML.SelectNodes("//musica"))
                {
                    dataGridView1.Rows.Add(no.Attributes[0].Value,
                   no.Attributes[1].Value, no.Attributes[2].Value, no.Attributes[3].Value);
                }
            }
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") {
            string Fich = "musicas.xml";
            this.dataGridView1.Rows.Clear();
            XmlDocument FicheiroXML = new XmlDocument();
            string a = textBox1.Text;
            FicheiroXML.Load(Fich);
            foreach (XmlNode no in FicheiroXML.SelectNodes("//musica"))
            {
                if (a.Equals(no.Attributes[0].Value) == true)
                {
               
                    dataGridView1.Rows.Add(no.Attributes[0].Value,
                    no.Attributes[1].Value, no.Attributes[2].Value, no.Attributes[3].Value);
                }


            }
        }
 }
        private void button1_Click(object sender, EventArgs e)
        {
            ler();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int rowindex = dataGridView1.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[rowindex];
                string n1 = Convert.ToString(selectedRow.Cells["co1"].Value);
                string n2 = Convert.ToString(selectedRow.Cells["co2"].Value);
                string n3 = Convert.ToString(selectedRow.Cells["co3"].Value);
                string n4 = Convert.ToString(selectedRow.Cells["co4"].Value);
                textBox1.Text = n1;
                textBox2.Text = n2;
                textBox3.Text = n3;
                textBox4.Text = n4;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int rowindex = dataGridView1.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[rowindex];
                string n1 = Convert.ToString(selectedRow.Cells["co1"].Value);
                string n2 = Convert.ToString(selectedRow.Cells["co2"].Value);
                string n3 = Convert.ToString(selectedRow.Cells["co3"].Value);
                string n4 = Convert.ToString(selectedRow.Cells["co4"].Value);
                string Fich = "musicas.xml";

                XmlDocument FicheiroXML = new XmlDocument();
                string a = n1;
                FicheiroXML.Load(Fich);

                XmlNode t = FicheiroXML.SelectSingleNode("musicas/musica[@nome='" + a + "']");
                t.ParentNode.RemoveChild(t);
                FicheiroXML.Save(Fich);
              
                ler();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
        }
    }
}
