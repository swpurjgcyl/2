namespace 电子族谱树状图
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("爷爷");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("爸爸");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("女儿");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("儿子");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("妈妈", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("爸爸兄弟儿子");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("爸爸兄弟", new System.Windows.Forms.TreeNode[] {
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("奶奶", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode5,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("家谱", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode8});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(143, 62);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点11";
            treeNode1.Text = "爷爷";
            treeNode2.Name = "节点13";
            treeNode2.Text = "爸爸";
            treeNode3.Name = "节点16";
            treeNode3.Text = "女儿";
            treeNode4.Name = "节点17";
            treeNode4.Text = "儿子";
            treeNode5.Name = "节点14";
            treeNode5.Text = "妈妈";
            treeNode6.Name = "节点18";
            treeNode6.Text = "爸爸兄弟儿子";
            treeNode7.Name = "节点15";
            treeNode7.Text = "爸爸兄弟";
            treeNode8.Name = "节点12";
            treeNode8.Text = "奶奶";
            treeNode9.Name = "节点10";
            treeNode9.Text = "家谱";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9});
            this.treeView1.Size = new System.Drawing.Size(480, 330);
            this.treeView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "添加根";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(453, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "在指定节点添加子树";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

