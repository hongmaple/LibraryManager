namespace UI
{
    partial class BorrowManage_UI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvBookInfo = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvBorrowed = new System.Windows.Forms.DataGridView();
            this.dgvReaderInfo = new System.Windows.Forms.DataGridView();
            this.labBorrowBook = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSelctReader = new System.Windows.Forms.Button();
            this.btnSelectBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookInfo)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReaderInfo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBookInfo
            // 
            this.dgvBookInfo.AllowUserToAddRows = false;
            this.dgvBookInfo.AllowUserToDeleteRows = false;
            this.dgvBookInfo.AllowUserToResizeColumns = false;
            this.dgvBookInfo.AllowUserToResizeRows = false;
            this.dgvBookInfo.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvBookInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookInfo.Location = new System.Drawing.Point(13, 47);
            this.dgvBookInfo.Name = "dgvBookInfo";
            this.dgvBookInfo.ReadOnly = true;
            this.dgvBookInfo.RowTemplate.Height = 23;
            this.dgvBookInfo.Size = new System.Drawing.Size(802, 168);
            this.dgvBookInfo.TabIndex = 8;
            this.dgvBookInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookInfo_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSelctReader);
            this.groupBox2.Controls.Add(this.dgvBorrowed);
            this.groupBox2.Controls.Add(this.dgvReaderInfo);
            this.groupBox2.Controls.Add(this.labBorrowBook);
            this.groupBox2.Controls.Add(this.txtUserId);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(827, 315);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "还书，续借";
            // 
            // dgvBorrowed
            // 
            this.dgvBorrowed.AllowUserToAddRows = false;
            this.dgvBorrowed.AllowUserToDeleteRows = false;
            this.dgvBorrowed.AllowUserToResizeColumns = false;
            this.dgvBorrowed.AllowUserToResizeRows = false;
            this.dgvBorrowed.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvBorrowed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrowed.Location = new System.Drawing.Point(14, 100);
            this.dgvBorrowed.Name = "dgvBorrowed";
            this.dgvBorrowed.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvBorrowed.RowTemplate.Height = 23;
            this.dgvBorrowed.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvBorrowed.Size = new System.Drawing.Size(802, 168);
            this.dgvBorrowed.TabIndex = 13;
            this.dgvBorrowed.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBorrowed_CellContentClick);
            this.dgvBorrowed.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvBorrowed_RowPostPaint);
            // 
            // dgvReaderInfo
            // 
            this.dgvReaderInfo.AllowUserToAddRows = false;
            this.dgvReaderInfo.AllowUserToDeleteRows = false;
            this.dgvReaderInfo.AllowUserToResizeColumns = false;
            this.dgvReaderInfo.AllowUserToResizeRows = false;
            this.dgvReaderInfo.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvReaderInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReaderInfo.Location = new System.Drawing.Point(13, 45);
            this.dgvReaderInfo.Name = "dgvReaderInfo";
            this.dgvReaderInfo.ReadOnly = true;
            this.dgvReaderInfo.RowHeadersVisible = false;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvReaderInfo.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReaderInfo.RowTemplate.Height = 23;
            this.dgvReaderInfo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvReaderInfo.Size = new System.Drawing.Size(802, 40);
            this.dgvReaderInfo.TabIndex = 14;
            this.dgvReaderInfo.DataSourceChanged += new System.EventHandler(this.dgvReaderInfo_DataSourceChanged);
            // 
            // labBorrowBook
            // 
            this.labBorrowBook.AutoSize = true;
            this.labBorrowBook.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labBorrowBook.ForeColor = System.Drawing.Color.OrangeRed;
            this.labBorrowBook.Location = new System.Drawing.Point(11, 85);
            this.labBorrowBook.Name = "labBorrowBook";
            this.labBorrowBook.Size = new System.Drawing.Size(67, 14);
            this.labBorrowBook.TabIndex = 10;
            this.labBorrowBook.Text = "已借图书";
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(71, 18);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(128, 21);
            this.txtUserId.TabIndex = 12;
            this.txtUserId.TextChanged += new System.EventHandler(this.txtUserId_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "用户编号";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelectBook);
            this.groupBox1.Controls.Add(this.txtBookId);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dgvBookInfo);
            this.groupBox1.Location = new System.Drawing.Point(12, 333);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(829, 265);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "借书";
            // 
            // txtBookId
            // 
            this.txtBookId.Location = new System.Drawing.Point(70, 20);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(128, 21);
            this.txtBookId.TabIndex = 10;
            this.txtBookId.TextChanged += new System.EventHandler(this.txtBookId_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "图书编号";
            // 
            // btnSelctReader
            // 
            this.btnSelctReader.BackgroundImage = global::UI.Properties.Resources.search;
            this.btnSelctReader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSelctReader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelctReader.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSelctReader.Location = new System.Drawing.Point(205, 16);
            this.btnSelctReader.Name = "btnSelctReader";
            this.btnSelctReader.Size = new System.Drawing.Size(42, 23);
            this.btnSelctReader.TabIndex = 16;
            this.btnSelctReader.UseVisualStyleBackColor = true;
            this.btnSelctReader.Click += new System.EventHandler(this.btnSelctReader_Click);
            // 
            // btnSelectBook
            // 
            this.btnSelectBook.BackgroundImage = global::UI.Properties.Resources.search;
            this.btnSelectBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSelectBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectBook.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSelectBook.Location = new System.Drawing.Point(205, 18);
            this.btnSelectBook.Name = "btnSelectBook";
            this.btnSelectBook.Size = new System.Drawing.Size(42, 23);
            this.btnSelectBook.TabIndex = 11;
            this.btnSelectBook.UseVisualStyleBackColor = true;
            this.btnSelectBook.Click += new System.EventHandler(this.btnSelectBook_Click);
            // 
            // BorrowManage_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 609);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BorrowManage_UI";
            this.Text = "图书借阅";
            this.Load += new System.EventHandler(this.BorrowManager_UI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookInfo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReaderInfo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBookInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSelctReader;
        private System.Windows.Forms.DataGridView dgvBorrowed;
        private System.Windows.Forms.DataGridView dgvReaderInfo;
        private System.Windows.Forms.Label labBorrowBook;
        public System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSelectBook;
        public System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.Label label7;
    }
}