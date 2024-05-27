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
    public class DalKullanici
    {
        public static int KullaniciEkle(EntityKullanici p)
        {
            SqlCommand Komut = new SqlCommand("İnsert into TblKullanici (KullaniciAdi,Sifre,Rol,SubeID) values (@p1,@p2,@p3,@p4))", Baglanti.bgl);
            if(Komut.Connection.State !=ConnectionState.Open)
            {
                Komut.Connection.Open();
            }
            Komut.Parameters.AddWithValue("@p1", p.KullaniciAdi);
            Komut.Parameters.AddWithValue("@p2", p.Sifre);
            Komut.Parameters.AddWithValue("@p3", p.Rol);
            Komut.Parameters.AddWithValue("@p4", p.SubeID);

            return Komut.ExecuteNonQuery();
        }

        public static int KullaniciSil(EntityKullanici p)
        {
            SqlCommand Komut = new SqlCommand("Delete from TblKullanici where KullaniciID = @p1)", Baglanti.bgl);
            if (Komut.Connection.State != ConnectionState.Open)
            {
                Komut.Connection.Open();
            }
            Komut.Parameters.AddWithValue("@p1", p.KullaniciID);

            return Komut.ExecuteNonQuery();
        }

        public static int KullaniciGuncelle(EntityKullanici p)
        {
            SqlCommand Komut = new SqlCommand("Update TblKullanici set KullaniciAdi=@p1,Sifre=@p2,Rol=@p3,SubeID=@p4 Where KulaniciID=@p5)", Baglanti.bgl);
            if (Komut.Connection.State != ConnectionState.Open)
            {
                Komut.Connection.Open();
            }
            Komut.Parameters.AddWithValue("@p1", p.KullaniciAdi);
            Komut.Parameters.AddWithValue("@p2", p.Sifre);
            Komut.Parameters.AddWithValue("@p3", p.Rol);
            Komut.Parameters.AddWithValue("@p4", p.SubeID);
            Komut.Parameters.AddWithValue("@p5", p.KullaniciID);

            return Komut.ExecuteNonQuery();
        }

        public static List<EntityKullanici> KullaniciListele()
        {
            SqlCommand Komut = new SqlCommand("select * from TblKullanici", Baglanti.bgl);
            if (Komut.Connection.State != ConnectionState.Open)
            {
                Komut.Connection.Open();
            }
            SqlDataReader dr = Komut.ExecuteReader();
            List<EntityKullanici> kullanici = new List<EntityKullanici>();
            while (dr.Read())
            {
                EntityKullanici ent = new EntityKullanici();
                ent.KullaniciID = int.Parse(dr[0].ToString());
                ent.KullaniciAdi = dr[1].ToString();
                ent.Sifre = dr[2].ToString();
                ent.Rol = dr[3].ToString();
                ent.SubeID = dr[4].ToString();

                kullanici.Add(ent);

            }

            return kullanici;

        }


    }   
   
   
}



