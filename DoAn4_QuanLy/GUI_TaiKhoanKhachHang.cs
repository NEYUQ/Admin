using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn4_QuanLy
{
    public partial class GUI_TaiKhoanKhachHang : Form
    {
        public GUI_TaiKhoanKhachHang()
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
            if (checkData(txt_taikhoan.Texts.Trim()) == true)
            {
                MessageBox.Show("Trùng Tài Khoản hoặc chưa nhập Tài Khoản");
                return;
            }
            Model.AcountClient AClient = new Model.AcountClient()
            {
                ID = txt_id.Texts,
                FullName = txt_tennkhachang.Texts,
                PhoneNumber = txt_taikhoan.Texts,
                PassWord = txt_matkhau.Texts
            };
            var setter = client.Set("USER/" + txt_taikhoan.Texts, AClient);
            MessageBox.Show("data inserted successfully");
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (checkData(txt_taikhoan.Texts.Trim()) == false)
            {
                MessageBox.Show("Không đúng Tài Khoản hoặc chưa nhập Tài Khoản");
                return;
            }
            DialogResult dialog = MessageBox.Show("Bạn có chắc chăn muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                var setter = client.Update("USER/" + txt_taikhoan.Texts, GetAccount());
                MessageBox.Show("data deleted successfully");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (checkData(txt_taikhoan.Texts.Trim()) == false)
            {
                MessageBox.Show("Không đúng Tài Khoản hoặc chưa nhập Tài Khoản");
                return;
            }
            DialogResult dialog = MessageBox.Show("Bạn có chắc chăn muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                var setter = client.Delete("USER/" + txt_taikhoan.Texts);
                MessageBox.Show("data deleted successfully");
            }
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            GetDataStafffromFB("USER");
        }
        private void LoadDataFromFirebase(Dictionary<string, Model.AcountClient> record)
        {
            dgv_taikhoan.Rows.Clear();
            dgv_taikhoan.Columns.Clear();

            dgv_taikhoan.Columns.Add("ID", "ID");
            dgv_taikhoan.Columns.Add("FullName", "FullName");
            dgv_taikhoan.Columns.Add("PhoneNumber", "PhoneNumber");
            dgv_taikhoan.Columns.Add("PassWord", "PassWord");

            foreach (var item in record)
            {
                dgv_taikhoan.Rows.Add(item.Value.ID, item.Value.FullName, item.Value.PhoneNumber, item.Value.PassWord);
            }
        }
        private void GetDataStafffromFB(String strr)
        {
            FirebaseResponse res = client.Get(strr);
            Dictionary<string, Model.AcountClient> data = JsonConvert.DeserializeObject<Dictionary<string, Model.AcountClient>>(res.Body.ToString());
            LoadDataFromFirebase(data);
        }
        private Dictionary<string, Model.AcountClient> GetAccount(String strr)
        {
            FirebaseResponse res = client.Get(strr);
            Dictionary<string, Model.AcountClient> data = JsonConvert.DeserializeObject<Dictionary<string, Model.AcountClient>>(res.Body.ToString());
            return data;
        }
        private bool checkData(string texts1)
        {
            foreach (Model.AcountClient f in GetAccount("USER").Values)
            {
                if (f.ID.ToString().Equals(texts1.Trim()))
                {
                    return true;
                }
            }
            return false;
        }
        private void GUI_TaiKhoanKhachHang_Load(object sender, EventArgs e)
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
        private Model.AcountClient GetAccount()
        {
            Model.AcountClient std = new Model.AcountClient()
            {
                ID = txt_id.Texts,
                FullName = txt_tennkhachang.Texts,
                PhoneNumber = txt_taikhoan.Texts,
                PassWord = txt_matkhau.Texts
            };
            return std;
        }
    }
}
