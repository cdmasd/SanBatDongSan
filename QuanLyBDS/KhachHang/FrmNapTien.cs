using DTO_QuanLyBDS;
using MongoDB.Bson;
using RestSharp;
using Newtonsoft.Json;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBDS.KhachHang
{
    public partial class FrmNapTien : UIForm
    {
        BUS_QuanLyBDS.KhachHang kh = new BUS_QuanLyBDS.KhachHang();
        public FrmNapTien()
        {
            InitializeComponent();
            loadData();
        }
        private void loadData()
        {
            try
            {
                List<BsonDocument> tt = kh.showInfo(FrmMain.mail);
                if (tt.Count > 0)
                {
                    txtPhone.Text = tt[0]["Sodienthoai"].ToString();
                    txtId.Text = kh.getidKh(FrmMain.mail);
                }

            }
            catch
            {
                MessageBox.Show($"Khách hàng bị lỗi, vui lòng thử lại hoặc liên hệ hỗ trợ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTaoMa_Click(object sender, EventArgs e)
        {
            var apiRequest = new APIRequest();
            apiRequest.acqId = 970423;
            apiRequest.accountNo = "08588394595";
            apiRequest.accountName = "Phan Duc Tien";
            apiRequest.amount = Convert.ToInt32(txtNap.Text);
            apiRequest.format = "text";
            apiRequest.addInfo = $"{txtPhone.Text} {txtId.Text}";
            apiRequest.template = "compact2";
            var jsonRequest = JsonConvert.SerializeObject(apiRequest);
            // use restsharp for request api.
            var client = new RestClient("https://api.vietqr.io/v2/generate");
            var request = new RestRequest();

            request.Method = Method.Post;
            request.AddHeader("Accept", "application/json");

            request.AddParameter("application/json", jsonRequest, ParameterType.RequestBody);

            var response = client.Execute(request);
            var content = response.Content;
            var dataResult = JsonConvert.DeserializeObject<ApiResponse>(content);


            var image = Base64ToImage(dataResult.data.qrDataURL.Replace("data:image/png;base64,", ""));
            pictureBox1.Image = image;
        }
        public Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            return image;
        }
    }
}
