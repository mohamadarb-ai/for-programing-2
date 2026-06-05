namespace PharmacyManagementSystem
{
    partial class ExpiredForm
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
            this.dgvExpired = new System.Windows.Forms.DataGridView();
            this.btnDestroy = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpired)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvExpired
            // 
            this.dgvExpired.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpired.Location = new System.Drawing.Point(23, 25);
            this.dgvExpired.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvExpired.Name = "dgvExpired";
            this.dgvExpired.RowHeadersWidth = 51;
            this.dgvExpired.Size = new System.Drawing.Size(700, 345);
            this.dgvExpired.TabIndex = 0;
            // 
            // btnDestroy
            // 
            this.btnDestroy.Location = new System.Drawing.Point(233, 394);
            this.btnDestroy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDestroy.Name = "btnDestroy";
            this.btnDestroy.Size = new System.Drawing.Size(233, 43);
            this.btnDestroy.TabIndex = 1;
            this.btnDestroy.Text = "حذف الأدوية منتهية الصلاحية";
            this.btnDestroy.UseVisualStyleBackColor = true;
            this.btnDestroy.Click += new System.EventHandler(this.btnDestroy_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(233, 455);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(233, 43);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "رجوع";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ExpiredForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 529);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDestroy);
            this.Controls.Add(this.dgvExpired);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ExpiredForm";
            this.Text = "الأدوية منتهية الصلاحية";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExpiredForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpired)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridView dgvExpired;
        private System.Windows.Forms.Button btnDestroy;
        private System.Windows.Forms.Button btnBack;
    }
}