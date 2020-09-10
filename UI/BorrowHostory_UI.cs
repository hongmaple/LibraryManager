using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI;
using BLL;
using Model;

namespace UI
{
    public partial class BorrowHostory_UI : Form
    {
        public BorrowHostory_UI()
        {
            InitializeComponent();
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).FlatStyle = FlatStyle.Standard;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).FlatStyle = FlatStyle.Flat;
        }
        List_UI com = new List_UI();
        BorrowReturn_BLL borrowReturn_bll = new BorrowReturn_BLL();

        private void btnUserId_Click(object sender, EventArgs e)
        {
            Info_UI i = new Info_UI();
            i.txtName = "用户信息";
            i.BorrowHostory = this;
            i.ShowDialog();
        }

        private void btnBookId_Click(object sender, EventArgs e)
        {
            Info_UI i = new Info_UI();
            i.txtName = "图书信息";
            i.BorrowHostory = this;
            i.ShowDialog();
        }

        private void BorrowHostory_UI_Load(object sender, EventArgs e)
        {
            cboBorrowTimeType.SelectedIndex = 0;
            #region dgvHostory列表生成

            string ColumnHeaderText = "图书编号,用户编号,图书名称,用户名称,图书类型,用户类型,用户性别,身份证号,借阅时间,应还时间,实际还书时间,罚金,续借次数";
            string ColumnHeaderName = @"BookId,UserId,BookName,UserName,BookTypeName,UserTypeName,Gender,IdentityCard,BorrowTime,ReturnTime,FactReturnTime,Fine,RenewCount";
            com.AutoColumn(ColumnHeaderText, ColumnHeaderName, dgvHostory);
            dgvHostory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHostory.DataSource = borrowReturn_bll.AllBorrowReturn().Tables[0];
            #endregion
        }

        //当编辑绑定完 DataGridView所有单元格之后，执行绘制引发的事件
        private void dgvHostory_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(e.RowBounds.Location.X,
               e.RowBounds.Location.Y,
               dgvHostory.RowHeadersWidth - 4,
               e.RowBounds.Height);

            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                dgvHostory.RowHeadersDefaultCellStyle.Font,
                rectangle,
                dgvHostory.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }
        //CheckBox是否选中打钩 事件
        private void checkTime_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTime.Checked)
            {
                dtIn.Enabled = true;
                dtOut.Enabled = true;
                cboBorrowTimeType.Enabled = true;
            }
            else
            {
                dtIn.Enabled = false;
                dtOut.Enabled = false;
                cboBorrowTimeType.Enabled = false;
            }
        }
        //单击查询
        private void btnSelect_Click(object sender, EventArgs e)
        {
            BorrowReturn b = new BorrowReturn();
            b.BookId = txtBookId.Text.Trim();
            b.UserId = txtUserId.Text.Trim();
            b.TimeIn = dtIn.Value;
            b.TimeOut = dtOut.Value;
            String rdoName = rdoAll.Text;
            if (rdoBorrow.Checked)
                rdoName = rdoBorrow.Text;
            else if (rdoReturn.Checked)
                rdoName = rdoReturn.Text;
            String cboBorrowTimeType = this.cboBorrowTimeType.SelectedItem.ToString();
            bool checkTime = this.checkTime.Checked;
            dgvHostory.DataSource = borrowReturn_bll.selectHostory(b, rdoName, cboBorrowTimeType, checkTime).Tables[0];
        }

    }
}
