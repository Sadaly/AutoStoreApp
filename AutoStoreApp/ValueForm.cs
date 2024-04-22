using System;
using System.Windows.Forms;

namespace AutoStoreApp
{
    public partial class ValueForm : Form
    {
        public static int SelectedID;
        public static DataGridView refdata;
        public ValueForm(ref DataGridView dataGrid_Users)
        {
            refdata = dataGrid_Users;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            SelectedID = Convert.ToInt32(textBox1.Text);

            if (Globals.currentUserID == SelectedID)
            {
                MessageBox.Show("Вы не можете удалить себя из системы");
            }
            else
            {
                var num = Globals.GetUserNumByID(ValueForm.SelectedID);
                refdata.Rows.RemoveAt(num);
                Globals.users.RemoveAt(num);

                if (SelectedID < Globals.currentUserID)
                    Globals.currentUserID--;
            }
            this.Close();
        }
    }
}
