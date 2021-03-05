using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Standard_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool enter_value = false;
        String operation = "";
        Double result = 0;

        private void Button_Click(object sender, EventArgs e)
        {
            if ((textBox.Text == "0") || (enter_value))
                    textBox.Text = "";
            enter_value = false;
            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!textBox.Text.Contains("."))
                    textBox.Text = textBox.Text + num.Text;
            }
            else
                textBox.Text = textBox.Text + num.Text;

        }

        private void clear_Button(object sender, EventArgs e)
        {
            textBox.Text = "0";
            labeltxt.Text = "";
        }

        private void backButton(object sender, EventArgs e)
        {
            if (textBox.Text.Length > 0) 
            {
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1, 1);
            }
            if (textBox.Text == "")
            {
                textBox.Text = "0";
            }
        }

        private void basicMath_Button(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            result= Double.Parse(textBox.Text);
            textBox.Text = "";
            labeltxt.Text = System.Convert.ToString(result) + "" + operation;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            labeltxt.Text = "";
            switch(operation)
            {
                case "+":
                    textBox.Text = (result + Double.Parse(textBox.Text)).ToString();
                    break;

                case "-":
                    textBox.Text = (result - Double.Parse(textBox.Text)).ToString();
                    break;

                case "*":
                    textBox.Text = (result * Double.Parse(textBox.Text)).ToString();
                    break;

                case "/":
                    textBox.Text = (result / Double.Parse(textBox.Text)).ToString();
                    break;

            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 245;
            textBox.Width = 206;

        }


        private void btnPM_Click(object sender, EventArgs e)
        {
            Double result = Double.Parse(textBox.Text);
            result = result * -1;
            textBox.Text = result.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
