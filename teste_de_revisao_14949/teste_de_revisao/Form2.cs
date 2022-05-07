using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste_de_revisao
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int t = 1;

        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            t = 1;
            textBox2.Enabled = false;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            contas conta = new contas();
            if (t == 1)
            {
                double b;
                if (Double.TryParse(textBox1.Text, out b))
                {
                    double total = conta.quad(b);
                    label5.Text = total.ToString();
                }
                    
             
            }
            else if (t == 2)
            {
                double b,y;
                if (Double.TryParse(textBox1.Text, out b) && Double.TryParse(textBox2.Text, out y))
                {
                    double total = conta.ret(b, y);
                    label5.Text = total.ToString();
                }
            
            }
           else  if (t == 3)
            {
                double b, y;
                if (Double.TryParse(textBox1.Text, out b) && Double.TryParse(textBox2.Text, out y))
                {
                    double total = conta.tri(b, y);
                    label5.Text = total.ToString();
                }
            }
            else if (t == 4)
            {
                double b;
                if (Double.TryParse(textBox1.Text, out b))
                {
                    double total = conta.cir(b);
                    label5.Text = total.ToString();
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            t = 2;

            textBox2.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            t = 3;
            textBox2.Enabled = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            t = 4;
            textBox2.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
