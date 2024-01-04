using Npgsql;
using System.Data;
using System.Linq.Expressions;

namespace spotifyDB
{
    public partial class FormSessionHistory : Form
    {
        public FormSessionHistory()
        {
            InitializeComponent();
        }

        private string connString = "Server=localhost; Port=5432; Username=postgres; Password=1234; Database=spotify;";
        private NpgsqlConnection conn;

        private void addBtn_Click(object sender, EventArgs e)
        {
            int user = Convert.ToInt32(userID.Text);
            string operationstatus = operationStatus.Text;
            DateTime date = dateTimePicker1.Value;

            string insert = "INSERT INTO tblsessionhistory (sessiondate, operationstatus,sessionuserid) VALUES" +
                            " (@date, @operationstatus,@user)";

            using (NpgsqlCommand cmd = new NpgsqlCommand(insert, conn))
            {
                cmd.Parameters.AddWithValue("@operationstatus", operationstatus);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@user", user);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Session history data inserted successfully!");
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
                    MessageBox.Show("Connected");
                }
                else
                {
                    MessageBox.Show("Connection is already open.");
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
                    MessageBox.Show("Disconnected");
                }
                else
                {
                    MessageBox.Show("Connection is already closed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User();
            this.Hide();
            user.Show();
        }

        private void userID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
