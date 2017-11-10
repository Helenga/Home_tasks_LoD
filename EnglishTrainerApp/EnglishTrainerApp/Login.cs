using System;
using System.Windows.Forms;

namespace EnglishTrainerApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Owner = this;
            registerForm.Show();
            Hide();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            // юзер не найден
            try
            {
                var name = textBox_NameInput.Text;
                var userId = Data.userService.Login(name);
                PersonalAccount personalAccount = new PersonalAccount(userId, name);
                personalAccount.Owner = this;
                personalAccount.Show();
                Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
