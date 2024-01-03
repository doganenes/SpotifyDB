using Npgsql;
using System.Data;
using System.Linq.Expressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace spotifyDB
{
    public partial class FormSong : Form
    {
        public FormSong()
        {
            InitializeComponent();
        }

        private string connString = "Server=localhost; Port=5432; Username=postgres; Password=mitaka; Database=spotify;";
        private NpgsqlConnection conn;


        private void addBtn_Click(object sender, EventArgs e)
        {
            string songname = songName.Text;
            string singerDB = singer.Text;
            DateTime date = dateTimePicker1.Value;
            string songtype = songType.Text;
            int restcount = Int32.Parse(restCount.Text);

            string insert = "INSERT INTO tblsong (songname, singer,  songtype, restcount,releaseyear) VALUES" +
                            " (@songname, @singerDB, @songtype, @restcount, @date)";

            using (NpgsqlCommand cmd = new NpgsqlCommand(insert, conn))
            {
                cmd.Parameters.AddWithValue("@songname", songname);
                cmd.Parameters.AddWithValue("@singerDB", singerDB);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@songtype", songtype);
                cmd.Parameters.AddWithValue("@restcount", restcount);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Song data inserted successfully!");
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
