using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace jogodamemoria
{
    public partial class Form1 : Form
    {
        int j = 0;
        int[] array1 = new int[11];
        PictureBox[] pictures;
        string first = "pic0";
    
        public Form1() 
        {
            InitializeComponent();
        }

        private void iniciar_Click(object sender, EventArgs e)
        {
        
            int i = 0;
            Random rdn2 = new Random();
            Random random = new Random();

            while (i < 10)
            {
                int num2 = rdn2.Next(1, 6);
               bool valida = array1.Contains(num2);
                if(valida==false)
                {
                    array1[i] = num2;
                    array1[i+1] = num2;
                    i=i+2;
                }
            }
            for (int p = array1.Length - 2; p > 0; p--)
            {
                int randomIndex = random.Next(0, p + 1);
                int temp = array1[p];
                array1[p] = array1[randomIndex];
                array1[randomIndex] = temp;
            }
            pictures = new PictureBox[10] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6 , pictureBox7, pictureBox8, pictureBox9, pictureBox10 };
            pictures[0].Name = "pic" + array1[0];
            pictures[1].Name = "pic" + array1[1];
            pictures[2].Name = "pic" + array1[2];
            pictures[3].Name = "pic" + array1[3];
            pictures[4].Name = "pic" + array1[4];
            pictures[5].Name = "pic" + array1[5];
            pictures[6].Name = "pic" + array1[6];
            pictures[7].Name = "pic" + array1[7];
            pictures[8].Name = "pic" + array1[8];
            pictures[9].Name = "pic" + array1[9];
          for(int p=0; p < 10; p++)
            {
                if (array1[p] == 1)
                {
                    pictures[p].Image = Properties.Resources.ananas;
                }
                if (array1[p] == 2)
                {
                    pictures[p].Image = Properties.Resources.banana;
                }
                if (array1[p] == 3)
                {
                    pictures[p].Image = Properties.Resources.laranja;
                }
                if (array1[p] == 4)
                {
                    pictures[p].Image = Properties.Resources.morango;
                }
                if (array1[p] == 5)
                {
                    pictures[p].Image = Properties.Resources.pera;
                }

            }

            Application.DoEvents();
            slep();
            
        }
        private void slep()
        {
            Thread.Sleep(1000);
            pictures[0].Image = Properties.Resources.deck;
            pictures[1].Image = Properties.Resources.deck;
            pictures[2].Image = Properties.Resources.deck;
            pictures[3].Image = Properties.Resources.deck;
            pictures[4].Image = Properties.Resources.deck;
            pictures[5].Image = Properties.Resources.deck;
            pictures[6].Image = Properties.Resources.deck;
            pictures[7].Image = Properties.Resources.deck;
            pictures[8].Image = Properties.Resources.deck;
            pictures[9].Image = Properties.Resources.deck;
        }
    
  
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (j == 0)
            {
                PictureBox dynamicButton = (sender as PictureBox);

                if (dynamicButton.Name == "pic1")
                {
                    dynamicButton.Image = Properties.Resources.ananas;
                }
                if (dynamicButton.Name == "pic2")
                {
                    dynamicButton.Image = Properties.Resources.banana;
                }
                if (dynamicButton.Name == "pic3")
                {
                    dynamicButton.Image = Properties.Resources.laranja;
                }
                if (dynamicButton.Name == "pic4")
                {
                    dynamicButton.Image = Properties.Resources.morango;
                }
                if (dynamicButton.Name == "pic5")
                {
                    dynamicButton.Image = Properties.Resources.pera;
                }
                j = 1;
                first = dynamicButton.Name;
            }
            else
            {
                j=0;
                PictureBox dynamicButton = (sender as PictureBox);
                if (dynamicButton.Name == "pic1")
                {
                    dynamicButton.Image = Properties.Resources.ananas;
                }
                if (dynamicButton.Name == "pic2")
                {
                    dynamicButton.Image = Properties.Resources.banana;
                }
                if (dynamicButton.Name == "pic3")
                {
                    dynamicButton.Image = Properties.Resources.laranja;
                }
                if (dynamicButton.Name == "pic4")
                {
                    dynamicButton.Image = Properties.Resources.morango;
                }
                if (dynamicButton.Name == "pic5")
                {
                    dynamicButton.Image = Properties.Resources.pera;
                }
                Application.DoEvents();
                if (first!=dynamicButton.Name)
                {
                  for(int p = 0; p < 10; p++)
                    {
                        if(dynamicButton.Name==pictures[p].Name)
                        {
                            pictures[p].Image= Properties.Resources.deck;
                            
                        }
                        if(first== pictures[p].Name)
                        {
                            pictures[p].Image = Properties.Resources.deck;
                            
                        }
                    }
                }
              
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void reni_Click(object sender, EventArgs e)
        {
            Application.Restart();
            
        }

        private void sair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
        }

    
        
         
        
    
    

