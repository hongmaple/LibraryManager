using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using UI;
using Model;
using System.Reflection;
using System.Data.SqlClient;

namespace UI
{
    public partial class BookInfoManage_UI : Form
    {
        public BookInfoManage_UI()
        {
            InitializeComponent();
        }
        public BookInfo_BLL bookInfo_bll = new BookInfo_BLL();
        BookType_BLL bookType_bll = new BookType_BLL();
        List_UI autocoumns = new List_UI();
        public BorrowReturn_BLL borrowReturn_bll = new BorrowReturn_BLL();

        //树绑定
        public void TreeViewBand()
        {
            //图书类型的集合
            List<BookType> list1 = bookType_bll.selectBookType();
            TreeNode nod = new TreeNode();
            nod.Text = "图书类型";
            nod.ImageIndex = 0;
            treeView1.Nodes.Add(nod);

            foreach (BookType k in list1)
            {
                TreeNode node = new TreeNode();
                node.Text = k.BookTypeName;
                node.Tag = k.BookTypeId;
                node.ImageIndex = 0;
                nod.Nodes.Add(node);
            }

            treeView1.ExpandAll();
        }

        private void BookInfoManager_UI_Load(object sender, EventArgs e)
        {
            #region DataGridView1绑定
            //需要添加列的列标题字符串
            string arraysHeaderText = @"图书编号,图书名称,登记时间,图书类型,作者,拼音码,翻译者,语言,页数,价格,印刷版面,存放位置,ISBN码,版本,描述";
            //需要绑定数据库列名称的字符串
            string arraysName = @"BookId,BookName,TimeIn,BookTypeName,Author,PinYinCode,Translator,Language,BookNumber,Price,Layout,Address,ISBN,Versions,BookRemark";


            //自动生成columns
            autocoumns.AutoColumn(arraysHeaderText, arraysName, dataGridView1);
            dataGridView1.DataSource = bookInfo_bll.selectBookInfo1().Tables[0];
            autocoumns.AddColumn("修改", dataGridView1);
            autocoumns.AddColumn("删除", dataGridView1);

            //DataGridView1数据集绑定
            this.dataGridView1.DataSource = bookInfo_bll.selectBookInfo1().Tables[0];
            //窗体加载时默认隐藏的列
            this.dataGridView1.Columns[14].Visible = false;
            this.dataGridView1.Columns[13].Visible = false;
            this.dataGridView1.Columns[12].Visible = false;
            this.dataGridView1.Columns[11].Visible = false;
            this.dataGridView1.Columns[10].Visible = false;
            #endregion

            #region 下拉框绑定

            DataGridViewColumnCollection columns = dataGridView1.Columns;

            for (int i = 0; i < columns.Count - 2; i++)
            {
                comboBox1.Items.Add(columns[i].HeaderText);
            }
            comboBox1.Items.Insert(0, "全部");
            comboBox1.SelectedIndex = 0;

            #endregion

            #region 树状图的绑定

            TreeViewBand();

            #endregion

            #region DgvHostory绑定

            string Header1 = @"图书编号,图书名称,用户编号,用户名称,借出时间,书应归还时间,实际归还时间,应付罚金,续借次数,借还描述";
            string PropertyNames1 = @"BookId,BookName,UserId,UserName,BorrowTime,ReturnTime,FactReturnTime,Fine,RenewCount,BorrowRemark";
            //自动生成columns
            autocoumns.AutoColumn(Header1, PropertyNames1, dgvHostory);

            #endregion
        }
        /// <summary>
        /// 树控件更改选定内容的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Level == 0)
            {
                dataGridView1.DataSource = bookInfo_bll.selectBookInfo1().Tables[0];
            }
            else if (treeView1.SelectedNode.Level == 1)
            {
                int index = (int)treeView1.SelectedNode.Tag;
                dataGridView1.DataSource = bookInfo_bll.selectBookInfo1(index).Tables[0];
            }
            //如果用户信息表中查不到一条数据，相关表的数据也清空
            if (dataGridView1.Rows.Count == 0)
            {
                dgvHostory.DataSource = null;
                return;
            }
        }

        /// <summary>
        /// 当编辑绑定完 DataGridView所有单元格之后，执行绘制引发的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(e.RowBounds.Location.X,
               e.RowBounds.Location.Y,
               dataGridView1.RowHeadersWidth - 4,
               e.RowBounds.Height);

            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                dataGridView1.RowHeadersDefaultCellStyle.Font,
                rectangle,
                dataGridView1.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BookInfoEditRows_UI b = new BookInfoEditRows_UI();
            b.Book = this;
            b.ShowDialog();
        }
        public string BookId = "";

        /// <summary>
        /// 单击DataGridView单元格事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //选中行的图书编号
                BookId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            }
            catch (Exception) { }

            //单击某行 历史记录表就显示相关的数据
            this.dgvHostory.DataSource = borrowReturn_bll.selectBorrowReturn(BookId).Tables[0];


            //DataGridView的总列数
            int rows = dataGridView1.Columns.Count;

            if (e.ColumnIndex == rows - 2)//修改
            {
                BookInfoEdit_UI b = new BookInfoEdit_UI();
                b.manager = this;
                b.BookId = BookId;
                b.ShowDialog();
            }
            else if (e.ColumnIndex == rows - 1)//删除
            {
                DialogResult result = MessageBox.Show("确定删除吗？", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    if (bookInfo_bll.DeleteBookInfo(BookId) > 0)
                    {
                        //调用查询按钮刷新图书信息表
                        btnSelect_Click(null, null);
                        //历史记录表中的数据引用着图书信息表的数据，删除图书信息应该刷新历史记录表
                        this.dgvHostory.DataSource = borrowReturn_bll.selectBorrowReturn(BookId).Tables[0];
                    }
                    else
                    {
                        MessageBox.Show("删除失败！");
                    }
                }
            }
        }
        /// <summary>
        /// 点击查询按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnSelect_Click(object sender, EventArgs e)
        {
            DataGridViewColumnCollection columns = dataGridView1.Columns;
            if (comboBox1.SelectedIndex == 0)//全部
            {
                List<string> list = new List<string>();
                for (int i = 0; i < columns.Count - 2; i++)
                {
                    list.Add(columns[i].DataPropertyName);
                }
                string B = textBox1.Text.Trim();
                dataGridView1.DataSource = bookInfo_bll.selectBookInfo1(list, B).Tables[0];
            }
            else
            {

                for (int i = 0; i < columns.Count - 2; i++)
                {
                    if (comboBox1.SelectedItem.ToString() == columns[i].HeaderText)
                    {
                        string A = columns[i].DataPropertyName;
                        string B = textBox1.Text.Trim();
                        dataGridView1.DataSource = bookInfo_bll.selectBookInfo1(A, B).Tables[0];
                        break;
                    }
                }
            }

            //如果用户信息表中查不到一条数据，相关表的数据也清空
            if (dataGridView1.Rows.Count == 0)
            {
                dgvHostory.DataSource = null;
                return;
            }
        }
        public BookInfoAdd_UI bookInfoAdd;
        public void btnAddBookInfo_Click(object sender, EventArgs e)
        {
            bookInfoAdd = new BookInfoAdd_UI();
            bookInfoAdd.manager = this;
            bookInfoAdd.ShowDialog();
        }
    }
}
