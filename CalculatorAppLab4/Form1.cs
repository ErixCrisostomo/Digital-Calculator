using System;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CalculatorAppLab4
{
    public partial class Form1 : Form
    {
        double firstNumber = 0;
        string operation = "";
        bool isOperationClicked = false;

        public Form1()
        {
            InitializeComponent();
            ApplyRoundedCorners();
            AddHoverEffects(this);
        }

        private void input_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void RoundButton(System.Windows.Forms.Button btn, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(btn.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(btn.Width - radius, btn.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, btn.Height - radius, radius, radius), 90, 90);
            path.CloseFigure();

            btn.Region = new Region(path);
        }

        private void ApplyRoundedCorners()
        {
            int radius = 25;

            RoundButton(btn_0, radius);
            RoundButton(btn_1, radius);
            RoundButton(btn_2, radius);
            RoundButton(btn_3, radius);
            RoundButton(btn_4, radius);
            RoundButton(btn_5, radius);
            RoundButton(btn_6, radius);
            RoundButton(btn_7, radius);
            RoundButton(btn_8, radius);
            RoundButton(btn_9, radius);

            RoundButton(btn_add, radius);
            RoundButton(btn_minus, radius);
            RoundButton(btn_multiply, radius);
            RoundButton(btn_divide, radius);
            RoundButton(btn_equal, radius);
            RoundButton(btn_mod, radius);
            RoundButton(btn_CE, radius);
            RoundButton(btn_Del, radius);
            RoundButton(btn_dec, radius);
        }

        private void AddHoverEffects(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is System.Windows.Forms.Button btn)
                {
                    if (btn.Tag == null)
                        btn.Tag = btn.BackColor;

                    btn.MouseEnter += Button_MouseEnter;
                    btn.MouseLeave += Button_MouseLeave;
                }
                else if (ctrl.HasChildren)
                {
                    AddHoverEffects(ctrl);
                }
            }
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.Control ctrl = sender as System.Windows.Forms.Control;
            if (ctrl is System.Windows.Forms.Button btn)
            {
                btn.BackColor = System.Drawing.Color.Tomato;
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.Button btn)
            {
                if (btn.Tag is System.Drawing.Color originalColor)
                {
                    btn.BackColor = originalColor;
                }
                else
                {
                    btn.BackColor = System.Drawing.SystemColors.Control;
                }
            }
        }

        private void btn_0_Click(object sender, EventArgs e) => AppendNumber("0");
        private void btn_1_Click(object sender, EventArgs e) => AppendNumber("1");
        private void btn_2_Click(object sender, EventArgs e) => AppendNumber("2");
        private void btn_3_Click(object sender, EventArgs e) => AppendNumber("3");
        private void btn_4_Click(object sender, EventArgs e) => AppendNumber("4");
        private void btn_5_Click(object sender, EventArgs e) => AppendNumber("5");
        private void btn_6_Click(object sender, EventArgs e) => AppendNumber("6");
        private void btn_7_Click(object sender, EventArgs e) => AppendNumber("7");
        private void btn_8_Click(object sender, EventArgs e) => AppendNumber("8");
        private void btn_9_Click(object sender, EventArgs e) => AppendNumber("9");

        private void AppendNumber(string number)
        {
            if (isOperationClicked)
            {
                input.Text = "";
                isOperationClicked = false;
            }

            input.Text += number;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (input.Text != "" && !input.Text.Contains(" + ") &&
                !input.Text.Contains(" - ") && !input.Text.Contains(" * ") &&
                !input.Text.Contains(" / ") && !input.Text.Contains(" % "))
            {
                input.Text += " + ";
            }
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            if (input.Text != "" && !input.Text.Contains(" + ") &&
                !input.Text.Contains(" - ") && !input.Text.Contains(" * ") &&
                !input.Text.Contains(" / ") && !input.Text.Contains(" % "))
            {
                input.Text += " - ";
            }
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            if (input.Text != "" && !input.Text.Contains(" + ") &&
                !input.Text.Contains(" - ") && !input.Text.Contains(" * ") &&
                !input.Text.Contains(" / ") && !input.Text.Contains(" % "))
            {
                input.Text += " * ";
            }
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            if (input.Text != "" && !input.Text.Contains(" + ") &&
                !input.Text.Contains(" - ") && !input.Text.Contains(" * ") &&
                !input.Text.Contains(" / ") && !input.Text.Contains(" % "))
            {
                input.Text += " / ";
            }
        }

        private void btn_mod_Click(object sender, EventArgs e)
        {
            if (input.Text != "" && !input.Text.Contains(" + ") &&
                !input.Text.Contains(" - ") && !input.Text.Contains(" * ") &&
                !input.Text.Contains(" / ") && !input.Text.Contains(" % "))
            {
                input.Text += " % ";
            }
        }

        private void SetOperation(string op)
        {
            if (double.TryParse(input.Text, out firstNumber))
            {
                operation = op;
                isOperationClicked = true;
            }
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            string expression = input.Text.Trim();
            string[] parts = expression.Split(' ');

            if (parts.Length != 3)
            {
                MessageBox.Show("Please enter a valid expression with two operands and one operator.");
                return;
            }

            if (!double.TryParse(parts[0], out double firstNumber) ||
                !double.TryParse(parts[2], out double secondNumber))
            {
                MessageBox.Show("Invalid numbers entered.");
                return;
            }

            string op = parts[1];
            double result;

            switch (op)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    if (secondNumber == 0)
                    {
                        textBox1.Text = "Undefined";
                        return;
                    }
                    result = firstNumber / secondNumber;
                    break;

                case "%":
                    if (secondNumber == 0)
                    {
                        textBox1.Text = "Undefined";
                        return;
                    }
                    result = firstNumber % secondNumber;
                    break;
                default:
                    MessageBox.Show("Unknown operator.");
                    return;
            }


            textBox1.Text = result.ToString();
        }


        private void btn_CE_Click(object sender, EventArgs e)
        {
            input.Clear();
            textBox1.Clear();
            firstNumber = 0;
            operation = "";
        }
        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (input.Text.Length > 0)
            {
                input.Text = input.Text.Substring(0, input.Text.Length - 1);
            }
        }

        private void btn_dec_Click(object sender, EventArgs e)
        {
            if (!input.Text.Contains("."))
            {
                input.Text += ".";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
