namespace UI
{
    partial class UserManage_UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManage_UI));
            this.已借阅的图书 = new System.Windows.Forms.TabPage();
            this.dgvReaderBorrowBook = new System.Windows.Forms.DataGridView();
            this.借阅历史记录 = new System.Windows.Forms.TabPage();
            this.dgvReaderBorrowBookInfoed = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvHeaderInfo = new System.Windows.Forms.DataGridView();
            this.btnExitColumn = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.已借阅的图书.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReaderBorrowBook)).BeginInit();
            this.借阅历史记录.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReaderBorrowBookInfoed)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeaderInfo)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // 已借阅的图书
            // 
            this.已借阅的图书.Controls.Add(this.dgvReaderBorrowBook);
            this.已借阅的图书.Location = new System.Drawing.Point(4, 22);
            this.已借阅的图书.Name = "已借阅的图书";
            this.已借阅的图书.Padding = new System.Windows.Forms.Padding(3);
            this.已借阅的图书.Size = new System.Drawing.Size(797, 229);
            this.已借阅的图书.TabIndex = 0;
            this.已借阅的图书.Text = "已借阅的图书";
            this.已借阅的图书.UseVisualStyleBackColor = true;
            // 
            // dgvReaderBorrowBook
            // 
            this.dgvReaderBorrowBook.AllowUserToAddRows = false;
            this.dgvReaderBorrowBook.AllowUserToDeleteRows = false;
            this.dgvReaderBorrowBook.AllowUserToResizeColumns = false;
            this.dgvReaderBorrowBook.AllowUserToResizeRows = false;
            this.dgvReaderBorrowBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReaderBorrowBook.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvReaderBorrowBook.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvReaderBorrowBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReaderBorrowBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReaderBorrowBook.Location = new System.Drawing.Point(3, 3);
            this.dgvReaderBorrowBook.Name = "dgvReaderBorrowBook";
            this.dgvReaderBorrowBook.RowTemplate.Height = 23;
            this.dgvReaderBorrowBook.Size = new System.Drawing.Size(791, 223);
            this.dgvReaderBorrowBook.TabIndex = 5;
            // 
            // 借阅历史记录
            // 
            this.借阅历史记录.Controls.Add(this.dgvReaderBorrowBookInfoed);
            this.借阅历史记录.Location = new System.Drawing.Point(4, 22);
            this.借阅历史记录.Name = "借阅历史记录";
            this.借阅历史记录.Padding = new System.Windows.Forms.Padding(3);
            this.借阅历史记录.Size = new System.Drawing.Size(797, 229);
            this.借阅历史记录.TabIndex = 1;
            this.借阅历史记录.Text = "借阅历史记录";
            this.借阅历史记录.UseVisualStyleBackColor = true;
            // 
            // dgvReaderBorrowBookInfoed
            // 
            this.dgvReaderBorrowBookInfoed.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvReaderBorrowBookInfoed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvReaderBorrowBookInfoed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReaderBorrowBookInfoed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReaderBorrowBookInfoed.Location = new System.Drawing.Point(3, 3);
            this.dgvReaderBorrowBookInfoed.Name = "dgvReaderBorrowBookInfoed";
            this.dgvReaderBorrowBookInfoed.RowTemplate.Height = 23;
            this.dgvReaderBorrowBookInfoed.Size = new System.Drawing.Size(791, 223);
            this.dgvReaderBorrowBookInfoed.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.已借阅的图书);
            this.tabControl1.Controls.Add(this.借阅历史记录);
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(0, 284);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(805, 255);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Controls.Add(this.dgvHeaderInfo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(127, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(804, 539);
            this.panel2.TabIndex = 2;
            // 
            // dgvHeaderInfo
            // 
            this.dgvHeaderInfo.AllowUserToAddRows = false;
            this.dgvHeaderInfo.AllowUserToDeleteRows = false;
            this.dgvHeaderInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHeaderInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHeaderInfo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvHeaderInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvHeaderInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHeaderInfo.Location = new System.Drawing.Point(0, 0);
            this.dgvHeaderInfo.Name = "dgvHeaderInfo";
            this.dgvHeaderInfo.RowTemplate.Height = 23;
            this.dgvHeaderInfo.Size = new System.Drawing.Size(804, 280);
            this.dgvHeaderInfo.TabIndex = 3;
            this.dgvHeaderInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHeaderInfo_CellContentClick);
            this.dgvHeaderInfo.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvHeaderInfo_RowPostPaint);
            // 
            // btnExitColumn
            // 
            this.btnExitColumn.Location = new System.Drawing.Point(683, 19);
            this.btnExitColumn.Name = "btnExitColumn";
            this.btnExitColumn.Size = new System.Drawing.Size(80, 23);
            this.btnExitColumn.TabIndex = 5;
            this.btnExitColumn.Text = "更改显示列";
            this.btnExitColumn.UseVisualStyleBackColor = true;
            this.btnExitColumn.Click += new System.EventHandler(this.btnExitColumn_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(588, 18);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "64467.jpg.gif");
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(440, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 21);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "关键字";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(238, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "查询字段";
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(3, 69);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(118, 539);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.28321F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.71679F));
            this.tableLayoutPanel1.Controls.Add(this.treeView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.84813F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.15187F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(934, 611);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.btnExitColumn);
            this.panel1.Controls.Add(this.btnSelect);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 60);
            this.panel1.TabIndex = 1;
            // 
            // UserManage_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserManage_UI";
            this.Text = "用户管理";
            this.Load += new System.EventHandler(this.ReaderManager_UI_Load);
            this.已借阅的图书.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReaderBorrowBook)).EndInit();
            this.借阅历史记录.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReaderBorrowBookInfoed)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeaderInfo)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage 已借阅的图书;
        public System.Windows.Forms.DataGridView dgvReaderBorrowBook;
        private System.Windows.Forms.TabPage 借阅历史记录;
        public System.Windows.Forms.DataGridView dgvReaderBorrowBookInfoed;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView dgvHeaderInfo;
        private System.Windows.Forms.Button btnExitColumn;
        public System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
    }
}