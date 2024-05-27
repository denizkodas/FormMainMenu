using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
   public class EntityKargo
    {
        public int? KargoID { get; set; }
        public int? MusteriID { get; set; }
        public int? KargoID_Gonderen { get; set; }
        public int? KargoID_Alan { get; set; }   
        public string Adres { get; set; }
        public string Ebat { get; set; }
        public float? Agirlik { get; set; }
        public string Durum { get; set; }
        public string Aciklama { get; set; }
        public string KargoTakipNo { get; set; }
    }
}
