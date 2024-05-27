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
    public class DalTasiyici
    {
        public static int TasiyiciEkle(EntityTasiyici p)
        {
            SqlCommand Komut = new SqlCommand("İnsert into TblTasiyici (Ad,Soyad,Telefon,Email) values (@p1,@p2,@p3,@p4)", Baglanti.bgl);
            if (Komut.Connection.State != ConnectionState.Open)
            {
                Komut.Connection.Open();
            }
            Komut.Parameters.AddWithValue("@p1", p.Ad);
            Komut.Parameters.AddWithValue("@p2", p.Soyad);
            Komut.Parameters.AddWithValue("@p3", p.Telefon);
            Komut.Parameters.AddWithValue("@p3", p.Email);


            return Komut.ExecuteNonQuery();
        }

        public static int TasiyiciSil(EntityTasiyici p)
        {
            SqlCommand Komut = new SqlCommand("Delete from TblTasiyici where TasiyiciID = @p1)", Baglanti.bgl);
            if (Komut.Connection.State != ConnectionState.Open)
            {
                Komut.Connection.Open();
            }
            Komut.Parameters.AddWithValue("@p1", p.TasiyiciID);

            return Komut.ExecuteNonQuery();
        }

        public static int TasiyiciGuncelle(EntityTasiyici p)
        {
            SqlCommand Komut = new SqlCommand("Update TblTasiyici set Ad=@p1,Soyad=@p2,Telefon=@p3,Email=@p4 Where TasiyiciID=@p5)", Baglanti.bgl);
            if (Komut.Connection.State != ConnectionState.Open)
            {
                Komut.Connection.Open();
            }
            Komut.Parameters.AddWithValue("@p1", p.Ad);
            Komut.Parameters.AddWithValue("@p2", p.Soyad);
            Komut.Parameters.AddWithValue("@p3", p.Telefon);
            Komut.Parameters.AddWithValue("@p4", p.Email);
            Komut.Parameters.AddWithValue("@p5", p.TasiyiciID);

            return Komut.ExecuteNonQuery();
        }

        public static List<EntityTasiyici> TasiyiciListele()
        {
            SqlCommand Komut = new SqlCommand("select * from TblTasiyici", Baglanti.bgl);
            if (Komut.Connection.State != ConnectionState.Open)
            {
                Komut.Connection.Open();
            }
            SqlDataReader dr = Komut.ExecuteReader();
            List<EntityTasiyici> tasiyici = new List<EntityTasiyici>();
            while (dr.Read())
            {
                EntityTasiyici ent = new EntityTasiyici();
                ent.TasiyiciID = int.Parse(dr[0].ToString());
                ent.Ad = dr[1].ToString();
                ent.Soyad = dr[2].ToString();
                ent.Telefon = dr[3].ToString();
                ent.Email = dr[3].ToString();


                tasiyici.Add(ent);

            }

            return tasiyici;

        }
    }
}
