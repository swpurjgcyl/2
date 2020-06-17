using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == ""||textBox3.Text == "" || textBox4.Text == ""|| textBox5.Text == ""||textBox6.Text == "")
            {
                MessageBox.Show("输入不完整", "提示", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            
            }
            else
            {
                string sql = "Insert into 成员信息表 values('"+ textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
                MessageBox.Show(sql);
                Dao dao = new Dao();
                int i = dao.Excute(sql);
                if(i>0)
                {
                    MessageBox.Show("插入成功");
                }
            }




        }

        private void datatime1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
