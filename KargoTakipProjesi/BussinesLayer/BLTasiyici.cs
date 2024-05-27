using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;
namespace BussinesLayer
{
    public class BLTasiyici
    {
        public static int BLTasiyiciEkle(EntityTasiyici p)
        {
            if (p.Ad != null && p.Ad.Length >= 3 && p.Ad.Length <= 20 && p.Soyad != null && p.Soyad.Length >= 3 && p.Soyad.Length <= 20 && p.Telefon != null && p.Email != null)
            {
                if ( p.Telefon.Length == 10 && p.Email.Length <= 40 && p.Email.Length >= 15)
                {
                    return DalTasiyici.TasiyiciEkle(p);
                }
                

            }
            return -1;

        }

        public static int BLTasiyiciGuncelle(EntityTasiyici p)
        {
            if (p.Ad != null && p.Ad.Length >= 3 && p.Ad.Length <= 20 && p.Soyad != null && p.Soyad.Length >= 3 && p.Soyad.Length <= 20 && p.Telefon != null && p.Telefon.Length == 10 && p.Email.Length <= 40 && p.Email.Length >= 15)
            {
                return DalTasiyici.TasiyiciGuncelle(p);

            }
            return -1;


        }



        public static int BLTasiyiciSil(EntityTasiyici p)
        {

            if (p.TasiyiciID > 0)
            {
                return DalTasiyici.TasiyiciSil(p);
            }
            return -1;
        }


        public static List<EntityTasiyici> TasiyiciListele()
        {
            return DalTasiyici.TasiyiciListele();


        }
    }
}