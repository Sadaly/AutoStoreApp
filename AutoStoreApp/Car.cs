namespace AutoStoreApp
{
    internal class Car
    {
        private readonly string mark;
        private readonly string model;
        private int price;
        private int amount;
        public readonly int id;
        private static int ID = 0;
        public Car(string mark, string model, int price, int amount)
        {
            this.mark = mark;
            this.model = model;
            this.price = price;
            this.amount = amount;
            id = ID++;
        }
        public string GetModel() 
        {   
            return model;
        }

        public string GetMark()
        {
            return mark;
        }
        public int GetPrice()
        {
            return price;
        }
        public void SetPrice(int price)
        {
            this.price = price;
        }
        public int GetAmount() { return amount; }
        public void SetAmount(int amount) {  this.amount = amount; }
    }
}
