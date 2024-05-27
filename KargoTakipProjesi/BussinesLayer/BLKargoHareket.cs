using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;

namespace BussinesLayer
{
    public class BLKargoHareket
    {
        public static int BLKargoHareketEkle(EntityKargoHareket p)
        {
            if (p.TasiyiciID != null && p.KargoID != null && p.SubeID != null && p.TarihSaat != null && p.HareketTipi.Length <= 20 && p.HareketTipi.Length >= 3)
            {
                return DalKargoHareket.KargoHareketEkle(p);

            }
            return -1;

        }

        public static int BLKargoHareketGuncelle(EntityKargoHareket p)
        {
            if (p.TasiyiciID != null && p.KargoID != null && p.SubeID != null && p.TarihSaat != null && p.HareketTipi.Length <= 20 && p.HareketTipi.Length >= 3)
            {
                return DalKargoHareket.KargoHareketGuncelle(p);

            }
            return -1;


        }



        public static int BLHareketSil(EntityKargoHareket p)
        {

            if (p.HareketID > 0)
            {
                return DalKargoHareket.KargoHareketSil(p);
            }
            return -1;
        }


        public static List<EntityKargoHareket> KargoHareketListele()
        {
            return DalKargoHareket.KargoHareketListele();


        }
    }
}