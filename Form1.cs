using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQLBH
{
    public partial class Form1 : Form
    {
        //khai báo enum. 
        enum FormEditState { Add, Edit, View }

        // Nếu không dùng enum có thể khai báo là string fES
        FormEditState fES = FormEditState.View;
        string oldMaHH = string.Empty;
        string oldLH = string.Empty;
        public Form1()
        {
            InitializeComponent();
            string[] lhs = new string[] { "Speakers", "Keyboard", "Mouse", "PowerBank", "Routers" };
            dataGridView1.Rows.Add("pt101", "MX Key", "Logitech", lhs[1], "7/12/2018", "7/12/2028");
            dataGridView1.Rows.Add("pt102", "Alexa", "Amazon", lhs[0], "30/12/2017", "1/1/2022");
            dataGridView1.Rows.Add("pt103", "MX Master 3 ", "Logitech", lhs[2], "7/12/2018", "5/3/2025");
            dataGridView1.Rows.Add("pt104", "PB 10000mah", "Aukey", lhs[3], "27/12/2019", "27/12/2023");
            dataGridView1.Rows.Add("pt105", "TP-LINK TD-W8960N", "TP-LINK", lhs[4], "25/4/2015", "25/4/2019");
            dataGridView1.ReadOnly = true;
            ChangeButtonState(true);
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            btnAdd.Click += btnAdd_Click;
            btnEdit.Click += btnEdit_Click;
            btnRemove.Click += btnRemove_Click;
            btnOK.Click += btnOK_Click;
            btnExit.Click += btnExit_Click;
            this.Height = 700;
            this.Width = 900;
            foreach (var item in lhs)
            {
                cbbProductcode.Items.Add(item);
                dataGridView2.Rows.Add(item, "X");
            }
            groupBox2.Visible = false;
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            var cr = dataGridView1 == null ? null : dataGridView1.CurrentRow;
            int rowIndex = cr == null ? -1 : cr.Index;


            bool allowchanged = !(btnOK.Enabled && btnOK.Visible);
            if (rowIndex >=0 && allowchanged)
            {
                txtProductcode.Text = dataGridView1[0, rowIndex].Value?.ToString();
                txtProductname.Text = dataGridView1[1, rowIndex].Value?.ToString();
                txtCompany.Text = dataGridView1[2, rowIndex].Value?.ToString();

                cbbProductcode.SelectedItem = dataGridView1[3, rowIndex].Value?.ToString();
                txtManuDate.Text = dataGridView1[4, rowIndex].Value?.ToString();
                txtExpireday.Text = dataGridView1[5, rowIndex].Value?.ToString();
            }
                   
        }
        private void ResetTextBox()
        {
            txtProductcode.Text = string.Empty;
            txtProductname.Text = string.Empty;
            txtCompany.Text = string.Empty;
            txtProductSearch.Text = string.Empty;
            txtManuDate.Text = string.Empty;
            txtExpireday.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChangeButtonState(false);
            fES = FormEditState.Add;
            ResetTextBox();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                oldMaHH = dataGridView1.CurrentRow.Cells[0].Value?.ToString();
                ChangeButtonState(false);
                fES = FormEditState.Edit;
                dataGridView1.Enabled = false;
            }
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Do you want to remove this?", "Announce", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot Remove");
            }
        }

        private void btnCancel_Click(object sender, DataGridViewCellEventArgs e)
        {
            ChangeButtonState(true);
            fES = FormEditState.View;
            dataGridView1_SelectionChanged(null, null);
            dataGridView1.Enabled = true;
        }


        private void ChangeButtonState(bool check)
        {
            btnExit.Enabled = check;
            btnEdit.Enabled = check;
            btnRemove.Enabled = check;
            btnAdd.Enabled = check;
            btnCancel.Visible = !check;
            btnOK.Visible = !check;

            txtProductcode.ReadOnly = check;
            txtProductname.ReadOnly = check;
            txtCompany.ReadOnly = check;
            cbbProductcode.Enabled = !check;
            txtManuDate.ReadOnly = check;
            txtExpireday.ReadOnly = check;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            DateTime nsx;
            DateTime hsd;
            string nsxString = string.Empty;
            string hsdString = string.Empty;
            if (!string.IsNullOrWhiteSpace(txtManuDate.Text))
            {
                bool check = DateTime.TryParse(txtManuDate.Text, out nsx);
                if (check)
                    nsxString = nsx.ToString("d");
            }

            if (!string.IsNullOrWhiteSpace(txtExpireday.Text))
            {
                bool check = DateTime.TryParse(txtExpireday.Text, out hsd);
                if (check)
                    hsdString = hsd.ToString("d");
            }
            bool duplicateCheck = false;
            if (fES == FormEditState.Add || fES == FormEditState.Edit && oldMaHH != txtProductcode.Text)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string s = row.Cells[0].Value.ToString();
                    if (s == txtProductcode.Text)
                    {
                        duplicateCheck = true;
                        break;
                    }
                }
            }

            if (string.IsNullOrWhiteSpace(txtProductcode.Text))
            {
                MessageBox.Show("Product code Empty!");
                return;
            }
            if (duplicateCheck)
            {

                MessageBox.Show("Code Already existed!");
                return;
            }
            if (fES == FormEditState.Add)
            {
                dataGridView1.Rows.Add(txtProductcode.Text, txtProductname.Text, txtCompany.Text, cbbProductcode.Text, nsxString, hsdString);
            }
            if (fES == FormEditState.Edit)
            {
                var row = dataGridView1.CurrentRow;
                row.Cells[0].Value = txtProductcode.Text;
                row.Cells[1].Value = txtProductname.Text;
                row.Cells[2].Value = txtCompany.Text;
                row.Cells[3].Value = cbbProductcode.Text;
                row.Cells[4].Value = nsxString;
                row.Cells[5].Value = hsdString;
            }
            fES = FormEditState.Add;
            dataGridView1.Enabled = true;
            ChangeButtonState(true);
            dataGridView1_SelectionChanged(null, null);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.CurrentRow.IsNewRow || e.ColumnIndex != 1)
            {
                return;
            }
            bool[] checks = new bool[dataGridView2.Rows.Count];
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string s = row.Cells[3].Value.ToString();
                for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                {
                    if (dataGridView2.Rows[i].Cells[0].Value.ToString() == s)
                    {
                        checks[i] = true;
                    }
                }
            }
            if (checks[dataGridView2.CurrentRow.Index])
            {
                MessageBox.Show("Cannot remove while other product refering this product ");
                return;
            }
            var index = dataGridView2.CurrentRow.Index;
            if (dataGridView2.Columns[e.ColumnIndex] is DataGridViewButtonColumn && index >= 0)
            {
                dataGridView2.Rows.RemoveAt(index);
            }
        }

        private void btnLHThem_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox1.Visible = false;
            this.Height = dataGridView2.Height + 350;
            this.Width = dataGridView2.Width + 100;
        }

        private void BtnLHChon_Click(object sender, EventArgs e)
        {
            var cr = dataGridView2 == null ? null : dataGridView2.CurrentRow;
            int rowIndex = cr == null ? -1 : cr.Index;
            if (rowIndex >= 0)
            {

                cbbProductcode.Items.Clear();
                for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                {
                    var row = dataGridView2.Rows[i];
                    var cell = row.Cells[0];
                    cbbProductcode.Items.Add(dataGridView2.Rows[i].Cells[0].Value.ToString());
                }
                if (fES != FormEditState.View)
                {
                    cbbProductcode.SelectedItem = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                }
                else
                {
                    dataGridView1_SelectionChanged(null, null);
                }
                groupBox2.Visible = false;
                groupBox1.Visible = true;
                txtPTsearch.Text = string.Empty;
                this.Height = 700;
                this.Width = 900;
            }
        }

        private void btnLHHuy_Click(object sender, EventArgs e)
        {
            cbbProductcode.Items.Clear();
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                var row = dataGridView2.Rows[i];
                var cell = row.Cells[0];
                cbbProductcode.Items.Add(dataGridView2.Rows[i].Cells[0].Value.ToString());
            }

            this.Height = 700;
            this.Width = 900;
            dataGridView1_SelectionChanged(null, null);

            txtPTsearch.Text = string.Empty;
            groupBox2.Visible = false;
            groupBox1.Visible = true;
        }

        private void btnLHTim_Click(object sender, EventArgs e)
        {
            TimKiem(dataGridView2, 0, txtPTsearch.Text);
        }

        private void btnHangHoaTim_Click(object sender, EventArgs e)
        {
            TimKiem(dataGridView1, 1, txtProductSearch.Text);
        }

        private void TimKiem(DataGridView dg, int indexCol, string textSearch)
        {
            int count = dg.Rows.Count;
            if (dg.AllowUserToAddRows == true)
            {
                count -= 1;
            }
            for (int i = 0; i < count; i++)
            {
                var row = dg.Rows[i];
                var cell = row.Cells[indexCol];
                if (cell != null)
                {
                    var cellValue = cell.Value?.ToString();
                    if (cellValue != null && cellValue.Contains(textSearch))
                    {
                        row.Visible = true;
                    }
                    else row.Visible = false;
                }
            }
        }

        private void dataGridView2_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                oldLH = dataGridView2.CurrentCell.Value.ToString();
            }
        }

        private void dataGridView2_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string currentCellString = string.Empty;
            if (dataGridView2.EditingControl is TextBox)
            {
                var tb = (TextBox)dataGridView2.EditingControl;
                currentCellString = tb.Text;
            }
            bool duplicateCheck = false;
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                var row = dataGridView2.Rows[i];
                if (dataGridView2.CurrentRow == row)
                {
                    continue;
                }
                string s = row.Cells[0].Value.ToString();
                if (s == currentCellString)
                {
                    duplicateCheck = true;
                    break;
                }
            }
            if (duplicateCheck)
            {
                MessageBox.Show("Product Already Existed!");
                e.Cancel = true;
                return;
            }
            if (oldLH == currentCellString)
            {
                return;
            }
            foreach (DataGridViewRow hhRow in dataGridView1.Rows)
            {
                if (hhRow.IsNewRow)
                {
                    continue;
                }
                var cellValue = hhRow.Cells[3].Value;
                if (cellValue.ToString() == oldLH)
                {
                    hhRow.Cells[3].Value = currentCellString;
                }
            }
        }
    }
}
