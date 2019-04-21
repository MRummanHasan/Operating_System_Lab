using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace Calculator_Marsh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmb_operator.SelectedIndex = 0;
        }

        [DllImport("calcdll.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int Addition(int a, int b);
        [DllImport("calcdll.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int Substraction(int a, int b);
        [DllImport("calcdll.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int Multiply(int a, int b);
        [DllImport("calcdll.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int Division(int a, int b);
        [DllImport("calcdll.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int Sqaure(int a);
        [DllImport("calcdll.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int Cube(int a);

        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(txt_value1.Text);
                int b = Convert.ToInt32(txt_value2.Text);
                switch (cmb_operator.Text)
                {
                    case "+":
                        txt_answer.Text = Addition(a, b).ToString(); break;
                    case "-":
                        txt_answer.Text = Substraction(a, b).ToString(); break;
                    case "*":
                        txt_answer.Text = Multiply(a, b).ToString(); break;
                    case "/":
                        txt_answer.Text = Division(a, b).ToString(); break;
                    case "^2 (square)":
                        txt_answer.Text = Sqaure(a).ToString(); b = 0; break;

                    case "^3 (cube)":
                        txt_answer.Text = Cube(a).ToString(); b = 0; break;
                }

                prev_listbox.Items.Add(a.ToString() + " " + cmb_operator.Text + " " + b.ToString() + " = " + txt_answer.Text.ToString());
            }
            catch { }
        }

        private void cmb_operator_SelectedIndexChanged(object sender, EventArgs e)
        {
            string oper = cmb_operator.SelectedItem.ToString();
            if (oper == "+" || oper == "-" || oper == "*" || oper == "/")
            {
                lbl_value2.Enabled = true;
                txt_value2.Enabled = true;
            }
            else
            {
                lbl_value2.Enabled = false;
                txt_value2.Enabled = false;
            }
        }

        private void btn_submit_Click_1(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(txt_value1.Text);
                int b = Convert.ToInt32(txt_value2.Text);
                switch (cmb_operator.Text)
                {
                    case "+":
                        txt_answer.Text = Addition(a, b).ToString(); break;
                    case "-":
                        txt_answer.Text = Substraction(a, b).ToString(); break;
                    case "*":
                        txt_answer.Text = Multiply(a, b).ToString(); break;
                    case "/":
                        txt_answer.Text = Division(a, b).ToString(); break;
                    case "^2 (square)":
                        txt_answer.Text = Sqaure(a).ToString(); b = 0; break;

                    case "^3 (cube)":
                        txt_answer.Text = Cube(a).ToString(); b = 0; break;
                }

                prev_listbox.Items.Add(a.ToString() + " " + cmb_operator.Text + " " + b.ToString() + " = " + txt_answer.Text.ToString());
            }
            catch { }
        }
    }
}