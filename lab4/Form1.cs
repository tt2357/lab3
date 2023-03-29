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
        public BindingList<Parametry> ParametryList = new BindingList<Parametry>();
        public Parametry parametry = new Parametry();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = ParametryList;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public void ADD(Parametry a1)

        {
            ParametryList.Add(a1);
            dataGridView1.Update();
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
            ParametryList.Clear();
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

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 Form3 = new Form3(ParametryList);
            Form3.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Xml.Serialization.XmlSerializer xmlSerializer = new System.Xml.Serialization.XmlSerializer(typeof(BindingList<Parametry>));
            using (var writer = new StreamWriter("eksport.xml"))
            {
                xmlSerializer.Serialize(writer, ParametryList);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!File.Exists("./eksport.xml"))
            {
                return;
            }

            System.Xml.Serialization.XmlSerializer xmlSerializer = new System.Xml.Serialization.XmlSerializer(typeof(BindingList<Parametry>));
            using (var reader = new StreamReader("eksport.xml"))
            {
                ParametryList = (BindingList<Parametry>)xmlSerializer.Deserialize(reader);
                dataGridView1.DataSource = ParametryList;
            }
        }
    }
}

