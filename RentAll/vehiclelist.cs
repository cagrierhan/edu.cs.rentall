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
    public partial class vehiclelist : Form
    {
        RentAll rentall = new RentAll();
        public vehiclelist()
        {
            InitializeComponent();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void vehiclelist_Load(object sender, EventArgs e)
        {
            Yeniaraclistesi();
        }

        private void Yeniaraclistesi()
        {
            String cumle = "select * from vehicle";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource=rentall.listele(adtr2, cumle);
        }

        private void picvehicle_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            txtnameplaka.Text = satir.Cells["İsim/Plaka"].Value.ToString();
            cmbmarka.Text = satir.Cells["Marka"].Value.ToString();
            cmbmodel.Text = satir.Cells["Model"].Value.ToString();
            cmbyakit.Text = satir.Cells["Yakıt"].Value.ToString();
            txtucret.Text = satir.Cells["Ucret"].Value.ToString();
            picvehicle.ImageLocation = satir.Cells["Resim"].Value.ToString();
        }
    }
}
