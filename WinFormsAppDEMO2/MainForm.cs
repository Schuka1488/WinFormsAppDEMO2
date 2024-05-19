using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppDEMO2
{
    public partial class MainForm : Form
    {
        public MainForm(string userType)
        {
            InitializeComponent();

            if (userType != "Administrator")
            {
                UsersButton.Visible = false;
                ShiftsButton.Visible = false;
            }

        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm();
            usersForm.Show();
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            OrdersForm ordersForm = new OrdersForm();
            ordersForm.Show();
        }

        private void ShiftsButton_Click(object sender, EventArgs e)
        {
            ShiftsForm shiftsForm = new ShiftsForm();
            shiftsForm.Show();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
