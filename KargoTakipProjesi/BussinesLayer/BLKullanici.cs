using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;
namespace BussinesLayer
{
    public class BLKullanici
    {
       

        public static int BLKullaniciEkle(EntityKullanici p)
        {
            if(p.KullaniciAdi != null && p.KullaniciAdi.Length >=3 && p.KullaniciAdi.Length <=20 && p.Sifre != null && p.Rol != null)
            {
                return DalKullanici.KullaniciEkle(p);

            }
            return -1;
                    
        }

        public static int BLKullaniciGuncelle(EntityKullanici p)
        {
            if (p.KullaniciAdi != null && p.KullaniciAdi.Length >= 3 && p.KullaniciAdi.Length <= 20 && p.Sifre != null && p.Rol!=null)
            {
                return DalKullanici.KullaniciGuncelle(p);

            }
            return -1;
        

        }


        
        public static int BLKullaniciSil(EntityKullanici p)
        {

            if (p.KullaniciID > 0)
            {
                return DalKullanici.KullaniciSil(p);
            }
            return -1;
        }

            
        public static  List<EntityKullanici> KullaniciListele()
        {
            return DalKullanici.KullaniciListele();


        }
    }
}
