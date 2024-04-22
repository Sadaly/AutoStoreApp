using System;
using System.Windows.Forms;

namespace AutoStoreApp
{
    public partial class DialogueForm : Form
    {

        public static DataGridView refdata;
        static public bool YesOrNo = false;
        public DialogueForm(ref DataGridView dataGrid_Users)
        {
            refdata = dataGrid_Users;
            InitializeComponent();
        }

        private void button_Yes_Click(object sender, EventArgs e)
        {
            var valForm = new ValueForm(ref refdata);
            valForm.Show();
            this.Close();
        }

        private void button_No_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
