using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace KonyvtarAsztaliKonzolos
{
    internal class Statisztika
    {
        private List<Book> books;
        private MySqlConnection connection = null;
        private MySqlCommand command = null;

        public Statisztika() 
        { 
            books = new List<Book>();
            KonyvekBeolvasasa();
        }

        

        private void KonyvekBeolvasasa()
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
                        Book book = new Book(dr.GetString("author"), dr.GetInt32("id"), dr.GetInt32("page_count"), dr.GetInt32("publish_year"), dr.GetString("title"));
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

        public void Feladatok()
        {
            OtszazOldalnalHosszabb();
            KonyvVanE1950Elott();
            LeghosszabbKonyvAdatai();
            LegtobbKonyvetIroSzerzo();
            KonyvSzerzoMeghatarozas();

        }

        private void OtszazOldalnalHosszabb()
        {
            int count = 0;
            foreach (Book book in books)
            {
                if (book.Page_count > 500) count++;
            }
            Console.WriteLine($"500 oldalnál hosszabb könyvek száma: {count}");
        }

        private void KonyvVanE1950Elott()
        {
            bool van1950EloettiKonyv = books.Exists(book => book.Publish_year < 1950);

            if (van1950EloettiKonyv)
                Console.WriteLine("Van 1950-nél régebbi könyv az adatok között.");
            else
                Console.WriteLine("Nincs 1950-nél régebbi könyv az adatok között.");
        }

        private void LeghosszabbKonyvAdatai()
        {
            Book legHosszabbKonyv = books[0];
            foreach (var book in books)
            {
                if (book.page_count > legHosszabbKonyv.page_count)
                    legHosszabbKonyv = book;
            }

            Console.WriteLine($"A leghosszabb könyv adatai:\nCím: {legHosszabbKonyv.Title}\nSzerző: {legHosszabbKonyv.Author}\nOldalszám: {legHosszabbKonyv.page_count}");
        }

        private void LegtobbKonyvetIroSzerzo()
        {
            string legtobbetIroSzerzo = "";
            int maxKonyvSzam = 0;

            foreach (var book in books)
            {
                int szerzoKonyvSzam = books.Count(b => b.Author == book.Author);

                if (szerzoKonyvSzam > maxKonyvSzam)
                {
                    maxKonyvSzam = szerzoKonyvSzam;
                    legtobbetIroSzerzo = book.Author;
                }
            }

            Console.WriteLine($"A legtöbb könyvet író szerző: {legtobbetIroSzerzo} ({maxKonyvSzam} könyv)");
        }


        private void KonyvSzerzoMeghatarozas()
        {
            Console.Write("Kérem adja meg a könyv címét: ");
            string keresettCim = Console.ReadLine();

            Book keresettKonyv = books.Find(book => book.Title == keresettCim);

            if (keresettKonyv != null)
                Console.WriteLine($"A könyv szerzője: {keresettKonyv.Author}");
            else
                Console.WriteLine("Nincs ilyen könyv az adatok között.");
        }
    }
}
