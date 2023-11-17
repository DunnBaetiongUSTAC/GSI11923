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
    public partial class FormSearchByStudent : Form
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

        public FormSearchByStudent()
        {
            InitializeComponent();
            this.Size = new Size(1400, 670);
            MaximizeBox = false;
        }

        private void btnSearchS_Click(object sender, EventArgs e)
        {
            if (cmbSearchS.Text == "Title")
            {
                da.SelectCommand = new SqlCommand(searchTitleQuery, cs);
                da.SelectCommand.Parameters.Add("@TitleSearchTerm", SqlDbType.VarChar).Value = txtSearchS.Text;
                ds.Clear();
                da.Fill(ds);

                int count = ds.Tables[0].Rows.Count;
                if (count > 0)
                {
                    MessageBox.Show("Search Successful", "Title Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvSearchS.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("Title Not Found", "Title Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else if (cmbSearchS.Text == "Category")
            {
                da.SelectCommand = new SqlCommand(searchCategoryQuery, cs);
                da.SelectCommand.Parameters.Add("@CategorySearchTerm", SqlDbType.VarChar).Value = txtSearchS.Text;
                ds.Clear();
                da.Fill(ds);

                int count = ds.Tables[0].Rows.Count;
                if (count > 0)
                {
                    MessageBox.Show("Search Successful", "Category Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvSearchS.DataSource = ds.Tables[0];
                }

                else
                {
                    MessageBox.Show("Category Not Found", "Category Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else if (cmbSearchS.Text == "SubCategory")
            {
                da.SelectCommand = new SqlCommand(searchSubCategoryQuery, cs);
                da.SelectCommand.Parameters.Add("@SubCategorySearchTerm", SqlDbType.VarChar).Value = txtSearchS.Text;
                ds.Clear();
                da.Fill(ds);

                int count = ds.Tables[0].Rows.Count;
                if (count > 0)
                {
                    MessageBox.Show("Search Successful", "SubCategory Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvSearchS.DataSource = ds.Tables[0];
                }

                else
                {
                    MessageBox.Show("SubCategory Not Found", "SubCategory Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else if (cmbSearchS.Text == "Author")
            {
                da.SelectCommand = new SqlCommand(searchAuthorQuery, cs);
                da.SelectCommand.Parameters.Add("@AuthorSearchTerm", SqlDbType.VarChar).Value = txtSearchS.Text;
                ds.Clear();
                da.Fill(ds);

                int count = ds.Tables[0].Rows.Count;
                if (count > 0)
                {
                    MessageBox.Show("Search Successful", "Author Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvSearchS.DataSource = ds.Tables[0];
                }

                else
                {
                    MessageBox.Show("Author Not Found", "Author Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnLoginS_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();

            if (login.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void dgvSearchS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormSearchByStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
