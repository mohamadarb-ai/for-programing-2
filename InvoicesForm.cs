using System;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class InvoicesForm : BaseForm
    {
        public InvoicesForm()
        {
            InitializeComponent();
            LoadInvoices();
        }

        private void LoadInvoices()
        {
            dgvInvoices.DataSource = null;
            dgvInvoices.DataSource = Program.DB.GetTodayInvoices();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void InvoicesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void InvoicesForm_Load(object sender, EventArgs e)
        {

        }
    }
}