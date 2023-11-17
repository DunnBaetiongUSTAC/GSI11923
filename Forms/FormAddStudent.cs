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
    public partial class FormAddStudent : Form
    {
        private readonly string connectionString = @"Data Source=LUWEESE; Initial Catalog=GlendaleLibrarySystem-Test; Integrated Security=true";

        public FormAddStudent()
        {

            InitializeComponent();
            this.Size = new Size(1400, 670);
            MaximizeBox = false;
        }

        private void FormAddStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_GlendaleLibrarySystem_TestDataSet1.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this._GlendaleLibrarySystem_TestDataSet1.Student);

        }

        private void bookDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentID.Text) || string.IsNullOrWhiteSpace(txtStudentFName.Text) || string.IsNullOrWhiteSpace(txtStudentMName.Text) || string.IsNullOrWhiteSpace(txtStudentLName.Text) || string.IsNullOrWhiteSpace(txtStudentSuffix.Text) || string.IsNullOrWhiteSpace(txtStudentEmail.Text))
            {
                MessageBox.Show("StudentID, Student Name, and Email are required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"INSERT INTO Student (StudentId, FirstName, MiddleName, LastName, Suffix, EmailAddress) VALUES (@StudentId, @FirstName, @MiddleName, @LastName, @Suffix, @EmailAddress) ";

                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@StudentId", txtStudentID.Text);
                        command.Parameters.AddWithValue("@FirstName", txtStudentFName.Text);
                        command.Parameters.AddWithValue("@MiddleName", txtStudentMName.Text);
                        command.Parameters.AddWithValue("@LastName", txtStudentLName.Text);
                        command.Parameters.AddWithValue("Suffix", txtStudentSuffix.Text);
                        command.Parameters.AddWithValue("@EmailAddress", txtStudentEmail.Text);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Student added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClearInputFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void ClearInputFields()
        {
            txtStudentID.Clear();
            txtStudentFName.Clear();
            txtStudentMName.Clear();
            txtStudentLName.Clear();
            txtStudentSuffix.Clear();
            txtStudentEmail.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                MessageBox.Show("Please enter a Student ID to Search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = "SELECT * FROM Student WHERE StudentId = @StudentId";
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@StudentId", txtSearch.Text);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            bookDataGridView.DataSource = dataTable;
                            if (dataTable.Rows.Count == 0)
                            {
                                MessageBox.Show("No student found with the provided Student ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
         
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}

