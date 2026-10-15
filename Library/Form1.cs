using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadLibraryData()
        {
            try
            {
                using var db = new LibraryDbContext();

                var loans = db.Loans
                    .Include(l => l.Reader)
                    .Include(l => l.Book)
                        .ThenInclude(b => b.Authors)
                    .ToList();

                var data = loans
                    .Select(l => new
                    {
                        НомерКвитка =
                            l.Reader.LibraryCardNumber,

                        Читач =
                            l.Reader.LastName + " " +
                            l.Reader.FirstName + " " +
                            (l.Reader.MiddleName ?? ""),

                        Адреса =
                            l.Reader.Address,

                        Телефон =
                            l.Reader.Phone,

                        ДатаНародження =
                            l.Reader.BirthDate,

                        Автори =
                            string.Join(", ",
                                l.Book.Authors.Select(a =>
                                    a.LastName + " " +
                                    a.FirstName + " " +
                                    (a.MiddleName ?? "")
                                )),

                        НазваКниги =
                            l.Book.Title,

                        ДатаВидачі =
                            l.IssueDate,

                        ДатаПовернення =
                            l.ReturnDate,

                        Ціна =
                            l.Book.Price
                    })
                    .ToList();

                dataGridViewLibrary.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadLibraryData();
        }
    }
}