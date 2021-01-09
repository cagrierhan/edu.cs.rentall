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
    public partial class addyatch : Form
    {
        RentAll rentall = new RentAll();
        public addyatch()
        {
            InitializeComponent();
        }

        private void addyatch_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            picvehicle.ImageLocation = openFileDialog1.FileName;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbmarka_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (cmbmarka.SelectedIndex == 0)//Absolute
                {
                    cmbmodel.Items.Add("MotorYat");
                    cmbmodel.Items.Add("Katamaran");

                }
                else if (cmbmarka.SelectedIndex == 1)//Canados
                {
                    cmbmodel.Items.Add("MotorYat");
                    cmbmodel.Items.Add("Katamaran");

                }
                else if (cmbmarka.SelectedIndex == 2)//Catana
                {
                    cmbmodel.Items.Add("MotorYat");
                    cmbmodel.Items.Add("Katamaran");
                }

            }
            catch
            {
                ;
            }

        }

        private void cmbmodel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbyatarac_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                cmbmarka.Items.Clear();
                cmbmodel.Items.Clear();
                if (cmbyatarac.SelectedIndex == 0)
                {
                    cmbmarka.Items.Add("Absolute");
                    cmbmarka.Items.Add("Canados");
                    cmbmarka.Items.Add("Catana");
                }
            }
            catch
            {
                ;
            }
        }

        private void btnupdate_Click_1(object sender, EventArgs e)
        {
            string cumle = "insert into vehicle(adplaka,kira,yakit,marka,model,durum,resim,tarih) values(@adplaka,@kira,@yakit,@marka,@model,@durum,@resim,@tarih)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@adplaka", txtnameplaka.Text);
            komut2.Parameters.AddWithValue("@kira", int.Parse(txtucret.Text));
            komut2.Parameters.AddWithValue("@yakit", cmbyakit.Text);
            komut2.Parameters.AddWithValue("@marka", cmbmarka.Text);
            komut2.Parameters.AddWithValue("@model", cmbmodel.Text);
            komut2.Parameters.AddWithValue("@durum", "Boş");
            komut2.Parameters.AddWithValue("@resim", picvehicle.ImageLocation);
            komut2.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            rentall.degisim(komut2, cumle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";

        }
    }
}
