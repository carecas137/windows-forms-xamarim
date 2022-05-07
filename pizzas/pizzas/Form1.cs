using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizzas
{
    public partial class Form1 : Form
    {
        int row = 0;
        double total = 0;

        public Form1()
        {
            InitializeComponent();
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if (string.Compare(comboBox1.Text, "") == 0 || string.Compare(comboBox2.Text, "") == 0 || string.Compare(comboBox3.Text, "") == 0) {

            }
            else {
            pizza pizzas = new pizza();
            ingredientes.Rows.Add(1);
            ingredientes[0, row].Value = comboBox3.Text;
            row++;
            double p = pizzas.add(comboBox1.Text, row);
                comboBox3.Items.Remove(comboBox3.SelectedItem);


                label5.Text = (total + p).ToString();
            }
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            pizza pizzas = new pizza();
            total = pizzas.ver(comboBox2.Text, comboBox1.Text);
            label5.Text = total.ToString();
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
        }
    }
}
