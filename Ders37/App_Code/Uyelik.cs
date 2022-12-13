using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

/// <summary>
/// Summary description for Uyelik
/// </summary>
public class Uyelik
{
    string strConn = @"Data Source=SERKAN;Initial Catalog=Calisma;Integrated Security=True";

    SqlConnection conn;
    public Uyelik()
    {
        conn = new SqlConnection(strConn);
    }

    public string MdBes(string sifre)
    {
        byte[] bytsifre = new byte[sifre.Length];

        for (int i = 0; i < sifre.Length; i++)
        {
            bytsifre[i] = (byte)sifre[i];

        }

        MD5 md5 = MD5.Create();

        byte[] hashSifre = md5.ComputeHash(bytsifre); //sonucu byte dizisi olarak veriyor girişi byte dizisi olarak istiyor. bunun için string şifre ifadesini bir byte dizisine çevirmemiz gerekti.

        string strHash = "";
        for (int i = 0; i < hashSifre.Length; i++)
        {
            strHash += hashSifre[i].ToString("x"); //x yazıp hexadesimal e çevirdik değerleri
        }

        return strHash;
    }

    public int uyeKontrol(string kullanici, string sifre, out string uyeAdi)
    {
        uyeAdi = "";
        int uyeID = -1;

        SqlCommand cmd = new SqlCommand("select * from uyeler where Kullanici = @ad and Sifre=@sifre", conn);

        cmd.Parameters.Clear();

        cmd.Parameters.AddWithValue("@ad", kullanici);
        cmd.Parameters.AddWithValue("@sifre", MdBes(sifre));

        conn.Open();

        SqlDataReader dr = cmd.ExecuteReader();

        dr.Read();

        if(dr.HasRows)
        {
            uyeID = Convert.ToInt32(dr[0]);
            uyeAdi = dr[1].ToString();
        }
        conn.Close();

        return uyeID;
    }
}