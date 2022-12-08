using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrunModel;

namespace BusinessLayer
{
    public class BusinessUrun
    {
        public void UrunEkle(string UrunAdi,double maliyet, short karOran, byte kdvOran)
        {
            Urun u = new Urun();

            u.UrunAdi = UrunAdi;
            u.BirimMaliyet = maliyet;
            u.KarOrani = karOran;
            u.KDVOrani = kdvOran;

            double birimFiyat = maliyet + (maliyet * karOran) / 100;

            u.KDVliFiyat = birimFiyat + (birimFiyat * kdvOran) / 100;

            DataAccessLibrary.UrunDB db = new DataAccessLibrary.UrunDB();

            db.UrunEkle(u);
        }

        public Urun UrunBul(int UrunID)
        {
            DataAccessLibrary.UrunDB db = new DataAccessLibrary.UrunDB();
            return db.UrunBul(UrunID);
        }

        public List<Urun> TumUrunler()
        {
            DataAccessLibrary.UrunDB db = new DataAccessLibrary.UrunDB();
            return db.TumUrunler();
        }

        public void UrunSil(int UrunID)
        {
            DataAccessLibrary.UrunDB db = new DataAccessLibrary.UrunDB();

            db.UrunSil(UrunID);
        }
    }
}
