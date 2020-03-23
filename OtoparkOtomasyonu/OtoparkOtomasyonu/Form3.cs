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

namespace OtoparkOtomasyonu
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public string tcno { get; set; }
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=OTOPARK;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {

            conn.Open();



            SqlCommand kaydet1 = new SqlCommand("INSERT into Arac(plaka,yakıt_türü,marka) values('" + textBoxP.Text + "','" + textBoxYT.Text + "','" + textBoxM.Text + "')", conn);
            kaydet1.ExecuteNonQuery();

            SqlCommand kaydet = new SqlCommand("INSERT into Müsteri(Telefon,ad_soyad,plaka) values('" + textBoxT.Text + "','" + textBoxAS.Text + "','" + textBoxP.Text + "')", conn);
            kaydet.ExecuteNonQuery();

            SqlCommand kaydet0 = new SqlCommand("INSERT into Aboneler (telefon,mail,adres,baslama,bitis) values('" + textBoxT.Text + "','" + textBoxMail.Text + "','" + textBoxA.Text + "','" + dateTimePickerBas.Value.ToString("yyyy-MM-dd HH:mm:ss:FFF") + "','" + dateTimePickerBit.Value.ToString("yyyy-MM-dd HH:mm:ss:FFF") + "')", conn);
            kaydet0.ExecuteNonQuery();

            SqlCommand kaydet2 = new SqlCommand("INSERT into müsteri_birakir_arac(plaka,telefon,giris_zamani) values('" + textBoxP.Text + "','" + textBoxT.Text + "','" + dateTimePickerBas.Value.ToString("yyyy-MM-dd HH:mm:ss:FFF") + "')", conn);
            kaydet2.ExecuteNonQuery();
            conn.Close();

            temizle();

            MessageBox.Show("Müşteri Kayıt İşlemi Gerçekleşti.");
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();

        }
        void temizle()
        {
            textBoxP.Clear();
            textBoxAS.Clear();
            textBoxT.Clear();
            textBoxM.Clear();
            textBoxYT.Clear();
            textBoxMail.Clear();
            textBoxA.Clear();
        }
        private void textBoxAS_TextChanged(object sender, EventArgs e)
        {
            textBoxAS.Text = textBoxAS.Text.ToUpper();
            textBoxAS.SelectionStart = textBoxAS.Text.Length;
        }

        private void textBoxP_TextChanged(object sender, EventArgs e)
        {
            textBoxP.Text = textBoxP.Text.ToUpper();
            textBoxP.SelectionStart = textBoxP.Text.Length;
        }

        private void textBoxM_TextChanged(object sender, EventArgs e)
        {
            textBoxM.Text = textBoxM.Text.ToUpper();
            textBoxM.SelectionStart = textBoxM.Text.Length;
        }

        private void textBoxYT_TextChanged(object sender, EventArgs e)
        {
            textBoxYT.Text = textBoxYT.Text.ToUpper();
            textBoxYT.SelectionStart = textBoxYT.Text.Length;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand com = new SqlCommand("select * from Personel where tc_no=" + tcno + "", conn);
            SqlDataReader dar = com.ExecuteReader();

            if (dar.Read())
            {

                label11.Text = dar["ad_soyad"].ToString();
               
            }
            conn.Close();

        }
    }
}
