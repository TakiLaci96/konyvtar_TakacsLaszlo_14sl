using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KonyvtarAsztaliWinForm
{
    internal class Adatbazis
    {
        MySqlConnection connection = null;
        MySqlCommand command;
        List<Book> books = new List<Book>();

        public Adatbazis()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Clear();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "books";
            sb.CharacterSet = "utf8";
            connection = new MySqlConnection(sb.ConnectionString);
            command = connection.CreateCommand();

            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM `books`";
                using (MySqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Book book = new Book(dr.GetString("author"), dr.GetInt32("page_count"), dr.GetInt32("publish_year"), dr.GetString("title"));
                        books.Add(book);
                    }
                }
                connection.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(1);
            }
        }

        public List<Book> getAllBooks()
        {
            List<Book> books = new List<Book>();
            command.CommandText = "SELECT * FROM `books`";

            try
            {
                connection.Open();
                using (MySqlDataReader dr = command.ExecuteReader()) 
                {
                    while (dr.Read())
                    {
                        int id = dr.GetInt32("id");
                        string title = dr.GetString("title");
                        string author = dr.GetString("author");
                        int publishYear = dr.GetInt32("publish_year");
                        int pageCount = dr.GetInt32("page_count");

                        Book book = new Book(author, pageCount, publishYear, title);
                        books.Add(book);
                    }
                }
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return books;
        }

        public void delete(Book book)
        {
            command.CommandText = "DELETE FROM `book` WHERE `id` = @id";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id", book.Id);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
