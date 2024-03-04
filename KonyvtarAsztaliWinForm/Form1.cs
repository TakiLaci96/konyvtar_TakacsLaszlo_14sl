using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KonyvtarAsztaliWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Book book in Program.books)
            {
                listBox_Konyvek.Items.Add($"{book.Title} - {book.author}");
            }
        }

        private void RefreshBookList()
        {
            listBox_Konyvek.Items.Clear();

            foreach (Book book in Program.books)
            {
                listBox_Konyvek.Items.Add($"{book.Title} - {book.Author}");
            }
        }

        private void button_Load_Click(object sender, EventArgs e)
        {
            Program.books = Program.db.getAllBooks();

            // listBox frissítése
            RefreshBookList();
        }

        private void listBox_Konyvek_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_Insert_Click(object sender, EventArgs e)
        {
            // adatok összegyűjtése
            string title = textBox_Title.Text;
            string author = textBox_Author.Text;
            int publishYear, pageCount;

            if (int.TryParse(textBox_Year.Text, out publishYear) && int.TryParse(textBox_Pages.Text, out pageCount))
            {
                Book newBook = new Book(author,  pageCount, publishYear, title);
                Program.books.Add(newBook);
                RefreshBookList();
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Érvénytelen adatok! Ellenőrizd a kiemelt mezőket.");
            }
        }

        // TextBoxok kitisztítása
        private void ClearTextBoxes()
        {
            textBox_Title.Clear();
            textBox_Author.Clear();
            textBox_Year.Clear();
            textBox_Pages.Clear();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {

            // Ellenőrizi, hogy van-e kválasztott elem
            if (listBox_Konyvek.SelectedIndex != -1)
            {
                // Ellenőrizi, hogy a kötelező mezők ki vannak-e töltve
                if (ValidateInput())
                {
                    Book updatedBook = CreateBookFromForm();
                    Program.books[listBox_Konyvek.SelectedIndex] = updatedBook;
                    RefreshBookList();
                }
            }
            else
            {
                MessageBox.Show("Válassz ki egy könyvet a módosításhoz!");
            }

        }

        // Ellenőrzi, hogy a kötelező mezők ki vannak-e töltve
        private bool ValidateInput()
        {

            if (string.IsNullOrEmpty(textBox_Title.Text) || string.IsNullOrEmpty(textBox_Author.Text))
            {
                MessageBox.Show("Töltse ki a kötelező mezőket (Cím és Szerző)!");
                return false;
            }
            return true;
        }

        private Book CreateBookFromForm()
        {
            string title = textBox_Title.Text;
            string author = textBox_Author.Text;
            int publishYear = int.Parse(textBox_Year.Text);
            int pageCount = int.Parse(textBox_Pages.Text);

            // Az új vagy módosított könyv objektum létrehozása
            return new Book(author, pageCount, publishYear, title);
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (listBox_Konyvek.SelectedIndex != -1)
            {

                //Adatbázisból törlés: 
               // Book deleteBook = new Book(textBox_Author.Text, int.Parse(textBox_id.Text), int.Parse(textBox_Pages.Text), int.Parse(textBox_Year.Text), textBox_Title.Text);
                //Program.db.delete(deleteBook);

                //Listboxból törlés: 
                Program.books.RemoveAt(listBox_Konyvek.SelectedIndex);
                RefreshBookList();
            }
            else
            {
                MessageBox.Show("Válassz ki egy könyvet a törléshez!");
            }
        }
        
    }
}
