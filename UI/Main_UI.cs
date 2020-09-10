using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using System.Threading;

namespace UI
{
    public partial class Main_UI : Form
    {
        public Main_UI()
        {
            InitializeComponent();
        }
        public Admin admin = null;
        BookInfoManage_UI book;
        UserManage_UI reader;
        private void Main_Load(object sender, EventArgs e)
        {
            this.toolStripStatusLabel.Text = "状态：" + admin.LoginType + "\"" + admin.LoginId + "\"已登录.";
            //图书管理窗体的绑定
            book = new BookInfoManage_UI();
            Control.CheckForIllegalCrossThreadCalls = false;
            banding(book, tabPage1);

            //用户管理窗体的绑定
            reader = new UserManage_UI();
            reader.book = book;
            banding(reader, tabPage2);

            //借还历史记录窗体的绑定
            banding(new BorrowHostory_UI(), tabPage3);
        }

        //TabControl的TabPage绑定窗体的公共方法
        public void banding(Form form, TabPage page)
        {
            page.Controls.Clear();
            form.FormBorderStyle = FormBorderStyle.None;
            form.StartPosition = FormStartPosition.Manual;
            form.Size = page.Size;
            form.TopLevel = false;
            page.Controls.Add(form);
            form.Show();

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();  
        }

        //图书管理
        private void toolStripButtonBookManager_Click(object sender, EventArgs e)
        {
            this.tabControl.SelectedIndex = 0;
        }
        //用户管理
        private void toolStripButtonUserManager_Click(object sender, EventArgs e)
        {
            this.tabControl.SelectedIndex = 1;
        }
        //借还记录
        private void toolStripButtonBorrowReturn_Click(object sender, EventArgs e)
        {
            this.tabControl.SelectedIndex = 2;
        }     


        private void menuStripBorrow_Click(object sender, EventArgs e)
        {
            BorrowManage_UI b = new BorrowManage_UI();
            b.ShowDialog();
        }

        private void toolStripBorrow_Click(object sender, EventArgs e)
        {
            BorrowManage_UI b = new BorrowManage_UI();
            b.ShowDialog();
        }

        private void 图书借还记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl.SelectedIndex = 2;
        }

        private void toolStripButtonBookAdd_Click(object sender, EventArgs e)
        {
            book.btnAddBookInfo_Click(null, null);
        }

        private void toolStripButtonTypeManage_Click(object sender, EventArgs e)
        {
            TypeManage_UI a = new TypeManage_UI();
            a.tabName = "图书类型";
            a.Manager = this.book;
            a.ShowDialog();
        }

        private void toolStripButtonUserAdd_Click(object sender, EventArgs e)
        {
            reader.btnAddReaderInfo_Click(null, null);
        }

        private void toolStripButtonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Design by HD");
        }

        private void toolStripButtonExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确认退出", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void toolStripButtonSA_Click(object sender, EventArgs e)
        {
            if (admin.LoginType == "超管")
            {
                MessageBox.Show("尚未开放");
            }
            else
            {
                MessageBox.Show("只有超管能使用此功能");
            }
        }





    }
}
