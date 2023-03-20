using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        public string Authorr;
        public string Titlee;
        public string Genree;
        public string ISBNN;
        public static Form1 instance1;
       
        public Form1()
        {
            InitializeComponent();
            instance1 = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();
        }
        public void refresh()
        {
            bookBindingSource.Add(new Book(){ Author1=Authorr, Title1=Titlee, Genre1=Genree, ISBN1=ISBNN});
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 Form3 = new Form3();
            Form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 Form4 = new Form4();
            Form4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 Form5 = new Form5();
            Form5.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
