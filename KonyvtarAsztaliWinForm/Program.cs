using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KonyvtarAsztaliWinForm
{
    internal static class Program
    {
        public static List<Book> books = new List<Book>();
        public static Adatbazis db = null;
        public static Form1 form1 = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            db = new Adatbazis();
            books = db.getAllBooks();
            form1 = new Form1();
            Application.Run(form1);
        }
    }
}
