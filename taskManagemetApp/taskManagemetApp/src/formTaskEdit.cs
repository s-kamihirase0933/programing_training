using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taskManagemetApp.src
{
    public partial class formTaskEdit : Form
    {
        public formTaskEdit()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtTaskStart.Text = dateTimePicker1.Value.ToString("yyyy/MM/dd");
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            txtTaskFinish.Text = dateTimePicker1.Value.ToString("yyyy/MM/dd");
        }
    }
}
