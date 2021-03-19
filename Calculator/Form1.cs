using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frmCalculator : Form
    {
        private char previousAct;
        private float previousNum;

        public frmCalculator()
        {
            InitializeComponent();
            Init();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            IncludeText(btnOne.Text);
        }
        private void IncludeText(string str)
        {
            if (previousAct == '=')
            {
                Init();
            }
            if ((str== "." && !txtResult.Text.Contains("."))
                ||(str != "."))
            txtResult.Text = txtResult.Text + str;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            IncludeText(btnTwo.Text);
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            IncludeText(btnThree.Text);
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            IncludeText(btnFour.Text);
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            IncludeText(btnFive.Text);
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            IncludeText(btnSix.Text);
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            IncludeText(btnSeven.Text);
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            IncludeText(btnEight.Text);
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            IncludeText(btnNine.Text);
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            IncludeText(btnDecimal.Text);
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            IncludeText(btnZero.Text);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            Calculate();
            previousAct = '+';
            txtResult.Text = "";

        }

        private void Calculate()
        {
            if (txtResult.Text != "")
            {
                switch (previousAct)
                {

                    case '+':
                        previousNum = previousNum + float.Parse(txtResult.Text);
                        break;
                    case '-':
                        previousNum = previousNum - float.Parse(txtResult.Text);
                        break;
                    case 'x':
                        previousNum = previousNum * float.Parse(txtResult.Text);
                        break;
                    case '/':
                        previousNum = previousNum / float.Parse(txtResult.Text);
                        break;
                    case ' ':
                    case '=':
                        previousNum = float.Parse(txtResult.Text);
                        break;
                    default:

                        break;


                }
            }
            
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            Calculate();
            txtResult.Text = previousNum.ToString();
            previousAct = '=';
        }
        private void Init()
        {
            txtResult.Text = "";
            previousAct = ' ';
            previousNum = 0;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            Calculate();
            previousAct = '-';
            txtResult.Text = "";
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            Calculate();
            previousAct = 'x';
            txtResult.Text = "";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            Calculate();
            previousAct = '/';
            txtResult.Text = "";
        }
    }
}
