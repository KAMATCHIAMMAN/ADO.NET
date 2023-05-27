namespace Windowsforms
{
    public partial class Form1 : Form
    {
        double firstnumber = 0;
        string operation = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Addition.Text = (int.Parse(textBox1.Text) + int.Parse(textBox2.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Result_Click(object sender, EventArgs e)
        {

        }

        private void number1_Click(object sender, EventArgs e)
        {
            if (textBox.Text != null && textBox.Text == "0")
            {
                textBox.Text = "1";
            }
            else
            {
                textBox.Text = textBox.Text + "1";
            }
        }

        private void number2_Click(object sender, EventArgs e)
        {
            if (textBox.Text != null && textBox.Text == "0")
            {
                textBox.Text = "2";
            }
            else
            {
                textBox.Text = textBox.Text + "2";
            }

        }

        private void number3_Click(object sender, EventArgs e)
        {
            if (textBox.Text != null && textBox.Text == "0")
            {
                textBox.Text = "3";
            }
            else
            {
                textBox.Text = textBox.Text + "3";
            }
        }

        private void number4_Click(object sender, EventArgs e)
        {
            if (textBox.Text != null && textBox.Text == "0")
            {
                textBox.Text = "4";
            }
            else
            {
                textBox.Text = textBox.Text + "4";
            }
        }

        private void number5_Click(object sender, EventArgs e)
        {
            if (textBox.Text != null && textBox.Text == "0")
            {
                textBox.Text = "5";
            }
            else
            {
                textBox.Text = textBox.Text + "5";
            }
        }

        private void number6_Click(object sender, EventArgs e)
        {
            if (textBox.Text != null && textBox.Text == "0")
            {
                textBox.Text = "6";
            }
            else
            {
                textBox.Text = textBox.Text + "6";
            }
        }

        private void number7_Click(object sender, EventArgs e)
        {
            if (textBox.Text != null && textBox.Text == "0")
            {
                textBox.Text = "7";
            }
            else
            {
                textBox.Text = textBox.Text + "7";
            }
        }

        private void number8_Click(object sender, EventArgs e)
        {
            if (textBox.Text != null && textBox.Text == "0")
            {
                textBox.Text = "8";
            }
            else
            {
                textBox.Text = textBox.Text + "8";
            }
        }

        private void number9_Click(object sender, EventArgs e)
        {
            if (textBox.Text != null && textBox.Text == "0")
            {
                textBox.Text = "9";
            }
            else
            {
                textBox.Text = textBox.Text + "9";
            }
        }

        private void number0_Click(object sender, EventArgs e)
        {
            if (textBox.Text != null && textBox.Text == "0")
            {
                textBox.Text = "0";
            }
            else
            {
                textBox.Text = textBox.Text + "0";
            }
        }

        private void addnumbers_Click(object sender, EventArgs e)
        {
            firstnumber = Convert.ToDouble(textBox.Text);
            textBox.Text = "";
            operation = "+";
        }

        private void subnumbers_Click(object sender, EventArgs e)
        {
            firstnumber = Convert.ToDouble(textBox.Text);
            textBox.Text = "";
            operation = "-";
        }

        private void mulnumbers_Click(object sender, EventArgs e)
        {
            firstnumber = Convert.ToDouble(textBox.Text);
            textBox.Text = "";
            operation = "*";
        }

        private void divnumbers_Click(object sender, EventArgs e)
        {
            firstnumber = Convert.ToDouble(textBox.Text);
            textBox.Text = "";
            operation = "/";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
        }

        private void dot_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + ".";

        }

        private void equal_Click(object sender, EventArgs e)
        {
            double secondnumber = Convert.ToDouble(textBox.Text);
            double result = 0;
            if (operation == "+")
            {
                result = firstnumber + secondnumber;
                textBox.Text = result.ToString();
                firstnumber = result;
            }
            if (operation == "-")
            {
                result = firstnumber - secondnumber;
                textBox.Text = result.ToString();
                firstnumber = result;
            }
            if (operation == "*")
            {
                result = firstnumber * secondnumber;
                textBox.Text = result.ToString();
                firstnumber = result;
            }
            if (operation == "/")
            {
                result = firstnumber / secondnumber;
                textBox.Text = result.ToString();
                firstnumber = result;
            }

        }
    }
}