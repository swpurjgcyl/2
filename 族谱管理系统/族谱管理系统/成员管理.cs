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
    public partial class 成员管理 : Form
    {
        public 成员管理()
        {
            InitializeComponent();

            Table();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 成员管理_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“zupusystemDataSet.成员信息表”中。您可以根据需要移动或删除它。
            this.成员信息表TableAdapter.Fill(this.zupusystemDataSet.成员信息表);

        }

        private void Table()
        {
            string sql = "select * from 成员信息表";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            while(dr.Read())
            {
                string a, b, c, d, e,f;
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





        private void 成员信息表DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 成员信息表DataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 成员信息表DataGridView_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click_1(object sender, EventArgs e)
        {

        }

        //private void toolStripButton1_Click(object sender, EventArgs e)
        //{
            
        //        this.Validate();
        //        this.成员信息表BindingSource.EndEdit();
        //        this.tableAdapterManager.UpdateAll(this.zupusystemDataSet);

            
        //}

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.成员信息表BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zupusystemDataSet);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem1_Click(object sender, EventArgs e)
        {
            //string id, name;
            //id = 成员信息表DataGridView.SelectedCells[0].Value.ToString();
            //name = 成员信息表DataGridView.SelectedCells[1].Value.ToString();
            //string sql = "delete form 成员信息表 where id='"+id+ "'and name =='"+name+"'";
            //Dao dao = new Dao();
            //dao.Excute(sql);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string id, name;
            id = dataGridView1.SelectedCells[0].Value.ToString();
            name= dataGridView1.SelectedCells[1].Value.ToString();
            string sql = "delete from 成员信息表 where ID='" + id + "' and 姓名 ='" + name + "'";
            MessageBox.Show(sql);
            Dao dao = new Dao();
            dao.Excute(sql);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)//刷新按钮，重新显示列表
        {
            Table();

        }
    }
}
