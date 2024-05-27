using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;
namespace BussinesLayer
{
    public class BLSube
    {
        public static int BLSubeEkle(EntitySube p)
        {
            if (p.SubeAdi != null && p.SubeAdi.Length >= 3 && p.SubeAdi.Length <= 20 && p.Telefon != null && p.Telefon.Length == 10 && p.Adres != null && p.Adres.Length >= 10 && p.Adres.Length <= 100)
            {
                return DalSube.SubeEkle(p);

            }
            return -1;

        }

        public static int BLSubeGuncelle(EntitySube p)
        {
            if (p.SubeAdi != null && p.SubeAdi.Length >= 3 && p.SubeAdi.Length <= 20 && p.Telefon != null && p.Telefon.Length == 10 && p.Adres != null && p.Adres.Length >= 10 && p.Adres.Length <= 100)
            {
                return DalSube.SubeGuncelle(p);

            }
            return -1;


        }



        public static int BLSubeSil(EntitySube p)
        {

            if (p.SubeID > 0)
            {
                return DalSube.SubeSil(p);
            }
            return -1;
        }


        public static List<EntitySube> SubeListele()
        {
            return DalSube.SubeListele();


        }
    }
}