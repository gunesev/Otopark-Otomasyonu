using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OtoparkOtomasyonu;

namespace UnitTestOtoparkOtomasyonu
{
    [TestClass]
    public class UnitTest1   //fiyat hesaplamasının yapıldığı sınıf
    {
        [TestMethod]
        public void TestMethodGetGuncelSure()
        {
            DateTime baslangic = DateTime.Now.AddMinutes(-1.5);
            double sonuc = OtomasyonHelper.GetGuncelSure(baslangic);
            Assert.AreEqual(2, sonuc);
        }

        [TestMethod]
        public void TestMethodGetGuncelFiyat1()
        {
            double sure = 1;
            double fiyat = OtomasyonHelper.GetGuncelFiyat(sure);
            Assert.AreEqual(5, fiyat);
        }

        [TestMethod]
        public void TestMethodGetGuncelFiyat2()
        {
            double sure = 2;
            double fiyat = OtomasyonHelper.GetGuncelFiyat(sure);
            Assert.AreEqual(7, fiyat);
        }
        [TestMethod]
        public void TestMethodGetGuncelFiyat3()
        {
            double sure = 5;
            double fiyat = OtomasyonHelper.GetGuncelFiyat(sure);
            Assert.AreEqual(9, fiyat);
        }

        [TestMethod]
        public void TestMethodGetGuncelFiyat4()
        {
            double sure = 25;
            double fiyat = OtomasyonHelper.GetGuncelFiyat(sure);
            Assert.AreEqual(20, fiyat);
        }
    }

    
}
