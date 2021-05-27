using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        bool beurtx = true;
        public Form1()
        {
            InitializeComponent();
        }


        private void btnBoter_Click(object sender, EventArgs e)
        {
            Button _btnheyhallo = (Button)sender;
            if (_btnheyhallo.Text == "")
            {
                if (beurtx)
                {
                    _btnheyhallo.Text = ("X");
                }
                else
                {
                    _btnheyhallo.Text = ("O");
                }
                beurtx = !beurtx;
                if (beurtx)
                {
                    lblBeurt.Text = ("Het is de beurt van: X");
                }
                else
                {
                    lblBeurt.Text = ("Het is de beurt van: O");
                }
            }
            if (btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X" || btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X" || btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X" || btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X" || btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X" || btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X" || btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X" || btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X")
            {
                MessageBox.Show("X heeft gewonnen");
                btn1.Text = "";
                btn2.Text = "";
                btn3.Text = "";
                btn4.Text = "";
                btn5.Text = "";
                btn6.Text = "";
                btn7.Text = "";
                btn8.Text = "";
                btn9.Text = "";
            }
            if (btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O" || btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O" || btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O" || btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O" || btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O" || btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O" || btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O" || btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O")
            {
                MessageBox.Show("O heeft gewonnen");
                btn1.Text = "";
                btn2.Text = "";
                btn3.Text = "";
                btn4.Text = "";
                btn5.Text = "";
                btn6.Text = "";
                btn7.Text = "";
                btn8.Text = "";
                btn9.Text = "";
            }
            
        }
    }
}