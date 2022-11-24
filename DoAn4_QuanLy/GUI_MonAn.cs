using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using DoAn4_QuanLy.Model;
using Newtonsoft.Json;

namespace DoAn4_QuanLy
{
    public partial class GUI_MonAn : Form
    {
        public GUI_MonAn()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "Image files(*.jpg, *.jpeg, *.bmp, *.png) | *.jpg; *.jpeg; *.bmp; *.png|All files (*.*)|*.*";
            if (od.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(od.FileName);
            }
        }
        public static string ImageIntoBase64String(PictureBox pbox)
        {
            MemoryStream ms = new MemoryStream();
            pbox.Image.Save(ms, pbox.Image.RawFormat);
            return Convert.ToBase64String(ms.ToArray());
        }

        public static Image Base64StringIntoImage(string str64)
        {
            byte[] img = Convert.FromBase64String(str64);
            MemoryStream ms = new MemoryStream(img);
            return Image.FromStream(ms);
        }
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "27RVtjfuDZndQz0ZCfjIypIDwyGvwdWxyFnAN0rn",
            BasePath = "https://fastfooddelivery-646b3-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };
        IFirebaseClient client;
        private void GUI_MonAn_Load(object sender, EventArgs e)
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
        private void LoadDataFromFirebase(Dictionary<string, Food> record)
        {
            dgv_monan.Rows.Clear();
            dgv_monan.Columns.Clear();

            if (record == null)
                return;

            dgv_monan.Columns.Add("id", "id");
            dgv_monan.Columns.Add("name", "name");
            dgv_monan.Columns.Add("catogory", "catogory");
            dgv_monan.Columns.Add("price", "price");
            dgv_monan.Columns.Add("information", "information");
            dgv_monan.Columns.Add("image", "image");
            foreach (var item in record)
            {
                dgv_monan.Rows.Add(item.Value.id, item.Value.name, item.Value.category, item.Value.price, item.Value.information, item.Value.image);
            }
        }
        private void GetDataFoodsromFB(String strr)
        {
            FirebaseResponse res = client.Get(strr);
            Dictionary<string, Food> data = JsonConvert.DeserializeObject<Dictionary<string, Food>>(res.Body.ToString());
            LoadDataFromFirebase(data);
        }
        private Dictionary<string, Food> GetFoods(String strr)
        {
            FirebaseResponse res = client.Get(strr);
            Dictionary<string, Food> data = JsonConvert.DeserializeObject<Dictionary<string, Food>>(res.Body.ToString());
            return data;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (checkData(txt_id.Texts,"Trùng mã món ăn"))
                return;
            Food data = new Food()
            {
                id = txt_id.Texts,
                name = txt_tenmonan.Texts,
                price = txt_gia.Texts,
                category = txt_loai.Texts,
                information = txt_inf.Texts,
                image = pictureBox1.Image != null ? ImageIntoBase64String(pictureBox1) : "No Image"
            };
            var set = client.Set("/Food/" + txt_id.Texts, data);
            MessageBox.Show("data inserted successfully");
            GetDataFoodsromFB("Food");
        }

        private bool checkData(string texts1,String str)
        {
            foreach(Food f in GetFoods("Food").Values)
            {
                if (f.id.Equals(texts1.Trim()))
                {
                    MessageBox.Show(str);
                    return true;
                }
            }
            return false;
        }
        private bool checkDataDeleteANDupdate(string texts1, String str)
        {
            foreach (Food f in GetFoods("Food").Values)
            {
                if (f.id.Equals(texts1.Trim()))
                {
                    return true;
                }
            }
            MessageBox.Show(str);
            return false;
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            GetDataFoodsromFB("Food");
        }

        private void dgv_monan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(!dgv_monan.CurrentRow.Cells["image"].Value.ToString().Equals("No Image"))
                pictureBox1.Image = Base64StringIntoImage(dgv_monan.CurrentRow.Cells["image"].Value.ToString());
            else
                pictureBox1.Image = null;
            txt_tenmonan.Texts = dgv_monan.CurrentRow.Cells["name"].Value.ToString();
            txt_id.Texts = dgv_monan.CurrentRow.Cells["id"].Value.ToString();
            txt_loai.Texts = dgv_monan.CurrentRow.Cells["catogory"].Value.ToString();
            txt_gia.Texts = dgv_monan.CurrentRow.Cells["price"].Value.ToString();
            txt_inf.Texts = dgv_monan.CurrentRow.Cells["information"].Value.ToString();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (!checkDataDeleteANDupdate(txt_id.Texts, "Không có mã món ăn cần xóa"))
                return;
            DialogResult dialog = MessageBox.Show("Bạn có chắc chăn muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                var delete = client.Delete("/Food/" + txt_id.Texts);
                MessageBox.Show("data deleted successfully");
            }
            GetDataFoodsromFB("Food");
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (!checkDataDeleteANDupdate(txt_id.Texts, "Không có mã món ăn cần sửa"))
                return;
            Food data = new Food()
            {
                id = txt_id.Texts,
                name = txt_tenmonan.Texts,
                price = txt_gia.Texts,
                category = txt_loai.Texts,
                information = txt_inf.Texts,
                image = pictureBox1.Image != null ? ImageIntoBase64String(pictureBox1) : "No Image"
            };
            DialogResult dialog = MessageBox.Show("Bạn có chắc chăn muốn sửa không?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                var update = client.Update("/Food/" + txt_id.Texts, data);
                MessageBox.Show("data updated successfully");
            }
            GetDataFoodsromFB("Food");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
