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
using UI;
using BLL;

namespace UI
{
    public partial class Edit_UI : Form
    {
        public Edit_UI()
        {
            InitializeComponent();
        }
        public Class c = null;
        public Department d = null;
        public UserType r = null;
        public TypeManage_UI aa = null;
        public BookType t = null;
        List_UI com = new List_UI();

        private void Edit_Load(object sender, EventArgs e)
        {
            if (t != null)
            {
                this.textBox1.Text = t.BookTypeName;
            }
            else if (r != null)
            {
                this.textBox1.Text = r.UserTypeName;
            }
            else if (d != null)
            {
                this.textBox1.Text = d.DepartmentName;
            }
            else if (c != null)
            {
                this.textBox1.Text = c.ClassName;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (t != null)
            {
                t.BookTypeName = textBox1.Text.Trim();
                if (aa.booktype.updateBookType(t) > 0)
                {
                    aa.dataGridView1.DataSource = aa.booktype.selectBookType1().Tables[0];
                    //自动找到刚刚修改成功的行，并选中
                    com.AutoFindRow(t.BookTypeId.ToString(), aa.dataGridView1);
                }
                else { MessageBox.Show("修改失败！"); }
            }
            if (r != null)
            {
                r.UserTypeName = textBox1.Text.Trim();
                if (aa.readerType_bll.updateUserType(r) > 0)
                {
                    aa.dataGridView2.DataSource = aa.readerType_bll.selectUserType1().Tables[0];
                    //自动找到刚刚修改成功的行，并选中
                    com.AutoFindRow(r.UserTypeId.ToString(), aa.dataGridView2);
                }
                else { MessageBox.Show("修改失败！"); }
            }
            if (d != null)
            {
                d.DepartmentName = textBox1.Text.Trim();
                if (aa.department_bll.updateDepartment(d) > 0)
                {
                    aa.dataGridView3.DataSource = aa.department_bll.selectDepartment1().Tables[0];
                    //自动找到刚刚修改成功的行，并选中
                    com.AutoFindRow(d.DepartmentId.ToString(), aa.dataGridView3);
                }
                else { MessageBox.Show("修改失败！"); }
            }
            if (c != null)
            {
                c.ClassName = textBox1.Text.Trim();
                if (aa.class_bll.updateClass(c) > 0)
                {
                    aa.dataGridView4.DataSource = aa.class_bll.selectClass1().Tables[0];
                    //自动找到刚刚修改成功的行，并选中
                    com.AutoFindRow(c.ClassId.ToString(), aa.dataGridView4);
                }
                else { MessageBox.Show("修改失败！"); }
            }
            this.Close();
        }
    }
}
