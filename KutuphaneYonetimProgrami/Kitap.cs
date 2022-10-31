using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYonetimProgrami
{
    public class Kitaplar
    {
        private List<Kitap> _KitapListesi = new List<Kitap>();

        public List<Kitap> KitapListesi { get => _KitapListesi; }

        public void KitapSil(int KitapID)
        {
            Kitap silinecekKitap = KitapListesi.Where(e => e.KitapID == KitapID).FirstOrDefault<Kitap>();

            if(silinecekKitap != null)
            {
                _KitapListesi.Remove(silinecekKitap);
            }
        }

        public void KitapEkle(Kitap YeniKitap)
        {
            _KitapListesi.Add(YeniKitap);
        }
    }
    
    public class Kitap
    {
        private int _KitapID;
        private string _KitapAd;
        private string _KitapYazar;
        private int _KitapBasimYil;
        private long _KitapISBN;
        private static int _KitapAdet;
        private bool _KitapKullanilabilirMi;
        
        public int KitapID { get => _KitapID; set => _KitapID = value; }
        public string KitapAd { get => _KitapAd; set => _KitapAd = value; }
        public string KitapYazar { get => _KitapYazar; set => _KitapYazar = value; }
        public int KitapBasimYil { get => _KitapBasimYil; set => _KitapBasimYil = value; }
        public long KitapISBN { get => _KitapISBN; set => _KitapISBN = value; }
        public int KitapAdet { get => _KitapAdet; set => _KitapAdet = value; }
        public bool KitapKullanilabilirMi { get => _KitapKullanilabilirMi; set => _KitapKullanilabilirMi = value; }

        public Kitap(int kitapID, string kitapAd, string kitapYazar, int kitapBasimYil, long kitapISBN, int kitapAdet, bool kitapKullanilabilirMi)
        {
            KitapID = kitapID;
            KitapAd = kitapAd;
            KitapYazar = kitapYazar;
            KitapBasimYil = kitapBasimYil;
            KitapISBN = kitapISBN;
            KitapAdet = kitapAdet;
            KitapKullanilabilirMi = kitapKullanilabilirMi;
        }
    }
}
