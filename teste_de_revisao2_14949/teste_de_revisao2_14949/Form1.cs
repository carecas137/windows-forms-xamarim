using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste_de_revisao2_14949
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] meu = new int[5] { 1,2,3,2,3 };
        int[] dele = new int[5];
        int[] aux = new int[5];
        int t = 0;
        int max=1;
        int max2 = -999;
        int prev = 0;
        int primeiro = 0;
        int p = 0;
        int certas = 0;
        int fora = 0;
        Random rdnt = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
           
            lb1.Text ="O maior numero de series é :" + max2.ToString();
         
        }

        private void adicionar_Click(object sender, EventArgs e)
        {
           

            int novo = int.Parse(textBox1.Text);
         
            label2.Text += novo.ToString() + " ";
            if (primeiro == 0)
            {
                prev = int.Parse(textBox1.Text);
                t = prev;
                primeiro = 1;

            }
            else{
                if (novo == prev)
                {
                    max=max+1;
                    prev = novo;
                    if (max2 < max) max2 = max;
                }
                else
                {
                    max = 1;
                    prev = novo;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
           
          
           
            for(int i =0; i<5;i++)
            {
              p = rdnt.Next(0, 10);
              meu[i] = p;
              aux[i] = p;
            }
            for (int i = 0; i < 5; i++)
            {
               
                label5.Text += meu[i].ToString();
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
              for(int i =0; i<5; i++)
            {
                dele[i] = int.Parse(textBox2.Text.Substring(i, 1));
                label3.Text += dele[i].ToString();
            }
            for (int i = 0; i < 5; i++)
            {
               
                if (meu[i] == dele[i])
                {
                    certas++;
                    dele[i] = -1;
                    meu[i] = -99;
                }
            }
            for (int i = 0; i < 5; i++)
            {
                int n = meu[i];
                for (int j = 0; j < 5; j++)

                    if (n == dele[j])
                {
                    fora++;
                        dele[j] = -1;
                        break;
                }
            }
            certaslbl.Text = certas.ToString();
            erradas.Text = fora.ToString();
            certas = 0;
            fora = 0;
            for(int i = 0; i < 5; i++)
            {
                meu[i] = aux[i];
            }
        }
    }
}
