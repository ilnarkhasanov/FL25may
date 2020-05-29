using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(radioButtonEasy.Checked || radioButtonNormal.Checked || radioButtonDifficult.Checked)) 
            {
                var result = MessageBox.Show("Вы не выбрали кнопку!");
            }

            if (radioButtonEasy.Checked)
            {
                easy easyWindow = new easy();
                easyWindow.Show();
            }

            if (radioButtonNormal.Checked)
            {
                middle middleWindow = new middle();
                middleWindow.Show();
            }

            if (radioButtonDifficult.Checked)
            {
                hard hardWindow = new hard();
                hardWindow.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormRegulations f2 = new FormRegulations();
            f2.Show();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
