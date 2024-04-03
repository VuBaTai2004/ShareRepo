using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void btn_ReadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs;
            try
            {
                fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
            }
            catch (Exception)
            {
                return;
            }
            StreamReader rd = new StreamReader(fs);
            textOutput.Text = rd.ReadToEnd();
            rd.Close();
        }

        private void btn_WriteFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs;
            try
            {
                fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate, FileAccess.Write);
            }
            catch (Exception)
            {
                return;
            }
            StreamWriter writer = new StreamWriter(fs);
            string FileContent = textOutput.Text;
            string command = "";
            string Postfix;
            double result;
            for (int index = 0; index < FileContent.Length; index++)
            {
                if (FileContent[index] == '\n' || index == FileContent.Length - 1)
                {
                    Postfix = InfixToPostfix(command);
                    writer.Write(command);
                    writer.Write(" = ");
                    command = "";
                    result = evaluatePostfix(Postfix);
                    result = Math.Round(result, 2);
                    writer.WriteLine(result);
                }
                else
                {
                    command += FileContent[index];
                }
            }
            writer.Close();
        }
        internal static int Prec(char ch)
        {
            switch (ch)
            {
                case '(':
                    {
                        return 0;
                    }
                case '+':
                case '-':
                    {
                        return 1;
                    }
                case '*':
                case '/':
                    {
                        return 2;
                    }
            }
            return 3;
        }

        public static string InfixToPostfix(string Infix)
        {
            string result = "";
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < Infix.Length; ++i)
            {
                char c = Infix[i];
                if (char.IsLetterOrDigit(c))
                {
                    result += c;
                }
                else if (c == '(')
                {
                    stack.Push(c);
                }
                else if (c == ')')
                {
                    while (stack.Count > 0 && stack.Peek() != '(')
                    {
                        result += stack.Pop();
                    }

                    if (stack.Count > 0 && stack.Peek() != '(')
                    {
                        return "Invalid Expression";
                    }
                    else
                    {
                        stack.Pop();
                    }
                }
                else
                {
                    while (stack.Count > 0 && Prec(c) <= Prec(stack.Peek()))
                    {
                        result += stack.Pop();
                    }
                    stack.Push(c);
                }
            }
            while (stack.Count > 0)
            {
                result += stack.Pop();
            }
            return result;
        }

        public static double evaluatePostfix(string Postfix)
        {
            Stack<double> stack = new Stack<double>();
            for (int index = 0; index < Postfix.Length; index++)
            {
                char c = Postfix[index];
                if (c == ' ')
                {
                    continue;
                }

                else if (char.IsDigit(c))
                {
                    double number = 0;

                    while (char.IsDigit(c))
                    {
                        number = number * 10 + (double)(c - '0');
                        index++;
                        c = Postfix[index];
                    }
                    index--;
                    stack.Push(number);
                }

                else
                {
                    double val1 = stack.Pop();
                    double val2 = stack.Pop();
                    switch (c)
                    {
                        case '+':
                            stack.Push(val2 + val1);
                            break;

                        case '-':
                            stack.Push(val2 - val1);
                            break;

                        case '/':
                            stack.Push(val2 / val1);
                            break;

                        case '*':
                            stack.Push(val2 * val1);
                            break;
                    }
                }
            }
            return stack.Pop();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
