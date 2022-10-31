using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYonetimProgrami
{
    public class OduncIslemler
    {
        private List<OduncIslem> _OduncIslemListesi = new List<OduncIslem>();

        public List<OduncIslem> OduncIslemListesi { get => _OduncIslemListesi; }

        public void OduncIslemEkle(OduncIslem YeniOduncIslem)
        {
            if (YeniOduncIslem.Kitap.KitapAdet == 0)
            {
                //Kitap Stoğu Olmadığından Hata Fırlatılmalı ve İşlem Yapılmamalı
            }
            _OduncIslemListesi.Add(YeniOduncIslem);
        }
        

        public void OduncIslemSil(int OduncIslemID)
        {
            OduncIslem silinecekIslem = OduncIslemListesi.Where(e => e.OduncIslemID == OduncIslemID).FirstOrDefault<OduncIslem>();

            if (silinecekIslem != null)
            {
                _OduncIslemListesi.Remove(silinecekIslem);
            }
        }
    }

    public class OduncIslem
    {
        private int _OduncIslemID;
        private Kitap _Kitap;
        private int _OgrenciNo;
        private DateTime _AlisTarihi;
        private DateTime _TeslimTarihi;

        public int OduncIslemID { get => _OduncIslemID; set => _OduncIslemID = value; }
        public Kitap Kitap { get => _Kitap; set => _Kitap = value; }
        public int OgrenciNo { get => _OgrenciNo; set => _OgrenciNo = value; }
        public DateTime AlisTarihi { get => _AlisTarihi; }
        public DateTime TeslimTarihi { get => _TeslimTarihi; set => _TeslimTarihi = value; }

        public OduncIslem(int oduncIslemID,Kitap kitap, int ogrenciNo)
        {
            if(kitap.KitapAdet == 0)
            {
                //Kitap Stoğu Olmadığından Hata Fırlatılmalı ve İşlem Create Edilmemeli
            }
            OduncIslemID = oduncIslemID;
            Kitap = kitap;
            OgrenciNo = ogrenciNo;
            _AlisTarihi = DateTime.Now;
        }


    }
}
