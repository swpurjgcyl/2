using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 族谱管理系统
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sconn = new SqlConnection("Data Source=DESKTOP-J9A7P77;Initial Catalog=pubs;Integrated Security=True");
            sconn.Open();
            string str = "select * from student ";
            if (textBox11.Text.Trim().Length > 0)
            {
                str += "where ID=" + Convert.ToInt32(textBox11.Text);

            }
            if (textBox21.Text.Trim().Length > 0)
            {
                if (str.Contains("where"))
                {
                    str += "and 名称='" + textBox21.Text + "'";
                }
                else
                {
                    str += "where 名称='" + textBox21.Text + "'";
                }
            }
            if (textBox31.Text.Trim().Length > 0)
            {
                if (str.Contains("where"))
                {
                    str += " and 父母=" + Convert.ToInt32(textBox31.Text);
                }
                else
                {
                    str += "where 父母=" + Convert.ToInt32(textBox31.Text);
                }
            }
            if (textBox41.Text.Trim().Length > 0)
            {
                if (str.Contains("where"))
                {
                    str += " and 配偶=" + Convert.ToInt32(textBox41.Text);
                }
                else
                {
                    str += "where 配偶=" + Convert.ToInt32(textBox41.Text);
                }
            }

            SqlCommand comm = new SqlCommand(str, sconn);
            comm.ExecuteNonQuery();
            SqlDataAdapter sd = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            sd.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            sconn.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“zupusystemDataSet.成员信息表”中。您可以根据需要移动或删除它。
            this.成员信息表TableAdapter.Fill(this.zupusystemDataSet.成员信息表);

        }
    }
}
