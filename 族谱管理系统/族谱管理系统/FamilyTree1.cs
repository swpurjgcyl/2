using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace 族谱管理系统
{
    public partial class FamilyTree : Form
    {
        private string ancestor_id;
        public FamilyTree(string ancestor_id)
        {
            this.ancestor_id = ancestor_id;
            InitializeComponent();
        }

        struct member
        {
            public string id;
            public string name;
            public string pid;//成员父亲ID
            public bool isCheck;
        }
        member[] memberInfo = new member[300];


        private void pictureBoxFtree_Paint(object sender, PaintEventArgs e)
        {
            

            string sql = "select * from 成员信息表";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            int i = 0;
            while (dr.Read())
            {
                memberInfo[i].id = dr["ID"].ToString();
                memberInfo[i].name = dr["姓名"].ToString();
                memberInfo[i].pid = dr["父母"].ToString();
                memberInfo[i].isCheck = false;
                i++;
            }
            int memberCount = i;
            

//初始变量
            int midCountFlag = 0;   //画中间结点时用到的偏移量
            int subCountFlag = 0;   //画顶层结点时用到的偏移量
            int x = 0;              //结点矩形图左上角X坐标
            int y = 0;              //结点矩形图左上角Y坐标
            int picX = pictureBoxFtree.Width;   //绘图区域水平长度
            int picY = pictureBoxFtree.Height;  //绘图区域竖直长度
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            Rectangle rect;         //结点矩形图
            Point loc;              //结点矩形图左上角坐标
            Point startP;           //连接线起始坐标
            Point endP;             //连接线终止坐标
            Point tempP = new Point();   //坐标缓存量
            SizeF sizeF;            //结点内容尺寸大小
            Size s;
            Font font = new Font("宋体", 18);     //结点内容的字体
            Pen redPen = new Pen(Color.Red, 2);   //连线需要的画笔
            Graphics g = e.Graphics;
            g.Clear(Color.White);         //每次重绘先把绘图区域清空

//祖先
            string parentTree = "祖先";
            sizeF = g.MeasureString(parentTree, font);
            sizeF.Width += 10;
            s = sizeF.ToSize();

            x = Convert.ToInt32((picX - sizeF.Width) / 2);
            y = 30;
            startP = new Point(picX / 2, y + s.Height);
            loc = new Point(x, y);

            rect = new Rectangle(loc, s);
            g.DrawRectangle(Pens.Black, rect);
            g.DrawString(parentTree, font, Brushes.Black, rect, sf);


            //成员
            for(i=0;i<memberCount;i++)
            {
                
                if (getChild(memberInfo[i].id, memberInfo) != null)
                {
                   
                    for(int j=0;j<5;j++)
                    {
                       
                    }
                    sizeF = g.MeasureString(memberInfo[i].name, font);
                    sizeF.Width += 10;
                    s = sizeF.ToSize();

                    x = Convert.ToInt32((picX - sizeF.Width) / 2);
                    y += 30;
                    startP = new Point(picX / 2, y + s.Height);
                    loc = new Point(x, y);

                    rect = new Rectangle(loc, s);
                    g.DrawRectangle(Pens.Black, rect);
                    g.DrawString(parentTree, font, Brushes.Black, rect, sf);

                }
            }


          
            
            string getChild(string id, member[] a)
            {
                for(int j=0;j<a.Length;j++)
                {

                    while (a[j].pid == id&&a[j].isCheck==false)
                    {
                        a[j].isCheck = true;
                        return a[j].id;                     
                    }
                    return null;
                }return null;
                       
            }
                
        }
    }    
    
}

