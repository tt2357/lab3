using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form2 : Form
    {
        public Form1 grid = null;
        public Form2(Form1 g)
        {
            InitializeComponent();
            this.grid = g;
        }

        private void removePlaceholder(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            string[] placeholders = { "Author", "Title", "Genre", "ISBN" };
            if(placeholders.Contains(textbox.Text))
            {
                textbox.Text = "";
                textbox.ForeColor = SystemColors.ControlText;
            }
        }
        private void addPlaceholder(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            if (textbox.Text == "")
            {
                textbox.Text = textbox.Tag as string;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Parametry tmp1 = new Parametry();
            tmp1 = new Parametry(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            grid.ADD(tmp1);

            textBox1.Text = textBox1.Tag as string;
            textBox2.Text = textBox2.Tag as string;
            textBox3.Text = textBox2.Tag as string;
            textBox4.Text = textBox2.Tag as string;


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
