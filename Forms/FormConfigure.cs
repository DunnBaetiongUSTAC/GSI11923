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
    public partial class FormConfigure : Form
    {
        GlendaleLibrarySystemEntities db = new GlendaleLibrarySystemEntities();
        public FormConfigure()
        {
            InitializeComponent();
            this.Size = new Size(714, 670);
            MaximizeBox = false;
        }

        private void FormConfigure_Load(object sender, EventArgs e)
        {

        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) && string.IsNullOrWhiteSpace(txtMiddleName.Text) && string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Please input at least one among the First Name, Middle Name, and Last Name fieldss", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                db.Author.Add(new Author()
                {
                    FirstName = txtFirstName.Text,
                    MiddleName = txtMiddleName.Text,
                    LastName = txtLastName.Text,
                    Suffix = txtSuffix.Text,
                });

                db.SaveChanges();

                MessageBox.Show("Author added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCategory.Text))
            {
                MessageBox.Show("Category is a required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                db.Category.Add(new Category()
                {
                    Category1 = txtCategory.Text
                });

                db.SaveChanges();

                MessageBox.Show("Category added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddSubCategory_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSubCategory.Text))
            {
                MessageBox.Show("Sub-Category is a required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                db.SubCategory.Add(new SubCategory()
                {
                    SubCategory1 = txtSubCategory.Text
                });

                db.SaveChanges();

                MessageBox.Show("Sub-Category added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddShelf_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtShelf.Text))
            {
                MessageBox.Show("Shelf is a required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                db.Shelf.Add(new Shelf()
                {
                    Shelf1 = txtShelf.Text
                });

                db.SaveChanges();

                MessageBox.Show("Shelf added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRow.Text))
            {
                MessageBox.Show("Row is a required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                db.Row.Add(new Row()
                {
                    Row1 = txtRow.Text
                });

                db.SaveChanges();

                MessageBox.Show("Row added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddPublisher_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPublisher.Text))
            {
                MessageBox.Show("Publisher is a required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                db.Publisher.Add(new Publisher()
                {
                    Publisher1 = txtPublisher.Text
                });

                db.SaveChanges();

                MessageBox.Show("Publisher added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearInputFields()
        {
            txtFirstName.Clear();
            txtMiddleName.Clear();
            txtLastName.Clear();
            txtSuffix.Clear();
            txtCategory.Clear();
            txtSubCategory.Clear();
            txtPublisher.Clear();
            txtShelf.Clear();
            txtRow.Clear();
        }
    }
}
