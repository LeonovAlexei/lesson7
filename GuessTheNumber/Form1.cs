//Леонов Алексей
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheNumber
{
    public partial class GuessTheNumber : Form
    {
        int scope = 0;
        int summ = 0;

        public GuessTheNumber()
        {
            InitializeComponent();

            Random rnd = new Random();
            summ = rnd.Next(0, 101);

        }
        private void printScope()
        {

            lblScope.Text = scope.ToString();
        }
        private void printWin()
        {

            tBProgAnswer.Text = $"Поздравляю вы угадали число!\r\nДля этого вам понадобилось {scope} ходов!";
        }
        private void printMin()
        {

            tBProgAnswer.Text = "Загаданное число меньше вашего.\r\nПопробуйте ещё раз!";
        }
        private void printMax()
        {

            tBProgAnswer.Text = "Загаданное число больше вашего.\r\nПопробуйте ещё раз!";
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            scope++;
            string UserAnswer = tBUserAnswer.Text;
            int UserAnswerint;
            if (int.TryParse(UserAnswer,out UserAnswerint))
            {
                if (summ == UserAnswerint) printWin();
                if (summ < UserAnswerint) printMin();
                if (summ > UserAnswerint) printMax();
            }
            else
            {
                tBProgAnswer.Text = "Не корректный ввод!\r\nПопробуйте ещё раз!";
            }
            
            printScope();
            tBUserAnswer.Text = "";
            tBUserAnswer.Focus();

        }
    }
}
