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
        public int minutes;
        public int seconds;

        public easy()
        {
            /*
             Данный момент вызывается автоматически при открытии (инициализации) окна.

             Запускается таймер, минусы и секунды ставятся на 0.

             */

            InitializeComponent();

            timer1.Start();
            minutes = 0;
            seconds = 0;
        }

        public string seconds_format(int min)
        {
            /*
             Данный метод используется для того, чтобы на экране отображалось не 9 секунд, а 09.
             */

            if (min < 10)
            {
                return "0" + min.ToString();
            }
            else
            {
                return min.ToString();
            }
        }

        /*
            Далее для всех текстбоксов используется однотипные строки кода, 
            который позволяют тексту, вводимому пользователем, иметь только 1 символ или не иметь вообще.
            
            Тип кода:

            try
            {
                текстБокс.Text = текстБокс.Text[текстБокс.TextLength - 1].ToString();
            }
            catch
            {
                текстБокс.Text = "";
            }

         */

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

        private void c_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox0.Text = textBox0.Text[textBox0.TextLength - 1].ToString();
            }
            catch
            {
                textBox0.Text = "";
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

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            /*
             В данном методе обрабатывается собитие нажатия на кнопку выхода из игры в меню.
             */

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
                Для каждого слова была выделена булева переменна, обозначающая, что true - слово введено верно, false - неверно.

                Тип переменной - слово_right
                
                В данном методе проверяются текстбоксы на наличие верно введённых слов. Если нужные текстбоксы содержат нужные буквы, 
                слово считается верно введенным, и переменная, которая относится к слову становится true.

                Далее проверяются все слова.
             */

            bool maska_right = false;
            bool skier_right = false;
            bool pero_right = false;
            bool vinograd_right = false;
            bool butterfly_right = false;
            bool vovka_right = false;
            bool guitar_right = false;
            bool toy_right = false;

            if (textBox1.Text.ToLower() == "м" &&
                textBox2.Text.ToLower() == "а" &&
                textBox3.Text.ToLower() == "с" &&
                textBox4.Text.ToLower() == "к" &&
                textBox5.Text.ToLower() == "а")
            {
                maska_right = true;
            }

            if (textBox11.Text.ToLower() == "л" &&
                textBox10.Text.ToLower() == "ы" &&
                textBox9.Text.ToLower() == "ж" &&
                textBox8.Text.ToLower() == "н" &&
                textBox6.Text.ToLower() == "и" &&
                textBox7.Text.ToLower() == "к")
            {
                skier_right = true;
            }

            if (textBox0.Text.ToLower() == "п" &&
                textBox14.Text.ToLower() == "е" &&
                textBox13.Text.ToLower() == "р" &&
                textBox12.Text.ToLower() == "о")
            {
                pero_right = true;
            }

            if (textBox22.Text.ToLower() == "в" &&
                textBox21.Text.ToLower() == "и" &&
                textBox20.Text.ToLower() == "н" &&
                textBox19.Text.ToLower() == "о" &&
                textBox18.Text.ToLower() == "г" &&
                textBox17.Text.ToLower() == "р" &&
                textBox15.Text.ToLower() == "а" &&
                textBox16.Text.ToLower() == "д")
            {
                vinograd_right = true;
            }

            if (textBox29.Text.ToLower() == "б" &&
                textBox28.Text.ToLower() == "а" &&
                textBox27.Text.ToLower() == "б" &&
                textBox26.Text.ToLower() == "о" &&
                textBox25.Text.ToLower() == "ч" &&
                textBox24.Text.ToLower() == "к" &&
                textBox23.Text.ToLower() == "а")
            {
                butterfly_right = true;
            }

            if (textBox34.Text.ToLower() == "в" &&
                textBox33.Text.ToLower() == "о" &&
                textBox32.Text.ToLower() == "в" &&
                textBox31.Text.ToLower() == "к" &&
                textBox30.Text.ToLower() == "а")
            {
                vovka_right = true;
            }

            if (textBox35.Text.ToLower() == "г" &&
                textBox36.Text.ToLower() == "и" &&
                textBox37.Text.ToLower() == "т" &&
                textBox38.Text.ToLower() == "а" &&
                textBox39.Text.ToLower() == "р" &&
                textBox40.Text.ToLower() == "а")
            {
                guitar_right = true;
            }

            if (textBox47.Text.ToLower() == "и" &&
                textBox46.Text.ToLower() == "г" &&
                textBox45.Text.ToLower() == "р" &&
                textBox44.Text.ToLower() == "у" &&
                textBox41.Text.ToLower() == "ш" &&
                textBox42.Text.ToLower() == "к" &&
                textBox43.Text.ToLower() == "а")
            {
                toy_right = true;
            }

            bool gold_right = false;

            if (textBox3.Text.ToLower() == "с" &&
                textBox8.Text.ToLower() == "н" &&
                textBox14.Text.ToLower() == "е" &&
                textBox18.Text.ToLower() == "г" &&
                textBox26.Text.ToLower() == "о" &&
                textBox32.Text.ToLower() == "в" &&
                textBox36.Text.ToLower() == "и" &&
                textBox42.Text.ToLower() == "к")
            {
                gold_right = true;
            }

            /*
             На данном этапе все слова проверены, и нам нужно вывести результат.

             Создадим переменную res типа string, которая будет содержать в себе результаты кроссворда и которую мы выведем в конце игры.

             Каждый вопрос проверяется следующим образом:
             1. Прибавляем к переменной res номер вопроса: res = res + "номер вопроса: ";
             2. Посредством переменной типа ответ_right проверяем, правильно ли ответил пользователь на вопрос, 
             и в зависимости от этого прибавляем "правильно" или "неправильно" и перенос на новую строку.

             В конце мы прибавляем время, за которое был решён кроссворд.
             */

            string res = "";

            res = res + "1: ";
            if (maska_right)
            {
                res = res + "правильно\n";
            }
            else
            {
                res = res + "неправильно\n";
            }

            res = res + "2: ";
            if (skier_right)
            {
                res = res + "правильно\n";
            }
            else
            {
                res = res + "неправильно\n";
            }

            res = res + "3: ";
            if (pero_right)
            {
                res = res + "правильно\n";
            }
            else
            {
                res = res + "неправильно\n";
            }

            res = res + "4: ";
            if (vinograd_right)
            {
                res = res + "правильно\n";
            }
            else
            {
                res = res + "неправильно\n";
            }

            res = res + "5: ";
            if (butterfly_right)
            {
                res = res + "правильно\n";
            }
            else
            {
                res = res + "неправильно\n";
            }

            res = res + "6: ";
            if (vovka_right)
            {
                res = res + "правильно\n";
            }
            else
            {
                res = res + "неправильно\n";
            }

            res = res + "7: ";
            if (guitar_right)
            {
                res = res + "правильно\n";
            }
            else
            {
                res = res + "неправильно\n";
            }

            res = res + "8: ";
            if (toy_right)
            {
                res = res + "правильно\n";
            }
            else
            {
                res = res + "неправильно\n";
            }

            res = res + "Золотое слово: ";
            if (gold_right)
            {
                res = res + "правильно\n";
            }
            else
            {
                res = res + "неправильно\n";
            }

            res = res + "Время: " + minutes.ToString() + ":" + seconds_format(seconds);

            res = res + "\n\nПерейти на следующий уровень?";

            /*Следующий метод показывает результат во всплывающем окне*/
            DialogResult dialogResult = MessageBox.Show(res, "Результат", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                middle middleWindow = new middle();
                middleWindow.Show();
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*
             Данный метод через каждые 1000 миллисекунд увеличивает переменную seconds на 1.
             Если перменная seconds равна 60, увеличивается переменная minutes на 1, а перменная seconds обнуляется.

             После мы изменяем строку в окне, отвечающую за минуты и секунды, на обновленные данные.
             */

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
