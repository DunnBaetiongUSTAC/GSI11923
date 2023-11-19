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
    public partial class FormGiveAccess : Form
    {
        GlendaleLibrarySystemEntities db = new GlendaleLibrarySystemEntities();
        private string _emailAddress { get; set; }
        public FormGiveAccess(string emailAddress)
        {
            InitializeComponent();
            this.Size = new Size(1400, 670);
            MaximizeBox = false;
            _emailAddress = emailAddress;
            btnEmail.Text = _emailAddress;
        }

        private void FormGiveAccess_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormLogin flog = new FormLogin();
            flog.Show();
            this.Hide();
        }

        //btnAddTransaction
        private void button5_Click(object sender, EventArgs e)
        {
            FormAddTransaction trans = new FormAddTransaction(_emailAddress);
            trans.Show();
            this.Hide();
        }

        private void btnEmployeeSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmployeeSearch.Text))
            {
                MessageBox.Show("Please enter a Student Number to Search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvGiveAccess.DataSource = db.User.ToList();
            }

            try
            {
                if (int.TryParse(txtEmployeeSearch.Text, out int value))
                    dgvGiveAccess.DataSource = db.User.Where(m => m.UserNumber == value).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //        List<UserDto> users = new List<UserDto>();

            //        users = db.User
            //        .Where(m => m.UserNumber.ToString().Contains(txtEmployeeSearch.Text))
            //        .Select(m => new UserDto
            //        {

            //         UserNumber = m.UserNumber,

            //        })
            //.ToList();
            //        if (txtEmployeeSearch.Text != null && txtEmployeeSearch.Text.Any())
            //        {
            //            MessageBox.Show("Search Successful", "User Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            dgvGiveAccess.DataSource = users;
            //        }
            //        else
            //        {
            //            MessageBox.Show("Title Not Found", "Title Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }

        }

        private void btnEmployeeAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnEmployeeEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnEmployeeDelete_Click(object sender, EventArgs e)
        {

        }

        //private IEnumerable<UserDto> MapToUserDto(IEnumerable<User> users)
        //{
        //    return users
        //        .Select(user => new UserDto()
        //        {
        //            UserNumber = user.UserNumber,
        //            Name = string.Join(" ", user.FirstName, user.LastName),
        //            Role = Convert.ToString(user.Role)
        //        });
        //}
    }
}
