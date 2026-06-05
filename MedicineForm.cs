using System;
using System.Linq;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class MedicineForm : BaseForm
    {
        public MedicineForm()
        {
            InitializeComponent();
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            dgvMedicines.DataSource = null;
            dgvMedicines.DataSource = Program.DB.Medicines.ToList();
        }

        private void ClearFields()
        {
            txtID.Clear();
            txtTradeName.Clear();
            txtScientificName.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();
            txtCompany.Clear();
            dtpExpiry.Value = DateTime.Now;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtTradeName.Text))
                {
                    ShowMessage("يرجى ملء رقم الدواء والاسم التجاري", "خطأ", MessageBoxIcon.Error);
                    return;
                }
                if (Program.DB.IsMedicineIdExist(txtID.Text))
                {
                    ShowMessage("رقم الدواء موجود مسبقاً", "خطأ", MessageBoxIcon.Error);
                    return;
                }
                Medicine newMed = new Medicine(
                    txtID.Text,
                    txtTradeName.Text,
                    txtScientificName.Text,
                    int.Parse(txtQuantity.Text),
                    double.Parse(txtPrice.Text),
                    txtCompany.Text,
                    dtpExpiry.Value
                );
                Program.DB.AddMedicine(newMed);
                RefreshGrid();
                ClearFields();
                ShowMessage("تمت إضافة الدواء بنجاح", "نجاح");
            }
            catch (Exception ex)
            {
                ShowMessage("خطأ: " + ex.Message, "فشل", MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMedicines.CurrentRow != null && dgvMedicines.CurrentRow.DataBoundItem is Medicine med)
            {
                Program.DB.RemoveMedicine(med);
                RefreshGrid();
                ShowMessage("تم حذف الدواء", "نجاح");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void MedicineForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}