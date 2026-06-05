using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public class BaseForm : Form
    {
        protected void ShowMessage(string text, string caption, MessageBoxIcon icon = MessageBoxIcon.Information)
        {
            MessageBox.Show(text, caption, MessageBoxButtons.OK, icon);
        }
        protected void RefreshDataGridView(DataGridView dgv, object dataSource)
        {
            dgv.DataSource = null;
            dgv.DataSource = dataSource;
        }
    }

    public class Medicine
    {
        public string ID { get; set; }
        public string TradeName { get; set; }
        public string ScientificName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string Company { get; set; }
        public DateTime ExpiryDate { get; set; }

        public Medicine() { }
        public Medicine(string id, string tradeName, string scientificName, int quantity, double price, string company, DateTime expiryDate)
        {
            ID = id; TradeName = tradeName; ScientificName = scientificName;
            Quantity = quantity; Price = price; Company = company; ExpiryDate = expiryDate;
        }
        public override string ToString() => TradeName;
    }

    public class InvoiceItem
    {
        public string MedicineName { get; set; }
        public double Price { get; set; }
        public int QuantitySold { get; set; }
        public double TotalPrice { get; set; }
        public InvoiceItem(string medicineName, double price, int quantitySold)
        {
            MedicineName = medicineName;
            Price = price;
            QuantitySold = quantitySold;
            TotalPrice = price * quantitySold;
        }
        public override string ToString() => $"{MedicineName} | كمية: {QuantitySold} | إجمالي: {TotalPrice} $";
    }

    public class Invoice
    {
        public string InvoiceID { get; set; }
        public DateTime SaleDate { get; set; }
        public List<InvoiceItem> Items { get; set; }
        public double TotalAmount { get; set; }
        public Invoice(string invoiceID)
        {
            InvoiceID = invoiceID;
            SaleDate = DateTime.Now;
            Items = new List<InvoiceItem>();
            TotalAmount = 0;
        }
        public void CalculateTotal() => TotalAmount = Items.Sum(i => i.TotalPrice);
        public void AddItem(InvoiceItem item) { Items.Add(item); CalculateTotal(); }
    }

    public class PharmacyDB
    {
        private List<Medicine> medicines = new List<Medicine>();
        private List<Invoice> invoices = new List<Invoice>();
        public IReadOnlyList<Medicine> Medicines => medicines.AsReadOnly();
        public IReadOnlyList<Invoice> Invoices => invoices.AsReadOnly();
        public void AddMedicine(Medicine med) => medicines.Add(med);
        public void RemoveMedicine(Medicine med) => medicines.Remove(med);
        public void AddInvoice(Invoice inv) => invoices.Add(inv);
        public List<Medicine> GetExpiredMedicines() => medicines.Where(m => m.ExpiryDate < DateTime.Now).ToList();
        public List<Invoice> GetTodayInvoices() => invoices.Where(inv => inv.SaleDate.Date == DateTime.Today).ToList();
        public bool IsMedicineIdExist(string id) => medicines.Any(m => m.ID == id);
    }
}