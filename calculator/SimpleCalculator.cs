using System;
using System.Windows.Forms;

namespace calculator
{
    public partial class SimpleCalculator : Form
    {
        public SimpleCalculator()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            one.Click += (s, e) => { textBox.Text += "1"; };
            two.Click += (s, e) => { textBox.Text += "2"; };
            three.Click += (s, e) => { textBox.Text += "3"; };
            four.Click += (s, e) => { textBox.Text += "4"; };
            five.Click += (s, e) => { textBox.Text += "5"; };
            six.Click += (s, e) => { textBox.Text += "6"; };
            seven.Click += (s, e) => { textBox.Text += "7"; };
            eight.Click += (s, e) => { textBox.Text += "8"; };
            nine.Click += (s, e) => { textBox.Text += "9"; };
            zero.Click += (s, e) => { textBox.Text += "0"; };
            dot.Click += (s, e) => { textBox.Text += "."; };
            add.Click += (s, e) => { textBox.Text += "+"; };
            subtract.Click += (s, e) => { textBox.Text += "-"; };
            multiply.Click += (s, e) => { textBox.Text += "*"; };
            divide.Click += (s, e) => { textBox.Text += "/"; };
            openingBrace.Click += (s, e) => { textBox.Text += "("; };
            closingBrace.Click += (s, e) => { textBox.Text += ")"; };
            pow.Click += (s, e) => { textBox.Text += "^"; };
            powMinusOne.Click += (s, e) => { textBox.Text = Calc.GetMinusOneDegree(textBox.Text).ToString(); };
            squareRoot.Click += (s, e) => { textBox.Text = Calc.GetSquareRoot(textBox.Text).ToString(); };
            factorial.Click += (s, e) => 
            {
                textBox.Text = (Int32.TryParse(textBox.Text, out int res)) ?
                    Calc.GetFactorial(res).ToString() : "";
            };
            clear.Click += (s, e) => 
            {
                textBox.Text = (textBox.Text.Length > 0) ?
                    textBox.Text.Remove(textBox.Text.Length - 1, 1) : String.Empty;
            };
            reset.Click += (s, e) => { textBox.Text = String.Empty; };
            execute.Click += (s, e) => Calculate();
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Back || e.KeyChar == '.' || e.KeyChar == '!' ||
                    e.KeyChar == '(' || e.KeyChar == ')' || e.KeyChar == '^' || e.KeyChar == '+' ||
                    e.KeyChar == '*' || e.KeyChar == '/' || e.KeyChar == '+' || e.KeyChar == '-')
                { }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Calculate();
            }
        }

        private void Calculate()
        {
            try
            {
                Calc calc = new Calc(textBox.Text);
                textBox.Text = calc.GetResult().ToString();
            }
            catch
            {
                MessageBox.Show("Input string has wrong format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
