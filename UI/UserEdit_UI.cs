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
    public partial class UserEdit_UI : Form
    {
        public UserEdit_UI()
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
        public string UserId = null;

        User_BLL reader_bll = new User_BLL();
        UserType_BLL readerType_bll = new UserType_BLL();
        Department_BLL department_bll = new Department_BLL();
        Class_BLL class_bll = new Class_BLL();
        List_UI com = new List_UI();

        public void ReaderExit_UI_Load(object sender, EventArgs e)
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

            List<User> list = reader_bll.selectUser1(UserId);
            txtUserId.Text = list[0].UserId;
            txtUserName.Text = list[0].UserName;
            dtTimeIn.Value = list[0].TimeIn;
            dtTimeOut.Value = list[0].TimeOut;
            cboReaderType.SelectedValue = list[0].UserTypeId;
            cboDepartment.SelectedValue = list[0].DepartmentId;
            cboClass.SelectedValue = list[0].ClassId;
            txtIdentityCard.Text = list[0].IdentityCard;
            txtGender.Text = list[0].Gender;
            txtQQ.Text = list[0].QQ;
            txtPhone.Text = list[0].Phone;
            txtEmail.Text = list[0].Email;
            txtAddress.Text = list[0].Address;
            txtRemark.Text = list[0].UserRemark;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
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
            r.QQ = txtQQ.Text.Trim();
            r.Phone = txtPhone.Text.Trim();
            r.Email = txtEmail.Text.Trim();
            r.Address = txtAddress.Text.Trim();
            r.UserRemark = txtRemark.Text.Trim();

            if (reader_bll.updateUser(r) > 0)
            {
                MessageBox.Show("修改成功！");
                //单价查询
                reader.btnSelect_Click(null, null);

                //自动找到刚刚修改成功的行，并选中
                com.AutoFindRow(txtUserId.Text.Trim(), reader.dgvHeaderInfo);
            }
            else
            {
                MessageBox.Show("修改失败！");
            }
        }
        //用户类型编辑
        private void button4_Click(object sender, EventArgs e)
        {
            TypeManage_UI a = new TypeManage_UI();
            a.tabName = "用户类型";
            a.readerExit = this;
            a.readerManager = this.reader;
            a.ShowDialog();
        }
        //学院编辑
        private void button3_Click(object sender, EventArgs e)
        {
            TypeManage_UI a = new TypeManage_UI();
            a.tabName = "学院";
            a.readerExit = this;
            a.readerManager = this.reader;
            a.ShowDialog();
        }
        //班级编辑
        private void button5_Click(object sender, EventArgs e)
        {
            TypeManage_UI a = new TypeManage_UI();
            a.tabName = "班级";
            a.readerExit = this;
            a.readerManager = this.reader;
            a.ShowDialog();
        }

    }
}
