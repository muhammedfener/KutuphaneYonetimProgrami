using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYonetimProgrami
{
    public class Ogrenciler
    {
        private List<Ogrenci> _OgrenciListesi = new List<Ogrenci>();

        public List<Ogrenci> OgrenciListesi { get => _OgrenciListesi; }

        public void OgrenciSil(int OgrenciID)
        {
            Ogrenci silinecekOgrenci = OgrenciListesi.Where(e => e.OgrenciID == OgrenciID).FirstOrDefault<Ogrenci>();

            if (silinecekOgrenci != null)
            {
                _OgrenciListesi.Remove(silinecekOgrenci);
            }
        }

        public void OgrenciEkle(Ogrenci YeniOgrenci)
        {
            _OgrenciListesi.Add(YeniOgrenci);
        }
    }

    public class Ogrenci
    {
        private int _OgrenciID;
        private long _OgrenciNo;
        private long _OgrenciTCKimlik;
        private string _OgrenciAd;
        private string _OgrenciSoyad;
        private string _OgrenciBolum;
        private int _OgrenciSinif;

        public int OgrenciID { get => _OgrenciID; set => _OgrenciID = value; }
        public long OgrenciNo { get => _OgrenciNo; set => _OgrenciNo = value; }
        public long OgrenciTCKimlik { get => _OgrenciTCKimlik; set => _OgrenciTCKimlik = value; }
        public string OgrenciAd { get => _OgrenciAd; set => _OgrenciAd = value; }
        public string OgrenciSoyad { get => _OgrenciSoyad; set => _OgrenciSoyad = value; }
        public string OgrenciBolum { get => _OgrenciBolum; set => _OgrenciBolum = value; }
        public int OgrenciSinif { get => _OgrenciSinif; set => _OgrenciSinif = value; }

        public Ogrenci(int ogrenciID, long ogrenciNo, long ogrenciTCKimlik, string ogrenciAd, string ogrenciSoyad, string ogrenciBolum, int ogrenciSinif)
        {
            OgrenciID = ogrenciID;
            OgrenciNo = ogrenciNo;
            OgrenciTCKimlik = ogrenciTCKimlik;
            OgrenciAd = ogrenciAd;
            OgrenciSoyad = ogrenciSoyad;
            OgrenciBolum = ogrenciBolum;
            OgrenciSinif = ogrenciSinif;
        }

    }
}
