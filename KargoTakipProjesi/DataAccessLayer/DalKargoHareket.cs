using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace DataAccessLayer
{
    public class DalKargoHareket
    {
        public static int KargoHareketEkle(EntityKargoHareket p)
        {
            SqlCommand Komut = new SqlCommand("İnsert into TblKargoHareket(TasiyiciID,KargoID,SubeID,TarihSaat,HareketTipi) values (@p1,@p2,@p3,@p4,@p5)", Baglanti.bgl);
            if (Komut.Connection.State != ConnectionState.Open)
            {
                Komut.Connection.Open();
            }
            Komut.Parameters.AddWithValue("@p1", p.TasiyiciID);
            Komut.Parameters.AddWithValue("@p2", p.KargoID);
            Komut.Parameters.AddWithValue("@p3", p.SubeID);
            Komut.Parameters.AddWithValue("@p3", p.TarihSaat);
            Komut.Parameters.AddWithValue("@p3", p.HareketTipi);



            return Komut.ExecuteNonQuery();
        }

        public static int KargoHareketSil(EntityKargoHareket p)
        {
            SqlCommand Komut = new SqlCommand("Delete from TblKargoHareket where HareketID = @p1)", Baglanti.bgl);
            if (Komut.Connection.State != ConnectionState.Open)
            {
                Komut.Connection.Open();
            }
            Komut.Parameters.AddWithValue("@p1", p.HareketID);

            return Komut.ExecuteNonQuery();
        }

        public static int KargoHareketGuncelle(EntityKargoHareket p)
        {
            SqlCommand Komut = new SqlCommand("Update TblKargoHareket set TasiyiciID=@p1,KargoID=@p2,SubeID=@p3,TarihSaat=@p4, HareketTipi=@p5 Where HareketID=@p6)", Baglanti.bgl);
            if (Komut.Connection.State != ConnectionState.Open)
            {
                Komut.Connection.Open();
            }
            Komut.Parameters.AddWithValue("@p1", p.TasiyiciID);
            Komut.Parameters.AddWithValue("@p2", p.KargoID);
            Komut.Parameters.AddWithValue("@p3", p.SubeID);
            Komut.Parameters.AddWithValue("@p4", p.TarihSaat);
            Komut.Parameters.AddWithValue("@p5", p.HareketTipi);
            Komut.Parameters.AddWithValue("@p6", p.HareketID);

            return Komut.ExecuteNonQuery();
        }

        public static List<EntityKargoHareket> KargoHareketListele()
        {
            SqlCommand Komut = new SqlCommand("select * from TblKargoHareket", Baglanti.bgl);
            if (Komut.Connection.State != ConnectionState.Open)
            {
                Komut.Connection.Open();
            }
            SqlDataReader dr = Komut.ExecuteReader();
            List<EntityKargoHareket> hareket = new List<EntityKargoHareket>();
            while (dr.Read())
            {
                EntityKargoHareket ent = new EntityKargoHareket();
                ent.HareketID = int.Parse(dr[0].ToString());
                ent.TasiyiciID = int.Parse(dr[1].ToString());
                ent.KargoID = int.Parse(dr[2].ToString());
                ent.SubeID = int.Parse(dr[3].ToString());
                ent.TarihSaat = DateTime.Parse(dr[4].ToString());
                ent.HareketTipi = dr[5].ToString();


                hareket.Add(ent);

            }

            return hareket;

        }
    }
}
