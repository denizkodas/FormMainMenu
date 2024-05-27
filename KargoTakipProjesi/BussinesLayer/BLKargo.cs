using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;
namespace BussinesLayer
{
    public class BLKargo
    {
        public static int BLKargoEkle(EntityKargo p)
        {
            if (p.MusteriID != null && p.KargoID_Gonderen != null && p.KargoID_Alan != null && p.Agirlik != null && p.Durum != null && p.Durum.Length <= 20 && p.Durum.Length >= 3 && p.Adres != null && p.Adres.Length >= 10 && p.Adres.Length <= 100 && p.Ebat != null && p.Ebat.Length >= 3 && p.Ebat.Length <= 50 && p.Aciklama.Length <= 200)
            {
                return DalKargo.KargoEkle(p);

            }
            return -1;

        }

        public static int BLKargoGuncelle(EntityKargo p)
        {
            if (p.MusteriID != null && p.KargoID_Gonderen != null && p.KargoID_Alan != null && p.Agirlik != null && p.Durum != null && p.Durum.Length <= 20 && p.Durum.Length >= 3 && p.Adres != null && p.Adres.Length >= 10 && p.Adres.Length <= 100 && p.Ebat != null && p.Ebat.Length >= 3 && p.Ebat.Length <= 50 && p.Aciklama.Length <= 200)
            {
                return DalKargo.KargoGuncelle(p);

            }
            return -1;


        }



        public static int BLKargoSil(EntityKargo p)
        {

            if (p.MusteriID > 0)
            {
                return DalKargo.KargoSil(p);
            }
            return -1;
        }


        public static List<EntityKargo> KargoListele()
        {
            return DalKargo.KargoListele();


        }
    }
}