using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Model;
using UI;
using BLL;


namespace UI
{
    public partial class BookInfoEdit_UI : Form
    {
        public BookInfoEdit_UI()
        {
            InitializeComponent();
        }
        public string BookId = null;
        public BookInfoManage_UI manager = null;
        List_UI com = new List_UI();

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).FlatStyle = FlatStyle.Standard;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).FlatStyle = FlatStyle.Flat;
        }
        BookInfo_BLL bookInfo = new BookInfo_BLL();
        BookType_BLL bookType = new BookType_BLL();

        public void BookInfoExit_UI_Load(object sender, EventArgs e)
        {
            this.cboBookTypeId.DataSource = bookType.selectBookType();
            this.cboBookTypeId.DisplayMember = "BookTypeName";
            this.cboBookTypeId.ValueMember = "BookTypeId";

            List<BookInfo> list = bookInfo.selectBookInfo(this.BookId);
            txtBookId.Text = list[0].BookId;
            txtBookName.Text = list[0].BookName;
            TimeIn.Value = list[0].TimeIn;
            cboBookTypeId.SelectedValue = list[0].BookTypeId;
            txtAuthor.Text = list[0].Author;
            txtPinYinCode.Text = list[0].PinYinCode;
            txtTranslator.Text = list[0].Translator;
            txtLanguge.Text = list[0].Language;
            txtBookNumber.Text = list[0].BookNumber;
            txtPrice.Text = list[0].Price;
            txtLayout.Text = list[0].Layout;
            txtAddress.Text = list[0].Address;
            txtISBN.Text = list[0].ISBN;
            txtVersions.Text = list[0].Versions;
            txtBookRemark.Text = list[0].BookRemark;
        }
        /// <summary>
        /// 添加图书分类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            TypeManage_UI a = new TypeManage_UI();
            a.tabName = "图书类型";
            a.bookInfoExit = this;
            a.Manager = this.manager;
            a.ShowDialog();
        }
        /// <summary>
        /// 保存修改信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            //创建添加的对象
            BookInfo book = new BookInfo();
            book.BookId = txtBookId.Text.Trim();
            book.BookName = txtBookName.Text.Trim();
            book.TimeIn = TimeIn.Value;
            book.BookTypeId = (int)cboBookTypeId.SelectedValue;
            book.Author = txtAuthor.Text.Trim();
            book.PinYinCode = txtPinYinCode.Text.Trim();
            book.Translator = txtTranslator.Text.Trim();
            book.Language = txtLanguge.Text.Trim();
            book.BookNumber = txtBookNumber.Text.Trim();
            book.Price = txtPrice.Text.Trim();
            book.Layout = txtLayout.Text.Trim();
            book.Address = txtAddress.Text.Trim();
            book.ISBN = txtISBN.Text.Trim();
            book.Versions = txtVersions.Text.Trim();
            book.BookRemark = txtBookRemark.Text.Trim();

            if (bookInfo.ExitBookInfo(book) > 0)
            {
                MessageBox.Show("修改信息成功！");
                //单击查询
                manager.btnSelect_Click(null, null);

                //自动找到刚刚修改成功的行，并选中
                com.AutoFindRow(txtBookId.Text.Trim(), this.manager.dataGridView1);
            }
            else
            {
                MessageBox.Show("修改信息失败！");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
