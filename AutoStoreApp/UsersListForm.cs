using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AutoStoreApp
{
    public partial class UsersListForm : Form
    {
        
        public UsersListForm()
        {
            InitializeComponent();

            dataGrid_Users.Columns.Add("ID", "ID");
            dataGrid_Users.Columns.Add("Name", "Имя");
            dataGrid_Users.Columns.Add("Role", "Роль");
            dataGrid_Users.Columns.Add("Login", "Логин");
            dataGrid_Users.Columns.Add("Password", "Пароль");

            foreach (var user in Globals.users)
            {
                dataGrid_Users.Rows.Add(user.GetId(), user.name, user.GetRoleText(), user.GetLogin(), user.GetPassword());
            }
        }


        private void button_prevForm_Click(object sender, EventArgs e)
        {
            this.Hide();

            var mainForm = new MainForm();
            mainForm.Show();
        }

        private void button_addUser_Click(object sender, EventArgs e)
        {
            var newUserForm = new NewUserForm(ref dataGrid_Users);
            newUserForm.Show();
        }

        private void button_deleteUser_Click(object sender, EventArgs e)
        {
            var dilg = new DialogueForm(ref dataGrid_Users);
            dilg.Show();
        }        

        private void UsersListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Globals.CloseApp();
        }
    }
}
