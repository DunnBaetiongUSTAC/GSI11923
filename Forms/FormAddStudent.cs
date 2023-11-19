using FormCollection.Database;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FormCollection.Forms
{
    public partial class FormAddStudent : Form
    {
        GlendaleLibrarySystemEntities db = new GlendaleLibrarySystemEntities();

        private string _emailAddress { get; set; }

        public FormAddStudent(string emailAddress)
        {

            InitializeComponent();
            this.Size = new Size(1400, 670);
            MaximizeBox = false;
            _emailAddress = emailAddress;
            btnEmail.Text = _emailAddress;

        }

        private void FormAddStudent_Load(object sender, EventArgs e)
        {
            dgvAddStudent.DataSource = db.Student.ToList();
        }

        private void bookDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentFName.Text) || string.IsNullOrWhiteSpace(txtStudentLName.Text) || string.IsNullOrWhiteSpace(txtStudentEmail.Text) || string.IsNullOrWhiteSpace(txtStudentNumber.Text))
            {
                MessageBox.Show("Student Number, Student Name, and Email are required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                db.Student.Add(new Student()
                {
                    StudentNumber = Convert.ToInt32(txtStudentNumber.Text),
                    FirstName = txtStudentFName.Text,
                    MiddleName = txtStudentMName.Text,
                    LastName = txtStudentLName.Text,
                    Suffix = txtStudentSuffix.Text,
                    EmailAddress = txtStudentEmail.Text
                });

                db.SaveChanges();

                MessageBox.Show("Student added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearInputFields();

                dgvAddStudent.DataSource = db.Student.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void ClearInputFields()
        {
            txtStudentNumber.Clear();
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
            if (string.IsNullOrWhiteSpace(txtStudentSearch.Text))
            {
                MessageBox.Show("Please enter a Student Number to Search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvAddStudent.DataSource = db.Student.ToList();
            }

            try
            {
                if (int.TryParse(txtStudentSearch.Text, out int value))
                    dgvAddStudent.DataSource = db.Student.Where(m => m.StudentNumber == value).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void txtStudentNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormAddStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            //FormViewInventory formViewInventory = new FormViewInventory(_emailAddress);
            //formViewInventory.Show();
            //this.Hide();
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

        private void button10_Click(object sender, EventArgs e)
        {
            FormViewInventory inv = new FormViewInventory(_emailAddress);
            inv.Show();
            inv.Hide();
        }

        private void btnTransactionHistory_Click(object sender, EventArgs e)
        {
            FormTransactionHistory history = new FormTransactionHistory(_emailAddress);
            history.Show();
            this.Hide();
        }

        private void btnPendingTransactions_Click(object sender, EventArgs e)
        {
            FormPending pen = new FormPending(_emailAddress);
            pen.Show();
            pen.Hide();
        }

        private void btnStudent_Click(object sender, EventArgs e)
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

        private void btnStudentEdit_Click(object sender, EventArgs e)
        {

        }
    }
}

