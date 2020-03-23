using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace OtoparkOtomasyonu
{
    public partial class Form1 : Form
    {
        BindingList<GirisBilgi> girisBilgiListesi = new BindingList<GirisBilgi>();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public Form1()
        {

            InitializeComponent();
            Form.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            kayitGetir();

   



        }


        private void buttonTamam_Click(object sender, EventArgs e)
        {
            Regex r = new Regex(@"\d{2}\s?[İ,Ş,Ü,Ö,Ç]|[A-Z]{1,3}\s?\d{2,4}");      
            bool plakaMevcutmu = girisBilgiListesi.Any(g => g.Plaka == textBoxPlaka.Text);
            if (plakaMevcutmu)
            {
                MessageBox.Show("Plaka mevcut", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
            if (r.IsMatch(textBoxPlaka.Text))
            {

                GirisBilgi girisBilgi = new GirisBilgi();
                girisBilgi.Telefon = textBoxTelefon.Text;
                girisBilgi.Isim = textBoxIsim.Text;
                girisBilgi.Plaka = textBoxPlaka.Text;
                girisBilgi.Marka = textBoxMarka.Text;
                girisBilgi.YakıtTürü = textBoxYakıtTürü.Text;
                girisBilgi.GirisTarihSaat = dateTimePickerSaat.Value;
                girisBilgi.Fiyat = 5;

                girisBilgiListesi.Add(girisBilgi);
                dataGridViewGüncelBilgi.DataSource = girisBilgiListesi;


                SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=OTOPARK;Integrated Security=True");

                conn.Open();

                SqlCommand kaydet1 = new SqlCommand("Insert into Arac(plaka,yakıt_türü,marka) values('" + textBoxPlaka.Text + "','" + textBoxYakıtTürü.Text + "','" + textBoxMarka.Text + "')", conn);
                kaydet1.ExecuteNonQuery();

                SqlCommand kaydet = new SqlCommand("Insert into Müsteri(Telefon,ad_soyad,plaka) values('" + textBoxTelefon.Text + "','" + textBoxIsim.Text + "','" + textBoxPlaka.Text + "')", conn);
                kaydet.ExecuteNonQuery();
                
                SqlCommand kaydet2 = new SqlCommand("Insert into müsteri_birakir_arac(plaka,telefon,giris_zamani) values('" + textBoxPlaka.Text + "','" + textBoxTelefon.Text + "','" + dateTimePickerSaat.Value.ToString("yyyy-MM-dd HH:mm:ss:FFF") + "')", conn);
                kaydet2.ExecuteNonQuery();
                conn.Close();

                kayitGetir();
                MessageBox.Show("Müşteri Kayıt İşlemi Gerçekleşti.");


                return;
            }

            else
            {
                MessageBox.Show("Hatalı Plaka", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                textBoxPlaka.Clear();

            }

        }


        private void buttonFis_Click(object sender, EventArgs e) 
        {
            OtomasyonHelper.GirisFisiOlustur(textBoxPlaka.Text, textBoxIsim.Text, textBoxTelefon.Text, textBoxMarka.Text, textBoxYakıtTürü.Text, dateTimePickerSaat.Value);

            textBoxPlaka.Clear();
            textBoxIsim.Clear();
            textBoxTelefon.Clear();
            textBoxMarka.Clear();
            textBoxYakıtTürü.Clear();

        }



        private void dataGridViewGüncelBilgi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonCıkıs_Click(object sender, EventArgs e)  
        {
            cik();

            foreach (DataGridViewRow drow in dataGridViewGüncelBilgi.SelectedRows)  
            {
                KayıtSil();
            }

            kayitGetir();          
                    
        }

        private void textBoxPlaka_TextChanged(object sender, EventArgs e) 
        {
            textBoxPlaka.Text = textBoxPlaka.Text.ToUpper();
            textBoxPlaka.SelectionStart = textBoxPlaka.Text.Length;
            textBoxYakıtTürü.Text = textBoxYakıtTürü.Text.ToUpper();
            textBoxYakıtTürü.SelectionStart = textBoxYakıtTürü.Text.Length;
            textBoxMarka.Text = textBoxMarka.Text.ToUpper();
            textBoxMarka.SelectionStart = textBoxMarka.Text.Length;
        }

        private void textBoxIsim_TextChanged(object sender, EventArgs e)
        {
            textBoxIsim.Text = textBoxIsim.Text.ToUpper();
            textBoxIsim.SelectionStart = textBoxIsim.Text.Length;
        }

        private void kayitGetir()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=OTOPARK;Integrated Security=True");

            con.Open();
            string kayit = "SELECT Arac.plaka,Müsteri.telefon,ad_soyad,yakıt_türü,marka,giris_zamani,Müsteri.ID FROM Müsteri FULL OUTER JOIN Arac ON Müsteri.plaka=Arac.plaka FULL OUTER JOIN  müsteri_birakir_arac ON Arac.plaka=müsteri_birakir_arac.plaka  ";
            SqlCommand komut = new SqlCommand(kayit, con);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewGüncelBilgi.DataSource = dt;
            con.Close();
        }
        void KayıtSil()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=OTOPARK;Integrated Security=True");
            int kayit = Int32.Parse(dataGridViewGüncelBilgi.CurrentRow.Cells[6].Value.ToString());
            con.Open();

            SqlCommand komut0 = new SqlCommand("DELETE FROM Aboneler WHERE ID=" + kayit + " ");
            komut0.Connection = con;
            komut0.ExecuteNonQuery();
            

            SqlCommand komut2 = new SqlCommand("DELETE FROM müsteri_birakir_arac WHERE ID=" + kayit + " ");
            komut2.Connection = con;
            komut2.ExecuteNonQuery();

            SqlCommand komut = new SqlCommand("DELETE FROM Müsteri WHERE ID=" + kayit + " ");
            komut.Connection = con;
            komut.ExecuteNonQuery();

            SqlCommand komut1 = new SqlCommand("DELETE FROM Arac WHERE ID=" + kayit + " ");
            komut1.Connection = con;
            komut1.ExecuteNonQuery();
            
            con.Close();
        }

        void cik()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=OTOPARK;Integrated Security=True");
            int kayit = Int32.Parse(dataGridViewGüncelBilgi.CurrentRow.Cells[6].Value.ToString());
            con.Open();

            SqlCommand com = new SqlCommand("SELECT*FROM Müsteri WHERE ID=" + kayit + " ");
            com.Connection = con;
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                label4.Text = dr["ad_soyad"].ToString();
                
            }
            dr.Close(); 
            SqlCommand com1 = new SqlCommand("SELECT*FROM Müsteri WHERE ID=" + kayit + " ");
            com1.Connection = con;
            SqlDataReader dr1 = com1.ExecuteReader();
            if (dr1.Read())
            {
                label5.Text = dr1["telefon"].ToString();
                
            }
            dr1.Close();
            SqlCommand com2 = new SqlCommand("SELECT*FROM Arac WHERE ID=" + kayit + " ");
            com2.Connection = con;
            SqlDataReader dr2 = com1.ExecuteReader();
            if (dr2.Read())
            {
                label6.Text = dr2["plaka"].ToString();
              
            }
            dr2.Close();
            SqlCommand com3 = new SqlCommand("SELECT*FROM müsteri_birakir_arac WHERE ID=" + kayit + " ");
            com3.Connection = con;
            SqlDataReader dr3 = com3.ExecuteReader();
            if (dr3.Read())
            {
                label7.Text = dr3["giris_zamani"].ToString();
               
            }

            dr3.Close();
            con.Close();
            label8.Text = DateTime.Now.ToString();


            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("Ad Soyad:" + label4.Text);

            stringBuilder.AppendLine("Telefon Numarası:" + label5.Text);

            stringBuilder.AppendLine("Plaka:" + label6.Text);

            stringBuilder.AppendLine("Giriş Zamanı:" + label7.Text);

            stringBuilder.AppendLine("Çıkış Zamanı:" + label8.Text);

            DateTime bTarih = Convert.ToDateTime(DateTime.Now);
            DateTime kTarih = Convert.ToDateTime(label7.Text);
            TimeSpan Sonuc = bTarih - kTarih;
            double fark = Sonuc.TotalMinutes;
            int ücret = 5;
            for (int i=0;i<=fark;i+=60)
            {
                ücret += 2;
            }

            stringBuilder.AppendLine("Ücret:"+ücret+ "₺");



            File.WriteAllText(@"c:\Cıkısfisi.txt", stringBuilder.ToString());

           
        }
       


        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelTelefon_Click(object sender, EventArgs e)
        {

        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
        }

        private void buttonAbone_Click(object sender, EventArgs e)
        {
            textBoxtcn.Visible = true;
            button4.Visible = true;           
           
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection baglantı = new SqlConnection("Data Source=.;Initial Catalog=OTOPARK;Integrated Security=True");
            baglantı.Open();

            SqlCommand komut = new SqlCommand("select * from YetkiliPersonel where tc_no=" + textBoxtcn.Text + "", baglantı);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form3 frm3 = new Form3();
                frm3.tcno = textBoxtcn.Text;
                this.Hide();
                frm3.Show();
                
            }

            else
            { MessageBox.Show("TC Numarası Yanlış", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                textBoxtcn.Visible = false;
                button4.Visible = false;

            }
            baglantı.Close();
        }
    }
}
