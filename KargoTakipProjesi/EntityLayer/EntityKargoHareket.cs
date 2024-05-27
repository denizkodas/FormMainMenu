using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityKargoHareket
    {
        public int? HareketID { get; set; }
        public int? TasiyiciID { get; set; }
        public int? KargoID { get; set; }
        public int? SubeID { get; set; }
        public DateTime TeslimAlmaTarihSaat { get; set; }
        public string HareketTipi { get; set; }
        public DateTime TeslimEtmeTarihSaat { get; set; }
    }
}
