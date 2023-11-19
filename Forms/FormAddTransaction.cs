using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormCollection.Database;
using FormCollection.Dto;

namespace FormCollection.Forms
{
    public partial class FormAddTransaction : Form
    {
        GlendaleLibrarySystemEntities db = new GlendaleLibrarySystemEntities();
        List<BookDto> bookCart = new List<BookDto>();

        private string _emailAddress { get; set; }
        public FormAddTransaction(string emailAddress)
        {
            InitializeComponent();
            _emailAddress = emailAddress;
            labelEmail.Text = _emailAddress;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvSearch.SelectedRows.Count > 0)
            {
                int bookId = Convert.ToInt32(dgvSearch.SelectedRows[0].Cells["BookId"].Value);

                if (bookCart.Any(m => m.BookId == bookId))
                {
                    MessageBox.Show("Book is already added to cart!");
                }
                else if (bookCart.Count() == 3)
                {
                    MessageBox.Show("Cannot add book. Maximum is 3 only");
                }
                else
                {
                    var book = db.Book.Find(bookId);
                    bookCart.Add(new BookDto()
                    {
                        BookId = bookId,
                        Title = book.Title,
                        BookCode = book.BookCode,
                        Publisher = book.Publisher.Publisher1,
                        Category = book.Category.Category1,
                        SubCategory = book.SubCategory.SubCategory1,
                        Name = String.Join(" ", book.Author.FirstName, book.Author.LastName)
                    });


                    dgvCart.DataSource = null;
                    dgvCart.DataSource = bookCart;
                }

            }
            else
            {
                MessageBox.Show("No row selected.");
            }
        }

        private void FormAddTransaction_Load(object sender, EventArgs e)
        {
            dgvSearch.DataSource = db.Book.ToList();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count > 0)
            {
                int bookId = Convert.ToInt32(dgvCart.SelectedRows[0].Cells["BookId"].Value);
                var book = bookCart.FirstOrDefault(m => m.BookId == bookId);
                bookCart.Remove(book);

                dgvCart.DataSource =null;
                dgvCart.DataSource = bookCart;

            }
            else
            {
                MessageBox.Show("No row selected.");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction()
            {

            };

            foreach(var book in bookCart)
            {
                SubtractBookCurrentQuantity(book.BookId);

                transaction.TransactionDetail.Add(new TransactionDetail()
                {
                    
                });
            }

            db.Transaction.Add(transaction);
            db.SaveChanges();
            bookCart = new List<BookDto>();
            dgvSearch.DataSource = null;
            dgvCart.DataSource = null;

        }

        private void SubtractBookCurrentQuantity(int id)
        {
            var book = db.Book.Find(id);
            book.CurrentQuantity = book.CurrentQuantity - 1;
            db.SaveChanges();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormLogin flog = new FormLogin();
            flog.Show();
            this.Hide();
        }

        private void btnAddRequest_Click(object sender, EventArgs e)
        {
            FormAddTransaction trans = new FormAddTransaction(_emailAddress);
            trans.Show();
            this.Hide();
        }

        private void btnViewInventory_Click(object sender, EventArgs e)
        {
            FormViewInventory view = new FormViewInventory(_emailAddress);
            view.Show();
            view.Hide();
        }

        private void btnTransactionHistory_Click(object sender, EventArgs e)
        {
            FormTransactionHistory trans = new FormTransactionHistory(_emailAddress);
            trans.Show();
            trans.Hide();
        }

        private void btnPendingTransaction_Click(object sender, EventArgs e)
        {
            FormPending pen = new FormPending(_emailAddress);
            pen.Show();
            pen.Hide();
        }

        private void btnManageStudentProfile_Click(object sender, EventArgs e)
        {
            FormAddStudent stud = new FormAddStudent(_emailAddress);
            stud.Show();
            stud.Hide();
        }

        private void btnGiveAccess_Click(object sender, EventArgs e)
        {
            FormGiveAccess give = new FormGiveAccess(_emailAddress);
            give.Show();
            give.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
