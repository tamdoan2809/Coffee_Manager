using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCF
{
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connect db = new Connect();
            string tv = "update NhanVien set MatKhau ='" + textBox2.Text + "'where TaiKhoan='" + textBox1.Text + "'";
            int kq = db.getNonQuery(tv);
            if (kq == 0)
            {
                MessageBox.Show("Chua sua");
            }
            else
            {
                MessageBox.Show("Da sua");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
