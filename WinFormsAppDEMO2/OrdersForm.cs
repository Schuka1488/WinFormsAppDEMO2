using MySql.Data.MySqlClient;
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
    public partial class OrdersForm : Form
    {
        private DatabaseManager databaseManager;
        System.Data.DataTable dataTable;

        private void LoadComboBoxData()
        {
            string queryUserTypes = "SELECT DISTINCT WaiterID FROM Orders";
            MySqlCommand cmdUserTypes = new MySqlCommand(queryUserTypes, databaseManager.GetConnection());
            using (MySqlDataReader reader = cmdUserTypes.ExecuteReader())
            {
                while (reader.Read())
                {
                    WaiterComboBox.Items.Add(reader.GetInt32("WaiterID").ToString());
                }
            }

            string queryUserStatuses = "SELECT DISTINCT Status FROM Orders";
            MySqlCommand cmdUserStatuses = new MySqlCommand(queryUserStatuses, databaseManager.GetConnection());
            using (MySqlDataReader reader = cmdUserStatuses.ExecuteReader())
            {
                while (reader.Read())
                {
                    StatusComboBox.Items.Add(reader.GetString("Status"));
                }
            }
        }
        public OrdersForm()
        {
            InitializeComponent();
            databaseManager = new DatabaseManager();
            LoadComboBoxData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        void SetWaiterID(int id, string fired)
        {
            MySqlCommand cmd = new MySqlCommand($"UPDATE orders SET Status='{fired}' WHERE OrderID={id};", databaseManager.GetConnection());
            cmd.ExecuteNonQuery();
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            SetWaiterID(Convert.ToInt32(dataTable.Rows[i]["OrderID"]), Convert.ToString(dataTable.Rows[i]["Status"]));
            LoadOrderData();
        }
        private void LoadOrderData()
        {
            dataGridView1.DataSource = null;
            string query = "SELECT * FROM orders";
            MySqlCommand cmd = new MySqlCommand(query, databaseManager.GetConnection());
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
            dataTable = new System.Data.DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            DataGridViewComboBoxColumn status = new DataGridViewComboBoxColumn();
            var list = new List<string>() { "Принят", "Оплачен", "Готовится", "Готов" };
            status.DataSource = list;
            status.HeaderText = "Статус";
            status.DataPropertyName = "Status";

            dataGridView1.DataSource = dataTable;

            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;

            dataGridView1.Columns.AddRange(status);

        }
        private void AddOrdersButton_Click(object sender, EventArgs e)
        {
            string datetime = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string table = TableTextBox.Text;
            string count = CountTextBox.Text;
            string wait = WaiterComboBox.SelectedItem.ToString();
            string status = StatusComboBox.SelectedItem.ToString();

            string query = "INSERT INTO Orders (OrderDate,TableNumber, CustomerCount, WaiterID, Status) VALUES (@datetime, @table, @count, @wait, @status)";
            MySqlCommand cmd = new MySqlCommand(query, databaseManager.GetConnection());

            cmd.Parameters.AddWithValue("@datetime", datetime);
            cmd.Parameters.AddWithValue("@table", table);
            cmd.Parameters.AddWithValue("@count", count);
            cmd.Parameters.AddWithValue("@wait", wait);
            cmd.Parameters.AddWithValue("@status", status);

            cmd.ExecuteNonQuery();

            LoadOrderData();
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            LoadOrderData();
        }
    }
}
