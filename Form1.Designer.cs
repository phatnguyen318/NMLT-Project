
namespace AppQLBH
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLHHuy = new System.Windows.Forms.Button();
            this.BtnLHChon = new System.Windows.Forms.Button();
            this.btnPTSearch = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtPTsearch = new System.Windows.Forms.TextBox();
            this.txtProductSearch = new System.Windows.Forms.TextBox();
            this.btnProductSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtExpireday = new System.Windows.Forms.TextBox();
            this.txtManuDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProductname = new System.Windows.Forms.TextBox();
            this.txtProductcode = new System.Windows.Forms.TextBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.btncodeadd = new System.Windows.Forms.Button();
            this.cbbProductcode = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtProductSearch);
            this.groupBox1.Controls.Add(this.btnProductSearch);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Controls.Add(this.txtExpireday);
            this.groupBox1.Controls.Add(this.txtManuDate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtProductname);
            this.groupBox1.Controls.Add(this.txtProductcode);
            this.groupBox1.Controls.Add(this.txtCompany);
            this.groupBox1.Controls.Add(this.btncodeadd);
            this.groupBox1.Controls.Add(this.cbbProductcode);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(838, 580);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHH,
            this.TenHH,
            this.Cty,
            this.LH,
            this.NSX,
            this.HSD});
            this.dataGridView1.Location = new System.Drawing.Point(22, 356);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(793, 265);
            this.dataGridView1.TabIndex = 58;
            // 
            // MaHH
            // 
            this.MaHH.DataPropertyName = "MaHH";
            this.MaHH.HeaderText = "Code";
            this.MaHH.Name = "MaHH";
            // 
            // TenHH
            // 
            this.TenHH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenHH.DataPropertyName = "TenHH";
            this.TenHH.HeaderText = "Name";
            this.TenHH.Name = "TenHH";
            // 
            // Cty
            // 
            this.Cty.DataPropertyName = "Cty";
            this.Cty.HeaderText = "Company";
            this.Cty.Name = "Cty";
            // 
            // LH
            // 
            this.LH.DataPropertyName = "LH";
            this.LH.HeaderText = "Type";
            this.LH.Name = "LH";
            // 
            // NSX
            // 
            this.NSX.DataPropertyName = "NSX";
            this.NSX.HeaderText = "Manufacturing Date";
            this.NSX.Name = "NSX";
            this.NSX.Width = 140;
            // 
            // HSD
            // 
            this.HSD.DataPropertyName = "HSD";
            this.HSD.HeaderText = "Expired Date";
            this.HSD.Name = "HSD";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLHHuy);
            this.groupBox2.Controls.Add(this.BtnLHChon);
            this.groupBox2.Controls.Add(this.btnPTSearch);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.txtPTsearch);
            this.groupBox2.Location = new System.Drawing.Point(41, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 321);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product Type";
            // 
            // btnLHHuy
            // 
            this.btnLHHuy.Location = new System.Drawing.Point(164, 252);
            this.btnLHHuy.Name = "btnLHHuy";
            this.btnLHHuy.Size = new System.Drawing.Size(75, 23);
            this.btnLHHuy.TabIndex = 4;
            this.btnLHHuy.Text = "Back";
            this.btnLHHuy.UseVisualStyleBackColor = true;
            // 
            // BtnLHChon
            // 
            this.BtnLHChon.Location = new System.Drawing.Point(41, 252);
            this.BtnLHChon.Name = "BtnLHChon";
            this.BtnLHChon.Size = new System.Drawing.Size(75, 23);
            this.BtnLHChon.TabIndex = 3;
            this.BtnLHChon.Text = "Pick";
            this.BtnLHChon.UseVisualStyleBackColor = true;
            // 
            // btnPTSearch
            // 
            this.btnPTSearch.Location = new System.Drawing.Point(122, 37);
            this.btnPTSearch.Name = "btnPTSearch";
            this.btnPTSearch.Size = new System.Drawing.Size(75, 23);
            this.btnPTSearch.TabIndex = 2;
            this.btnPTSearch.Text = "Search";
            this.btnPTSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView2.Location = new System.Drawing.Point(16, 71);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Product Type";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Remove";
            this.Column2.Name = "Column2";
            this.Column2.Text = "X";
            this.Column2.Width = 50;
            // 
            // txtPTsearch
            // 
            this.txtPTsearch.Location = new System.Drawing.Point(16, 39);
            this.txtPTsearch.Name = "txtPTsearch";
            this.txtPTsearch.Size = new System.Drawing.Size(100, 20);
            this.txtPTsearch.TabIndex = 0;
            // 
            // txtProductSearch
            // 
            this.txtProductSearch.Location = new System.Drawing.Point(686, 6);
            this.txtProductSearch.Name = "txtProductSearch";
            this.txtProductSearch.Size = new System.Drawing.Size(97, 20);
            this.txtProductSearch.TabIndex = 56;
            // 
            // btnProductSearch
            // 
            this.btnProductSearch.Location = new System.Drawing.Point(789, 6);
            this.btnProductSearch.Name = "btnProductSearch";
            this.btnProductSearch.Size = new System.Drawing.Size(49, 20);
            this.btnProductSearch.TabIndex = 55;
            this.btnProductSearch.Text = "Search";
            this.btnProductSearch.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(713, 311);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 39);
            this.btnExit.TabIndex = 54;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(610, 311);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(97, 39);
            this.btnRemove.TabIndex = 53;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(510, 311);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(96, 39);
            this.btnEdit.TabIndex = 52;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(408, 311);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 39);
            this.btnAdd.TabIndex = 51;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(740, 282);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 50;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(659, 282);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 49;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // txtExpireday
            // 
            this.txtExpireday.Location = new System.Drawing.Point(535, 64);
            this.txtExpireday.Name = "txtExpireday";
            this.txtExpireday.Size = new System.Drawing.Size(231, 20);
            this.txtExpireday.TabIndex = 48;
            // 
            // txtManuDate
            // 
            this.txtManuDate.Location = new System.Drawing.Point(535, 32);
            this.txtManuDate.Name = "txtManuDate";
            this.txtManuDate.Size = new System.Drawing.Size(231, 20);
            this.txtManuDate.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(451, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Expired Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(418, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Manufacturing Date";
            // 
            // txtProductname
            // 
            this.txtProductname.Location = new System.Drawing.Point(133, 64);
            this.txtProductname.Name = "txtProductname";
            this.txtProductname.Size = new System.Drawing.Size(231, 20);
            this.txtProductname.TabIndex = 44;
            // 
            // txtProductcode
            // 
            this.txtProductcode.Location = new System.Drawing.Point(133, 32);
            this.txtProductcode.Name = "txtProductcode";
            this.txtProductcode.Size = new System.Drawing.Size(231, 20);
            this.txtProductcode.TabIndex = 43;
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(133, 98);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(231, 20);
            this.txtCompany.TabIndex = 42;
            // 
            // btncodeadd
            // 
            this.btncodeadd.Location = new System.Drawing.Point(319, 124);
            this.btncodeadd.Name = "btncodeadd";
            this.btncodeadd.Size = new System.Drawing.Size(45, 23);
            this.btncodeadd.TabIndex = 41;
            this.btncodeadd.Text = "Add";
            this.btncodeadd.UseVisualStyleBackColor = true;
            this.btncodeadd.Click += new System.EventHandler(this.btnLHThem_Click);
            // 
            // cbbProductcode
            // 
            this.cbbProductcode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbProductcode.DropDownWidth = 180;
            this.cbbProductcode.FormattingEnabled = true;
            this.cbbProductcode.Location = new System.Drawing.Point(133, 126);
            this.cbbProductcode.Name = "cbbProductcode";
            this.cbbProductcode.Size = new System.Drawing.Size(180, 21);
            this.cbbProductcode.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Product Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Company";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Code ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(12, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Student Name : Nguyễn Triển Phát";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Red;
            this.textBox2.Location = new System.Drawing.Point(12, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 26);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "MSSV: 20880268";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 662);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Product Management Software";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncodeadd;
        private System.Windows.Forms.ComboBox cbbProductcode;
        private System.Windows.Forms.TextBox txtProductSearch;
        private System.Windows.Forms.Button btnProductSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtExpireday;
        private System.Windows.Forms.TextBox txtManuDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProductname;
        private System.Windows.Forms.TextBox txtProductcode;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLHHuy;
        private System.Windows.Forms.Button BtnLHChon;
        private System.Windows.Forms.Button btnPTSearch;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtPTsearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cty;
        private System.Windows.Forms.DataGridViewTextBoxColumn LH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn HSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

