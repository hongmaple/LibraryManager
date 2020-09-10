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
using BLL;
using UI;

namespace UI
{
    public partial class BookInfoAdd_UI : Form
    {
        public BookInfoAdd_UI()
        {
            InitializeComponent();
        }
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

        public void BookInfoAdd_UI_Load(object sender, EventArgs e)
        {
            this.cboBookTypeId.DataSource = bookType.selectBookType();
            this.cboBookTypeId.DisplayMember = "BookTypeName";
            this.cboBookTypeId.ValueMember = "BookTypeId";
        }
        /// <summary>
        /// 添加图书信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //图书编号必须唯一
            int rows = this.manager.dataGridView1.RowCount;
            lab.Text = "";
            for (int i = 0; i < rows; i++)
            {
                string Columns1 = this.manager.dataGridView1.Rows[i].Cells[0].Value.ToString();
                if (Columns1 == txtBookId.Text.Trim())
                {
                    lab.Text = "图书编号已存在！";
                    return;
                }
            }

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

            if (bookInfo.AddBookInfo(book) > 0)
            {
                MessageBox.Show("添加信息成功！");
                //图书类型信息的绑定
                manager.dataGridView1.DataSource = manager.bookInfo_bll.selectBookInfo1().Tables[0];

                //自动找到刚刚添加成功的新行，并选中
                com.AutoFindRow(txtBookId.Text.Trim(), this.manager.dataGridView1);
            }
            else
            {
                MessageBox.Show("添加信息失败！");
            }
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
            a.bookInfoAdd = this;
            a.Manager = this.manager;
            a.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
