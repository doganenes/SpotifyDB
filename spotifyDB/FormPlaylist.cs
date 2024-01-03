using Npgsql;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace spotifyDB
{
    public partial class FormPlaylist : Form
    {
        public FormPlaylist()
        {
            InitializeComponent();
        }

        private string connString = "Server=localhost; Port=5432; Username=postgres; Password=1234; Database=spotify;";
        private NpgsqlConnection conn;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string playlistname = playlistName.Text;
            DateTime date = dateTimePicker1.Value;
            string insert = "INSERT INTO tblplaylist (playlistname, creationdate) VALUES" +
            " (@playlistname, @date)";


            using (NpgsqlCommand cmd = new NpgsqlCommand(insert, conn))
            {
                cmd.Parameters.AddWithValue("@playlistname", playlistname);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Playlist data inserted successfully!");
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

        private void button2_Click(object sender, EventArgs e)
        {
            User user = new User();
            this.Hide();
            user.Show();
        }
    }
}