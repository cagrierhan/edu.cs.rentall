using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentAll
{
    class RentAll
    {
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-T311M4I4;Initial Catalog=rentalluserlist;Integrated Security=True");
        DataTable tablo;
        public void degisim(SqlCommand komut,string sorgu)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public DataTable listele(SqlDataAdapter adtr, string sorgu)
        {
            DataTable tablo = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sorgu, baglanti);
            adtr = sqlDataAdapter;
            adtr.Fill(tablo);
            baglanti.Close();
            return tablo;
        }
    }
}
