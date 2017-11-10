using System;
using System.Windows.Forms;

namespace EnglishTrainerApp
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            // Не удалось зарег.
            try
            {
                var name = textBox_nameInput.Text;
                var userId = Data.userService.Registrate(name);
                PersonalAccount personalAccount = new PersonalAccount(userId, name);
                personalAccount.Owner = this;
                personalAccount.Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
