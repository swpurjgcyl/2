﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 族谱管理系统
{
    public partial class 主功能 : Form
    {
        public 主功能()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            成员管理 c1 = new 成员管理();
            c1.Show();
        }

        private void 主功能_Load(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void 主功能_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
