using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FormCollection.Forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            this.Size = new Size(1400, 670);
            MaximizeBox = false;
        }

        SqlConnection conn = new SqlConnection(@"Data Source = LUWEESE; Initial Catalog = GlendaleLibrarySystem - Test; Integrated Security = true");
        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username, password;

            username = txtEmail.Text;
            password = txtPassword.Text;

            try
            {
                String querry = "SELECT * FROM UserLogin WHERE EmailAddress = '" + txtEmail.Text + "' AND Password = '" + txtPassword.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = txtEmail.Text;
                    password = txtPassword.Text;

                    FormViewInventory formViewInventory = new FormViewInventory();
                    formViewInventory.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Invalid Login Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Clear();
                    txtPassword.Clear();
                }

            }
            catch
            {
                MessageBox.Show("Error");
            }

        }
    }
}
