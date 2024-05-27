using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Baglanti
    {
        public static SqlConnection bgl = new SqlConnection("Data Source=DESKTOP-PAF2NE0\\SQLEXPRESS;Initial" +
            " Catalog=DbKargoTakip;Integrated Security=True");
    }
}
