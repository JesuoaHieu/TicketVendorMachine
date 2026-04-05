using System;
using System.Data.SqlClient; 
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketVendorMachine 
{
    public partial class Form1 : Form
    {
       
        string strConn = @"Data Source=HP-OMEN;Initial Catalog=TicketDB;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        
            pnHome.Visible = true;
            pnSelect.Visible = false;
            pnPayment.Visible = false;
        }
        void LuuVaoSQL(string ga, string phuongThuc)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                string sql = "INSERT INTO Transactions (StationName, Price, PaymentMethod, Status) VALUES (@ga, @gia, @pt, @st)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ga", ga);
                cmd.Parameters.AddWithValue("@gia", 15000);
                cmd.Parameters.AddWithValue("@pt", phuongThuc);
                cmd.Parameters.AddWithValue("@st", "Success");

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }


        private void btnStart_Click_1(object sender, EventArgs e)
        {
            pnHome.Visible = false;
            pnSelect.Visible = true;
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            if (cbGa.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn ga!");
                return;
            }
            pnSelect.Visible = false;
            pnPayment.Visible = true;
        }

        private async void btnMomo_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Đang kết nối Momo...");
            await Task.Delay(2000); 

            try
            {
                LuuVaoSQL(cbGa.Text, "Momo");
                MessageBox.Show("Mua vé thành công! Đã lưu vào SQL.");
                pnPayment.Visible = false;
                pnHome.Visible = true; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối SQL: " + ex.Message);
            }
        }

        private void pnPayment_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void btnCard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vui lòng chạm thẻ vào khe đọc...");
            await Task.Delay(3000);

            try
            {
                LuuVaoSQL(cbGa.Text, "Card");
                MessageBox.Show("Thanh toán THẺ thành công! Đã lưu vào SQL.");
                pnPayment.Visible = false;
                pnHome.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối SQL: " + ex.Message);
            }
        }
    }
}