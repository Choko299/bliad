using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LaptopManager
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=CHOKO\\SQLEXPRESS;Initial Catalog=LaptopDB;Integrated Security=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadLaptops();
        }

        private void LoadLaptops()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Laptops";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Laptops (Brand, Model, CPU, RAM, Storage, Price) VALUES (@Brand, @Model, @CPU, @RAM, @Storage, @Price)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Brand", txtBrand.Text);
                    cmd.Parameters.AddWithValue("@Model", txtModel.Text);
                    cmd.Parameters.AddWithValue("@CPU", txtCPU.Text);
                    cmd.Parameters.AddWithValue("@RAM", int.Parse(txtRAM.Text));
                    cmd.Parameters.AddWithValue("@Storage", int.Parse(txtStorage.Text));
                    cmd.Parameters.AddWithValue("@Price", decimal.Parse(txtPrice.Text));

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("მონაცემი დაემატა წარმატებით!");
                            ClearInputs();
                            LoadLaptops();
                        }
                        else
                        {
                            MessageBox.Show("ჩანაწერი არ დაემატა.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("შეცდომა: " + ex.Message);
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Laptops WHERE Id = @Id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                LoadLaptops();
            }
            else
            {
                MessageBox.Show("აირჩიე წასაშლელი ჩანაწერი ცხრილიდან.");
            }
        }

        private void ClearInputs()
        {
            txtBrand.Text = "";
            txtModel.Text = "";
            txtCPU.Text = "";
            txtRAM.Text = "";
            txtStorage.Text = "";
            txtPrice.Text = "";
        }
    }
}
