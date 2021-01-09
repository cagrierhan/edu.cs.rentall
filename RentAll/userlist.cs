using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentAll
{
    public partial class userlist : Form
    {
        RentAll rentall = new RentAll();
        public userlist()
        {
            InitializeComponent();
        }

        private void userlist_Load(object sender, EventArgs e)
        {
            tablereflesh();
        }

        private void tablereflesh()
        {
            String cumle = "select * form kullanıcı";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = rentall.listele(adtr2, cumle);
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            
            
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            txttcnum.Text = satir.Cells["TC"].Value.ToString();
            txtname.Text = satir.Cells["İsim"].Value.ToString();
            txtpass.Text = satir.Cells["Sifre"].Value.ToString();
            txttel.Text = satir.Cells["Numara"].Value.ToString();
            txtmail.Text = satir.Cells["Mail"].Value.ToString();
        }
    }
}
