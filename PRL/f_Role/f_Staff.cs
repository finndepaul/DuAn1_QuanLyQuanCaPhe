namespace PRL
{
    public partial class f_Staff : Form
    {
        public f_Staff()
        {
            InitializeComponent();
        }

        private void btn_Home_Click(object sender, EventArgs e) //
        {
            f_TrangChu objForm = new f_TrangChu();
            objForm.TopLevel = false;
            pn_Staff.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void f_Staff_Load(object sender, EventArgs e)
        {
            f_TrangChu objForm = new f_TrangChu();
            objForm.TopLevel = false;
            pn_Staff.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            var mess = MessageBox.Show("Bạn xác nhận đăng xuất?", "Xác nhận", MessageBoxButtons.OKCancel);

            if (mess == DialogResult.OK)
            {
                // Ẩn form hiện tại
                this.Hide();

                // Tạo và hiển thị form đăng nhập mới
                f_Login f_Login = new f_Login();
                f_Login.ShowDialog();

                // Đóng form hiện tại khi form đăng nhập đóng
                this.Close();
            }
            else if (mess == DialogResult.Cancel)
            {
                // Do nothing or handle as needed
                return;
            }
        }
    }
}