using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityMusteri
    {
        public int KullaniciID { get; set; }
        public string MusteriAdi { get; set; }
        public string Sifre { get; set; }
        public string Rol { get; set; } 
        public int? SubeID { get; set; } 
    }
}
