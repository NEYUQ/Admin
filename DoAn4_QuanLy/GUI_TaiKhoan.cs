using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using Newtonsoft.Json;
using DoAn4_QuanLy.Model;
namespace DoAn4_QuanLy
{
    public partial class GUI_TaiKhoan : Form
    {
        public GUI_TaiKhoan()
        {
            InitializeComponent();
        }
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "27RVtjfuDZndQz0ZCfjIypIDwyGvwdWxyFnAN0rn",
            BasePath = "https://fastfooddelivery-646b3-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };
        IFirebaseClient client;
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (checkData(txt_manhanvien.Texts.Trim()) == true)
            {
                MessageBox.Show("Trùng Mã nhân viên hoặc chưa nhập mã Nhân viên");
                return;
            }
            Account std = new Account()
            {
                MaNhanVien = txt_manhanvien.Texts,
                TenNhanVien = txt_tennhanvien.Texts,
                DiaChi = txt_diachi.Texts,
                SoDienThoai = txt_sdt.Texts,
                TaiKhoan = txt_taikhoan.Texts,
                MatKhau = txt_matkhau.Texts,
            };
            var setter = client.Set("AccountEmployee/" +txt_manhanvien.Texts, std);
            MessageBox.Show("data inserted successfully");
        }
        private void LoadDataFromFirebase(Dictionary<string, Account> record)
        {
            dgv_taikhoan.Rows.Clear();
            dgv_taikhoan.Columns.Clear();

            dgv_taikhoan.Columns.Add("MaNhanVien", "MaNhanVien");
            dgv_taikhoan.Columns.Add("TenNhanVien", "TenNhanVien");
            dgv_taikhoan.Columns.Add("DiaChi", "DiaChi");
            dgv_taikhoan.Columns.Add("SoDienThoai", "SoDienThoai");
            dgv_taikhoan.Columns.Add("TaiKhoan", "TaiKhoan");
            dgv_taikhoan.Columns.Add("MatKhau", "MatKhau");

            foreach (var item in record)
            {
                dgv_taikhoan.Rows.Add(item.Value.MaNhanVien, item.Value.TenNhanVien, item.Value.DiaChi, item.Value.SoDienThoai, item.Value.TaiKhoan, item.Value.MatKhau);
            }
        }
        private void GetDataStafffromFB(String strr)
        {
            FirebaseResponse res = client.Get(strr);
            Dictionary<string, Account> data = JsonConvert.DeserializeObject<Dictionary<string, Account>>(res.Body.ToString());
            LoadDataFromFirebase(data);
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            GetDataStafffromFB("AccountEmployee");
        }

        private void GUI_TaiKhoan_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }
            catch
            {
                MessageBox.Show("No internet!");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (checkData(txt_manhanvien.Texts.Trim()) == false)
            {
                MessageBox.Show("Không đúng Mã nhân viên hoặc chưa nhập mã Nhân viên");
                return;
            }
            DialogResult dialog = MessageBox.Show("Bạn có chắc chăn muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                var setter = client.Delete("AccountEmployee/" + txt_manhanvien.Texts);
                MessageBox.Show("data deleted successfully");
            }
            
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (checkData(txt_manhanvien.Texts.Trim()) == false)
            {
                MessageBox.Show("Không đúng Mã nhân viên hoặc chưa nhập mã Nhân viên");
                return;
            }

            DialogResult dialog = MessageBox.Show("Bạn có chắc chăn muốn sửa không?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                var update = client.Update("AccountEmployee/" + txt_manhanvien.Texts, GetAccount());
                MessageBox.Show("data updated successfully");
            }
        }

        private void dgv_taikhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_taikhoan.Texts = dgv_taikhoan.CurrentRow.Cells["TaiKhoan"].Value.ToString();
            txt_diachi.Texts = dgv_taikhoan.CurrentRow.Cells["DiaChi"].Value.ToString();
            txt_manhanvien.Texts = dgv_taikhoan.CurrentRow.Cells["MaNhanVien"].Value.ToString();
            txt_matkhau.Texts = dgv_taikhoan.CurrentRow.Cells["MatKhau"].Value.ToString();
            txt_sdt.Texts = dgv_taikhoan.CurrentRow.Cells["SoDienThoai"].Value.ToString();
            txt_tennhanvien.Texts = dgv_taikhoan.CurrentRow.Cells["TenNhanVien"].Value.ToString();
        }
        private Account GetAccount()
        {
            Account std = new Account()
            {
                MaNhanVien = txt_manhanvien.Texts,
                TenNhanVien = txt_tennhanvien.Texts,
                DiaChi = txt_diachi.Texts,
                SoDienThoai = txt_sdt.Texts,
                TaiKhoan = txt_taikhoan.Texts,
                MatKhau = txt_matkhau.Texts,
            };
            return std;
        }
        private Dictionary<string, Account> GetAccount(String strr)
        {
            FirebaseResponse res = client.Get(strr);
            Dictionary<string, Account> data = JsonConvert.DeserializeObject<Dictionary<string, Account>>(res.Body.ToString());
            return data;
        }
        private bool checkData(string texts1)
        {
            foreach (Account f in GetAccount("AccountEmployee").Values)
            {
                if (f.MaNhanVien.ToString().Equals(texts1.Trim()))
                {
                    return true;
                }
            }
            return false;
        }
       
    }
}
