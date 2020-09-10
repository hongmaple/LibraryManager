using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection;
using System.Drawing;

namespace UI
{
    public class List_UI
    {
        public void thread() {
        
        }

        //DataGridView样式
        public void EditGridView(DataGridView GridView)
        {
            GridView.AllowDrop = false;
            GridView.AllowUserToAddRows = false;
            GridView.AllowUserToDeleteRows = false;
            GridView.AllowUserToOrderColumns = false;
            GridView.AllowUserToResizeColumns = true;
        }

        //生成一列按钮
        public void AddColumn(string name, DataGridView GridView)
        {
            //添加修改按钮
            DataGridViewButtonColumn c = new DataGridViewButtonColumn();
            //设置列标题单元格的名称
            c.Text = name;
            //单元格的背景色
            c.DefaultCellStyle.BackColor = Color.LightGray;
            //单元格选定时的背景色
            c.DefaultCellStyle.SelectionBackColor = Color.DarkGray;
            //单元格的默认文本
            c.UseColumnTextForButtonValue = true;
            //单元格宽
            c.Width = 60;
            //添加新的一列对象
            //选中时背景色为灰色
            c.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            c.DefaultCellStyle.SelectionForeColor = Color.Black;
            c.FillWeight = 50;
            GridView.Columns.Add(c);
        }

        //自动生成columns
        public void AutoColumn(string HeaderText, string DataPropertyNames, DataGridView GrdiView)
        {
            //去掉自动生成的列
            GrdiView.AutoGenerateColumns = false;
            GrdiView.RowHeadersDefaultCellStyle.SelectionBackColor = Color.DarkGray;
            //生成行标题标号
            GrdiView.DataSource = System.Drawing.Imaging.ImageCodecInfo.GetImageDecoders();
            // 禁止用户改变DataGridView1的所有列的列宽
            GrdiView.AllowUserToResizeColumns = false;
            //禁止用户改变DataGridView1所有行的行高 
            GrdiView.AllowUserToResizeRows = false;
            //选择整行
            GrdiView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GrdiView.AllowDrop = false;
            //不可以添加行
            GrdiView.AllowUserToAddRows = false;
            //不可以删除行
            GrdiView.AllowUserToDeleteRows = false;
            //不可以手动对列重新定位
            GrdiView.AllowUserToOrderColumns = false;
            //可以调整列的大小
            GrdiView.AllowUserToResizeColumns = true;
            //不可以调整行的大小
            GrdiView.AllowUserToResizeRows = false;
            //行标题行的宽度
            GrdiView.RowHeadersWidth = 32;
            //不能多选
            GrdiView.MultiSelect = false;
            //获取标题样式
            GrdiView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            string[] arrayHeaderText = HeaderText.Split(',');
            string[] arrayDataPropertyNames = DataPropertyNames.Split(',');
            for (int i = 0; i < arrayHeaderText.Length; i++)
            {
                DataGridViewTextBoxColumn d = new DataGridViewTextBoxColumn();
                //绑定数据库列名称
                d.DataPropertyName = arrayDataPropertyNames[i];
                //设置列标题的名称
                d.HeaderText = arrayHeaderText[i];
                //单元格选定时的背景色
                d.DefaultCellStyle.SelectionBackColor = Color.Gainsboro;
                d.DefaultCellStyle.SelectionForeColor = Color.Black;
                //单元格的内容居中
                d.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                GrdiView.Columns.Add(d);
            }
            GrdiView.DataSource = null;
        }

        //找到刚刚添加成功的数据行
        public void AutoFindRow(string A, DataGridView GridView) 
        {
            //获取DataGridView中的总行数
            int rows = GridView.RowCount;

            //找到刚刚添加成功的数据行
            for (int i = 0; i < rows; i++)
            {
                string a = GridView.Rows[i].Cells[0].Value.ToString();
                if (a == A)
                {
                    //选中整行
                    GridView.Rows[i].Selected = true;
                    //垂直滚动条，滚动到当前行索引位置
                    GridView.FirstDisplayedScrollingRowIndex = i;
                }
                else
                {
                    //清除整行选中
                    GridView.Rows[i].Selected = false;
                }
            }
        }

        //找到刚刚添加成功的数据行
        public void AutoFindRow(int A, DataGridView GridView)
        {
            //获取DataGridView总行数
            int rows = GridView.RowCount;

            //找到刚刚添加成功的数据行
            for (int i = 0; i < rows; i++)
            {
                int a = (int)GridView.Rows[i].Cells[0].Value;
                if (a == A)
                {
                    //选中整行
                    GridView.Rows[i].Selected = true;
                    //垂直滚动条，滚动到当前行索引位置
                    GridView.FirstDisplayedScrollingRowIndex = i;
                }
                else
                {
                    //清除整行选中
                    GridView.Rows[i].Selected = false;
                }
            }
        }
    }
}
