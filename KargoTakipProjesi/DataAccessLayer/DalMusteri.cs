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
   public class DalMusteri
    {
        public static int MusteriEkle(EntityMusteri p)
        {
            SqlCommand Komut = new SqlCommand("İnsert into TblMusteri (Ad,Soyad,Telefon,Email,Adres) values (@p1,@p2,@p3,@p4,@p5)", Baglanti.bgl);
            if (Komut.Connection.State != ConnectionState.Open)
            {
                Komut.Connection.Open();
            }
            Komut.Parameters.AddWithValue("@p1", p.Ad);
            Komut.Parameters.AddWithValue("@p2", p.Soyad);
            Komut.Parameters.AddWithValue("@p3", p.Telefon);
            Komut.Parameters.AddWithValue("@p4", p.Email);
            Komut.Parameters.AddWithValue("@p5", p.Adres);

            return Komut.ExecuteNonQuery();
        }

        public static int MusteriSil(EntityMusteri p)
        {
            SqlCommand Komut = new SqlCommand("Delete from TblMusteri where MusteriID = @p1)", Baglanti.bgl);
            if (Komut.Connection.State != ConnectionState.Open)
            {
                Komut.Connection.Open();
            }
            Komut.Parameters.AddWithValue("@p1", p.MusteriID);

            return Komut.ExecuteNonQuery();
        }

        public static int MusteriGuncelle(EntityMusteri p)
        {
            SqlCommand Komut = new SqlCommand("Update TblMusteri set Ad=@p1,Soyad=@p2,Telefon=@p3,Email=@p4,Adres=@p5 Where KulaniciID=@p6)", Baglanti.bgl);
            if (Komut.Connection.State != ConnectionState.Open)
            {
                Komut.Connection.Open();
            }
            Komut.Parameters.AddWithValue("@p1", p.Ad);
            Komut.Parameters.AddWithValue("@p2", p.Soyad);
            Komut.Parameters.AddWithValue("@p3", p.Telefon);
            Komut.Parameters.AddWithValue("@p4", p.Email);
            Komut.Parameters.AddWithValue("@p5", p.Adres);
            Komut.Parameters.AddWithValue("@p6", p.MusteriID);

            return Komut.ExecuteNonQuery();
        }

        public static List<EntityMusteri> MusteriListele()
        {
            SqlCommand Komut = new SqlCommand("select * from TblMusteri", Baglanti.bgl);
            if (Komut.Connection.State != ConnectionState.Open)
            {
                Komut.Connection.Open();
            }
            SqlDataReader dr = Komut.ExecuteReader();
            List<EntityMusteri> musteri = new List<EntityMusteri>();
            while (dr.Read())
            {
                EntityMusteri ent = new EntityMusteri();
                ent.MusteriID = int.Parse(dr[0].ToString());
                ent.Ad = dr[1].ToString();
                ent.Soyad = dr[2].ToString();
                ent.Telefon = dr[3].ToString();
                ent.Email = dr[4].ToString();

                musteri.Add(ent);

            }

            return musteri;

        }
    }
}
