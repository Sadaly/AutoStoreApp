using System.Collections.Generic;

namespace AutoStoreApp
{
    internal class Globals
    {
        public static List<User> users = new List<User>()
            {
                new User("Worker01", "qwerty", Role.Worker, "Генадий", 10, 20000000, 30000),
                new User("Worker02", "qwerty", Role.Worker, "Екатерина", 15, 1000000, 50000),
                new User("Worker03", "qwerty", Role.Worker, "Евгений", 10, 30000000, 30000),
                new User("Worker04", "qwerty", Role.Worker, "Олег", 2, 200000, 40000),
                new User("Worker05", "qwerty", Role.Worker, "Александра", 0, 0, 20000),
                new User("Worker06", "qwerty", Role.Worker, "Анастасия", 5, 1200000, 20000),
                new User("Admin01", "admin", Role.Admin, "Михаил"),
                new User("Manager01", "manager", Role.Manager, "Наталья")
            };

        public static List<Car> cars = new List<Car>()
            {
                new Car("Mitsubishi", "Outlander", 1000000, 6),
                new Car("Mitsubishi", "A385", 20000000, 1),
                new Car("Mitsubishi", "V800", 3000000, 2),
                new Car("Audi", "A5", 7000000, 6),
                new Car("Audi", "Q3", 1000000, 3),
                new Car("Audi", "Q8", 2000000, 4),
                new Car("Audi", "A6", 200000, 1),
            };

        public static int currentUserID = -1;
        public static int GetUserNumByID(int id)
        {
            return users.FindIndex(user_t => user_t.GetId() == id);
        }
        public static void CloseApp()
        {
            if (currentUserID > -1)
                users[currentUserID].LoggedOut();
            System.Windows.Forms.Application.Exit();
        }
    }
}
