using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class middle : Form
    {
        public int minutes;
        public int seconds;

        public middle()
        {
            InitializeComponent();
            timer1.Start();
            minutes = 0;
            seconds = 0;
        }

        public string seconds_format(int min)
        {
            if (min < 10)
            {
                return "0" + min.ToString();
            }
            else
            {
                return min.ToString();
            }
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
                textBox1.Text.ToLower() == "а")
            {
                arfa_right = true;
            }

            string res = "";

            res = res + "1 по горизонтали: ";
            if (buben_right)
            {
                res = res + "правильно\n";
            }
            else
            {
                res = res + "неправильно\n";
            }

            res = res + "2 по горизонтали: ";
            if (truba_right)
            {
                res = res + "правильно\n";
            }
            else
            {
                res = res + "неправильно\n";
            }

            res = res + "3 по горизонтали: ";
            if (guitar_right)
            {
                res = res + "правильно\n";
            }
            else
            {
                res = res + "неправильно\n";
            }

            res = res + "1 по вертикали: ";
            if (baraban_right)
            {
                res = res + "правильно\n";
            }
            else
            {
                res = res + "неправильно\n";
            }

            res = res + "4 по вертикали: ";
            if (arfa_right)
            {
                res = res + "правильно\n";
            }
            else
            {
                res = res + "неправильно\n";
            }

            res = res + "Время: " + minutes.ToString() + ":" + seconds_format(seconds);

            MessageBox.Show(
                res
                );
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
                textBox1.Text = textBox1.Text[textBox1.TextLength - 1].ToString();
            }
            catch
            {
                textBox1.Text = "";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            if (seconds == 60)
            {
                minutes++;
                seconds = 0;
            }

            time_label.Text = "Время: " + minutes.ToString() + ":" + seconds_format(seconds);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
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

        private void textBox3_TextChanged_1(object sender, EventArgs e)
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

        private void textBox16_TextChanged_1(object sender, EventArgs e)
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

        private void textBox17_TextChanged_1(object sender, EventArgs e)
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

        private void textBox36_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox36.Text = textBox36.Text[textBox36.TextLength - 1].ToString();
            }
            catch
            {
                textBox36.Text = "";
            }
        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox37.Text = textBox37.Text[textBox37.TextLength - 1].ToString();
            }
            catch
            {
                textBox37.Text = "";
            }
        }

        private void textBox38_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox38.Text = textBox38.Text[textBox38.TextLength - 1].ToString();
            }
            catch
            {
                textBox38.Text = "";
            }
        }

        private void textBox9_TextChanged_1(object sender, EventArgs e)
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

        private void textBox8_TextChanged_1(object sender, EventArgs e)
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

        private void textBox7_TextChanged_1(object sender, EventArgs e)
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

        private void textBox11_TextChanged_1(object sender, EventArgs e)
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

        private void textBox12_TextChanged_1(object sender, EventArgs e)
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

        private void textBox13_TextChanged_1(object sender, EventArgs e)
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

        private void textBox14_TextChanged_1(object sender, EventArgs e)
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

        private void textBox15_TextChanged_1(object sender, EventArgs e)
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

        private void textBox10_TextChanged_1(object sender, EventArgs e)
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

        private void textBox6_TextChanged_1(object sender, EventArgs e)
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

        private void textBox5_TextChanged_1(object sender, EventArgs e)
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

        private void textBox4_TextChanged_1(object sender, EventArgs e)
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

        private void textBox18_TextChanged_1(object sender, EventArgs e)
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

        private void textBox19_TextChanged_1(object sender, EventArgs e)
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

        private void textBox20_TextChanged_1(object sender, EventArgs e)
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

        private void textBox21_TextChanged_1(object sender, EventArgs e)
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

        private void textBox22_TextChanged_1(object sender, EventArgs e)
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

        private void textBox23_TextChanged_1(object sender, EventArgs e)
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

        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox24.Text = textBox24.Text[textBox24.TextLength - 1].ToString();
            }
            catch
            {
                textBox24.Text = "";
            }
        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox25.Text = textBox25.Text[textBox25.TextLength - 1].ToString();
            }
            catch
            {
                textBox25.Text = "";
            }
        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox28.Text = textBox28.Text[textBox28.TextLength - 1].ToString();
            }
            catch
            {
                textBox28.Text = "";
            }
        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox29.Text = textBox29.Text[textBox29.TextLength - 1].ToString();
            }
            catch
            {
                textBox29.Text = "";
            }
        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox30.Text = textBox30.Text[textBox30.TextLength - 1].ToString();
            }
            catch
            {
                textBox30.Text = "";
            }
        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox31.Text = textBox31.Text[textBox31.TextLength - 1].ToString();
            }
            catch
            {
                textBox31.Text = "";
            }
        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox32.Text = textBox32.Text[textBox32.TextLength - 1].ToString();
            }
            catch
            {
                textBox32.Text = "";
            }
        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox27.Text = textBox27.Text[textBox27.TextLength - 1].ToString();
            }
            catch
            {
                textBox27.Text = "";
            }
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox26.Text = textBox26.Text[textBox26.TextLength - 1].ToString();
            }
            catch
            {
                textBox26.Text = "";
            }
        }

        private void textBox39_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox39.Text = textBox39.Text[textBox39.TextLength - 1].ToString();
            }
            catch
            {
                textBox39.Text = "";
            }
        }

        private void textBox40_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox40.Text = textBox40.Text[textBox40.TextLength - 1].ToString();
            }
            catch
            {
                textBox40.Text = "";
            }
        }

        private void textBox41_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox41.Text = textBox41.Text[textBox41.TextLength - 1].ToString();
            }
            catch
            {
                textBox41.Text = "";
            }
        }

        private void textBox44_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox44.Text = textBox44.Text[textBox44.TextLength - 1].ToString();
            }
            catch
            {
                textBox44.Text = "";
            }
        }

        private void textBox45_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox45.Text = textBox45.Text[textBox45.TextLength - 1].ToString();
            }
            catch
            {
                textBox45.Text = "";
            }
        }

        private void textBox43_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox43.Text = textBox43.Text[textBox43.TextLength - 1].ToString();
            }
            catch
            {
                textBox43.Text = "";
            }
        }

        private void textBox47_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox47.Text = textBox47.Text[textBox47.TextLength - 1].ToString();
            }
            catch
            {
                textBox47.Text = "";
            }
        }

        private void textBox48_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox48.Text = textBox48.Text[textBox48.TextLength - 1].ToString();
            }
            catch
            {
                textBox48.Text = "";
            }
        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox34.Text = textBox34.Text[textBox34.TextLength - 1].ToString();
            }
            catch
            {
                textBox34.Text = "";
            }
        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox33.Text = textBox33.Text[textBox33.TextLength - 1].ToString();
            }
            catch
            {
                textBox33.Text = "";
            }
        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox35.Text = textBox35.Text[textBox35.TextLength - 1].ToString();
            }
            catch
            {
                textBox35.Text = "";
            }
        }

        private void textBox42_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox42.Text = textBox42.Text[textBox42.TextLength - 1].ToString();
            }
            catch
            {
                textBox42.Text = "";
            }
        }

        private void textBox46_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox46.Text = textBox46.Text[textBox46.TextLength - 1].ToString();
            }
            catch
            {
                textBox46.Text = "";
            }
        }
    }
}
