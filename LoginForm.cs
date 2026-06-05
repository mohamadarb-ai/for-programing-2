using System;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class LoginForm : BaseForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "mohamad" && txtPassword.Text == "0000")
            {
                ShowMessage("تم تسجيل الدخول بنجاح!", "نجاح", MessageBoxIcon.Information);
                this.Hide();
                new MainForm().Show();
            }
            else
            {
                ShowMessage("اسم المستخدم أو كلمة المرور غير صحيحة", "خطأ", MessageBoxIcon.Error);
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}