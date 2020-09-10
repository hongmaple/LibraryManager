using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class BookInfoEditRows_UI : Form
    {
        public BookInfoEditRows_UI()
        {
            InitializeComponent();
        }
        public BookInfoManage_UI Book = null;
        public UserManage_UI Reader = null;

        DataGridViewColumnCollection columns;

        private void BookInfoExitRows_UI_Load(object sender, EventArgs e)
        {
            if (Book != null)
            {
                columns = Book.dataGridView1.Columns;
            }
            else if (Reader != null)
            {
                columns = Reader.dgvHeaderInfo.Columns;
            }
            for (int i = 0; i < columns.Count - 2; i++)
            {
                if (columns[i].Visible == true)
                {
                    listBox1.Items.Add(columns[i].HeaderText);
                }
                else
                {
                    listBox2.Items.Add(columns[i].HeaderText);
                }
            }
        }
        //左移
        private void btnLeft_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectListBox2 = listBox2.SelectedItems;
            for (int i = 0; i < selectListBox2.Count; i++)
            {
                listBox1.Items.Add(selectListBox2[i]);
                for (int j = 0; j < columns.Count - 2; j++)
                {
                    if (columns[j].HeaderText == selectListBox2[i].ToString())
                    {
                        columns[j].Visible = true;
                    }
                }
            }

            ListBox.SelectedIndexCollection indices = listBox2.SelectedIndices;

            for (int i = indices.Count - 1; i >= 0; i--)
            {
                int index = indices[i];
                listBox2.Items.RemoveAt(index);
            }
        }
        //右移
        private void btnRight_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectListBox1 = listBox1.SelectedItems;
            for (int i = 0; i < selectListBox1.Count; i++)
            {
                listBox2.Items.Add(selectListBox1[i]);
                for (int j = 0; j < columns.Count - 2; j++)
                {
                    if (columns[j].HeaderText == selectListBox1[i].ToString())
                    {
                        columns[j].Visible = false;
                    }
                }
            }


            ListBox.SelectedIndexCollection indices = listBox1.SelectedIndices;
            for (int i = indices.Count - 1; i >= 0; i--)
            {
                int index = indices[i];
                listBox1.Items.RemoveAt(index);

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
