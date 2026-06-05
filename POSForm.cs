using System;
using System.Linq;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class POSForm : BaseForm
    {
        private Invoice currentInvoice;

        public POSForm()
        {
            InitializeComponent();
            LoadMedicines();
            currentInvoice = new Invoice("INV-" + (Program.DB.Invoices.Count + 1));
        }

        private void LoadMedicines()
        {
            var available = Program.DB.Medicines.Where(m => m.Quantity > 0 && m.ExpiryDate >= DateTime.Now).ToList();
            cmbMedicines.DataSource = available;
            cmbMedicines.DisplayMember = "TradeName";
        }

        private void btnAddToBill_Click(object sender, EventArgs e)
        {
            Medicine selected = cmbMedicines.SelectedItem as Medicine;
            if (selected == null) return;
            if (int.TryParse(txtQuantityToSell.Text, out int qty) && qty > 0)
            {
                if (qty <= selected.Quantity)
                {
                    InvoiceItem item = new InvoiceItem(selected.TradeName, selected.Price, qty);
                    currentInvoice.AddItem(item);
                    selected.Quantity -= qty;
                    lstCurrentItems.Items.Add(item.ToString());
                    lblTotal.Text = $"الإجمالي: {currentInvoice.TotalAmount} $";
                }
                else ShowMessage("الكمية غير متوفرة", "فشل", MessageBoxIcon.Warning);
            }
            else ShowMessage("أدخل كمية صحيحة", "تنبيه", MessageBoxIcon.Asterisk);
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (currentInvoice.Items.Count > 0)
            {
                Program.DB.AddInvoice(currentInvoice);
                ShowMessage($"تمت العملية! الإجمالي: {currentInvoice.TotalAmount} $", "نجاح", MessageBoxIcon.Information);
                this.Hide();
            }
            else ShowMessage("الفاتورة فارغة", "خطأ", MessageBoxIcon.Error);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void POSForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}