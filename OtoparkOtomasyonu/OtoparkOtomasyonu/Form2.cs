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

namespace OtoparkOtomasyonu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=.;Initial Catalog=OTOPARK;Integrated Security=True");


        private void buttonGiris_Click(object sender, EventArgs e)
        {

            baglantı.Open();

            SqlCommand komut = new SqlCommand("select * from Personel where tc_no=" + textBoxTc.Text + " and sifre=" + textBoxSifre.Text + "", baglantı);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form1 frm = new Form1();
                this.Hide();
                frm.Show();
            }

            else { MessageBox.Show("TC veya Şifre Yanlış", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            baglantı.Close();
        }   
    }
}
