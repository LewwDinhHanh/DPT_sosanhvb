namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTinhTuongTu_Click(object sender, EventArgs e)
        {
            if (this.txtVbA.Text.Trim() == "" || this.txtVbB.Text.Trim() == "")
            {
                MessageBox.Show("Văn bản không thể rỗng! Hãy nhập tiếp");
            }
            else
                this.lblResult.Text = ((int)ControlCls.calSimilar2AmTiet(this.txtVbA.Text, this.txtVbB.Text)).ToString() + "%";
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn đóng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
