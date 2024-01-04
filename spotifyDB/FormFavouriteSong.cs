using Npgsql;
using System.Data;
using System.Linq.Expressions;

namespace spotifyDB
{
    public partial class FormFavouriteSong : Form
    {
        public FormFavouriteSong()
        {
            InitializeComponent();
        }

        private string connString = "Server=localhost; Port=5432; Username=postgres; Password=1234; Database=spotify;";
        private NpgsqlConnection conn;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormFavouriteSong_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value;
            int favouriteSong = Convert.ToInt32(songID.Text);
            int userSong = Convert.ToInt32(userID.Text);

            string insert = "INSERT INTO tblfavouritesong (favouritesongid, likedate, favouritesonguserid) VALUES" +
                            " (@favouritesong, @date, @userSong)";

            using (NpgsqlCommand cmd = new NpgsqlCommand(insert, conn))
            {
                cmd.Parameters.AddWithValue("@favouriteSong", favouriteSong);
                cmd.Parameters.AddWithValue("@date", date);
                ; cmd.Parameters.AddWithValue("@userSong", userSong);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Favourite song data inserted successfully!");
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            User user = new User();
            this.Hide();
            user.Show();
        }

        private void songID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
