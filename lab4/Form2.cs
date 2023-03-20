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
        public class Book
        {
            public string Authorl { get; set; }
            public string Title1 { get; set; }
            public string Genre1 { get; set; }
            public string ISBN1 { get; set; }

        }
        public static Form2 instance2;
        public Form2()
        {
            InitializeComponent();
            instance2 = this;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.instance1.Authorr = textBox1.Text;
            Form1.instance1.Titlee = textBox2.Text;
            Form1.instance1.Genree = textBox3.Text;
            Form1.instance1.ISBNN = textBox4.Text;


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
