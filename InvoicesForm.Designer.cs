namespace PharmacyManagementSystem
{
    partial class InvoicesForm
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
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoices.Location = new System.Drawing.Point(23, 25);
            this.dgvInvoices.Margin = new System.Windows.Forms.Padding(4);
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.RowHeadersWidth = 51;
            this.dgvInvoices.Size = new System.Drawing.Size(758, 406);
            this.dgvInvoices.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(327, 455);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(175, 43);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "رجوع";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // InvoicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 529);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvInvoices);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InvoicesForm";
            this.Text = "فواتير اليوم";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InvoicesForm_FormClosed);
            this.Load += new System.EventHandler(this.InvoicesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridView dgvInvoices;
        private System.Windows.Forms.Button btnBack;
    }
}