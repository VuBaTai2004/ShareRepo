using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Lab2 : Form
    {
        public Lab2()
        {
            InitializeComponent();
        }

        private void Bai01_Click(object sender, EventArgs e)
        {
            Bai1 a = new Bai1();
            a.Show();
        }

        private void Bai02_Click(object sender, EventArgs e)
        {
            Bai2 a = new Bai2();
            a.Show();
        }

        private void Bai3_Click(object sender, EventArgs e)
        {
            Bai3 a = new Bai3();
            a.Show();
        }

        private void Bai04_Click(object sender, EventArgs e)
        {
            Bai4 a = new Bai4();
            a.Show();
        }

        private void Bai05_Click(object sender, EventArgs e)
        {

        }

        private void Bai06_Click(object sender, EventArgs e)
        {
            Bai6 a = new Bai6();
            a.Show();
        }
    }
}
