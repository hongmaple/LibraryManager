namespace UI
{
    partial class Main_UI
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripButtonBookManager = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUserManager = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTypeManage = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBorrowReturn = new System.Windows.Forms.ToolStripButton();
            this.toolStripBorrow = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBookAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUserAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSA = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonExit = new System.Windows.Forms.ToolStripButton();
            this.tabControl.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(0, 42);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1054, 551);
            this.tabControl.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1046, 525);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "图书管理";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1046, 525);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "用户管理";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1046, 525);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "图书借还记录";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonBookManager,
            this.toolStripButtonUserManager,
            this.toolStripButtonTypeManage,
            this.toolStripButtonBorrowReturn,
            this.toolStripBorrow,
            this.toolStripButtonBookAdd,
            this.toolStripButtonUserAdd,
            this.toolStripButtonSA,
            this.toolStripButtonAbout,
            this.toolStripButtonExit});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1054, 64);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 593);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1054, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel.Text = "toolStripStatusLabel1";
            // 
            // toolStripButtonBookManager
            // 
            this.toolStripButtonBookManager.Image = global::UI.Properties.Resources.library;
            this.toolStripButtonBookManager.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBookManager.Name = "toolStripButtonBookManager";
            this.toolStripButtonBookManager.Size = new System.Drawing.Size(68, 61);
            this.toolStripButtonBookManager.Text = " 图书管理 ";
            this.toolStripButtonBookManager.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonBookManager.Click += new System.EventHandler(this.toolStripButtonBookManager_Click);
            // 
            // toolStripButtonUserManager
            // 
            this.toolStripButtonUserManager.Image = global::UI.Properties.Resources.user_man_info;
            this.toolStripButtonUserManager.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUserManager.Name = "toolStripButtonUserManager";
            this.toolStripButtonUserManager.Size = new System.Drawing.Size(68, 61);
            this.toolStripButtonUserManager.Text = " 用户管理 ";
            this.toolStripButtonUserManager.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonUserManager.Click += new System.EventHandler(this.toolStripButtonUserManager_Click);
            // 
            // toolStripButtonTypeManage
            // 
            this.toolStripButtonTypeManage.Image = global::UI.Properties.Resources.File;
            this.toolStripButtonTypeManage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTypeManage.Name = "toolStripButtonTypeManage";
            this.toolStripButtonTypeManage.Size = new System.Drawing.Size(68, 61);
            this.toolStripButtonTypeManage.Text = " 分类管理 ";
            this.toolStripButtonTypeManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonTypeManage.Click += new System.EventHandler(this.toolStripButtonTypeManage_Click);
            // 
            // toolStripButtonBorrowReturn
            // 
            this.toolStripButtonBorrowReturn.Image = global::UI.Properties.Resources.Record;
            this.toolStripButtonBorrowReturn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBorrowReturn.Name = "toolStripButtonBorrowReturn";
            this.toolStripButtonBorrowReturn.Size = new System.Drawing.Size(68, 61);
            this.toolStripButtonBorrowReturn.Text = " 借还记录 ";
            this.toolStripButtonBorrowReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonBorrowReturn.Click += new System.EventHandler(this.toolStripButtonBorrowReturn_Click);
            // 
            // toolStripBorrow
            // 
            this.toolStripBorrow.Image = global::UI.Properties.Resources.library3;
            this.toolStripBorrow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBorrow.Name = "toolStripBorrow";
            this.toolStripBorrow.Size = new System.Drawing.Size(68, 61);
            this.toolStripBorrow.Text = " 图书借阅 ";
            this.toolStripBorrow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBorrow.Click += new System.EventHandler(this.toolStripBorrow_Click);
            // 
            // toolStripButtonBookAdd
            // 
            this.toolStripButtonBookAdd.Image = global::UI.Properties.Resources.library2;
            this.toolStripButtonBookAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBookAdd.Name = "toolStripButtonBookAdd";
            this.toolStripButtonBookAdd.Size = new System.Drawing.Size(72, 61);
            this.toolStripButtonBookAdd.Text = "  新增图书 ";
            this.toolStripButtonBookAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonBookAdd.Click += new System.EventHandler(this.toolStripButtonBookAdd_Click);
            // 
            // toolStripButtonUserAdd
            // 
            this.toolStripButtonUserAdd.Image = global::UI.Properties.Resources.user_man_add;
            this.toolStripButtonUserAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUserAdd.Name = "toolStripButtonUserAdd";
            this.toolStripButtonUserAdd.Size = new System.Drawing.Size(68, 61);
            this.toolStripButtonUserAdd.Text = " 新增用户 ";
            this.toolStripButtonUserAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonUserAdd.Click += new System.EventHandler(this.toolStripButtonUserAdd_Click);
            // 
            // toolStripButtonSA
            // 
            this.toolStripButtonSA.Image = global::UI.Properties.Resources.Gear;
            this.toolStripButtonSA.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSA.Name = "toolStripButtonSA";
            this.toolStripButtonSA.Size = new System.Drawing.Size(68, 61);
            this.toolStripButtonSA.Text = " 超管操作 ";
            this.toolStripButtonSA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonSA.Click += new System.EventHandler(this.toolStripButtonSA_Click);
            // 
            // toolStripButtonAbout
            // 
            this.toolStripButtonAbout.AutoSize = false;
            this.toolStripButtonAbout.Image = global::UI.Properties.Resources.about;
            this.toolStripButtonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAbout.Name = "toolStripButtonAbout";
            this.toolStripButtonAbout.Size = new System.Drawing.Size(68, 61);
            this.toolStripButtonAbout.Text = " 关于";
            this.toolStripButtonAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonAbout.Click += new System.EventHandler(this.toolStripButtonAbout_Click);
            // 
            // toolStripButtonExit
            // 
            this.toolStripButtonExit.AutoSize = false;
            this.toolStripButtonExit.Image = global::UI.Properties.Resources._out;
            this.toolStripButtonExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExit.Name = "toolStripButtonExit";
            this.toolStripButtonExit.Size = new System.Drawing.Size(68, 61);
            this.toolStripButtonExit.Text = " 退出";
            this.toolStripButtonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonExit.Click += new System.EventHandler(this.toolStripButtonExit_Click);
            // 
            // Main_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 615);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl);
            this.Name = "Main_UI";
            this.Text = "图书管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonBookManager;
        private System.Windows.Forms.ToolStripButton toolStripButtonUserManager;
        private System.Windows.Forms.ToolStripButton toolStripButtonBorrowReturn;
        private System.Windows.Forms.ToolStripButton toolStripBorrow;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripButton toolStripButtonBookAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonTypeManage;
        private System.Windows.Forms.ToolStripButton toolStripButtonUserAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonAbout;
        private System.Windows.Forms.ToolStripButton toolStripButtonExit;
        private System.Windows.Forms.ToolStripButton toolStripButtonSA;
    }
}