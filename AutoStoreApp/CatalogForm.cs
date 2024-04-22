using System;
using System.Windows.Forms;

namespace AutoStoreApp
{
    public partial class CatalogForm : Form
    {
        int price = 0;
        bool carIsAdded = false;
        public CatalogForm()
        {
            InitializeComponent();

            dataGrid_Users.Columns.Add("ID", "ID");
            dataGrid_Users.Columns.Add("Mark", "Марка");
            dataGrid_Users.Columns.Add("Model", "Модель");
            dataGrid_Users.Columns.Add("Price", "Стоимость");
            dataGrid_Users.Columns.Add("Amount", "Количество");

            foreach (var car in Globals.cars)
            {
                dataGrid_Users.Rows.Add(car.id, car.GetMark(), car.GetModel(), car.GetPrice(), car.GetAmount());
            }
        }

        private void CatalogForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Globals.CloseApp();
        }

        private void button_prevForm_Click(object sender, System.EventArgs e)
        {
            var mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }


        private void button_add_Click(object sender, System.EventArgs e)
        {
            if (!carIsAdded)
            {
                if (textBox1.Text != "")
                {
                    price = Convert.ToInt32(label2.Text);
                    int id = Convert.ToInt32(textBox1.Text);
                    if (id > -1)
                    {
                        var carIndexList = Globals.cars.FindIndex(car_t => car_t.id == id);
                        if (Globals.cars[carIndexList].GetAmount() > 0)
                        {
                            foreach (var item in checkedListBox1.CheckedItems)
                            {
                                price += 20000;
                            }

                            price += Globals.cars[carIndexList].GetPrice();
                            Globals.cars[carIndexList].SetAmount(Globals.cars[carIndexList].GetAmount() - 1);
                            

                            RefreshForm();
                            carIsAdded = true;
                        }
                        else
                        {
                            MessageBox.Show("Автомобиля нет на складе");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неверный ID автомобиля");
                    }
                }
                else
                {
                    MessageBox.Show("Неверный формат ввода ID");
                }
            }
            else
            {
                MessageBox.Show("Вы не можете добавить больше одного автомобиля");
            }
        }

        private void button_payment_Click(object sender, EventArgs e)
        {
            if (!carIsAdded)
            {
                MessageBox.Show("Сначала выберите атомобиль");
                return;
            }
            MessageBox.Show("Отсутствует модуль оплаты, будет считаться, что машина была продана этим работником");

            int soldCars = Globals.users[Globals.currentUserID].GetSellerStatistics().GetSoldCars() + 1;
            Globals.users[Globals.currentUserID].GetSellerStatistics().SetSoldCars(soldCars);

            int income = Globals.users[Globals.currentUserID].GetSellerStatistics().GetIncome() + price;
            Globals.users[Globals.currentUserID].GetSellerStatistics().SetIncome(income);

            price = 0;
            RefreshForm();

            dataGrid_Users.Rows.Clear();

            foreach (var car in Globals.cars)
            {
                dataGrid_Users.Rows.Add(car.id, car.GetMark(), car.GetModel(), car.GetPrice(), car.GetAmount());
            }
            carIsAdded = false;
        }

        void RefreshForm()
        {
            label2.Text = (price).ToString();
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
            textBox1.Text = "";
            carIsAdded = false;
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            price = 0;
            RefreshForm();
        }
    }
}
