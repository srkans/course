using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookDatabase
{
    class Database
    {
        string strConn = "Data Source=SERKAN;Initial Catalog = Calisma; Integrated Security = True";

        SqlConnection connection;

        public Database()
        {
            connection = new SqlConnection(strConn);
        }

        public void addBook(int ISBN, string bookName, int numberofPages, string summary, double price, int authorID)
        {
            connection.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Kitaplar VALUES(@ISBN, @KitapAdi, @SayfaSayisi, @OzetBilgi, @Fiyat, @YazarID)", connection);

            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@ISBN", ISBN);
            cmd.Parameters.AddWithValue("@KitapAdi", bookName);
            cmd.Parameters.AddWithValue("@SayfaSayisi", numberofPages);
            cmd.Parameters.AddWithValue("@OzetBilgi", summary);
            cmd.Parameters.AddWithValue("@Fiyat", price);
            cmd.Parameters.AddWithValue("@YazarID", authorID);



            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public void deleteBook(int bookID)
        {
            connection.Open();

            SqlCommand cmd = new SqlCommand("DELETE FROM Kitaplar WHERE KitapID=@KitapID", connection);

            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@KitapID", bookID);

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public void updateBook(int bookID, int ISBN, string bookName, int numberofPages, string summary, double price, int authorID)
        {
            connection.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Kitaplar SET ISBN = @ISBN, KitapAdi = @KitapAdi, SayfaSayisi = @SayfaSayisi, OzetBilgi = @OzetBilgi, Fiyat = @Fiyat, YazarID = @YazarID WHERE KitapID = @KitapID", connection);

            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@KitapID",bookID);
            cmd.Parameters.AddWithValue("@ISBN",ISBN);
            cmd.Parameters.AddWithValue("@KitapAdi", bookName);
            cmd.Parameters.AddWithValue("@SayfaSayisi",numberofPages);
            cmd.Parameters.AddWithValue("@OzetBilgi",summary);
            cmd.Parameters.AddWithValue("@Fiyat",price);
            cmd.Parameters.AddWithValue("@YazarID",authorID);

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public void listBooks(DataGridView grid, string name)
        {
            grid.ColumnCount = 4;

            grid.Columns[0].Name = "Kitap ID";
            grid.Columns[0].Width = 40;

            grid.Columns[1].Name = "ISBN";
            grid.Columns[1].Width = 50;

            grid.Columns[2].Name = "Kitap Adı";
            grid.Columns[2].Width = 280;

            grid.Columns[3].Name = "Fiyat";
            grid.Columns[3].Width = 50;


            string strSQL = "";

            if (name == null)
            {
                strSQL = "SELECT KitapID,ISBN,KitapAdi,Fiyat FROM Kitaplar";
            }
            else
            {
                strSQL = "SELECT KitapID,ISBN,KitapAdi,Fiyat FROM Kitaplar WHERE KitapAdi LIKE '%" + name + "%'";
            }

            connection.Open();

            SqlCommand cmd = new SqlCommand(strSQL, connection);

            SqlDataReader dr = cmd.ExecuteReader();

            string[] row = new string[4];

            while (dr.Read())
            {
                row[0] = dr[0].ToString();
                row[1] = dr[1].ToString();
                row[2] = dr[2].ToString();
                row[3] = dr[3].ToString();

                grid.Rows.Add(row);
            }
            connection.Close();
        }

        public List<Author> allAuthors()
        {
            List<Author> authors = new List<Author>();

            connection.Open();

            SqlCommand cmd = new SqlCommand("select * from Yazarlar", connection);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Author a = new Author();
                a.id = Convert.ToInt32(dr[0]);
                a.name = dr[1].ToString();
                authors.Add(a);
            }

            connection.Close();
            return authors;
        }
    }
}
