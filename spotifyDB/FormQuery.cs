using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace spotifyDB
{
    public partial class FormQuery : Form
    {
        public FormQuery()
        {
            InitializeComponent();

        }

        private string connString = "Server=localhost; Port=5432; Username=postgres; Password=1234; Database=spotify;";
        private NpgsqlConnection conn;
        private void button1_Click(object sender, EventArgs e)
        {
            string query = queryBox.Text;
            DataTable queryResult = ExecuteQuery(query);
            dataGridView1.DataSource = queryResult;



        }

        private void queryBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void QueryForm_Load(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private DataTable ExecuteQuery(string query)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {


                conn.Open();

                using (NpgsqlCommand command = new NpgsqlCommand(query, conn))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User user = new User();
            this.Hide();
            user.Show();
        }
    }
}

