
namespace DoAn4_QuanLy
{
    partial class GUI_DONHANG
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_loadStaff = new System.Windows.Forms.Button();
            this.lbl_TongTien = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(143, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(935, 366);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_loadStaff
            // 
            this.btn_loadStaff.Location = new System.Drawing.Point(25, 64);
            this.btn_loadStaff.Name = "btn_loadStaff";
            this.btn_loadStaff.Size = new System.Drawing.Size(75, 23);
            this.btn_loadStaff.TabIndex = 1;
            this.btn_loadStaff.Text = "LOAD";
            this.btn_loadStaff.UseVisualStyleBackColor = true;
            this.btn_loadStaff.Click += new System.EventHandler(this.btn_loadStaff_Click);
            // 
            // lbl_TongTien
            // 
            this.lbl_TongTien.AutoSize = true;
            this.lbl_TongTien.Location = new System.Drawing.Point(973, 428);
            this.lbl_TongTien.Name = "lbl_TongTien";
            this.lbl_TongTien.Size = new System.Drawing.Size(62, 13);
            this.lbl_TongTien.TabIndex = 2;
            this.lbl_TongTien.Text = "Tong Tien :";
            // 
            // GUI_DONHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1117, 481);
            this.Controls.Add(this.lbl_TongTien);
            this.Controls.Add(this.btn_loadStaff);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GUI_DONHANG";
            this.Text = "GUI_NhanVien";
            this.Load += new System.EventHandler(this.GUI_NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_loadStaff;
        private System.Windows.Forms.Label lbl_TongTien;
    }
}