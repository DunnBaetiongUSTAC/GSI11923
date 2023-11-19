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

namespace FormCollection.Forms
{
    public partial class FormEdit : Form
    {
        GlendaleLibrarySystemEntities db = new GlendaleLibrarySystemEntities();

        public FormEdit()
        {
            InitializeComponent();
            this.Size = new Size(650, 700);
            MaximizeBox = false;
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {

        }

        private void btnConfigure_Click(object sender, EventArgs e)
        {
            FormConfigure FConfig = new FormConfigure();
            FConfig.Show();
            this.Hide();
        }

        private void btnEditCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnEditAdd_Click(object sender, EventArgs e)
        {
           //db.Book.Add(new Book()
           // {
           //     BookCode = txtEditBookCode.Text,
           //     Title = txtEditTitle.Text,
           //     Author
           // });

        }

        private void btnEditUpdate_Click(object sender, EventArgs e)
        {
            int selectedBookId = Convert.ToInt32(txtEditSearch.Text);

            Book selectedBook = db.Book.FirstOrDefault(b => b.BookId == selectedBookId);

            if (selectedBook != null)
            {
                txtEditBookCode.Text = selectedBook.BookCode;
                txtEditTitle.Text = selectedBook.Title;
                cmbEditAuthor.Text = selectedBook.AuthorId.ToString();
                cmbEditPublisher.Text = selectedBook.PublisherId.ToString();
                cmbEditCategory.Text = selectedBook.CategoryId.ToString();
                cmbEditSubCategory.Text = selectedBook.SubCategoryId.ToString();
                txtEditQuantity.Text = selectedBook.TotalQuantity.ToString();
                txtEditYear.Text = selectedBook.Year;
                cmbEditShelf.Text = selectedBook.ShelfId.ToString();
                cmbEditRow.Text = selectedBook.RowId.ToString();



                db.SaveChanges();

                MessageBox.Show("Book updated successfully");
            }
            else
            {
                MessageBox.Show("Book not found");
            }
        }
        private void btnEditDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnEditSearch_Click(object sender, EventArgs e)
        {
            //List<SearchDto> books = new List<SearchDto>();

            int selectedBookId = Convert.ToInt32(txtEditSearch.Text);

            Book selectedBook = db.Book.FirstOrDefault(b => b.BookId == selectedBookId);

            if (selectedBook != null)
            {

                txtEditBookCode.Text = selectedBook.BookCode;
                txtEditTitle.Text = selectedBook.Title;
                cmbEditAuthor.Text = selectedBook.AuthorId.ToString();
                cmbEditPublisher.Text = selectedBook.PublisherId.ToString();
                cmbEditCategory.Text = selectedBook.CategoryId.ToString();
                cmbEditSubCategory.Text = selectedBook.SubCategoryId.ToString();
                txtEditQuantity.Text = selectedBook.TotalQuantity.ToString();
                txtEditYear.Text = selectedBook.Year;
                cmbEditShelf.Text = selectedBook.ShelfId.ToString();
                cmbEditRow.Text = selectedBook.RowId.ToString();

            }
            else
            {
                MessageBox.Show("Please enter a valid Book ID.");
            }

        }

    }

}
