using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri m1 = new Musteri();
            m1.MusteriID = 1;
            m1.MusteriAd = "ismail";
            m1.MusteriSoyAd = "yonca";
            m1.MusteriEmail = "ismail@gamil.com";
            m1.MusteriKullaniciAd = "ismail.yonca";
            m1.MusteriSifre = "1";

            Musteri.MusteriEkle(m1);



        }
    }
}
