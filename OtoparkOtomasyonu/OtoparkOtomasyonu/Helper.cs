using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoparkOtomasyonu
{
    public static class OtomasyonHelper
    {
        public static void SetGuncelFiyat(BindingList<GirisBilgi> girisBilgiListesi)
        {
            double guncelSure;

            for (int i = 0; i < girisBilgiListesi.Count; i++)
            {
                guncelSure = GetGuncelSure(girisBilgiListesi[i].GirisTarihSaat);
                girisBilgiListesi[i].Fiyat = GetGuncelFiyat(guncelSure);
            }
        }

        public static void CıkısFisiOlustur(GirisBilgi girisBilgi) //çıkış fişini metin belgessine oluşturur
        {
            StringBuilder sB = new StringBuilder();

            sB.AppendLine("İsim:" + girisBilgi.Isim);
            sB.AppendLine("Telefon Numarası:" + girisBilgi.Telefon);
            sB.AppendLine("Plaka:" + girisBilgi.Plaka);
            sB.AppendLine("Marka:" + girisBilgi.Marka);
            sB.AppendLine("Yakıt Türü:" + girisBilgi.YakıtTürü);
            sB.AppendLine("Giriş Tarih/Saat:" + girisBilgi.GirisTarihSaat.ToString());
            sB.AppendLine("Çıkış Tarih/Saat:" + DateTime.Now.ToString());
            sB.AppendLine("Fiyat:" + girisBilgi.Fiyat + " TL");

            File.WriteAllText(@"c:\Cıkısfisi.txt", sB.ToString());


        }

        public static void GirisFisiOlustur(string plaka, string isim, string telefon,string marka,string yakıtTürü, DateTime tarihSaat)  //giriş fişini oluşturur
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("İsim:" + isim);
            stringBuilder.AppendLine("Telefon Numarası:" + telefon);
            stringBuilder.AppendLine("Plaka:" + plaka);
            stringBuilder.AppendLine("Marka:" + marka);
            stringBuilder.AppendLine("Yakıt Türü:" + yakıtTürü);
            stringBuilder.AppendLine("Tarih ve Saat:" + tarihSaat.ToString());

            File.WriteAllText(@"c:\fis.txt", stringBuilder.ToString());
        }

        public static double GetGuncelFiyat(double guncelSure)
        {
            if (guncelSure < 0)
                throw new Exception("süre 0'dan küçük olamaz");
            else if (guncelSure < 2)
                return 5;
            else if (guncelSure < 4)
                return 7;
            else if (guncelSure < 6)
                return 9;
            return 10 * (int)(guncelSure/24 + 1);
        }

        public static double GetGuncelSure(DateTime girisTarihSaat)
        {
            var fark = DateTime.Now.Subtract(girisTarihSaat);
            return Math.Ceiling(fark.TotalMinutes);
        }
    }
}
