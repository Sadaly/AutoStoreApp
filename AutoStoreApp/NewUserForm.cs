using System.Windows.Forms;

namespace AutoStoreApp
{
    public partial class NewUserForm : Form
    {
        static public DataGridView refdata;
        public NewUserForm(ref DataGridView dataGrid_Users)
        {
            refdata = dataGrid_Users;
            InitializeComponent();
        }

        private void button_add_Click(object sender, System.EventArgs e)
        {
            if (textBox_name.Text != "" &&
                textBox_login.Text != "" &&
                Globals.users.FindIndex(user_t => user_t.GetLogin() == textBox_login.Text) == -1 &&
                maskedTextBox_password.Text == maskedTextBox_password2.Text &&
                comboBox_roles.Text != "")
            {
                Role role;
                switch (comboBox_roles.Text)
                {
                    case "Admin":
                            role = Role.Admin; break;
                    case "Manager":
                        role = Role.Manager; break;
                    case "Worker":
                        role = Role.Worker; break;
                    default:
                        role = Role.None; break;
                }

                Globals.users.Add(new User(textBox_login.Text, maskedTextBox_password.Text, role, textBox_name.Text));
                this.Close();
            }
            else
            {
                MessageBox.Show("Ошибка! Убедитесь, что все поля заполнены верно, а логин пользователя не совпадает с существующими.");
            }
        }
    }
}
