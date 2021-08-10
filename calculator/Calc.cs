using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculator
{
    public class Calc
    {
        // A list of all characters in an expression
        private readonly List<char> chars;
        // A stack of operators
        private readonly Stack<char> operators;
        // A stack of values
        private readonly Stack<double> values;

        public Calc(string expressionString)
        {
            chars = expressionString.ToCharArray().ToList();
            operators = new Stack<char>();
            values = new Stack<double>();
        }

        // Get final result
        public double GetResult()
        {
            for (int i = 0; i < chars.Count; i++)
            {
                // Condition if char is a digit
                if (chars[i] >= '0' && chars[i] <= '9' || chars[i] == '.')
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append(chars[i++]);

                    if (i < chars.Count && chars[i] == '.')
                    {
                        sb.Append(',');
                        i++;
                    }

                    while (i < chars.Count && chars[i] >= '0' && chars[i] <= '9')
                    {
                        sb.Append(chars[i++]);

                        if (i < chars.Count && chars[i] == '.')
                        {
                            sb.Append(',');
                            i++;
                        }
                    }

                    values.Push(Double.Parse(sb.ToString()));
                }

                // Condition if a digit is less than 0
                if (i < chars.Count)
                {
                    if (chars[i] == '(')
                    {
                        RemoveParentheses(ref i);
                    }
                }

                // Condition if there are parentheses 
                if (i < chars.Count)
                {
                    if (chars[i] == '(')
                    {
                        operators.Push(chars[i]);
                    }
                    else if (chars[i] == ')')
                    {
                        while (operators.Peek() != '(')
                        {
                            values.Push(ApproveOperation(operators.Pop(), values.Pop(), values.Pop()));
                        }
                        operators.Pop();
                    }
                    else
                    {
                        // Condition if character is an operator
                        if (chars[i] == '+' || chars[i] == '-' || chars[i] == '*' || chars[i] == '/' || chars[i] == '^')
                        {
                            while (operators.Count > 0 && HasPriority(operators.Peek(), chars[i]))
                            {
                                values.Push(ApproveOperation(operators.Pop(), values.Pop(), values.Pop()));
                            }

                            operators.Push(chars[i]);
                        }
                    }
                }
            }

            while (operators.Count > 0)
                values.Push(ApproveOperation(operators.Pop(), values.Pop(), values.Pop()));

            return values.Pop();
        }

        // Check operators priority
        private bool HasPriority(char op1, char op2)
        {
            if (op1 == '(' || op1 == ')')
                return false;
            if ((op1 == '+') || (op1 == '-') && (op2 == '*') || (op2 == '/'))
                return false;
            if (op2 == '^')
                return false;
            else
                return true;
        }

        // Execute single operatoin
        private double ApproveOperation(char op, double b, double a)
        {
            switch (op)
            {
                case '+': return a + b;
                case '-': return a - b;
                case '*': return a * b;
                case '/':
                    if (b == 0)
                    {
                        MessageBox.Show("Attempt to divide by zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    return a / b;
                case '^': return Math.Pow(a, b);
            }
            return 0;
        }

        // Remove parentheses from negative numbers and add them to values stack
        private void RemoveParentheses(ref int i)
        {
            if (chars[++i] == '-')
            {
                StringBuilder sb = new StringBuilder();
                chars.RemoveAt(--i);
                sb.Append(chars[i++]);

                if (i < chars.Count && chars[i] == '.')
                {
                    sb.Append(',');
                    i++;
                }

                if (chars[i] >= '0' && chars[i] <= '9' || chars[i] == '.')
                {
                    while (i < chars.Count && chars[i] >= '0' && chars[i] <= '9')
                    {
                        sb.Append(chars[i++]);

                        if (i < chars.Count && chars[i] == '.')
                        {
                            sb.Append(',');
                            i++;
                        }
                    }
                }

                values.Push(Double.Parse(sb.ToString()));
                chars.RemoveAt(i);
            }
            else
            {
                i--;
            }
        }

        public static double GetSquareRoot(string valueString)
        {
            try
            {
                if (valueString.Contains("."))
                    valueString = valueString.Replace(".", ",");

                double value = Double.Parse(valueString);
                return Math.Sqrt(value);
            }
            catch
            {
                MessageBox.Show("Input string has a wrong format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return 0;
        }

        public static long GetFactorial(int value)
        {
            try
            {
                if (value == 0)
                {
                    return 1;
                }

                return value * GetFactorial(value - 1);
            }
            catch
            {
                MessageBox.Show("Input string has a wrong format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return 0;
        }

        public static double GetMinusOneDegree(string valueString)
        {
            try
            {
                if (valueString.Contains("."))
                    valueString = valueString.Replace(".", ",");

                double value = Double.Parse(valueString);
                return Math.Pow(value, -1);
            }
            catch
            {
                MessageBox.Show("Input string has a wrong format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return 0;
        }
    }
}
