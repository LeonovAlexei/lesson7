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

namespace WF_Udvoitel
{

    
    public partial class Form1 : Form
    {
        

        Stack<char> action = new Stack<char>();
        

        public Form1()
        {
            InitializeComponent();

            Random rnd = new Random();
            int summ = rnd.Next(0, 101);
            lblcolamout.Text = summ.ToString();
            
        }
       
        
        
        public int Scope { get => scope; set => scope = value; }
        

        int scope = 0;
        

        private void printScope()
        {

            lblScope.Text = scope.ToString();
        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            Scope++;
            printScope();
            action.Push('+');
            отменитьХодToolStripMenuItem.Enabled = true;
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            
            Scope++;
            printScope();
            action.Push('*');
            отменитьХодToolStripMenuItem.Enabled = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "0";
            Scope++;
            printScope();
        }

        private void игратьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int summ = rnd.Next(0,101);
            lblcolamout.Text = summ.ToString();
            scope = 0;
            printScope();
            lblNumber.Text = "0";
        }

        private void правилаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show( "При нажатии кнопки меню \"Играть\" появится сообщение, какое числодолжен получить игрок.\nИгрок должен получить это число за минимальное количество ходов.");
        }

        private void lblScope_Click(object sender, EventArgs e)
        {

        }

        private void отменитьХодToolStripMenuItem_Click(object sender, EventArgs e)
        {

            char stackElement = action.Pop();
            if (stackElement=='+') lblNumber.Text = (int.Parse(lblNumber.Text) - 1).ToString();
            if (stackElement == '*') lblNumber.Text = (int.Parse(lblNumber.Text) /2).ToString();
            if (action.Count == 0) отменитьХодToolStripMenuItem.Enabled = false;
            else отменитьХодToolStripMenuItem.Enabled = true;

        }
    }
}
