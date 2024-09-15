using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageToolApp
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=BDSQL.db;";
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT * FROM tool"; 
                var adapter = new SQLiteDataAdapter(query, connection);
                var dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void AddTool(string inventoryNumber, string shortName, string fullName, int professionalLevel, int wearPercentage, int quantity)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var query = "INSERT INTO tool (inventory_number, short_name, full_name, professional_level, wear_percentage, quantity) " +
                            "VALUES (@inventoryNumber, @shortName, @fullName, @professionalLevel, @wearPercentage, @quantity)";
                using (var command = new SQLiteCommand(query, connection))
                {
                    // Параметризованный запрос
                    command.Parameters.AddWithValue("@inventoryNumber", inventoryNumber);
                    command.Parameters.AddWithValue("@shortName", shortName);
                    command.Parameters.AddWithValue("@fullName", fullName);
                    command.Parameters.AddWithValue("@professionalLevel", professionalLevel);
                    command.Parameters.AddWithValue("@wearPercentage", wearPercentage);
                    command.Parameters.AddWithValue("@quantity", quantity);

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Инструмент успешно добавлен.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка добавления инструмента: " + ex.Message);
                    }
                }
            }
            // Обновляем таблицу с данными
            LoadData();
        }

        private void UpdateTool(int toolId, string inventoryNumber, string shortName, string fullName, int professionalLevel, int wearPercentage, int quantity)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var query = "UPDATE tool SET inventory_number = @inventoryNumber, short_name = @shortName, full_name = @fullName, professional_level = @professionalLevel, wear_percentage = @wearPercentage, quantity = @quantity WHERE tool_id = @toolId";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@toolId", toolId);
                    command.Parameters.AddWithValue("@inventoryNumber", inventoryNumber);
                    command.Parameters.AddWithValue("@shortName", shortName);
                    command.Parameters.AddWithValue("@fullName", fullName);
                    command.Parameters.AddWithValue("@professionalLevel", professionalLevel);
                    command.Parameters.AddWithValue("@wearPercentage", wearPercentage);
                    command.Parameters.AddWithValue("@quantity", quantity);
                    command.ExecuteNonQuery();
                }
            }
            LoadData();
        }

        private void DeleteTool(int toolId)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var query = "DELETE FROM tool WHERE tool_id = @toolId";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@toolId", toolId);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Инструмент удален.");
                    }
                    else
                    {
                        MessageBox.Show("Инструмент не найден.");
                    }
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Собираем данные из текстовых полей
            string inventoryNumber = txtInventoryNumber.Text;
            string shortName = txtShortName.Text;
            string fullName = txtFullName.Text;
            int professionalLevel;
            int wearPercentage;
            int quantity;

            // Проверяем, корректны ли введенные данные
            if (string.IsNullOrWhiteSpace(inventoryNumber) ||
                string.IsNullOrWhiteSpace(shortName) ||
                string.IsNullOrWhiteSpace(fullName) ||
                !int.TryParse(txtProfessionalLevel.Text, out professionalLevel) ||
                !int.TryParse(txtWearPercentage.Text, out wearPercentage) ||
                !int.TryParse(txtQuantity.Text, out quantity))
            {
                MessageBox.Show("Заполните все данные.");
                return;
            }

            // Добавляем инструмент в базу данных
            AddTool(inventoryNumber, shortName, fullName, professionalLevel, wearPercentage, quantity);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateTool(1, "INV-001", "Updated Hammer", "Updated Professional Hammer", 2, 20, 60);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var toolId = Convert.ToInt32(selectedRow.Cells["tool_id"].Value);

                DeleteTool(toolId);
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления.");
            }
        }
    }
}
