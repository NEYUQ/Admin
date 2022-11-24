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
using DoAn4_QuanLy.Model;
using Newtonsoft.Json;

namespace DoAn4_QuanLy
{
    public partial class GUI_DONHANG : Form
    {
        public GUI_DONHANG()
        {
            InitializeComponent();
        }
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "27RVtjfuDZndQz0ZCfjIypIDwyGvwdWxyFnAN0rn",
            BasePath = "https://fastfooddelivery-646b3-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };
        IFirebaseClient client;
        private void GUI_NhanVien_Load(object sender, EventArgs e)
        {
            
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }catch
            {
                MessageBox.Show("No internet!");
            }
            
        }

        private void btn_loadStaff_Click(object sender, EventArgs e)
        {
            GetDataStafffromFB("ORDER");
            lbl_TongTien.Text = "Tong Tien :" + TongTien("ORDER");
        }
        private void LoadDataFromFirebase(Dictionary<string, Oder> record)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Phone", "phoneNumber");
            dataGridView1.Columns.Add("Address", "address");
            dataGridView1.Columns.Add("price", "price");
            dataGridView1.Columns.Add("Information", "information");
            dataGridView1.Columns.Add("phoneNumberDriver", "phoneNumberDriver");
            dataGridView1.Columns.Add("nameDriver", "nameDriver");

            foreach(var item in record)
            {
                dataGridView1.Rows.Add(item.Value.id, item.Value.name, item.Value.phoneNumber, item.Value.address,
                    item.Value.price,item.Value.information,item.Value.phoneNumberDriver, item.Value.nameDriver);
            }
        }
        private void GetDataStafffromFB(String strr)
        {
            FirebaseResponse res = client.Get(strr);
            Dictionary<string, Oder> data = JsonConvert.DeserializeObject<Dictionary<string, Oder>>(res.Body.ToString());
            LoadDataFromFirebase(data);
        }

        private double TongTien(String strr)
        {
            double sum = 0;
            FirebaseResponse res = client.Get(strr);
            Dictionary<string, Oder> data = JsonConvert.DeserializeObject<Dictionary<string, Oder>>(res.Body.ToString());
            foreach(Oder o in data.Values)
            {
                sum += Double.Parse(o.price.ToString());
            }
            
            return sum;
        }
    }
}
