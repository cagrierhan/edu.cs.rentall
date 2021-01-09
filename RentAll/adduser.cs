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
    public partial class adduser : Form 
    {
        RentAll rent_all = new RentAll();
        public adduser()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string word = "insert into kullanıcı(tcno,adsoyad,email,telefonnum,sifre) values(@tcno,@adsoyad,@email,@telefon,@sifre)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@tcno", txttcnum.Text);
            komut2.Parameters.AddWithValue("@adsoyad", txtname.Text);
            komut2.Parameters.AddWithValue("@email", txtmail.Text);
            komut2.Parameters.AddWithValue("@telefon", txttel.Text);
            komut2.Parameters.AddWithValue("@sifre", txtpass.Text);
            rent_all.degisim(komut2, word);
            foreach (Control item in Controls) if (item is TextBox) item.Text = ""; 
        }
    }
}
