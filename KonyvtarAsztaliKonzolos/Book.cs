using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonyvtarAsztaliKonzolos
{
    internal class Book
    {
        public string author;
        public int id;
        public int page_count;
        public int publish_year;
        public string title;

        public Book(string author, int id, int page_count, int publish_year, string title)
        {
            this.author = author;
            this.id = id;
            this.page_count = page_count;
            this.publish_year = publish_year;
            this.title = title;
        }

        public string Author { get => author; set => author = value; }
        public int Id { get => id; set => id = value; }
        public int Page_count { get => page_count; set => page_count = value; }
        public int Publish_year { get => publish_year; set => publish_year = value; }
        public string Title { get => title; set => title = value; }

    }
}
