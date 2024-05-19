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
    public partial class ShiftsForm : Form
    {
        private DatabaseManager databaseManager;
        System.Data.DataTable dataTable;

        private void LoadComboBoxData()
        {
            string queryUserTypes = "SELECT DISTINCT WaiterID FROM Shifts";
            MySqlCommand cmdUserTypes = new MySqlCommand(queryUserTypes, databaseManager.GetConnection());
            using (MySqlDataReader reader = cmdUserTypes.ExecuteReader())
            {
                while (reader.Read())
                {
                    WaiterComboBox.Items.Add(reader.GetInt32("WaiterID").ToString());
                }
            }

            string queryUserStatuses = "SELECT DISTINCT ChefID FROM Shifts";
            MySqlCommand cmdUserStatuses = new MySqlCommand(queryUserStatuses, databaseManager.GetConnection());
            using (MySqlDataReader reader = cmdUserStatuses.ExecuteReader())
            {
                while (reader.Read())
                {
                    ChefComboBox.Items.Add(reader.GetInt32("ChefID").ToString());
                }
            }
        }
        public ShiftsForm()
        {
            InitializeComponent();
            databaseManager = new DatabaseManager();
            LoadComboBoxData();
        }

        private void AddShiftsButton_Click(object sender, EventArgs e)
        {
            string shiftdate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string desc = DescriptionTextBox.Text;
            string wait = WaiterComboBox.SelectedItem.ToString();
            string chef = ChefComboBox.SelectedItem.ToString();

            string query = "INSERT INTO Shifts (ShiftDate, ShiftDescription, WaiterID, ChefID) VALUES (@shiftdate, @desc, @wait, @chef)";
            MySqlCommand cmd = new MySqlCommand(query, databaseManager.GetConnection());

            cmd.Parameters.AddWithValue("@shiftdate", shiftdate);
            cmd.Parameters.AddWithValue("@desc", desc);
            cmd.Parameters.AddWithValue("@wait", wait);
            cmd.Parameters.AddWithValue("@chef", chef);

            cmd.ExecuteNonQuery();

            LoadShiftData();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        void SetWaiterID(int id, string fired)
        {
            MySqlCommand cmd = new MySqlCommand($"UPDATE users SET UserStatus='{fired}' WHERE UserID={id};", databaseManager.GetConnection());
            cmd.ExecuteNonQuery();
        }
        private void LoadShiftData()
        {
            dataGridView1.DataSource = null;
            string query = "SELECT * FROM shifts";
            MySqlCommand cmd = new MySqlCommand(query, databaseManager.GetConnection());

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
            dataTable = new System.Data.DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            SetWaiterID(Convert.ToInt32(dataTable.Rows[i]["ShiftID"]), Convert.ToString(dataTable.Rows[i]["WaiterID"]));
            LoadShiftData();
        }

        private void ShiftsForm_Load(object sender, EventArgs e)
        {
            LoadShiftData();
        }
    }
}
