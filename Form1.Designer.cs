
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCty = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNSX = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtHangHoaTim = new System.Windows.Forms.TextBox();
            this.btnHangHoaTim = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLHHuy = new System.Windows.Forms.Button();
            this.BtnLHChon = new System.Windows.Forms.Button();
            this.btnLHTim = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtLHTim = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtHangHoaTim);
            this.groupBox1.Controls.Add(this.btnHangHoaTim);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.txtNSX);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.txtCty);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(838, 638);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hàng Hóa";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hàng Hóa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Hàng Hóa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Công Ty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Loại Hàng Hóa";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.DropDownWidth = 180;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(133, 126);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 21);
            this.comboBox1.TabIndex = 40;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtCty
            // 
            this.txtCty.Location = new System.Drawing.Point(133, 98);
            this.txtCty.Name = "txtCty";
            this.txtCty.Size = new System.Drawing.Size(231, 20);
            this.txtCty.TabIndex = 42;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 20);
            this.textBox1.TabIndex = 43;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(133, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(231, 20);
            this.textBox2.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(451, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "NSX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(451, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "HSD";
            // 
            // txtNSX
            // 
            this.txtNSX.Location = new System.Drawing.Point(486, 32);
            this.txtNSX.Name = "txtNSX";
            this.txtNSX.Size = new System.Drawing.Size(231, 20);
            this.txtNSX.TabIndex = 47;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(486, 64);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(231, 20);
            this.textBox3.TabIndex = 48;
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
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(740, 282);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 50;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(408, 311);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(97, 39);
            this.btnThem.TabIndex = 51;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(510, 311);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(96, 39);
            this.btnSua.TabIndex = 52;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(713, 311);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(102, 39);
            this.btnThoat.TabIndex = 54;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(610, 311);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(97, 39);
            this.btnXoa.TabIndex = 53;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // txtHangHoaTim
            // 
            this.txtHangHoaTim.Location = new System.Drawing.Point(653, 0);
            this.txtHangHoaTim.Name = "txtHangHoaTim";
            this.txtHangHoaTim.Size = new System.Drawing.Size(62, 20);
            this.txtHangHoaTim.TabIndex = 56;
            // 
            // btnHangHoaTim
            // 
            this.btnHangHoaTim.Location = new System.Drawing.Point(721, 0);
            this.btnHangHoaTim.Name = "btnHangHoaTim";
            this.btnHangHoaTim.Size = new System.Drawing.Size(49, 20);
            this.btnHangHoaTim.TabIndex = 55;
            this.btnHangHoaTim.Text = "Tìm";
            this.btnHangHoaTim.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLHHuy);
            this.groupBox2.Controls.Add(this.BtnLHChon);
            this.groupBox2.Controls.Add(this.btnLHTim);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.txtLHTim);
            this.groupBox2.Location = new System.Drawing.Point(6, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 338);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loại Hàng";
            // 
            // btnLHHuy
            // 
            this.btnLHHuy.Location = new System.Drawing.Point(165, 327);
            this.btnLHHuy.Name = "btnLHHuy";
            this.btnLHHuy.Size = new System.Drawing.Size(75, 23);
            this.btnLHHuy.TabIndex = 4;
            this.btnLHHuy.Text = "Quay lại";
            this.btnLHHuy.UseVisualStyleBackColor = true;
            // 
            // BtnLHChon
            // 
            this.BtnLHChon.Location = new System.Drawing.Point(16, 327);
            this.BtnLHChon.Name = "BtnLHChon";
            this.BtnLHChon.Size = new System.Drawing.Size(75, 23);
            this.BtnLHChon.TabIndex = 3;
            this.BtnLHChon.Text = "Chọn";
            this.BtnLHChon.UseVisualStyleBackColor = true;
            // 
            // btnLHTim
            // 
            this.btnLHTim.Location = new System.Drawing.Point(122, 37);
            this.btnLHTim.Name = "btnLHTim";
            this.btnLHTim.Size = new System.Drawing.Size(75, 23);
            this.btnLHTim.TabIndex = 2;
            this.btnLHTim.Text = "Tìm";
            this.btnLHTim.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView2.Location = new System.Drawing.Point(16, 116);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Loại Hàng";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Xóa";
            this.Column2.Name = "Column2";
            this.Column2.Text = "X";
            this.Column2.Width = 30;
            // 
            // txtLHTim
            // 
            this.txtLHTim.Location = new System.Drawing.Point(16, 39);
            this.txtLHTim.Name = "txtLHTim";
            this.txtLHTim.Size = new System.Drawing.Size(100, 20);
            this.txtLHTim.TabIndex = 0;
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
            this.MaHH.HeaderText = "Mã HH";
            this.MaHH.Name = "MaHH";
            // 
            // TenHH
            // 
            this.TenHH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenHH.DataPropertyName = "TenHH";
            this.TenHH.HeaderText = "Tên Hàng Hóa";
            this.TenHH.Name = "TenHH";
            // 
            // Cty
            // 
            this.Cty.DataPropertyName = "Cty";
            this.Cty.HeaderText = "Công ty";
            this.Cty.Name = "Cty";
            // 
            // LH
            // 
            this.LH.DataPropertyName = "LH";
            this.LH.HeaderText = "Loại Hàng";
            this.LH.Name = "LH";
            // 
            // NSX
            // 
            this.NSX.DataPropertyName = "NSX";
            this.NSX.HeaderText = "NSX";
            this.NSX.Name = "NSX";
            // 
            // HSD
            // 
            this.HSD.DataPropertyName = "HSD";
            this.HSD.HeaderText = "HSD";
            this.HSD.Name = "HSD";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 662);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Phần Mềm Quản Lý Hàng Hóa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtHangHoaTim;
        private System.Windows.Forms.Button btnHangHoaTim;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtNSX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtCty;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cty;
        private System.Windows.Forms.DataGridViewTextBoxColumn LH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn HSD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLHHuy;
        private System.Windows.Forms.Button BtnLHChon;
        private System.Windows.Forms.Button btnLHTim;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.TextBox txtLHTim;
    }
}

