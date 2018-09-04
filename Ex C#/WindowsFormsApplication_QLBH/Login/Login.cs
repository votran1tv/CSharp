using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string ckn = @"Data Source=DESKTOP-5HCOVCQ\VOTRAN;Initial Catalog=QuanLyBanHang;Integrated Security=True";
            SqlConnection conn = new SqlConnection(ckn);
            try
            { }
            catch(Exception ex)
            {
                MessageBox.Show("Không kết nối Database:" + ex.ToString());
            }
        }
    }
}
