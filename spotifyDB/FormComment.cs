using Npgsql;
using System.Data;
using System.Linq.Expressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace spotifyDB
{
    public partial class FormComment : Form
    {
        public FormComment()
        {
            InitializeComponent();
        }

        private string connString = "Server=localhost; Port=5432; Username=postgres; Password=1234; Database=spotify;";
        private NpgsqlConnection conn;

        private void button1_Click(object sender, EventArgs e)
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

        private void FormComment_Load(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string commenttext = commentText.Text;
            DateTime date = dateTimePicker1.Value;

            string insert = "INSERT INTO tblcomment (commenttext, commentdate) VALUES" +
                            " (@commenttext, @date)";


            using (NpgsqlCommand cmd = new NpgsqlCommand(insert, conn))
            {
                cmd.Parameters.AddWithValue("@commenttext", commenttext);
                cmd.Parameters.AddWithValue("@date", date);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Comment data inserted successfully!");
        }

        private void disconnectionBtn_Click(object sender, EventArgs e)
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
    }
}
