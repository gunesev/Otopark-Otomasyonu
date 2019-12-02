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
            

            var startTimeSpan = TimeSpan.Zero;
            var periodTimeSpan = TimeSpan.FromSeconds(15);

            var timer = new System.Threading.Timer((t) =>
            {
                if (dataGridViewGüncelBilgi.DataSource != null)
                {
                    OtomasyonHelper.SetGuncelFiyat(girisBilgiListesi);
                    //dataGridViewGüncelBilgi.DataSource = girisBilgiListesi;
                }
            }, null, startTimeSpan, periodTimeSpan);
        }
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=OTOPARK;Integrated Security=True");

       



        private void buttonTamam_Click(object sender, EventArgs e)
        {
            Regex r = new Regex(@"\d{2}\s?[İ,Ş,Ü,Ö,Ç]|[A-Z]{1,3}\s?\d{2,4}");       //plakanın geçerliliğini kontrol eder
            bool plakaMevcutmu = girisBilgiListesi.Any(g => g.Plaka == textBoxPlaka.Text);
            if (plakaMevcutmu)
            {
                MessageBox.Show("Plaka mevcut", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
            if (r.IsMatch(textBoxPlaka.Text)) //plaka geçerli ve mevcut değilse datagridview e aktarır
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


                //veri tabanı bağlantısı
               // SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=OTOPARK;Integrated Security=True");
                               
                conn.Open();    
               
                //alınan bilgileri veritabanına kaydeder
                SqlCommand kaydet = new SqlCommand("Insert into Müsteri(Telefon,ad_soyad) values('"+textBoxTelefon.Text +"','" + textBoxIsim.Text + "')", conn);
                kaydet.ExecuteNonQuery();
                SqlCommand kaydet1 = new SqlCommand("Insert into Arac(plaka,yakıt_türü,marka) values('" + textBoxPlaka.Text + "','" + textBoxYakıtTürü.Text + "','" + textBoxMarka.Text + "')", conn);
                kaydet1.ExecuteNonQuery();
                SqlCommand kaydet2 = new SqlCommand("Insert into müsteri_birakir_arac(plaka,telefon,giris_zamani) values('" + textBoxPlaka.Text + "','" + textBoxTelefon.Text + "','" + dateTimePickerSaat.Value.ToString("yyyy-MM-dd HH:mm:ss:FFF") + "')", conn);
                kaydet2.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Müşteri Kayıt İşlemi Gerçekleşti.");
                
                return;
            }
            
            else
            {
                MessageBox.Show("Hatalı Plaka","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                
                textBoxPlaka.Clear();

            }  

        }


        private void buttonFis_Click(object sender, EventArgs e) //giriş fişini yazdırır
        {
            OtomasyonHelper.GirisFisiOlustur(textBoxPlaka.Text, textBoxIsim.Text,textBoxTelefon.Text,textBoxMarka.Text,textBoxYakıtTürü.Text, dateTimePickerSaat.Value);
             
            textBoxPlaka.Clear();
            textBoxIsim.Clear();
            textBoxTelefon.Clear();
            textBoxMarka.Clear();
            textBoxYakıtTürü.Clear();
            

            
        }

        

        private void dataGridViewGüncelBilgi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonCıkıs_Click(object sender, EventArgs e)  //datagridview de seçilenin çıkış  fişini yazdırır
        {
            if (dataGridViewGüncelBilgi.SelectedRows.Count > 0)
            {
                var selectedItem = ((BindingList<GirisBilgi>)(dataGridViewGüncelBilgi.DataSource))[dataGridViewGüncelBilgi.SelectedRows[0].Index];

                OtomasyonHelper.CıkısFisiOlustur(selectedItem);

                dataGridViewGüncelBilgi.Rows.RemoveAt(dataGridViewGüncelBilgi.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Lüffen Çıkış Yapacak Aracı Seçin");
            }
        }

        private void textBoxPlaka_TextChanged(object sender, EventArgs e) //yazılan harfleri büyük yapar
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
    }
}
