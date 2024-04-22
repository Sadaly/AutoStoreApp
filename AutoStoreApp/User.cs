using System.Windows.Forms;

namespace AutoStoreApp
{
    internal class User
    {
        static private int ID = 0; 
        private readonly string login;
        private readonly string password;
        private readonly Role role;

        private readonly int id = ID++;
        public readonly string name;
        private bool isLogged = false;
        private SellerStatistics sellerStatistics = null;

        public User(string login, string password, Role role, string name, int soldCars = 0, int incomeAmount = 0, int salary = 20000)
        {
            this.login = login;
            this.password = password;
            this.role = role;
            this.name = name;

            if (role == Role.Worker)
            {
                sellerStatistics = new SellerStatistics(soldCars, incomeAmount, salary);
            }
        }

        public Role GetRole()
        {
            return role;
        }
        public string GetRoleText()
        {
            switch (this.role)
            {
                case Role.Admin:
                    return "Администаратор";
                case Role.Worker:
                    return "Сотрудник";
                case Role.Manager:
                    return "Управляющий";
                default:
                    return "Exepc";
            }
        }
        public string GetLogin()
        {
            return login;
        }
        public string GetPassword()
        {
            return password;
        }
        public int GetId()
        {
            return id;
        }
        public void Logged() 
        { 
            isLogged = true;
            MessageBox.Show($"{name}, здраствуйте!");
        }
        public void LoggedOut()
        {
            Globals.currentUserID = -1;
            isLogged = false;
        }
        public bool IsLogged()
        {
            return isLogged;
        }
        public SellerStatistics GetSellerStatistics()
        {
            return sellerStatistics;
        }
    }
}
