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
namespace ficheiros_xml
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Fich = "ficheiro.xml";
            XmlDocument Ficheiroxml = new XmlDocument();
            Ficheiroxml.Load(Fich);
            XmlElement socio = Ficheiroxml.CreateElement("socio");
            XmlAttribute numero = Ficheiroxml.CreateAttribute("numero");
            XmlAttribute nome = Ficheiroxml.CreateAttribute("nome");
            XmlAttribute telemovel = Ficheiroxml.CreateAttribute("telemovel");
            numero.InnerText = textBox1.Text;
            nome.InnerText = textBox2.Text;
            telemovel.InnerText = textBox3.Text;
            socio.Attributes.Append(numero);
            socio.Attributes.Append(nome);
            socio.Attributes.Append(telemovel);
            Ficheiroxml.DocumentElement.AppendChild(socio);
            Ficheiroxml.Save(Fich);
            ler();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            datagrid.AllowUserToAddRows = false;
            string Fich = "ficheiro.xml";
            if(File.Exists(Fich) == false)
            {
                XmlTextWriter FicheiroXml = new XmlTextWriter(Fich,System.Text.Encoding.UTF8);
                FicheiroXml.WriteStartDocument(true);
                FicheiroXml.Formatting = Formatting.Indented;
                FicheiroXml.Indentation = 2;
                FicheiroXml.WriteStartElement("associacao");
                FicheiroXml.WriteEndDocument();
                FicheiroXml.Close();
                
            }
            ler();
            }

        void ler()
        {
            string Fich = "ficheiro.xml";
            if (File.Exists(Fich) == true)
            {

                XmlDocument FicheiroXML = new XmlDocument();

                FicheiroXML.Load(Fich);
                datagrid.Rows.Clear();
                foreach (XmlNode no in FicheiroXML.SelectNodes("//socio"))
                {
                    datagrid.Rows.Add(no.Attributes[0].Value,
                   no.Attributes[1].Value,no.Attributes[2].Value);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Fich = "ficheiro.xml";
           
            XmlDocument FicheiroXML = new XmlDocument();
            string a = textBox1.Text;
            FicheiroXML.Load(Fich);
            foreach (XmlNode no in FicheiroXML.SelectNodes("//socio"))
            {
                if (a.Equals(no.Attributes[0].Value)==true)
                {
                    XmlNode t = FicheiroXML.SelectSingleNode("associacao/socio[@numero='" + a + "']");
                    t.ParentNode.RemoveChild(t);
                    FicheiroXML.Save(Fich);
                }
                
               
            }
            ler();
        }

    }
}
