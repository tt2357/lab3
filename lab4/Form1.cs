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
using System.IO;

namespace lab4
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2(this);
            Form2.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(row.Index);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (StreamWriter Writer = new StreamWriter("File1.csv"))
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells.Count > 0)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell.Value != null)
                            {
                                Writer.Write(cell.Value.ToString() + ",");
                            }
                            else
                            {
                                Writer.Write(",");
                            }
                        }
                        Writer.WriteLine();
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            using (StreamReader reader = new StreamReader("File1.csv"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(',');
                    dataGridView1.Rows.Add(values);
                }
            }
        }
    }
}

