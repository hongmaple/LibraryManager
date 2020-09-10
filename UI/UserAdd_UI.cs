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
    public partial class UserAdd_UI : Form
    {
        public UserAdd_UI()
        {
            InitializeComponent();
        }
        private void button3_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).FlatStyle = FlatStyle.Standard;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).FlatStyle = FlatStyle.Flat;
        }
        public UserManage_UI reader = null;

        User_BLL reader_bll = new User_BLL();
        UserType_BLL readerType_bll = new UserType_BLL();
        Department_BLL department_bll = new Department_BLL();
        Class_BLL class_bll = new Class_BLL();
        List_UI com = new List_UI();

        //加载
        private void ReaderAdd_UI_Load(object sender, EventArgs e)
        {
            //用户类型的下拉框绑定
            cboReaderType.DataSource = readerType_bll.selectUserType();
            cboReaderType.DisplayMember = "UserTypeName";
            cboReaderType.ValueMember = "UserTypeId";

            //学院的下拉框绑定
            cboDepartment.DataSource = department_bll.selectDepartment();
            cboDepartment.DisplayMember = "DepartmentName";
            cboDepartment.ValueMember = "DepartmentId";

            //班级的下拉框绑定
            cboClass.DataSource = class_bll.selectClass();
            cboClass.DisplayMember = "ClassName";
            cboClass.ValueMember = "ClassId";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        //添加用户类型
        private void btnReaderType_Click(object sender, EventArgs e)
        {
            TypeManage_UI a = new TypeManage_UI();
            a.tabName = "用户类型";
            a.readerManager = this.reader;
            a.readerAdd = this;
            a.ShowDialog();
        }
        //添加学院
        private void btnDepartment_Click(object sender, EventArgs e)
        {
            TypeManage_UI a = new TypeManage_UI();
            a.tabName = "学院";
            a.readerManager = this.reader;
            a.readerAdd = this;
            a.ShowDialog();
        }
        //添加班级
        private void btnClass_Click(object sender, EventArgs e)
        {
            TypeManage_UI a = new TypeManage_UI();
            a.tabName = "班级";
            a.readerManager = this.reader;
            a.readerAdd = this;
            a.ShowDialog();
        }
        //新增用户信息
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //图书编号必须唯一
            int rows = reader.dgvHeaderInfo.RowCount;
            lab.Text = "";
            for (int i = 0; i < rows; i++)
            {
                string Columns1 = reader.dgvHeaderInfo.Rows[i].Cells[0].Value.ToString();
                if (Columns1 == txtUserId.Text.Trim())
                {
                    lab.Text = "用户编号已存在！";
                    return;
                }
            }
            User r = new User();
            r.UserId = txtUserId.Text.Trim();
            r.UserName = txtUserName.Text.Trim();
            r.TimeIn = dtTimeIn.Value;
            r.TimeOut = dtTimeOut.Value;
            r.UserTypeId = (int)cboReaderType.SelectedValue;
            r.DepartmentId = (int)cboDepartment.SelectedValue;
            r.ClassId = (int)cboClass.SelectedValue;
            r.IdentityCard = txtIdentityCard.Text.Trim();
            r.Gender = txtGender.Text.Trim();
            r.Phone = txtPhone.Text.Trim();
            r.QQ = txtQQ.Text.Trim();
            r.Email = txtEmail.Text.Trim();
            r.Address = txtAddress.Text.Trim();
            r.UserRemark = txtRemark.Text.Trim();

            if (reader_bll.addUser(r) == 0)
            {
                MessageBox.Show("新增成功！");
                //单击查询 刷新用户信息表
                reader.btnSelect_Click(null, null);

                //自动找到刚刚添加成功的新行，并选中
                com.AutoFindRow(txtUserId.Text.Trim(), reader.dgvHeaderInfo);
            }
            else
            {
                MessageBox.Show("新增失败！");
            }
        }

    }
}
