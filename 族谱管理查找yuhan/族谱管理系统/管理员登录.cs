using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 族谱管理系统
{
    public partial class 管理员登录 : Form
    {
        public 管理员登录()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(login())
            {
                timer1.Start();
                textBox1.Visible = false;
                textBox2.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
                //if (pictureBox1.Location.X >150)
                //{
                //    pictureBox1.Location = new Point(pictureBox1.Location.X + 1, pictureBox1.Location.Y);
                //}


            }

        }
        private bool login()
        {
            if (textBox1.Text == "" ||textBox2.Text== "")
            {
                MessageBox.Show("输入不完整","提示",MessageBoxButtons.OK);
                return false;

            }
            else
            {
                //string sql = "select * from 管理员信息 where 账号='+textBox1.Text+' and 密码='+textBox2.Text+'";
                //Dao dao = new Dao();
                //IDataReader dr = dao.read(sql);
               // int i = 0;
                
                if(textBox1.Text=="123"&textBox2.Text=="123")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void 管理员登录_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (pictureBox1.Location.X < 150)
           {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 1, pictureBox1.Location.Y);
           }
            else
            {
                主功能 form1 = new 主功能();
                form1.Show();
                timer1.Stop();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
