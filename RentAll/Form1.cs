using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentAll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnadduser_Click(object sender, EventArgs e)
        {
            adduser ekle = new adduser();
            ekle.ShowDialog();
        }

        private void btnuserlist_Click(object sender, EventArgs e)
        {
            userlist listele = new userlist();
            listele.ShowDialog();           
        }

        private void btnaddvehicle_Click(object sender, EventArgs e)
        {
            addvehicle kayit = new addvehicle();
            kayit.ShowDialog();
        }

        private void btmaddyatch_Click(object sender, EventArgs e)
        {
            addyatch kayityat = new addyatch();
            kayityat.ShowDialog();
        }

        private void btncars_Click(object sender, EventArgs e)
        {
            vehiclelist aracliste = new vehiclelist();
            aracliste.ShowDialog();
        }
    }
}
