using Npgsql;
using System.Data;
using System.Linq.Expressions;

namespace spotifyDB
{
    public partial class FormPremiumMembership : Form
    {
        public FormPremiumMembership()
        {
            InitializeComponent();
        }

        private string connString = "Server=localhost; Port=5432; Username=postgres; Password=1234; Database=spotify;";
        private NpgsqlConnection conn;

        private void FormPremiumMembership_Load(object sender, EventArgs e)
        {
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            DateTime date1 = dateTimePicker1.Value;
            DateTime date2 = dateTimePicker1.Value;

            string insert = "INSERT INTO tblpremiummembership (startdate,enddate) VALUES" +
                            " (@date1,@date2)";

            using (NpgsqlCommand cmd = new NpgsqlCommand(insert, conn))
            {

                cmd.Parameters.AddWithValue("@date1", date1);
                cmd.Parameters.AddWithValue("@date2", date2);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Premium membership data inserted successfully!");
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn == null)
                {
                    conn = new NpgsqlConnection(connString);
                }

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    // MessageBox.Show("Connected");
                }
                else
                {
                    // MessageBox.Show("Connection is already open.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void disconnectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    //  MessageBox.Show("Disconnected");
                }
                else
                {
                    // MessageBox.Show("Connection is already closed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

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