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

namespace FormCollection.Forms
{
    public partial class FormViewInventory : Form
    {
        SqlConnection cs = new SqlConnection(@"Data Source=LUWEESE; Initial Catalog=GlendaleLibrarySystem-Test; Integrated Security=true");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();


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

        public FormViewInventory()
        {
            InitializeComponent();
            this.Size = new Size(1400, 670);
            MaximizeBox = false;
        }

        private void bookDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormViewInventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_GlendaleLibrarySystem_TestDataSet2.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this._GlendaleLibrarySystem_TestDataSet2.Book);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            if (cbSearch.Text == "Title")
            {
                da.SelectCommand = new SqlCommand(searchTitleQuery, cs);
                da.SelectCommand.Parameters.Add("@TitleSearchTerm", SqlDbType.VarChar).Value = txtSearch.Text;
                ds.Clear();
                da.Fill(ds);
                int count = ds.Tables[0].Rows.Count;

                if (count > 0)
                {
                    MessageBox.Show("Search Successful", "Title Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvSearch.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("Title Not Found", "Title Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else if (cbSearch.Text == "Category")
            {
                da.SelectCommand = new SqlCommand(searchCategoryQuery, cs);
                da.SelectCommand.Parameters.Add("@CategorySearchTerm", SqlDbType.VarChar).Value = txtSearch.Text;
                ds.Clear();
                da.Fill(ds);

                int count = ds.Tables[0].Rows.Count;
                if (count > 0)
                {
                    MessageBox.Show("Search Successful", "Category Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvSearch.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("Category Not Found", "Category Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else if (cbSearch.Text == "SubCategory")
            {
                da.SelectCommand = new SqlCommand(searchSubCategoryQuery, cs);
                da.SelectCommand.Parameters.Add("@SubCategorySearchTerm", SqlDbType.VarChar).Value = txtSearch.Text;
                ds.Clear();
                da.Fill(ds);

                int count = ds.Tables[0].Rows.Count;
                if (count > 0)
                {
                    MessageBox.Show("Search Successful", "SubCategory Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvSearch.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("SubCategory Not Found", "SubCategory Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else if (cbSearch.Text == "Author")
            {
                da.SelectCommand = new SqlCommand(searchAuthorQuery, cs);
                da.SelectCommand.Parameters.Add("@AuthorSearchTerm", SqlDbType.VarChar).Value = txtSearch.Text;
                ds.Clear();
                da.Fill(ds);

                int count = ds.Tables[0].Rows.Count;
                if (count > 0)
                {
                    MessageBox.Show("Search Successful", "Author Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvSearch.DataSource = ds.Tables[0];
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

        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}