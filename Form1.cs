using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{

    public partial class Form1 : Form
    {
        private double resultValue = 0;
        private string OperationPerformed = "";
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {

            if ((textbox_Results.Text == "0") || isOperationPerformed )
            { 
            textbox_Results.Clear();
            }
            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textbox_Results.Text.Contains("."))
                    textbox_Results.Text = textbox_Results.Text + button.Text;
            }
            else

                textbox_Results.Text = textbox_Results.Text + button.Text;
           
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                button12.PerformClick();
                OperationPerformed = button.Text;
                isOperationPerformed = true;
                labelCurrentOperation.Text = resultValue + " " + OperationPerformed;
            }
            else
            {

                OperationPerformed = button.Text;
                resultValue = double.Parse(textbox_Results.Text);
                isOperationPerformed = true;

                labelCurrentOperation.Text = resultValue + " " + OperationPerformed;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textbox_Results.Text = "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textbox_Results.Text = "0";
            resultValue = 0;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            switch (OperationPerformed) 
            { 
            case "+":
                    textbox_Results.Text = (resultValue + double.Parse(textbox_Results.Text)).ToString();
                    break;
                case "-":
                    textbox_Results.Text = (resultValue - double.Parse(textbox_Results.Text)).ToString();
                    break;
                case "x":
                    textbox_Results.Text = (resultValue * double.Parse(textbox_Results.Text)).ToString();
                    break;
                case "/":
                    textbox_Results.Text = (resultValue / double.Parse(textbox_Results.Text)).ToString();
                    break;
               default:
                    break;

            }
            resultValue=double.Parse(textbox_Results.Text);
            labelCurrentOperation.Text = "";
        }
    }
}
