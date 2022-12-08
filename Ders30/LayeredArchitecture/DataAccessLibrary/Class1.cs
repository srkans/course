using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrunModel;



namespace DataAccessLibrary
{
    public class UrunDB
    {
        string strConn;
        SqlConnection conn;

       

        public UrunDB()
        {
            strConn = ConfigurationManager.ConnectionStrings["UrunDBConnStr"].ConnectionString;

            conn = new SqlConnection(strConn);
        }

        public void UrunEkle(Urun urun)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Katman.Urunler VALUES(@ad,@maliyet,@karOran,@kdvOran,@KDVliFiyat)", conn);

            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@ad",urun.UrunAdi);
            cmd.Parameters.AddWithValue("@maliyet",urun.BirimMaliyet);
            cmd.Parameters.AddWithValue("@karOran",urun.KarOrani);
            cmd.Parameters.AddWithValue("@kdvOran",urun.KDVOrani);
            cmd.Parameters.AddWithValue("@KDVliFiyat",urun.KDVliFiyat);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public Urun UrunBul(int UrunID)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Katman.Urunler WHERE UrunID = @ID", conn);

            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@ID", UrunID);

            SqlDataReader dr = cmd.ExecuteReader();

            dr.Read();

            Urun urun = new Urun();

            if(dr.HasRows)
            {
                urun.UrunID = UrunID;
                urun.UrunAdi = dr[1].ToString();
                urun.BirimMaliyet = Convert.ToDouble(dr[2]);
                urun.KarOrani = Convert.ToInt16(dr[3]);
                urun.KDVOrani = Convert.ToByte(dr[4]);
                urun.KDVliFiyat = Convert.ToDouble(dr[5]);
            }

            conn.Close();

            return urun;
        }

        public List<Urun> TumUrunler()
        {
            List<Urun> urunler = new List<Urun>();

            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Katman.Urunler", conn);

            SqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                Urun u = new Urun();

                u.UrunID = Convert.ToInt32(dr[0]);
                u.UrunAdi = dr[1].ToString();
                u.BirimMaliyet = Convert.ToDouble(dr[2]);
                u.KarOrani = Convert.ToInt16(dr[3]);
                u.KDVOrani = Convert.ToByte(dr[4]);
                u.KDVliFiyat = Convert.ToDouble(dr[5]);

                urunler.Add(u);
            }

            conn.Close();

            return urunler;
        }

        public void UrunSil(int UrunID)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("DELETE FROM Katman.Urunler WHERE UrunID=@ID", conn);

            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@ID", UrunID);

            cmd.ExecuteNonQuery();

            conn.Close();
                
        }
    }
}
