using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCollection.Forms
{

    public partial class FormTransactionHistory : Form
    {
       

        private void PopulateTransactionTable(string timeInterval)
        {

            string connectionString = @"Data Source=LUWEESE; Initial Catalog=GlendaleLibrarySystem-Test; Integrated Security=true";
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();

            string transactionsetting = @"
            SELECT
                STUD.StudentId,
                    CONCAT(
                        COALESCE(STUD.FirstName, '');
                        ' ',
                        COALESCE(STUD.MiddleName, '');
                        ' ',
                        COALESCE(STUD.LastName, '');
                        ' ',
                        COALESCE(STUD.Suffix, '');
                    ' ',
                    ) AS Name,
                STAT.StatusId,
                TRANS.TransactionId,
                TRANS.BorrowedDate,
                TRANS.ReturnDate,
                TRANS.AuthorizedBy
            FROM
                Transaction AS TRANS
                JOIN Student AS STUD ON TRANS.StudentId=STUD.StudentId
                JOIN Status AS STAT ON TRANS.StatusId=STAT.StatusId
                JOIN User AS USER ON TRANS.AuthorizedBy=USER.UserId

            ";

            switch (timeInterval)
            {
                case "Daily":
                    transactionsetting += "DATEDIFF(DAY, t.BorrowedDate, GETDATE()) = 0";
                    break;
                case "Weekly":
                    transactionsetting += "DATEDIFF(WEEK, t.BorrowedDate, GETDATE()) = 0";
                    break;
                case "Monthly":
                    transactionsetting += "DATEDIFF(MONTH, t.BorrowedDate, GETDATE()) = 0";
                    break;
                default:
                    
                    transactionsetting += "1=1";
                    break;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(transactionsetting, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        
                        dgvTransaction.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

        }


        public FormTransactionHistory()
        {
            InitializeComponent();
            this.Size = new Size(1400, 670);
            MaximizeBox = false;
        }

        private void bookDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDaily_Click(object sender, EventArgs e)
        {
            PopulateTransactionTable("Daily");
        }

        private void btnWeekly_Click(object sender, EventArgs e)
        {
            PopulateTransactionTable("Weekly");
        }

        private void btnMonthly_Click(object sender, EventArgs e)
        {
            PopulateTransactionTable("Monthly");
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {

        }

        private void FormTransactionHistory_Load(object sender, EventArgs e)
        {

        }
    }
}
