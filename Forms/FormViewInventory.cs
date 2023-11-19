 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormCollection.Database;
using FormCollection.Dto;

namespace FormCollection.Forms
{
    public partial class FormViewInventory : Form
    {
        string searchTitleQuery = @"
            SELECT
                B.BookCode,
                CONCAT(
                    COALESCE(A.FirstName, ''),
                    ' ',
                    COALESCE(A.MiddleName, ''),
                    ' ',
                    COALESCE(A.LastName, ''),
                    ' ',
                    COALESCE(A.Suffix, '')
                ) AS Name,
                B.Title,
                P.Publisher,
                C.Category,
                SC.SubCategory
            FROM
                Book AS B
                JOIN Author AS A ON B.AuthorId = A.AuthorId
                JOIN Publisher AS P ON B.PublisherId = P.PublisherId
                JOIN Category AS C ON B.CategoryId = C.CategoryId
                JOIN SubCategory AS SC ON B.SubCategoryId = SC.SubCategoryId
            WHERE 
                 B.Title LIKE '%' + @TitleSearchTerm + '%';";

        string searchCategoryQuery = @"
            SELECT
                B.BookCode,
                CONCAT(
                    COALESCE(A.FirstName, ''),
                    ' ',
                    COALESCE(A.MiddleName, ''),
                    ' ',
                    COALESCE(A.LastName, ''),
                    ' ',
                    COALESCE(A.Suffix, '')
                ) AS Name,
                B.Title,
                P.Publisher,
                C.Category,
                SC.SubCategory
            FROM
                Book AS B
                JOIN Author AS A ON B.AuthorId = A.AuthorId
                JOIN Publisher AS P ON B.PublisherId = P.PublisherId
                JOIN Category AS C ON B.CategoryId = C.CategoryId
                JOIN SubCategory AS SC ON B.SubCategoryId = SC.SubCategoryId
            WHERE 
                 C.Category LIKE '%' + @CategorySearchTerm + '%';";

        string searchSubCategoryQuery = @"
            SELECT
                B.BookCode,
                CONCAT(
                    COALESCE(A.FirstName, ''),
                    ' ',
                    COALESCE(A.MiddleName, ''),
                    ' ',
                    COALESCE(A.LastName, ''),
                    ' ',
                    COALESCE(A.Suffix, '')
                ) AS Name,
                B.Title,
                P.Publisher,
                C.Category,
                SC.SubCategory
            FROM
                Book AS B
                JOIN Author AS A ON B.AuthorId = A.AuthorId
                JOIN Publisher AS P ON B.PublisherId = P.PublisherId
                JOIN Category AS C ON B.CategoryId = C.CategoryId
                JOIN SubCategory AS SC ON B.SubCategoryId = SC.SubCategoryId
            WHERE 
                 SC.SubCategory LIKE '%' + @SubCategorySearchTerm + '%';";

        string searchAuthorQuery = @"
            SELECT
                B.BookCode,
                CONCAT(
                    COALESCE(A.FirstName, ''),
                    ' ',
                    COALESCE(A.MiddleName, ''),
                    ' ',
                    COALESCE(A.LastName, ''),
                    ' ',
                    COALESCE(A.Suffix, '')
                ) AS Name,
                B.Title,
                P.Publisher,
                C.Category,
                SC.SubCategory
            FROM
                Book AS B
                JOIN Author AS A ON B.AuthorId = A.AuthorId
                JOIN Publisher AS P ON B.PublisherId = P.PublisherId
                JOIN Category AS C ON B.CategoryId = C.CategoryId
                JOIN SubCategory AS SC ON B.SubCategoryId = SC.SubCategoryId
            WHERE 
                CONCAT(
                    COALESCE(A.FirstName, ''),
                    ' ',
                    COALESCE(A.MiddleName, ''),
                    ' ',
                    COALESCE(A.LastName, ''),
                    ' ',
                    COALESCE(A.Suffix, '')
                    ) LIKE '%' + @AuthorSearchTerm + '%';";

        private string _emailAddress { get; set; }


        GlendaleLibrarySystemEntities db = new GlendaleLibrarySystemEntities();

        public FormViewInventory(string emailAddress)
        {
            InitializeComponent();
            this.Size = new Size(1400, 670);
            MaximizeBox = false;
            _emailAddress = emailAddress;
            labelEmail.Text = _emailAddress;
        }

        private void bookDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormViewInventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_GlendaleLibrarySystem_TestDataSet2.Book' table. You can move, or remove it, as needed.
            //this.bookTableAdapter.Fill(this._GlendaleLibrarySystem_TestDataSet2.Book);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<BookDto> books = new List<BookDto>();

            if (cmbSearch.Text == "Title")
            {
                books = MapToBookDto(db.Book.Where(m => m.Title.Contains(txtSearch.Text))).ToList();
                int count = books.Count();

                if (count > 0)
                {
                    MessageBox.Show("Search Successful", "Title Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvSearch.DataSource = books;
                }
                else
                {
                    MessageBox.Show("Title Not Found", "Title Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else if (cmbSearch.Text == "Category")
            {
                books = MapToBookDto(db.Book.Where(m => m.Category.Category1.Contains(txtSearch.Text))).ToList();
                int count = books.Count();

                if (count > 0)
                {
                    MessageBox.Show("Search Successful", "Category Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvSearch.DataSource = books;
                }
                else
                {
                    MessageBox.Show("Category Not Found", "Category Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else if (cmbSearch.Text == "SubCategory")
            {
                books = MapToBookDto(db.Book.Where(m => m.SubCategory.SubCategory1.Contains(txtSearch.Text))).ToList();
                int count = books.Count();

                
                if (count > 0)
                {
                    MessageBox.Show("Search Successful", "SubCategory Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvSearch.DataSource = books;
                }
                else
                {
                    MessageBox.Show("SubCategory Not Found", "SubCategory Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else if (cmbSearch.Text == "Author")
            {
                books = MapToBookDto(db.Book.Where(m => m.Author.FirstName.Contains(txtSearch.Text) || m.Author.LastName.Contains(txtSearch.Text))).ToList();
                int count = books.Count();

               
                if (count > 0)
                {
                    MessageBox.Show("Search Successful", "Author Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvSearch.DataSource = books;
                }
                else
                {
                    MessageBox.Show("Author Not Found", "Author Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEditInv_Click(object sender, EventArgs e)
        {
            FormEdit editInv = new FormEdit();
            editInv.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private IEnumerable<BookDto> MapToBookDto(IEnumerable<Book> books)
        {
            return books
                .Select(book => new BookDto()
                {
                    BookCode = book.BookCode,
                    Name = string.Join(" ", book.Author.FirstName, book.Author.LastName),
                    Title = book.Title,
                    Publisher = book.Publisher.Publisher1,
                    Category = book.Category.Category1,
                    SubCategory = book.SubCategory.SubCategory1
                });
        }

        private void btnManageStudentProfile_Click(object sender, EventArgs e)
        {
            FormAddStudent formaddstudent = new FormAddStudent(_emailAddress);
            formaddstudent.Show();
            this.Hide();
        }

        private void btnTransactionHistory_Click(object sender, EventArgs e)
        {
            FormTransactionHistory formtransactionhistory = new FormTransactionHistory(_emailAddress);
            formtransactionhistory.Show();
            this.Hide();
        }

        private void btnPendingTransaction_Click(object sender, EventArgs e)
        {
            FormPending formPending = new FormPending(_emailAddress);
            formPending.Show();
            this.Hide();
        }

        private void btnAddRequest_Click(object sender, EventArgs e)
        {

        }

        private void btnGiveAccess_Click(object sender, EventArgs e)
        {
            FormGiveAccess formGiveAccess = new FormGiveAccess(_emailAddress);
            formGiveAccess.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormViewInventory formViewInventory = new FormViewInventory(_emailAddress);
            formViewInventory.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormLogin flog = new FormLogin();
            flog.Show();
            this.Hide();
        }
    }
}