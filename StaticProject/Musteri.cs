using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticProject
{
    public class Musteri
    {
        static ArrayList musteriDatabase;

        static Musteri()
        {
            musteriDatabase = new ArrayList();
        }

        public int MusteriID { get; set; }
        public String MusteriAd { get; set; }
        public String MusteriSoyAd { get; set; }
        public String MusteriEmail { get; set; }
        public String MusteriSifre { get; set; }

        private String _musteriKullaniciAd;

        public String MusteriKullaniciAd
        {
            get
            {
                return this._musteriKullaniciAd;
            }
            set
            {
                bool kullaniciAdiKontrol = musteriKullaniciAdiKontrol(value);

                if (kullaniciAdiKontrol)
	            {
                    Console.WriteLine("Bu kullanıcı adı kayıtlı");
                    this._musteriKullaniciAd= string.Empty;
	            }
                else
                {
                    this._musteriKullaniciAd = value;
                }
            }
        }


        static bool musteriKullaniciAdiKontrol(string _musteriKullaniciAd)
        {
            bool Kontrol = false;

            for (int i = 0; i < musteriDatabase.Count; i++)
			{
                Musteri Temp = (Musteri)musteriDatabase[i];
                if (Temp.MusteriKullaniciAd == _musteriKullaniciAd)
            	{
                    Kontrol = true;
                    break;
	            }
			}
            return Kontrol;
        }

        public  static void MusteriEkle(Musteri M)
        {
            if (M != null && !string.IsNullOrEmpty(M.MusteriKullaniciAd) 
                && !string.IsNullOrEmpty(M.MusteriEmail))
	        {
                 bool emailAdresKontrol = musteriEmailAdresKontrol(M.MusteriEmail);

                if (emailAdresKontrol)
	            {
                    Console.WriteLine("Bu Email adı kayıtlı");
	            }
                else
                {
                    musteriDatabase.Add(M);
                    Console.WriteLine("Kaytı yapıldı");
                }
        	}
        }

        static bool musteriEmailAdresKontrol(string _emailAdres)
        {
            bool Kontrol = false;

            for (int i = 0; i < musteriDatabase.Count; i++)
			{
                Musteri Temp = (Musteri)musteriDatabase[i];
                if (Temp.MusteriEmail == _emailAdres)
            	{
                    Kontrol = true;
                    break;
	            }
			}
            return Kontrol;
        }


    }
}   
