using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace lab4
{
    public partial class Form3 : Form
    {
        private BindingList<Parametry> ParametryList = new BindingList<Parametry>();
        public Form3(BindingList<Parametry> list)
        {
            InitializeComponent();
            ParametryList = list;
            dataGridView2.DataSource = ParametryList;
        }


        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxS_TextChanged(object sender, EventArgs e)
        {
            if(textBoxS.Text == string.Empty)
            {
                dataGridView2.DataSource = ParametryList;
                return;
            }

            BindingList<Parametry> tmp1 = new BindingList<Parametry>();
            tmp1 = ParametryList;
            string pattern = @"^.*" + textBoxS.Text + @".*$";
            Regex r1 = new Regex(pattern, RegexOptions.IgnoreCase);
            BindingList<Parametry> filteredBindingList = new BindingList<Parametry>(tmp1.Where(x => r1.IsMatch(x.ToString())).ToList());
            dataGridView2.DataSource = filteredBindingList;
        }
    }
}
