using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace iData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (StreamReader reader = new StreamReader("db.txt"))
            {
                int row = 0;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] Columns = line.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                    dataView.Rows.Add();
                    for (int i = 0; i < Columns.Length; i++)
                    {
                        dataView[i, row].Value = Columns[i];
                    }
                    row++;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbxName.Text == "" || tbxAge.Text == "" || tbxName.Text == "")
            {
                MessageBox.Show("You have not filled in all fields. Please check your fields again.", "Error");
            }
            else
            using (StreamWriter writer = new StreamWriter("db.txt", true))
            {
                writer.WriteLine(tbxName.Text + "|" + tbxAge.Text + "|" + tbxGender.Text);
                Application.Restart();
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
