using System;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class ExpiredForm : BaseForm
    {
        public ExpiredForm()
        {
            InitializeComponent();
            LoadExpired();
        }

        private void LoadExpired()
        {
            dgvExpired.DataSource = null;
            dgvExpired.DataSource = Program.DB.GetExpiredMedicines();
        }

        private void btnDestroy_Click(object sender, EventArgs e)
        {
            foreach (var med in Program.DB.GetExpiredMedicines())
                Program.DB.RemoveMedicine(med);
            LoadExpired();
            ShowMessage("تم حذف جميع الأدوية منتهية الصلاحية", "نجاح");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ExpiredForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}