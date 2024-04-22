using System;
using System.Windows.Forms;

namespace AutoStoreApp
{
    public partial class RatingForm : Form
    {
        public RatingForm()
        {
            
            InitializeComponent();

            var workersList = Globals.users.FindAll(user_t => user_t.GetRole() == Role.Worker);

            dataGrid_Users.Columns.Add("ID", "ID");
            dataGrid_Users.Columns.Add("Name", "Имя");
            dataGrid_Users.Columns.Add("Income", "Доход");
            dataGrid_Users.Columns.Add("SoldCars", "Продано машин");
            dataGrid_Users.Columns.Add("Salary", "Зарплата");
            dataGrid_Users.Columns.Add("Profit", "Рентабельность работник");

            foreach (var user in workersList)
            {
                var income = user.GetSellerStatistics().GetIncome();
                var salary = user.GetSellerStatistics().GetSalary();
                double temp = (double)income / salary / 100;
                dataGrid_Users.Rows.Add(user.GetId(), user.name, income, user.GetSellerStatistics().GetSoldCars(), salary, Math.Round(temp, 3).ToString());
            }
        }

        private void button_prevForm_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void RatingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Globals.CloseApp();
        }
    }
}
