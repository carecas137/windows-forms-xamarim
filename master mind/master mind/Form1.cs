using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace master_mind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PictureBox[] picture;
        PictureBox[] picture2;
        int[] meu = new int[5] { 1, 2, 3, 4 , 5 };
        int[] dele = new int[4];
        int[] aux = new int[4];
        int p = 1;
        int o = 0;
        int tenta = 1;
        int certas = 0, fora = 0;
        Random rdnt = new Random();
        int r = 0;
        int tu = 1;

        private void Form1_Load(object sender, EventArgs e)
        {
            picture = new PictureBox[17] { ten1_1, ten1_2, ten1_3, ten1_4, ten2_1, ten2_2, ten2_3, ten2_4, ten3_1, ten3_2, ten3_3, ten3_4, ten4_1, ten4_2, ten4_3, ten4_4, ten4_4 };
            picture2 = new PictureBox[16] { e11, e12, e13, e14, e21, e22, e23, e24, e31, e32, e33, e34, e41, e42, e43, e44 };
            redpic.AllowDrop = false;
            bluepic.AllowDrop = false;
            yellowpic.AllowDrop = false;
            pinkpic.AllowDrop = false;
            greenpic.AllowDrop = false;
            ten1_1.AllowDrop = true;
         
            for (int p = meu.Length - 2; p > 0; p--)
            {
                int randomIndex = rdnt.Next(0, p + 1);
                int temp = meu[p];
                meu[p] = meu[randomIndex];
                meu[randomIndex] = temp;

            }

            for (int i = 0; i < 4; i++)
            {
                aux[i] = meu[i];
              
            }





        }
        private void pic_MouseDown(object sender, MouseEventArgs e)
        {

            PictureBox picture = sender as PictureBox;
            
            if (picture.BackColor != null)
                DoDragDrop(sender, DragDropEffects.Move);
        }
        private void pic_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(PictureBox)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }
        private void pic_DragDrop(object sender, DragEventArgs e)
        {
            var picorigem = e.Data.GetData(typeof(PictureBox)) as PictureBox;
            var picdes = sender as PictureBox;
           
            picdes.BackColor = picorigem.BackColor;
           picdes.AllowDrop = false;
            picture[p].AllowDrop = true;
            p++;
            if (picdes.BackColor==redpic.BackColor)
            {
                dele[o] = 1;    
            }
            if (picdes.BackColor == pinkpic.BackColor)
            {
                dele[o] = 2; 
                }
            if (picdes.BackColor == bluepic.BackColor)
            {
                dele[o] = 3; 
                }
            if (picdes.BackColor == greenpic.BackColor)
            {
                dele[o] = 4; 
                }
            if (picdes.BackColor == yellowpic.BackColor)
            {
                dele[o] = 5;
                }
            
                o++;

            if (o == 4)
            {
                
                for (int i = 0; i < 4; i++)
                {

                    if (meu[i] == dele[i])
                    {
                        certas++;
                        dele[i] = -1;
                        meu[i] = -99;
                    }
                }
                for (int i = 0; i < 4; i++)
                {
                    int n = meu[i];
                    for (int j = 0; j < 4; j++)

                        if (n == dele[j])
                        {
                            fora++;
                            dele[j] = -1;
                            break;
                        }
                }
              
                
              
               
                if (tenta == 1)
                {
                    if (certas != 0)
                    {
                        if (certas == 4)
                        {
                            label1.Text = "GANHOU!";
                        }
                        for (int i = 0; i < certas; i++)
                        {
                            picture2[r].BackColor = Color.Black;
                            r++;

                        }
                    }
                    if (fora != 0)
                    {
                        for (int i = 0; i < fora; i++)
                        {

                            picture2[r].BackColor = Color.Gray; r++;
                        }
                    }
                    o = 0;
                    fora = 0;
                    certas = 0;
                    for (int i = 0; i < 4; i++)
                    {
                        meu[i] = aux[i];
                    }
                    delel.Text = null;
                    ten1_1.AllowDrop = false;
                    ten1_2.AllowDrop = false;
                    ten1_3.AllowDrop = false;
                    ten1_4.AllowDrop = false;
                    ten2_1.AllowDrop = true;
                    ten2_2.AllowDrop = true;
                    ten2_3.AllowDrop = true;
                    ten2_4.AllowDrop = true;
                    ten2_1.BorderStyle = BorderStyle.Fixed3D;
                    ten2_2.BorderStyle = BorderStyle.Fixed3D;
                    ten2_3.BorderStyle = BorderStyle.Fixed3D;
                    ten2_4.BorderStyle = BorderStyle.Fixed3D;


                    r = 4;
                    tenta=2;
                }
                else if(tenta == 2)
                {
                   
                    if (certas != 0)
                    {
                        if (certas == 4)
                        {
                            label1.Text = "GANHOU!";
                        }
                        for (int i = 0; i < certas; i++)
                        {
                            picture2[r].BackColor = Color.Black;
                            r++;

                        }
                    }
                    if (fora != 0)
                    {
                        for (int i = 0; i < fora; i++)
                        {
                            picture2[r].BackColor = Color.Gray; r++;
                        }
                    }
                    o = 0;
                    fora = 0;
                    certas = 0;
                    for (int i = 0; i < 4; i++)
                    {
                        meu[i] = aux[i];
                    }
                    delel.Text = null;
                    ten2_1.AllowDrop = false;
                    ten2_2.AllowDrop = false;
                    ten2_3.AllowDrop = false;
                    ten2_4.AllowDrop = false;
                    ten3_1.AllowDrop = true;
                    ten3_2.AllowDrop = true;
                    ten3_3.AllowDrop = true;
                    ten3_4.AllowDrop = true;
                    ten3_1.BorderStyle = BorderStyle.Fixed3D;
                    ten3_2.BorderStyle = BorderStyle.Fixed3D;
                    ten3_3.BorderStyle = BorderStyle.Fixed3D;
                    ten3_4.BorderStyle = BorderStyle.Fixed3D;
                  
                    r = 8;
                    tenta = 3;
                }
                else if (tenta == 3)
                {
                    if (certas != 0)
                    {
                        if (certas == 4)
                        {
                            label1.Text = "GANHOU!";
                        }
                        for (int i = 0; i < certas; i++)
                        {
                            picture2[r].BackColor = Color.Black;
                            r++;
                        }
                    }
                    if (fora != 0)
                    {
                        for (int i = 0; i < fora; i++)
                        {
                            picture2[r].BackColor = Color.Gray; r++;
                        }
                    }
                    o = 0;
                    fora = 0;
                    certas = 0;
                    for (int i = 0; i < 4; i++)
                    {
                        meu[i] = aux[i];
                    }
                    delel.Text = null;
                    ten3_1.AllowDrop = false;
                    ten3_2.AllowDrop = false;
                    ten3_3.AllowDrop = false;
                    ten3_4.AllowDrop = false;
                    ten4_1.AllowDrop = true;
                    ten4_2.AllowDrop = true;
                    ten4_3.AllowDrop = true;
                    ten4_4.AllowDrop = true;
                    ten4_1.BorderStyle = BorderStyle.Fixed3D;
                    ten4_2.BorderStyle = BorderStyle.Fixed3D;
                    ten4_3.BorderStyle = BorderStyle.Fixed3D;
                    ten4_4.BorderStyle = BorderStyle.Fixed3D;
                    r = 12;
                    tenta = 4;
                }
                if (tenta == 4)
                {
                    if (certas != 0)
                    {
                        if (certas == 4)
                        {
                            label1.Text = "GANHOU!";
                        }
                        else
                        {
                            label1.Text = "PERDEU!";
                        }
                        for (int i = 0; i < certas; i++)
                        {
                            picture2[r].BackColor = Color.Black;
                            r++;

                        }
                    }
                    if (fora != 0)
                    {
                        for (int i = 0; i < fora; i++)
                        {

                            picture2[r].BackColor = Color.Gray; r++;
                        }
                    }
                    o = 0;
                    fora = 0;
                    certas = 0;
                    for (int i = 0; i < 4; i++)
                    {
                        meu[i] = aux[i];
                    }
                    delel.Text = null;
                  
                   
                }



            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (tu == 1)
                {
            for (int i = 0; i < 4; i++)
            {
                
                    teste.Text += meu[i].ToString();
                    tu = 3;
               
               
                

            }
        } }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
