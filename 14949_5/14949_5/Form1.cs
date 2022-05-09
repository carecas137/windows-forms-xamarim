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

namespace _14949_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void inserir_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string Fich = "digito.xml";
            dataGridView1.AllowUserToAddRows = false;
            if (File.Exists(Fich) == false)
            {
                XmlTextWriter FicheiroXml = new XmlTextWriter(Fich, System.Text.Encoding.UTF8);
                FicheiroXml.WriteStartDocument(true);
                FicheiroXml.Formatting = Formatting.Indented;
                FicheiroXml.Indentation = 2;
                FicheiroXml.WriteStartElement("isbn13");
                FicheiroXml.WriteEndDocument();
                FicheiroXml.Close();
            }
            testar();

        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {

            int teste = 0;

            bool success2 = int.TryParse(inserir.Text, out teste);
            if (inserir.Text != "" && inserir.TextLength==13)
            {
                
                string Fich = "digito.xml";
                XmlDocument Ficheiroxml = new XmlDocument();
                Ficheiroxml.Load(Fich);
                XmlElement isbn = Ficheiroxml.CreateElement("isbn");
                XmlAttribute numero = Ficheiroxml.CreateAttribute("numero");
                numero.InnerText = inserir.Text;
                isbn.Attributes.Append(numero);
                Ficheiroxml.DocumentElement.AppendChild(isbn);
                Ficheiroxml.Save(Fich);
                MessageBox.Show("Inserido");
            }
            else
            {
                MessageBox.Show("Numero nao valido");
            }
            testar();
        }
        void testar()
        {
            string Fich = "digito.xml";
            if (File.Exists(Fich) == true)
            {

                XmlDocument FicheiroXML = new XmlDocument();

                FicheiroXML.Load(Fich);
                dataGridView1.Rows.Clear();
                foreach (XmlNode no in FicheiroXML.SelectNodes("//isbn"))
                {
                    int real;
                    int real1=0;
                    string n = no.Attributes[0].Value;
                    string last = n.Substring(n.Length - 1);

                  
                    //numero final
                    bool success = int.TryParse(last, out real);
                    //soma dos 12 
                    string so12 = n.Remove(n.Length - 1);
                    int soma = 0;
                    for(int i=0; i < so12.Length; i++)
                    {
                        char first = so12[i];
                        real1 = first - '0';
                        if(i==0 || i % 2 == 0)
                        {
                           
                            real1 = real1 * 1;
                            soma = soma + real1;
                            
                        }
                        else
                        {
                            real1 = real1 * 3;
                            soma = soma + real1;
                            
                        }

                    }
                   
                    //calcular o resto 
                    int resto = soma % 10;
                    //passo 3
                    int passo3 = 10 - resto;
                    int control = 0;
                    if (passo3 == 10)
                    {
                         control = 0;
                    }
                    else
                    {
                         control = passo3;

                    }
                    string estado;
                    if (real == control)
                    {
                         estado = "OK";
                    }
                    else
                    {
                         estado = "ERRO";
                    }

                    dataGridView1.Rows.Add(no.Attributes[0].Value,estado);



                }
            }
        }
    }
}
