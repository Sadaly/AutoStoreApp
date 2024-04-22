using System;
using System.Windows.Forms;

namespace AutoStoreApp
{
    internal partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button_LoadMainForm_Click(object sender, EventArgs e)
        {
            LoadMainForm();
        }

        public void LoadMainForm()
        {
            Globals.currentUserID = Globals.users.FindIndex(user_t => user_t.GetLogin() == textBox_Login.Text);
            if (Globals.currentUserID > -1 && Globals.users[Globals.currentUserID].GetPassword() == textBox_Password.Text)
            {
                Globals.users[Globals.currentUserID].Logged();
                var mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Globals.CloseApp();
        }
    }
}
