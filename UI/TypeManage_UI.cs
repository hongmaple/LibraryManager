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
using Model;
using UI;

namespace UI
{
    public partial class TypeManage_UI : Form
    {
        public TypeManage_UI()
        {
            InitializeComponent();
        }
        public BookInfoManage_UI Manager = null;
        public BookInfoEdit_UI bookInfoExit = null;
        public BookInfoAdd_UI bookInfoAdd = null;

        public UserManage_UI readerManager = null;
        public UserEdit_UI readerExit = null;
        public UserAdd_UI readerAdd = null;

        public BookType_BLL booktype = new BookType_BLL();
        public UserType_BLL readerType_bll = new UserType_BLL();
        public Department_BLL department_bll = new Department_BLL();
        public Class_BLL class_bll = new Class_BLL();
        List_UI auto = new List_UI();

        public string tabName = null;

        private void Add_Load(object sender, EventArgs e)
        {
            TabControl.TabPageCollection tabs = this.tabControl1.TabPages;
            for (int i = 0; i < tabs.Count; i++)
            {
                if (tabs[i].Text == tabName)
                {
                    this.tabControl1.SelectedIndex = i;
                    break;
                }
            }


            #region 图书类型表的绑定

            string HeaderText = "ID,图书类型";
            string DataPropertyNames = "BookTypeId,BookTypeName";
            //this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //自动生成列
            auto.AutoColumn(HeaderText, DataPropertyNames, this.dataGridView1);
            auto.AddColumn("修改", this.dataGridView1);
            auto.AddColumn("删除", this.dataGridView1);

            this.dataGridView1.DataSource = booktype.selectBookType1().Tables[0];
            this.dataGridView1.Columns[0].Visible = false;

            #endregion

            #region 用户类型表的绑定

            string HeaderText1 = "ID,用户类型";
            string DataPropertyNames1 = "UserTypeId,UserTypeName";
            //this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //自动生成列
            auto.AutoColumn(HeaderText1, DataPropertyNames1, this.dataGridView2);
            auto.AddColumn("修改", this.dataGridView2);
            auto.AddColumn("删除", this.dataGridView2);

            this.dataGridView2.DataSource = readerType_bll.selectUserType1().Tables[0];
            this.dataGridView2.Columns[0].Visible = false;

            #endregion

            #region 学院表的绑定

            string HeaderText2 = "ID,学院";
            string DataPropertyNames2 = "DepartmentId,DepartmentName";
            //this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //自动生成列
            auto.AutoColumn(HeaderText2, DataPropertyNames2, this.dataGridView3);
            auto.AddColumn("修改", this.dataGridView3);
            auto.AddColumn("删除", this.dataGridView3);

            this.dataGridView3.DataSource = department_bll.selectDepartment1().Tables[0];
            this.dataGridView3.Columns[0].Visible = false;

            #endregion

            #region 班级表的绑定

            string HeaderText3 = "ID,班级";
            string DataPropertyNames3 = "ClassId,ClassName";
            //this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //自动生成列
            auto.AutoColumn(HeaderText3, DataPropertyNames3, this.dataGridView4);
            auto.AddColumn("修改", this.dataGridView4);
            auto.AddColumn("删除", this.dataGridView4);

            this.dataGridView4.DataSource = class_bll.selectClass1().Tables[0];
            this.dataGridView4.Columns[0].Visible = false;

            #endregion
        }
        List_UI com = new List_UI();

        //添加图书类型
        private void button1_Click(object sender, EventArgs e)
        {
            BookType type = new BookType();
            type.BookTypeName = textBox1.Text.Trim();
            if (booktype.AddBookTypeInfo(type) == 0)
            {
                MessageBox.Show("添加成功！");
                this.dataGridView1.DataSource = booktype.selectBookType1().Tables[0];

                //自动找到刚刚添加成功的新行，并选中
                com.AutoFindRow(type.BookTypeId.ToString(), this.dataGridView1);
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
        }

        //添加用户类型
        private void button2_Click(object sender, EventArgs e)
        {
            UserType r = new UserType();
            r.UserTypeName = textBox2.Text.Trim();
            if (readerType_bll.addUserType(r) == 0)
            {
                MessageBox.Show("添加成功！");
                this.dataGridView2.DataSource = readerType_bll.selectUserType1().Tables[0];

                //自动找到刚刚添加成功的新行，并选中
                com.AutoFindRow(r.UserTypeId.ToString(), this.dataGridView2);
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
        }

        //添加学院
        private void button3_Click(object sender, EventArgs e)
        {
            Department d = new Department();
            d.DepartmentName = textBox3.Text.Trim();
            if (department_bll.addDepartment(d) == 0)
            {
                MessageBox.Show("添加成功！");
                this.dataGridView3.DataSource = department_bll.selectDepartment1().Tables[0];

                //自动找到刚刚添加成功的新行，并选中
                com.AutoFindRow(d.DepartmentId.ToString(), this.dataGridView3);
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
        }

        //添加班级
        private void button4_Click(object sender, EventArgs e)
        {
            Class c = new Class();
            c.ClassName = textBox4.Text.Trim();
            if (class_bll.AddClass(c) == 0)
            {
                MessageBox.Show("添加成功！");
                this.dataGridView4.DataSource = class_bll.selectClass1().Tables[0];

                //自动找到刚刚添加成功的新行，并选中
                com.AutoFindRow(c.ClassId.ToString(), this.dataGridView4);
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
        }

        //当编辑绑定完 DataGridView所有单元格之后，执行绘制引发的事件
        private void dataGridView2_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        //图书类型表的单元格单击事件
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //选中行的图书编号
            int str = -1;
            try
            {
                str = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            }
            catch (Exception) { }

            //DataGridView的总列数
            int rows = dataGridView1.Columns.Count;

            if (e.ColumnIndex == rows - 2)//修改
            {
                BookType t = new BookType();
                t.BookTypeId = str;
                t.BookTypeName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                Edit_UI exit = new Edit_UI();
                exit.aa = this;
                exit.t = t;
                exit.Text = "修改图书类型";
                exit.ShowDialog();
            }
            else if (e.ColumnIndex == rows - 1)//删除
            {
                DialogResult result = MessageBox.Show("确定删除吗？", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    if (booktype.deleteBookType(str) > 0)
                    {
                        this.dataGridView1.DataSource = booktype.selectBookType1().Tables[0];
                    }
                    else
                    {
                        MessageBox.Show("删除失败！");
                    }
                }
            }
        }

        //用户类型表的单元格单击事件
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //选中行的图书编号
            int str = -1;
            try
            {
                str = (int)dataGridView2.Rows[e.RowIndex].Cells[0].Value;
            }
            catch (Exception) { }

            //DataGridView的总列数
            int rows = dataGridView2.Columns.Count;

            if (e.ColumnIndex == rows - 2)//修改
            {
                UserType r = new UserType();
                r.UserTypeId = str;
                r.UserTypeName = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
                Edit_UI exit = new Edit_UI();
                exit.aa = this;
                exit.r = r;
                exit.Text = "修改用户类型";
                exit.ShowDialog();
            }
            else if (e.ColumnIndex == rows - 1)//删除
            {
                DialogResult result = MessageBox.Show("确定删除吗？", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    if (readerType_bll.deleteUser(str) > 0)
                    {
                        this.dataGridView2.DataSource = readerType_bll.selectUserType1().Tables[0];
                    }
                    else
                    {
                        MessageBox.Show("删除失败！");
                    }
                }
            }
        }

        //学院表的单元格单击事件
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //选中行的图书编号
            int str = -1;
            try
            {
                str = (int)dataGridView3.Rows[e.RowIndex].Cells[0].Value;
            }
            catch (Exception) { }

            //DataGridView的总列数
            int rows = dataGridView3.Columns.Count;

            if (e.ColumnIndex == rows - 2)//修改
            {
                Department d = new Department();
                d.DepartmentId = str;
                d.DepartmentName = dataGridView3.Rows[e.RowIndex].Cells[1].Value.ToString();
                Edit_UI exit = new Edit_UI();
                exit.aa = this;
                exit.d = d;
                exit.Text = "修改学院";
                exit.ShowDialog();
            }
            else if (e.ColumnIndex == rows - 1)//删除
            {
                DialogResult result = MessageBox.Show("确定删除吗？", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    if (department_bll.deleteDepartment(str) > 0)
                    {
                        this.dataGridView3.DataSource = department_bll.selectDepartment1().Tables[0];
                    }
                    else
                    {
                        MessageBox.Show("删除失败！");
                    }
                }
            }
        }

        //班级表的单元格单击事件
        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //选中行的图书编号
            int str = -1;
            try
            {
                str = (int)dataGridView4.Rows[e.RowIndex].Cells[0].Value;
            }
            catch (Exception) { }

            //DataGridView的总列数
            int rows = dataGridView4.Columns.Count;

            if (e.ColumnIndex == rows - 2)//修改
            {
                Class c = new Class();
                c.ClassId = str;
                c.ClassName = dataGridView4.Rows[e.RowIndex].Cells[1].Value.ToString();
                Edit_UI exit = new Edit_UI();
                exit.aa = this;
                exit.c = c;
                exit.Text = "修改班级";
                exit.ShowDialog();
            }
            else if (e.ColumnIndex == rows - 1)//删除
            {
                DialogResult result = MessageBox.Show("确定删除吗？", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    if (class_bll.deleteClass(str) > 0)
                    {
                        this.dataGridView4.DataSource = class_bll.selectClass1().Tables[0];
                    }
                    else
                    {
                        MessageBox.Show("删除失败！");
                    }
                }
            }
        }

        //窗口关闭时为了刷新前一个窗体的下拉菜单
        private void Add_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bookInfoExit != null)
            {
                bookInfoExit.BookInfoExit_UI_Load(null, null);
            }
            if (readerExit != null)
            {
                readerExit.ReaderExit_UI_Load(null, null);
            }
            if (Manager != null)
            {
                Manager.treeView1.Nodes.Clear();
                Manager.TreeViewBand();
                Manager.btnSelect_Click(null, null);
            }
            if (bookInfoAdd != null)
            {
                bookInfoAdd.BookInfoAdd_UI_Load(null, null);
            }
            if (readerManager != null)
            {
                readerManager.treeView1.Nodes.Clear();
                readerManager.TreeViewBand();
                readerManager.btnSelect_Click(null, null);
            }
        }
    }
}
