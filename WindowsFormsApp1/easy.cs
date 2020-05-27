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
    public partial class easy : Form
    {
        public easy()
        {
            InitializeComponent();
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool baraban_right = false;
            bool buben_right = false;
            bool truba_right = false;
            bool guitar_right = false;
            bool arfa_right = false;

            if (textBox5.Text.ToLower() == "б" &&
                textBox8.Text.ToLower() == "у" &&
                textBox9.Text.ToLower() == "б" &&
                textBox10.Text.ToLower() == "е" &&
                textBox11.Text.ToLower() == "н")
            {
                buben_right = true;
            }

            if (textBox5.Text.ToLower() == "б" &&
                textBox1.Text.ToLower() == "а" &&
                textBox2.Text.ToLower() == "р" &&
                textBox3.Text.ToLower() == "а" &&
                textBox4.Text.ToLower() == "б" &&
                textBox6.Text.ToLower() == "а" &&
                textBox7.Text.ToLower() == "н"
                )
            {
                baraban_right = true;
            }

            if (textBox12.Text.ToLower() == "т" &&
                textBox2.Text.ToLower() == "р" &&
                textBox13.Text.ToLower() == "у" &&
                textBox14.Text.ToLower() == "б" &&
                textBox15.Text.ToLower() == "а")
            {
                truba_right = true;
            }

            if (textBox18.Text.ToLower() == "г" &&
                textBox17.Text.ToLower() == "и" &&
                textBox16.Text.ToLower() == "т" &&
                textBox6.Text.ToLower() == "а" &&
                textBox19.Text.ToLower() == "р" &&
                textBox20.Text.ToLower() == "а")
            {
                guitar_right = true;
            }

            if (textBox20.Text.ToLower() == "а" &&
                textBox21.Text.ToLower() == "р" &&
                textBox22.Text.ToLower() == "ф" &&
                textBox23.Text.ToLower() == "а")
            {
                arfa_right = true;
            }


        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox5.Text = textBox5.Text[textBox5.TextLength - 1].ToString();
            }
            catch
            {
                textBox5.Text = "";
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox8.Text = textBox8.Text[textBox8.TextLength - 1].ToString();
            }
            catch
            {
                textBox8.Text = "";
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox9.Text = textBox9.Text[textBox9.TextLength - 1].ToString();
            }
            catch
            {
                textBox9.Text = "";
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox10.Text = textBox10.Text[textBox10.TextLength - 1].ToString();
            }
            catch
            {
                textBox10.Text = "";
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox11.Text = textBox11.Text[textBox11.TextLength - 1].ToString();
            }
            catch
            {
                textBox11.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = textBox1.Text[textBox1.TextLength - 1].ToString();
            }
            catch
            {
                textBox1.Text = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = textBox2.Text[textBox2.TextLength - 1].ToString();
            }
            catch
            {
                textBox2.Text = "";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = textBox3.Text[textBox3.TextLength - 1].ToString();
            }
            catch
            {
                textBox3.Text = "";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox4.Text = textBox4.Text[textBox4.TextLength - 1].ToString();
            }
            catch
            {
                textBox4.Text = "";
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox6.Text = textBox6.Text[textBox6.TextLength - 1].ToString();
            }
            catch
            {
                textBox6.Text = "";
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox7.Text = textBox7.Text[textBox7.TextLength - 1].ToString();
            }
            catch
            {
                textBox7.Text = "";
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox12.Text = textBox12.Text[textBox12.TextLength - 1].ToString();
            }
            catch
            {
                textBox12.Text = "";
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox13.Text = textBox13.Text[textBox13.TextLength - 1].ToString();
            }
            catch
            {
                textBox13.Text = "";
            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox14.Text = textBox14.Text[textBox14.TextLength - 1].ToString();
            }
            catch
            {
                textBox14.Text = "";
            }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox15.Text = textBox15.Text[textBox15.TextLength - 1].ToString();
            }
            catch
            {
                textBox15.Text = "";
            }
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox18.Text = textBox18.Text[textBox18.TextLength - 1].ToString();
            }
            catch
            {
                textBox18.Text = "";
            }
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox17.Text = textBox17.Text[textBox17.TextLength - 1].ToString();
            }
            catch
            {
                textBox17.Text = "";
            }
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox16.Text = textBox16.Text[textBox16.TextLength - 1].ToString();
            }
            catch
            {
                textBox16.Text = "";
            }
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox19.Text = textBox19.Text[textBox19.TextLength - 1].ToString();
            }
            catch
            {
                textBox19.Text = "";
            }
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox20.Text = textBox20.Text[textBox20.TextLength - 1].ToString();
            }
            catch
            {
                textBox20.Text = "";
            }
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox21.Text = textBox21.Text[textBox21.TextLength - 1].ToString();
            }
            catch
            {
                textBox21.Text = "";
            }
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox22.Text = textBox22.Text[textBox22.TextLength - 1].ToString();
            }
            catch
            {
                textBox22.Text = "";
            }
        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox23.Text = textBox23.Text[textBox23.TextLength - 1].ToString();
            }
            catch
            {
                textBox23.Text = "";
            }
        }
    }
}
