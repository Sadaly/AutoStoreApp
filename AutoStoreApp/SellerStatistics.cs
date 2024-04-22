namespace AutoStoreApp
{
    internal class SellerStatistics
    {
        private int soldCars;
        private int incomeAmount;
        private int salary;

        public SellerStatistics() { }
        public SellerStatistics(int soldCars, int incomeAmount, int salary)
        {
            this.salary = salary;
            this.soldCars = soldCars;
            this.incomeAmount = incomeAmount;
        }
        public int GetSoldCars() { return soldCars; }
        public int GetSalary() {  return salary; }
        public int GetIncome() {  return incomeAmount; }
        public void SetSalary(int salary) {  this.salary = salary; }
        public void SetIncome(int incomeAmount) { this.incomeAmount = incomeAmount; }
        public void SetSoldCars(int soldCars) { this.soldCars = soldCars; }

    }
}
