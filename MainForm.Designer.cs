namespace PharmacyManagementSystem
{
    partial class MainForm
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
            this.btnMedicines = new System.Windows.Forms.Button();
            this.btnPOS = new System.Windows.Forms.Button();
            this.btnExpired = new System.Windows.Forms.Button();
            this.btnInvoices = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMedicines
            // 
            this.btnMedicines.Location = new System.Drawing.Point(93, 49);
            this.btnMedicines.Margin = new System.Windows.Forms.Padding(4);
            this.btnMedicines.Name = "btnMedicines";
            this.btnMedicines.Size = new System.Drawing.Size(210, 55);
            this.btnMedicines.TabIndex = 0;
            this.btnMedicines.Text = "إدارة الأدوية";
            this.btnMedicines.UseVisualStyleBackColor = true;
            this.btnMedicines.Click += new System.EventHandler(this.btnMedicines_Click);
            // 
            // btnPOS
            // 
            this.btnPOS.Location = new System.Drawing.Point(93, 123);
            this.btnPOS.Margin = new System.Windows.Forms.Padding(4);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(210, 55);
            this.btnPOS.TabIndex = 1;
            this.btnPOS.Text = "نقطة بيع";
            this.btnPOS.UseVisualStyleBackColor = true;
            this.btnPOS.Click += new System.EventHandler(this.btnPOS_Click);
            // 
            // btnExpired
            // 
            this.btnExpired.Location = new System.Drawing.Point(93, 197);
            this.btnExpired.Margin = new System.Windows.Forms.Padding(4);
            this.btnExpired.Name = "btnExpired";
            this.btnExpired.Size = new System.Drawing.Size(210, 55);
            this.btnExpired.TabIndex = 2;
            this.btnExpired.Text = "أدوية منتهية الصلاحية";
            this.btnExpired.UseVisualStyleBackColor = true;
            this.btnExpired.Click += new System.EventHandler(this.btnExpired_Click);
            // 
            // btnInvoices
            // 
            this.btnInvoices.Location = new System.Drawing.Point(93, 271);
            this.btnInvoices.Margin = new System.Windows.Forms.Padding(4);
            this.btnInvoices.Name = "btnInvoices";
            this.btnInvoices.Size = new System.Drawing.Size(210, 55);
            this.btnInvoices.TabIndex = 3;
            this.btnInvoices.Text = "فواتير اليوم";
            this.btnInvoices.UseVisualStyleBackColor = true;
            this.btnInvoices.Click += new System.EventHandler(this.btnInvoices_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 382);
            this.Controls.Add(this.btnInvoices);
            this.Controls.Add(this.btnExpired);
            this.Controls.Add(this.btnPOS);
            this.Controls.Add(this.btnMedicines);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "القائمة الرئيسية - نظام إدارة الصيدلية";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnMedicines;
        private System.Windows.Forms.Button btnPOS;
        private System.Windows.Forms.Button btnExpired;
        private System.Windows.Forms.Button btnInvoices;
    }
}