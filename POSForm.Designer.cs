namespace PharmacyManagementSystem
{
    partial class POSForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cmbMedicines = new System.Windows.Forms.ComboBox();
            this.txtQuantityToSell = new System.Windows.Forms.TextBox();
            this.btnAddToBill = new System.Windows.Forms.Button();
            this.lstCurrentItems = new System.Windows.Forms.ListBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbMedicines
            // 
            this.cmbMedicines.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedicines.FormattingEnabled = true;
            this.cmbMedicines.Location = new System.Drawing.Point(35, 49);
            this.cmbMedicines.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbMedicines.Name = "cmbMedicines";
            this.cmbMedicines.Size = new System.Drawing.Size(233, 24);
            this.cmbMedicines.TabIndex = 0;
            // 
            // txtQuantityToSell
            // 
            this.txtQuantityToSell.Location = new System.Drawing.Point(35, 111);
            this.txtQuantityToSell.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuantityToSell.Name = "txtQuantityToSell";
            this.txtQuantityToSell.Size = new System.Drawing.Size(116, 24);
            this.txtQuantityToSell.TabIndex = 1;
            // 
            // btnAddToBill
            // 
            this.btnAddToBill.Location = new System.Drawing.Point(175, 105);
            this.btnAddToBill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddToBill.Name = "btnAddToBill";
            this.btnAddToBill.Size = new System.Drawing.Size(117, 37);
            this.btnAddToBill.TabIndex = 2;
            this.btnAddToBill.Text = "إضافة للفاتورة";
            this.btnAddToBill.UseVisualStyleBackColor = true;
            this.btnAddToBill.Click += new System.EventHandler(this.btnAddToBill_Click);
            // 
            // lstCurrentItems
            // 
            this.lstCurrentItems.FormattingEnabled = true;
            this.lstCurrentItems.ItemHeight = 16;
            this.lstCurrentItems.Location = new System.Drawing.Point(327, 49);
            this.lstCurrentItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstCurrentItems.Name = "lstCurrentItems";
            this.lstCurrentItems.Size = new System.Drawing.Size(326, 196);
            this.lstCurrentItems.TabIndex = 3;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(467, 271);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(120, 21);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "الإجمالي: 0 $";
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(35, 271);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(140, 43);
            this.btnCheckout.TabIndex = 5;
            this.btnCheckout.Text = "إتمام البيع";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(35, 332);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(117, 37);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "رجوع";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "اختر الدواء:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "الكمية:";
            // 
            // POSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 418);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lstCurrentItems);
            this.Controls.Add(this.btnAddToBill);
            this.Controls.Add(this.txtQuantityToSell);
            this.Controls.Add(this.cmbMedicines);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "POSForm";
            this.Text = "نقطة البيع";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.POSForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ComboBox cmbMedicines;
        private System.Windows.Forms.TextBox txtQuantityToSell;
        private System.Windows.Forms.Button btnAddToBill;
        private System.Windows.Forms.ListBox lstCurrentItems;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}