namespace PharmacyManagementSystem
{
    partial class MedicineForm
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
            this.dgvMedicines = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblTrade = new System.Windows.Forms.Label();
            this.txtTradeName = new System.Windows.Forms.TextBox();
            this.lblScientific = new System.Windows.Forms.Label();
            this.txtScientificName = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.lblExpiry = new System.Windows.Forms.Label();
            this.dtpExpiry = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicines)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMedicines
            // 
            this.dgvMedicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicines.Location = new System.Drawing.Point(23, 25);
            this.dgvMedicines.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMedicines.Name = "dgvMedicines";
            this.dgvMedicines.RowHeadersWidth = 51;
            this.dgvMedicines.Size = new System.Drawing.Size(747, 246);
            this.dgvMedicines.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(23, 295);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 43);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "إضافة";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(152, 295);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 43);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(280, 295);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(117, 43);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "رجوع";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(23, 369);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(67, 17);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "رقم الدواء:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(140, 366);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(174, 24);
            this.txtID.TabIndex = 5;
            // 
            // lblTrade
            // 
            this.lblTrade.AutoSize = true;
            this.lblTrade.Location = new System.Drawing.Point(23, 412);
            this.lblTrade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrade.Name = "lblTrade";
            this.lblTrade.Size = new System.Drawing.Size(96, 17);
            this.lblTrade.TabIndex = 6;
            this.lblTrade.Text = "الاسم التجاري:";
            // 
            // txtTradeName
            // 
            this.txtTradeName.Location = new System.Drawing.Point(140, 409);
            this.txtTradeName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTradeName.Name = "txtTradeName";
            this.txtTradeName.Size = new System.Drawing.Size(174, 24);
            this.txtTradeName.TabIndex = 7;
            // 
            // lblScientific
            // 
            this.lblScientific.AutoSize = true;
            this.lblScientific.Location = new System.Drawing.Point(23, 455);
            this.lblScientific.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScientific.Name = "lblScientific";
            this.lblScientific.Size = new System.Drawing.Size(95, 17);
            this.lblScientific.TabIndex = 8;
            this.lblScientific.Text = "الاسم العلمي:";
            // 
            // txtScientificName
            // 
            this.txtScientificName.Location = new System.Drawing.Point(140, 452);
            this.txtScientificName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtScientificName.Name = "txtScientificName";
            this.txtScientificName.Size = new System.Drawing.Size(174, 24);
            this.txtScientificName.TabIndex = 9;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(23, 498);
            this.lblQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(49, 17);
            this.lblQty.TabIndex = 10;
            this.lblQty.Text = "الكمية:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(140, 495);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(174, 24);
            this.txtQuantity.TabIndex = 11;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(23, 542);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(48, 17);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "السعر:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(140, 538);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(174, 24);
            this.txtPrice.TabIndex = 13;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(23, 585);
            this.lblCompany.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(107, 17);
            this.lblCompany.TabIndex = 14;
            this.lblCompany.Text = "الشركة المصنعة:";
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(140, 581);
            this.txtCompany.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(174, 24);
            this.txtCompany.TabIndex = 15;
            // 
            // lblExpiry
            // 
            this.lblExpiry.AutoSize = true;
            this.lblExpiry.Location = new System.Drawing.Point(23, 628);
            this.lblExpiry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpiry.Name = "lblExpiry";
            this.lblExpiry.Size = new System.Drawing.Size(127, 17);
            this.lblExpiry.TabIndex = 16;
            this.lblExpiry.Text = "تاريخ انتهاء الصلاحية:";
            // 
            // dtpExpiry
            // 
            this.dtpExpiry.Location = new System.Drawing.Point(140, 624);
            this.dtpExpiry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpExpiry.Name = "dtpExpiry";
            this.dtpExpiry.Size = new System.Drawing.Size(174, 24);
            this.dtpExpiry.TabIndex = 17;
            // 
            // MedicineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 689);
            this.Controls.Add(this.dtpExpiry);
            this.Controls.Add(this.lblExpiry);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.txtScientificName);
            this.Controls.Add(this.lblScientific);
            this.Controls.Add(this.txtTradeName);
            this.Controls.Add(this.lblTrade);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvMedicines);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MedicineForm";
            this.Text = "إدارة الأدوية";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MedicineForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dgvMedicines;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblTrade;
        private System.Windows.Forms.TextBox txtTradeName;
        private System.Windows.Forms.Label lblScientific;
        private System.Windows.Forms.TextBox txtScientificName;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label lblExpiry;
        private System.Windows.Forms.DateTimePicker dtpExpiry;
    }
}