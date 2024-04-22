using System.Windows.Forms;

namespace AutoStoreApp
{
    internal partial class MainForm : Form
    {
        Role role = Globals.users[Globals.currentUserID].GetRole();
        public MainForm()
        {
            InitializeComponent();
            label_role.Text = $"Роль: {Globals.users[Globals.currentUserID].GetRoleText()}";
        }

        private void button_carList_Click(object sender, System.EventArgs e)
        {
            if (role == Role.Worker || role == Role.Admin)
            {
                this.Hide();

                var catalogForm = new CatalogForm();
                catalogForm.Show();
            }
            else
                MessageBox.Show("Нет доступа");
        }

        private void button_deleteUser_Click(object sender, System.EventArgs e)
        {
            if (role == Role.Admin)
            {
                this.Hide();

                var usersListForm = new UsersListForm();
                usersListForm.Show();
            }
            else
                MessageBox.Show("Нет доступа");
        }

        private void button_sellerRating_Click(object sender, System.EventArgs e)
        {
            if (role == Role.Manager || role == Role.Admin)
            {
                this.Hide();

                var ratingForm = new RatingForm();
                ratingForm.Show();
            }
            else
                MessageBox.Show("Нет доступа");
        }

            private void button_prevForm_Click(object sender, System.EventArgs e)
        {
            Globals.users[Globals.currentUserID].LoggedOut();
            var loginForm = new LoginForm();
            loginForm.Show();
            Globals.currentUserID = -1;
            this.Hide();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Globals.CloseApp();
        }
    }
}
