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
    public partial class FormPending : Form
    {

        private string _emailAddress { get; set; }


        GlendaleLibrarySystemEntities db = new GlendaleLibrarySystemEntities();

        public FormPending(string emailAddress)
        {
            InitializeComponent();
            this.Size = new Size(1400, 670);
            MaximizeBox = false;
            _emailAddress = emailAddress;
            btnEmail.Text = _emailAddress;
        }

        private void FormPending_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormLogin flog = new FormLogin();
            flog.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormAddTransaction trans = new FormAddTransaction(_emailAddress);
            trans.Show();
            this.Hide();
        }
    }
}
