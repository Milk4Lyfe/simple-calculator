using System.Diagnostics.Contracts;

namespace hello
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "0";
            label4.Text = "0";
            this.Icon = Properties.Resources.Untitled;
        }
        public string num1 = "0";
        public bool num = false;
        public string num2 = "0";
        public double num3 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (num == false)
            {
                if (num1 == "0")
                {
                    num1 = "1";
                    label2.Text = num1;
                }
                else
                {
                    num1 = num1 + "1";
                    label2.Text = num1;
                }
            }
            if (num == true)
            {
                if (num2 == "0")
                {
                    num2 = "1";
                    label4.Text = num2;
                }
                else
                {
                    num2 = num2 + "1";
                    label4.Text = num2;
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (num == false)
            {
                if (num1 == "0")
                {
                    num1 = "2";
                    label2.Text = num1;
                }
                else
                {
                    num1 = num1 + "2";
                    label2.Text = num1;
                }
            }
            if (num == true)
            {
                if (num2 == "0")
                {
                    num2 = "2";
                    label4.Text = num2;
                }
                else
                {
                    num2 = num2 + "2";
                    label4.Text = num2;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (num == false)
            {
                if (num1 == "0")
                {
                    num1 = "3";
                    label2.Text = num1;
                }
                else
                {
                    num1 = num1 + "3";
                    label2.Text = num1;
                }
            }
            if (num == true)
            {
                if (num2 == "0")
                {
                    num2 = "3";
                    label4.Text = num2;
                }
                else
                {
                    num2 = num2 + "3";
                    label4.Text = num2;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (num == false)
            {
                if (num1 == "0")
                {
                    num1 = "6";
                    label2.Text = num1;
                }
                else
                {
                    num1 = num1 + "6";
                    label2.Text = num1;
                }
            }
            if (num == true)
            {
                if (num2 == "0")
                {
                    num2 = "6";
                    label4.Text = num2;
                }
                else
                {
                    num2 = num2 + "6";
                    label4.Text = num2;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (num == false)
            {
                if (num1 == "0")
                {
                    num1 = "5";
                    label2.Text = num1;
                }
                else
                {
                    num1 = num1 + "5";
                    label2.Text = num1;
                }
            }
            if (num == true)
            {
                if (num2 == "0")
                {
                    num2 = "5";
                    label4.Text = num2;
                }
                else
                {
                    num2 = num2 + "5";
                    label4.Text = num2;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            num = false;
            label7.Text = "_";
            label8.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (num == false)
            {
                if (num1 == "0")
                {
                    num1 = "0";
                    label2.Text = num1;
                }
                else
                {
                    num1 = num1 + "0";
                    label2.Text = num1;
                }
            }
            if (num == true)
            {
                if (num2 == "0")
                {
                    num2 = "6";
                    label4.Text = num2;
                }
                else
                {
                    num2 = num2 + "0";
                    label4.Text = num2;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (num == false)
            {
                if (num1 == "0")
                {
                    num1 = "8";
                    label2.Text = num1;
                }
                else
                {
                    num1 = num1 + "8";
                    label2.Text = num1;
                }
            }
            if (num == true)
            {
                if (num2 == "0")
                {
                    num2 = "8";
                    label4.Text = num2;
                }
                else
                {
                    num2 = num2 + "8";
                    label4.Text = num2;
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (num == false)
            {
                if (num1 == "0")
                {
                    num1 = "7";
                    label2.Text = num1;
                }
                else
                {
                    num1 = num1 + "7";
                    label2.Text = num1;
                }
            }
            if (num == true)
            {
                if (num2 == "7")
                {
                    num2 = "7";
                    label4.Text = num2;
                }
                else
                {
                    num2 = num2 + "7";
                    label4.Text = num2;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (num == false)
            {
                if (num1 == "0")
                {
                    num1 = "9";
                    label2.Text = num1;
                }
                else
                {
                    num1 = num1 + "9";
                    label2.Text = num1;
                }
            }
            if (num == true)
            {
                if (num2 == "0")
                {
                    num2 = "9";
                    label4.Text = num2;
                }
                else
                {
                    num2 = num2 + "9";
                    label4.Text = num2;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (num == false)
            {
                if (num1 == "0")
                {
                    num1 = "4";
                    label2.Text = num1;
                }
                else
                {
                    num1 = num1 + "4";
                    label2.Text = num1;
                }
            }
            if (num == true)
            {
                if (num2 == "0")
                {
                    num2 = "4";
                    label4.Text = num2;
                }
                else
                {
                    num2 = num2 + "4";
                    label4.Text = num2;
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            num1 = "0";
            label2.Text = num1;
            num2 = "0";
            label4.Text = num1;
            num3 = 0;
            label6.Text = "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (operation == 0)
            {
                num3 = double.Parse(num1) + double.Parse(num2);
                label6.Text = num3.ToString();
            }
            if (operation == 1)
            {
                num3 = double.Parse(num1) - double.Parse(num2);
                label6.Text = num3.ToString();
            }
            if (operation == 2)
            {
                num3 = double.Parse(num1) * double.Parse(num2);
                label6.Text = num3.ToString();
            }
            if (operation == 3)
            {
                if (num2 == "0")
                {
                    label6.Text = "Cannot Divide by 0";
                }
                else
                {
                    num3 = double.Parse(num1) / double.Parse(num2);
                    label6.Text = num3.ToString();
                }
                
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            num = true;
            label7.Text = "";
            label8.Text = "_";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        public float operation = 0;
        private void button13_Click(object sender, EventArgs e)
        {
            operation = 0;
            label3.Text = "+";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            operation = 1;
            label3.Text = "-";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            operation = 2;
            label3.Text = "x";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            operation = 3;
            label3.Text = "÷";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (num == false)
            {
                
                  num1 = num1 + ".";
                  label2.Text = num1;
                
            }
            if (num == true)
            {
                num2 = num2 + ".";
                label4.Text = num2;
            }
        }
    }
}