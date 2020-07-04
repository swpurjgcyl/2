namespace 族谱管理系统
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.textBox41 = new System.Windows.Forms.TextBox();
            this.button12 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.zupusystemDataSet = new 族谱管理系统.zupusystemDataSet();
            this.成员信息表BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.成员信息表TableAdapter = new 族谱管理系统.zupusystemDataSetTableAdapters.成员信息表TableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.性别DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.生日DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.配偶DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.父母DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zupusystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.成员信息表BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(163, 42);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 25);
            this.textBox11.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "父母";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "配偶";
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(477, 45);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(100, 25);
            this.textBox21.TabIndex = 7;
            // 
            // textBox31
            // 
            this.textBox31.Location = new System.Drawing.Point(163, 109);
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(100, 25);
            this.textBox31.TabIndex = 8;
            // 
            // textBox41
            // 
            this.textBox41.Location = new System.Drawing.Point(477, 109);
            this.textBox41.Name = "textBox41";
            this.textBox41.Size = new System.Drawing.Size(100, 25);
            this.textBox41.TabIndex = 9;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(247, 191);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 10;
            this.button12.Text = "查询";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button1_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(398, 191);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(75, 23);
            this.button21.TabIndex = 11;
            this.button21.Text = "取消";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.姓名DataGridViewTextBoxColumn,
            this.性别DataGridViewTextBoxColumn,
            this.生日DataGridViewTextBoxColumn,
            this.配偶DataGridViewTextBoxColumn,
            this.父母DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.成员信息表BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 279);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(784, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // zupusystemDataSet
            // 
            this.zupusystemDataSet.DataSetName = "zupusystemDataSet";
            this.zupusystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 成员信息表BindingSource
            // 
            this.成员信息表BindingSource.DataMember = "成员信息表";
            this.成员信息表BindingSource.DataSource = this.zupusystemDataSet;
            // 
            // 成员信息表TableAdapter
            // 
            this.成员信息表TableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // 姓名DataGridViewTextBoxColumn
            // 
            this.姓名DataGridViewTextBoxColumn.DataPropertyName = "姓名";
            this.姓名DataGridViewTextBoxColumn.HeaderText = "姓名";
            this.姓名DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.姓名DataGridViewTextBoxColumn.Name = "姓名DataGridViewTextBoxColumn";
            this.姓名DataGridViewTextBoxColumn.Width = 125;
            // 
            // 性别DataGridViewTextBoxColumn
            // 
            this.性别DataGridViewTextBoxColumn.DataPropertyName = "性别";
            this.性别DataGridViewTextBoxColumn.HeaderText = "性别";
            this.性别DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.性别DataGridViewTextBoxColumn.Name = "性别DataGridViewTextBoxColumn";
            this.性别DataGridViewTextBoxColumn.Width = 125;
            // 
            // 生日DataGridViewTextBoxColumn
            // 
            this.生日DataGridViewTextBoxColumn.DataPropertyName = "生日";
            this.生日DataGridViewTextBoxColumn.HeaderText = "生日";
            this.生日DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.生日DataGridViewTextBoxColumn.Name = "生日DataGridViewTextBoxColumn";
            this.生日DataGridViewTextBoxColumn.Width = 125;
            // 
            // 配偶DataGridViewTextBoxColumn
            // 
            this.配偶DataGridViewTextBoxColumn.DataPropertyName = "配偶";
            this.配偶DataGridViewTextBoxColumn.HeaderText = "配偶";
            this.配偶DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.配偶DataGridViewTextBoxColumn.Name = "配偶DataGridViewTextBoxColumn";
            this.配偶DataGridViewTextBoxColumn.Width = 125;
            // 
            // 父母DataGridViewTextBoxColumn
            // 
            this.父母DataGridViewTextBoxColumn.DataPropertyName = "父母";
            this.父母DataGridViewTextBoxColumn.HeaderText = "父母";
            this.父母DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.父母DataGridViewTextBoxColumn.Name = "父母DataGridViewTextBoxColumn";
            this.父母DataGridViewTextBoxColumn.Width = 125;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.textBox41);
            this.Controls.Add(this.textBox31);
            this.Controls.Add(this.textBox21);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zupusystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.成员信息表BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox31;
        private System.Windows.Forms.TextBox textBox41;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.DataGridView dataGridView1;
        private zupusystemDataSet zupusystemDataSet;
        private System.Windows.Forms.BindingSource 成员信息表BindingSource;
        private zupusystemDataSetTableAdapters.成员信息表TableAdapter 成员信息表TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 性别DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 生日DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 配偶DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 父母DataGridViewTextBoxColumn;
    }
}