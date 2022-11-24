
namespace DoAn4_QuanLy
{
    partial class GUI_MonAn
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_loai = new DoAn4_QuanLy.Custom.RJTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_gia = new DoAn4_QuanLy.Custom.RJTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tenmonan = new DoAn4_QuanLy.Custom.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id = new DoAn4_QuanLy.Custom.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_reload = new FontAwesome.Sharp.IconButton();
            this.btn_sua = new FontAwesome.Sharp.IconButton();
            this.btn_xoa = new FontAwesome.Sharp.IconButton();
            this.btn_them = new FontAwesome.Sharp.IconButton();
            this.dgv_monan = new System.Windows.Forms.DataGridView();
            this.txt_inf = new DoAn4_QuanLy.Custom.RJTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_monan)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txt_inf);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_loai);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_gia);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_tenmonan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(800, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 439);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin món ăn";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(109, 276);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(187, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Hình Ảnh";
            // 
            // txt_loai
            // 
            this.txt_loai.BackColor = System.Drawing.SystemColors.Window;
            this.txt_loai.Bordercolor = System.Drawing.Color.Violet;
            this.txt_loai.Bordersize = 2;
            this.txt_loai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txt_loai.ForeColor = System.Drawing.Color.DimGray;
            this.txt_loai.Location = new System.Drawing.Point(139, 170);
            this.txt_loai.Margin = new System.Windows.Forms.Padding(4);
            this.txt_loai.Name = "txt_loai";
            this.txt_loai.Padding = new System.Windows.Forms.Padding(4);
            this.txt_loai.Size = new System.Drawing.Size(243, 25);
            this.txt_loai.TabIndex = 7;
            this.txt_loai.Texts = "";
            this.txt_loai.Underlinestyle = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Loại";
            // 
            // txt_gia
            // 
            this.txt_gia.BackColor = System.Drawing.SystemColors.Window;
            this.txt_gia.Bordercolor = System.Drawing.Color.Violet;
            this.txt_gia.Bordersize = 2;
            this.txt_gia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txt_gia.ForeColor = System.Drawing.Color.DimGray;
            this.txt_gia.Location = new System.Drawing.Point(139, 122);
            this.txt_gia.Margin = new System.Windows.Forms.Padding(4);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Padding = new System.Windows.Forms.Padding(4);
            this.txt_gia.Size = new System.Drawing.Size(243, 25);
            this.txt_gia.TabIndex = 5;
            this.txt_gia.Texts = "";
            this.txt_gia.Underlinestyle = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giá";
            // 
            // txt_tenmonan
            // 
            this.txt_tenmonan.BackColor = System.Drawing.SystemColors.Window;
            this.txt_tenmonan.Bordercolor = System.Drawing.Color.Violet;
            this.txt_tenmonan.Bordersize = 2;
            this.txt_tenmonan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txt_tenmonan.ForeColor = System.Drawing.Color.DimGray;
            this.txt_tenmonan.Location = new System.Drawing.Point(139, 74);
            this.txt_tenmonan.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tenmonan.Name = "txt_tenmonan";
            this.txt_tenmonan.Padding = new System.Windows.Forms.Padding(4);
            this.txt_tenmonan.Size = new System.Drawing.Size(243, 25);
            this.txt_tenmonan.TabIndex = 3;
            this.txt_tenmonan.Texts = "";
            this.txt_tenmonan.Underlinestyle = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Món";
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
            this.label1.Location = new System.Drawing.Point(44, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
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
            this.groupBox2.Location = new System.Drawing.Point(800, 480);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 96);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
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
            this.btn_reload.Location = new System.Drawing.Point(310, 38);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(93, 36);
            this.btn_reload.TabIndex = 2;
            this.btn_reload.Text = "Reload";
            this.btn_reload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_reload.UseVisualStyleBackColor = true;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
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
            this.btn_sua.Location = new System.Drawing.Point(211, 40);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(84, 34);
            this.btn_sua.TabIndex = 2;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
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
            this.btn_xoa.Location = new System.Drawing.Point(109, 39);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(82, 34);
            this.btn_xoa.TabIndex = 1;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
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
            this.btn_them.Location = new System.Drawing.Point(13, 39);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(84, 34);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dgv_monan
            // 
            this.dgv_monan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_monan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_monan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_monan.Location = new System.Drawing.Point(33, 35);
            this.dgv_monan.Name = "dgv_monan";
            this.dgv_monan.Size = new System.Drawing.Size(734, 541);
            this.dgv_monan.TabIndex = 9;
            this.dgv_monan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_monan_CellClick);
            // 
            // txt_inf
            // 
            this.txt_inf.BackColor = System.Drawing.SystemColors.Window;
            this.txt_inf.Bordercolor = System.Drawing.Color.Violet;
            this.txt_inf.Bordersize = 2;
            this.txt_inf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txt_inf.ForeColor = System.Drawing.Color.DimGray;
            this.txt_inf.Location = new System.Drawing.Point(139, 213);
            this.txt_inf.Margin = new System.Windows.Forms.Padding(4);
            this.txt_inf.Name = "txt_inf";
            this.txt_inf.Padding = new System.Windows.Forms.Padding(4);
            this.txt_inf.Size = new System.Drawing.Size(243, 25);
            this.txt_inf.TabIndex = 12;
            this.txt_inf.Texts = "";
            this.txt_inf.Underlinestyle = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Information";
            // 
            // GUI_MonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1239, 635);
            this.Controls.Add(this.dgv_monan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GUI_MonAn";
            this.Text = "Quản lý món ăn";
            this.Load += new System.EventHandler(this.GUI_MonAn_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_monan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public Custom.RJTextBox txt_loai;
        private System.Windows.Forms.Label label4;
        public Custom.RJTextBox txt_gia;
        private System.Windows.Forms.Label label3;
        public Custom.RJTextBox txt_tenmonan;
        private System.Windows.Forms.Label label2;
        public Custom.RJTextBox txt_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btn_reload;
        private FontAwesome.Sharp.IconButton btn_sua;
        private FontAwesome.Sharp.IconButton btn_xoa;
        private FontAwesome.Sharp.IconButton btn_them;
        public System.Windows.Forms.DataGridView dgv_monan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        public Custom.RJTextBox txt_inf;
        private System.Windows.Forms.Label label6;
    }
    
    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>


        #endregion
}