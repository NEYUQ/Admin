
namespace DoAn4_QuanLy
{
    partial class GUI_TaiKhoanKhachHang
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
            this.txt_matkhau = new DoAn4_QuanLy.Custom.RJTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_taikhoan = new DoAn4_QuanLy.Custom.RJTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_tennkhachang = new DoAn4_QuanLy.Custom.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id = new DoAn4_QuanLy.Custom.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_taikhoan = new System.Windows.Forms.DataGridView();
            this.btn_them = new FontAwesome.Sharp.IconButton();
            this.btn_xoa = new FontAwesome.Sharp.IconButton();
            this.btn_sua = new FontAwesome.Sharp.IconButton();
            this.btn_reload = new FontAwesome.Sharp.IconButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_taikhoan)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txt_matkhau);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_taikhoan);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_tennkhachang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(800, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 229);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.BackColor = System.Drawing.SystemColors.Window;
            this.txt_matkhau.Bordercolor = System.Drawing.Color.Violet;
            this.txt_matkhau.Bordersize = 2;
            this.txt_matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txt_matkhau.ForeColor = System.Drawing.Color.DimGray;
            this.txt_matkhau.Location = new System.Drawing.Point(139, 173);
            this.txt_matkhau.Margin = new System.Windows.Forms.Padding(4);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Padding = new System.Windows.Forms.Padding(4);
            this.txt_matkhau.Size = new System.Drawing.Size(243, 25);
            this.txt_matkhau.TabIndex = 7;
            this.txt_matkhau.Texts = "";
            this.txt_matkhau.Underlinestyle = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mật Khẩu";
            // 
            // txt_taikhoan
            // 
            this.txt_taikhoan.BackColor = System.Drawing.SystemColors.Window;
            this.txt_taikhoan.Bordercolor = System.Drawing.Color.Violet;
            this.txt_taikhoan.Bordersize = 2;
            this.txt_taikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txt_taikhoan.ForeColor = System.Drawing.Color.DimGray;
            this.txt_taikhoan.Location = new System.Drawing.Point(139, 127);
            this.txt_taikhoan.Margin = new System.Windows.Forms.Padding(4);
            this.txt_taikhoan.Name = "txt_taikhoan";
            this.txt_taikhoan.Padding = new System.Windows.Forms.Padding(4);
            this.txt_taikhoan.Size = new System.Drawing.Size(243, 25);
            this.txt_taikhoan.TabIndex = 7;
            this.txt_taikhoan.Texts = "";
            this.txt_taikhoan.Underlinestyle = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tài Khoản";
            // 
            // txt_tennkhachang
            // 
            this.txt_tennkhachang.BackColor = System.Drawing.SystemColors.Window;
            this.txt_tennkhachang.Bordercolor = System.Drawing.Color.Violet;
            this.txt_tennkhachang.Bordersize = 2;
            this.txt_tennkhachang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txt_tennkhachang.ForeColor = System.Drawing.Color.DimGray;
            this.txt_tennkhachang.Location = new System.Drawing.Point(139, 74);
            this.txt_tennkhachang.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tennkhachang.Name = "txt_tennkhachang";
            this.txt_tennkhachang.Padding = new System.Windows.Forms.Padding(4);
            this.txt_tennkhachang.Size = new System.Drawing.Size(243, 25);
            this.txt_tennkhachang.TabIndex = 3;
            this.txt_tennkhachang.Texts = "";
            this.txt_tennkhachang.Underlinestyle = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.SystemColors.Window;
            this.txt_id.Bordercolor = System.Drawing.Color.Violet;
            this.txt_id.Bordersize = 2;
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txt_id.ForeColor = System.Drawing.Color.DimGray;
            this.txt_id.Location = new System.Drawing.Point(139, 22);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Padding = new System.Windows.Forms.Padding(4);
            this.txt_id.Size = new System.Drawing.Size(243, 25);
            this.txt_id.TabIndex = 1;
            this.txt_id.Texts = "";
            this.txt_id.Underlinestyle = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // dgv_taikhoan
            // 
            this.dgv_taikhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_taikhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_taikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_taikhoan.Location = new System.Drawing.Point(33, 35);
            this.dgv_taikhoan.Name = "dgv_taikhoan";
            this.dgv_taikhoan.Size = new System.Drawing.Size(734, 486);
            this.dgv_taikhoan.TabIndex = 9;
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.Green;
            this.btn_them.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btn_them.IconColor = System.Drawing.Color.OrangeRed;
            this.btn_them.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_them.IconSize = 25;
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(45, 21);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(108, 34);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.White;
            this.btn_xoa.FlatAppearance.BorderSize = 0;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.Green;
            this.btn_xoa.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btn_xoa.IconColor = System.Drawing.Color.OrangeRed;
            this.btn_xoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_xoa.IconSize = 25;
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(45, 81);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(108, 34);
            this.btn_xoa.TabIndex = 1;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.Green;
            this.btn_sua.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.btn_sua.IconColor = System.Drawing.Color.OrangeRed;
            this.btn_sua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_sua.IconSize = 25;
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(228, 21);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(102, 34);
            this.btn_sua.TabIndex = 2;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_reload
            // 
            this.btn_reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reload.ForeColor = System.Drawing.Color.Green;
            this.btn_reload.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateForward;
            this.btn_reload.IconColor = System.Drawing.Color.OrangeRed;
            this.btn_reload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_reload.IconSize = 25;
            this.btn_reload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reload.Location = new System.Drawing.Point(228, 81);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(102, 36);
            this.btn_reload.TabIndex = 2;
            this.btn_reload.Text = "Reload";
            this.btn_reload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_reload.UseVisualStyleBackColor = true;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btn_reload);
            this.groupBox2.Controls.Add(this.btn_sua);
            this.groupBox2.Controls.Add(this.btn_xoa);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Location = new System.Drawing.Point(810, 372);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 131);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // GUI_TaiKhoanKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1239, 580);
            this.Controls.Add(this.dgv_taikhoan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GUI_TaiKhoanKhachHang";
            this.Text = "Quản lý tài khoản";
            this.Load += new System.EventHandler(this.GUI_TaiKhoanKhachHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_taikhoan)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        public Custom.RJTextBox txt_tennkhachang;
        private System.Windows.Forms.Label label2;
        public Custom.RJTextBox txt_id;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgv_taikhoan;
        public Custom.RJTextBox txt_matkhau;
        private System.Windows.Forms.Label label6;
        public Custom.RJTextBox txt_taikhoan;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btn_them;
        private FontAwesome.Sharp.IconButton btn_xoa;
        private FontAwesome.Sharp.IconButton btn_sua;
        private FontAwesome.Sharp.IconButton btn_reload;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}