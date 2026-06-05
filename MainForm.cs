using System;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class MainForm : BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
            LoadInitialData();
        }

        private void LoadInitialData()
        {
            if (Program.DB.Medicines.Count == 0)
            {
                Program.DB.AddMedicine(new Medicine("M001", "Panadol", "Paracetamol", 50, 5.5, "SanoFi", new DateTime(2027, 12, 30)));
                Program.DB.AddMedicine(new Medicine("M002", "Aspirin", "Acetylsalicylic", 20, 3.0, "Bayer", new DateTime(2025, 5, 1)));
                Program.DB.AddMedicine(new Medicine("M003", "Brufen", "Ibuprofen", 30, 4.2, "Abbott", new DateTime(2026, 8, 15)));
            }
        }

        private void btnMedicines_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MedicineForm().ShowDialog();
            this.Show();
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            this.Hide();
            new POSForm().ShowDialog();
            this.Show();
        }

        private void btnExpired_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ExpiredForm().ShowDialog();
            this.Show();
        }

        private void btnInvoices_Click(object sender, EventArgs e)
        {
            this.Hide();
            new InvoicesForm().ShowDialog();
            this.Show();
            //this way its so ez 
           // InvoicesForm uu = new InvoicesForm();
           // uu.ShowDialog();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}