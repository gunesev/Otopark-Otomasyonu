using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OtoparkOtomasyonu
{
    public static class OtomasyonHelper
    {
        

        

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

       

       
    }
}
