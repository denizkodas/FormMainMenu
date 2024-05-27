using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
   public class DalSube
    {
        public static int SubeEkle(EntitySube p)
        {
            SqlCommand Komut = new SqlCommand("İnsert into TblSube (SubeAdi,Telefon,Adres) values (@p1,@p2,@p3)", Baglanti.bgl);
            if (Komut.Connection.State != ConnectionState.Open)
            {
                Komut.Connection.Open();
            }
            Komut.Parameters.AddWithValue("@p1", p.SubeAdi);
            Komut.Parameters.AddWithValue("@p2", p.Telefon);
            Komut.Parameters.AddWithValue("@p3", p.Adres);
           

            return Komut.ExecuteNonQuery();
        }

        public static int SubeSil(EntitySube p)
        {
            SqlCommand Komut = new SqlCommand("Delete from TblMusteri where SubeID = @p1)", Baglanti.bgl);
            if (Komut.Connection.State != ConnectionState.Open)
            {
                Komut.Connection.Open();
            }
            Komut.Parameters.AddWithValue("@p1", p.SubeID);

            return Komut.ExecuteNonQuery();
        }

        public static int SubeGuncelle(EntitySube p)
        {
            SqlCommand Komut = new SqlCommand("Update TblSube set SubeAdi=@p1,Telefon=@p2,Adres=@p3 Where SubeID=@p4)", Baglanti.bgl);
            if (Komut.Connection.State != ConnectionState.Open)
            {
                Komut.Connection.Open();
            }
            Komut.Parameters.AddWithValue("@p1", p.SubeAdi);      
            Komut.Parameters.AddWithValue("@p2", p.Telefon);
            Komut.Parameters.AddWithValue("@p3", p.Adres);
            Komut.Parameters.AddWithValue("@p4", p.SubeID);

            return Komut.ExecuteNonQuery();
        }

        public static List<EntitySube> SubeListele()
        {
            SqlCommand Komut = new SqlCommand("select * from TblSube", Baglanti.bgl);
            if (Komut.Connection.State != ConnectionState.Open)
            {
                Komut.Connection.Open();
            }
            SqlDataReader dr = Komut.ExecuteReader();
            List<EntitySube> sube = new List<EntitySube>();
            while (dr.Read())
            {
                EntitySube ent = new EntitySube();
                ent.SubeID = int.Parse(dr[0].ToString());
                ent.SubeAdi = dr[1].ToString();
                ent.Telefon = dr[2].ToString();
                ent.Adres = dr[3].ToString();
               

                sube.Add(ent);

            }

            return sube;

        }
    }
}
