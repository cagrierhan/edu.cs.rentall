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
    public partial class addvehicle : Form
    {
        RentAll rentall = new RentAll();
        public addvehicle()
        {
            InitializeComponent();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbmarka.Items.Clear();
                cmbmodel.Items.Clear();
                if (cmbyatarac.SelectedIndex == 0)
                {
                    cmbmarka.Items.Add("Mercedes-Benz");
                    cmbmarka.Items.Add("Audi");
                    cmbmarka.Items.Add("BMW");
                    cmbmarka.Items.Add("FIAT");
                    cmbmarka.Items.Add("Volkswagen");
                    cmbmarka.Items.Add("SEAT");
                }
            }
            catch
            {
                ;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbmarka.SelectedIndex == 0)//mercedes
                {
                    cmbmodel.Items.Add("A-Class");
                    cmbmodel.Items.Add("C-Class");
                    cmbmodel.Items.Add("E-Class");
                    cmbmodel.Items.Add("S-Class");
                    cmbmodel.Items.Add("AMG");
                }
                else if (cmbmarka.SelectedIndex == 1)//audi
                {
                    cmbmodel.Items.Add("A1");
                    cmbmodel.Items.Add("A3");
                    cmbmodel.Items.Add("A4");
                    cmbmodel.Items.Add("A5");
                    cmbmodel.Items.Add("A7");
                    cmbmodel.Items.Add("A8");
                    cmbmodel.Items.Add("RS");

                }
                else if (cmbmarka.SelectedIndex == 2)//BMW
                {
                    cmbmodel.Items.Add("1 Series");
                    cmbmodel.Items.Add("2 Series");
                    cmbmodel.Items.Add("3 Series");
                    cmbmodel.Items.Add("4 Series");
                    cmbmodel.Items.Add("5 Series");
                    cmbmodel.Items.Add("6 Series");
                    cmbmodel.Items.Add("8 Series");
                    cmbmodel.Items.Add("M3");
                    cmbmodel.Items.Add("M4");
                    cmbmodel.Items.Add("M5");
                }
                else if (cmbmarka.SelectedIndex == 3)//FIAT
                {
                    cmbmodel.Items.Add("500");
                    cmbmodel.Items.Add("Egea");
                    cmbmodel.Items.Add("Doblo");
                }
                else if (cmbmarka.SelectedIndex == 4)//VW
                {
                    cmbmodel.Items.Add("Golf");
                    cmbmodel.Items.Add("Caddy");
                    cmbmodel.Items.Add("Passat");
                    cmbmodel.Items.Add("Jetta");
                    cmbmodel.Items.Add("Scirocco");
                    cmbmodel.Items.Add("Polo");
                    cmbmodel.Items.Add("Arteon");

                }
                else if (cmbmarka.SelectedIndex == 5)//SEAT
                {
                    cmbmodel.Items.Add("Leon");
                    cmbmodel.Items.Add("Ateca");
                }
             
            }
            catch
            {
                ;
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string cumle = "insert into vehicle(adplaka,kira,yakit,marka,model,durum,resim,tarih) values(@adplaka,@kira,@yakit,@marka,@model,@durum,@resim,@tarih)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@adplaka", txtnameplaka.Text);
            komut2.Parameters.AddWithValue("@kira",int.Parse(txtucret.Text));
            komut2.Parameters.AddWithValue("@yakit", cmbyakit.Text);
            komut2.Parameters.AddWithValue("@marka",cmbmarka.Text);
            komut2.Parameters.AddWithValue("@model",cmbmodel.Text);
            komut2.Parameters.AddWithValue("@durum","Boş" );
            komut2.Parameters.AddWithValue("@resim",picvehicle.ImageLocation);
            komut2.Parameters.AddWithValue("@tarih",DateTime.Now.ToString());
            rentall.degisim(komut2, cumle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
        }
    }
}
