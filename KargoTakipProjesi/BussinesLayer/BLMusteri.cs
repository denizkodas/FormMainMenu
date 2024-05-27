using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;
namespace BussinesLayer
{
    public class BLMusteri
    {
        public static int BLMusteriEkle(EntityMusteri p)
        {
            if (p.Ad != null && p.Ad.Length >= 3 && p.Ad.Length <= 20 && p.Soyad != null && p.Soyad.Length >= 3 && p.Soyad.Length <= 20 && p.Telefon != null && p.Telefon.Length == 10 && p.Email != null && p.Email.Length <= 40 && p.Email.Length >= 15 && p.Adres != null && p.Adres.Length >= 10 && p.Adres.Length <= 100)
            {
                return DalMusteri.MusteriEkle(p);

            }
            return -1;

        }

        public static int BLMusteriGuncelle(EntityMusteri p)
        {
            if (p.Ad != null && p.Ad.Length >= 3 && p.Ad.Length <= 20 && p.Soyad != null && p.Soyad.Length >= 3 && p.Soyad.Length <= 20 && p.Telefon != null && p.Telefon.Length == 10 && p.Email != null && p.Email.Length <= 40 && p.Email.Length >= 15 && p.Adres != null && p.Adres.Length >= 10 && p.Adres.Length <= 100)
            {
                return DalMusteri.MusteriGuncelle(p);

            }
            return -1;


        }



        public static int BLMusteriSil(EntityMusteri p)
        {

            if (p.MusteriID > 0)
            {
                return DalMusteri.MusteriSil(p);
            }
            return -1;
        }


        public static List<EntityMusteri> MusteriListele()
        {
            return DalMusteri.MusteriListele();


        }
    }
}