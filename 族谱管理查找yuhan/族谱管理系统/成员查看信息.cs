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
    public partial class 成员查看信息 : Form
    {
        public 成员查看信息()
        {
            InitializeComponent();
            Table();
        }


        private void Table()
        {
            string sql = "select * from 成员信息表";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                string a, b, c, d, e, f;
                a = dr["ID"].ToString();
                b = dr["姓名"].ToString();
                c = dr["性别"].ToString();
                d = dr["生日"].ToString();
                e = dr["配偶"].ToString();
                f = dr["父母"].ToString();
                string[] str = { a, b, c, d, e, f };
                dataGridView1.Rows.Add(str);

            }

            dr.Close();//读完关闭读取链接

        }






        private void 信息修改_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Table();
        }
    }
}
