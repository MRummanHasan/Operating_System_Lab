using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multithreadedForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Thread th = new Thread(startNewForm);
            th.Name = "MainThread";

            th.Start();


        }

        public void startNewForm(object obj)
        {
            Form2 ftwo = new Form2();
            ftwo.Show();
        }
    }
}
