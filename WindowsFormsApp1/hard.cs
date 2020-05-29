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
    public partial class hard : Form
    {
        public int minutes;
        public int seconds;

        public hard()
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

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool cow_right = false;
            bool ovca_right = false;
            bool osel_right = false;
            bool olen_right = false;
            bool loshad_right = false;
            bool homyak_right = false;
            bool dog_right = false;
            bool pig_right = false;
            bool koza_right = false;
            bool krolik_right = false;
            bool koshka_right = false;

            if (textBox1.Text.ToLower() == "к" &&
                textBox2.Text.ToLower() == "о" &&
                textBox3.Text.ToLower() == "р" &&
                textBox4.Text.ToLower() == "о" &&
                textBox5.Text.ToLower() == "в" &&
                textBox6.Text.ToLower() == "а")
            {
                cow_right = true;
            }

            if (textBox15.Text.ToLower() == "о" &&
                textBox13.Text.ToLower() == "в" &&
                textBox12.Text.ToLower() == "ц" &&
                textBox11.Text.ToLower() == "а")
            {
                ovca_right = true;
            }

            if (textBox29.Text.ToLower() == "и" &&
                textBox31.Text.ToLower() == "ш" &&
                textBox32.Text.ToLower() == "а" &&
                textBox33.Text.ToLower() == "к")
            {
                osel_right = true;
            }

            if (textBox22.Text.ToLower() == "о" &&
                textBox21.Text.ToLower() == "л" &&
                textBox20.Text.ToLower() == "е" &&
                textBox17.Text.ToLower() == "н" &&
                textBox23.Text.ToLower() == "ь")
            {
                olen_right = true;
            }

            if (textBox37.Text.ToLower() == "л" &&
                textBox36.Text.ToLower() == "о" &&
                textBox35.Text.ToLower() == "ш" &&
                textBox38.Text.ToLower() == "а" &&
                textBox39.Text.ToLower() == "д" &&
                textBox40.Text.ToLower() == "ь")
            {
                loshad_right = true;
            }

            if (textBox27.Text.ToLower() == "х" &&
                textBox26.Text.ToLower() == "о" &&
                textBox25.Text.ToLower() == "м" &&
                textBox19.Text.ToLower() == "я" &&
                textBox24.Text.ToLower() == "к")
            {
                homyak_right = true;
            }

            if (textBox45.Text.ToLower() == "с" &&
                textBox44.Text.ToLower() == "о" &&
                textBox43.Text.ToLower() == "б" &&
                textBox42.Text.ToLower() == "а" &&
                textBox46.Text.ToLower() == "к" &&
                textBox47.Text.ToLower() == "а")
            {
                dog_right = true;
            }

            if (textBox14.Text.ToLower() == "с" &&
                textBox13.Text.ToLower() == "в" &&
                textBox16.Text.ToLower() == "и" &&
                textBox17.Text.ToLower() == "н" &&
                textBox18.Text.ToLower() == "ь" &&
                textBox19.Text.ToLower() == "я")
            {
                pig_right = true;
            }

            if (textBox7.Text.ToLower() == "к" &&
                textBox2.Text.ToLower() == "о" &&
                textBox8.Text.ToLower() == "з" &&
                textBox11.Text.ToLower() == "а")
            {
                koza_right = true;
            }

            if (textBox10.Text.ToLower() == "к" &&
                textBox9.Text.ToLower() == "р" &&
                textBox4.Text.ToLower() == "о" &&
                textBox28.Text.ToLower() == "л" &&
                textBox29.Text.ToLower() == "и" &&
                textBox30.Text.ToLower() == "к")
            {
                krolik_right = true;
            }

            if (textBox33.Text.ToLower() == "к" &&
                textBox34.Text.ToLower() == "о" &&
                textBox35.Text.ToLower() == "ш" &&
                textBox41.Text.ToLower() == "к" &&
                textBox42.Text.ToLower() == "а")
            {
                koshka_right = true;
            }

            string res = "";

            res = res + "1: ";
            if (cow_right)
            {
                res = res + "правильно\n";
            }
            else
            {
                res = res + "неправильно\n";
            }

            res = res + "2: ";
            if (ovca_right)
            {
                res = res + "правильно\n";
            }
            else
            {
                res = res + "неправильно\n";
            }

            res = res + "3: ";
            if (osel_right)
            {
                res = res + "правильно\n";
            }
            else
            {
                res = res + "неправильно\n";
            }

            res = res + "4: ";
            if (olen_right)
            {
                res = res + "правильно\n";
            }
            else
            {
                res = res + "неправильно\n";
            }

            res = res + "5: ";
            if (loshad_right)
            {
                res = res + "правильно\n";
            }
            else
            {
                res = res + "неправильно\n";
            }

            res = res + "6: ";
            if (homyak_right)
            {
                res = res + "правильно\n";
            }
            else
            {
                res = res + "неправильно\n";
            }

            res = res + "7: ";
            if (dog_right)
            {
                res = res + "правильно\n";
            }
            else
            {
                res = res + "неправильно\n";
            }

            res = res + "8: ";
            if (pig_right)
            {
                res = res + "правильно\n";
            }
            else
            {
                res = res + "неправильно\n";
            }

            res = res + "9: ";
            if (koza_right)
            {
                res = res + "правильно\n";
            }
            else
            {
                res = res + "неправильно\n";
            }

            res = res + "10: ";
            if (krolik_right)
            {
                res = res + "правильно\n";
            }
            else
            {
                res = res + "неправильно\n";
            }

            res = res + "11: ";
            if (koshka_right)
            {
                res = res + "правильно\n";
            }
            else
            {
                res = res + "неправильно\n";
            }

            res = res + "Время: " + minutes.ToString() + ":" + seconds_format(seconds);

            MessageBox.Show(res);
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
    }
}
