using Npgsql;
using System.Data;
using System.Linq.Expressions;

namespace spotifyDB
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }
        private string connString = "Server=localhost; Port=5432; Username=postgres; Password=mitaka; Database=spotify;";
        private NpgsqlConnection conn;


        private void addBtn_Click(object sender, EventArgs e)
        {
            string username = userName.Text;
            string pass = password.Text;
            string usermail = email.Text;
            DateTime date = DateTime.Now;



            string insert = "INSERT INTO tbluser (username, password, email, creationdate) VALUES" +
                            " (@username, @pass, @usermail, @date)";

            using (NpgsqlCommand cmd = new NpgsqlCommand(insert, conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@pass", pass);
                cmd.Parameters.AddWithValue("@usermail", usermail);
                cmd.Parameters.AddWithValue("@date", date);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("User data inserted successfully!");
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {


        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnPlayList_Click(object sender, EventArgs e)
        {
            FormPlaylist playlist = new FormPlaylist();
            this.Hide();
            playlist.Show();
        }

        private void User_Load(object sender, EventArgs e)
        {

        }

        private void queryBtn_Click(object sender, EventArgs e)
        {
            FormQuery q = new FormQuery();
            this.Hide();
            q.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormSearchHistory searchHistory = new FormSearchHistory();
            this.Hide();
            searchHistory.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormComment comment = new FormComment();
            this.Hide();
            comment.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormDevices devices = new FormDevices();
            this.Hide();
            devices.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormFavouriteSong favouriteSong = new FormFavouriteSong();
            this.Hide();
            favouriteSong.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormFollowedUser followedUser = new FormFollowedUser();
            this.Hide();
            followedUser.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormPremiumMembership formPremiumMembership = new FormPremiumMembership();
            this.Hide();
            formPremiumMembership.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormSong formSong = new FormSong();
            this.Hide();
            formSong.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormSessionHistory sessionHistory = new FormSessionHistory();
            this.Hide();
            sessionHistory.Show();
        }
    }
}