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
   public class DalKargo
    {
        public static int KargoEkle(EntityKargo p)
        {
            SqlCommand Komut = new SqlCommand("İnsert into TblKargo (MusteriID,KargoID_Gonderen,KargoID_Alan,Adres," +
                "Ebat,Agirlik,Durum,Aciklama) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", Baglanti.bgl);
            if (Komut.Connection.State != ConnectionState.Open)
            {
                Komut.Connection.Open();
            }
            Komut.Parameters.AddWithValue("@p1", p.MusteriID);
            Komut.Parameters.AddWithValue("@p2", p.KargoID_Gonderen);
            Komut.Parameters.AddWithValue("@p3", p.KargoID_Alan);
            Komut.Parameters.AddWithValue("@p4", p.Adres);
            Komut.Parameters.AddWithValue("@p5", p.Ebat);
            Komut.Parameters.AddWithValue("@p6", p.Agirlik);
            Komut.Parameters.AddWithValue("@p7", p.Durum);
            Komut.Parameters.AddWithValue("@p8", p.Aciklama);


            return Komut.ExecuteNonQuery();
        }

        public static int KargoSil(EntityKargo p)
        {
            SqlCommand Komut = new SqlCommand("Delete from TblKargo where KargoID = @p1)", Baglanti.bgl);
            if (Komut.Connection.State != ConnectionState.Open)
            {
                Komut.Connection.Open();
            }
            Komut.Parameters.AddWithValue("@p1", p.KargoID);

            return Komut.ExecuteNonQuery();
        }

        public static int KargoGuncelle(EntityKargo p)
        {
            SqlCommand Komut = new SqlCommand("Update TblKargo set MusteriID=@p1,KargoID_Gonderen=@p2,KargoID_Alan=@p3," +
                "Adres=@p4,Ebat=@p5,Agirlik=@p6,Durum=@p7,Aciklama=@p8  Where KargoID=@p9)", Baglanti.bgl);
            if (Komut.Connection.State != ConnectionState.Open)
            {
                Komut.Connection.Open();
            }
            Komut.Parameters.AddWithValue("@p1", p.MusteriID);
            Komut.Parameters.AddWithValue("@p2", p.KargoID_Gonderen);
            Komut.Parameters.AddWithValue("@p3", p.KargoID_Alan);
            Komut.Parameters.AddWithValue("@p4", p.Adres);
            Komut.Parameters.AddWithValue("@p5", p.Ebat);
            Komut.Parameters.AddWithValue("@p1", p.Agirlik);
            Komut.Parameters.AddWithValue("@p1", p.Durum);
            Komut.Parameters.AddWithValue("@p1", p.Aciklama);
            Komut.Parameters.AddWithValue("@p1", p.KargoID);

            return Komut.ExecuteNonQuery();
        }

        public static List<EntityKargo> KargoListele()
        {
            SqlCommand Komut = new SqlCommand("select * from TblKargo", Baglanti.bgl);
            if (Komut.Connection.State != ConnectionState.Open)
            {
                Komut.Connection.Open();
            }
            SqlDataReader dr = Komut.ExecuteReader();
            List<EntityKargo> kargo = new List<EntityKargo>();
            while (dr.Read())
            {
                EntityKargo ent = new EntityKargo();
                ent.KargoID = int.Parse(dr[0].ToString());
                ent.MusteriID = int.Parse(dr[1].ToString());
                ent.KargoID_Gonderen = int.Parse(dr[2].ToString());
                ent.KargoID_Alan = int.Parse(dr[3].ToString());
                ent.Adres = dr[4].ToString();
                ent.Ebat = dr[5].ToString();
                ent.Agirlik = float.Parse(dr[6].ToString());
                ent.Durum = dr[7].ToString();
                ent.Aciklama = dr[8].ToString();


                kargo.Add(ent);

            }

            return kargo;

        }
    }
}
