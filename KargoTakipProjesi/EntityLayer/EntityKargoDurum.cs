using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityKargoDurum
    {
        public int? DurumID { get; set; }
        public int? KargoID { get; set; }
        public string Durum { get; set; }
        public string Lokasyon { get; set; }
        public DateTime GuncellemeTarihi { get; set; }
        public string Acıklama { get; set; }
      
    }
}
