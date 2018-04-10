using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iData
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void menuCE_Click(object sender, EventArgs e)
        {
            using (var form2 = new Form2())
            {
                form2.ShowDialog();
            }
        }

        private void menuVE_Click(object sender, EventArgs e)
        {
            using (var form1 = new Form1())
            {
                form1.ShowDialog();
            }
            using (var form2 = new Form2())
            {
                form2.Close();
            }
        }
    }
}
