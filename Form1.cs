using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 查询窗体
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = @"Data Source = DESKTOP-G9BAOAP; Initial Catalog = test;
                             User ID = sa; Password = 123456";
            string id = label6.Text;
            conn.Open();
            SqlConnection conn = new SqlConnection(connString);
            string sql = @"select * from zjjstudent WHERE [ID]='" + label6.Text + "';
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader sp = cmd.ExecuteReader();
            if (!sp.Read())
            {
                MessageBox.Show("未找到成员ID为" + id + "的成员");
                return;
            }
            label6.Text = sp["ID"].ToString();
            a.Text = sp["name"].ToString();
            label2.Text = sp["sex"].ToString();
            label3.Text = sp["DID"].ToString();
            label4.Text = sp["FID"].ToString();
            label5.Text = sp["rank"].ToString();
            label7.Text = sp["birth"].ToString();
            label8.Text = sp["death"].ToString();
        }
    }
}
