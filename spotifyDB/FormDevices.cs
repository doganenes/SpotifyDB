using Npgsql;
using System.Data;
using System.Linq.Expressions;

namespace spotifyDB
{
    public partial class FormDevices : Form
    {
        public FormDevices()
        {
            InitializeComponent();
        }

        private string connString = "Server=localhost; Port=5432; Username=postgres; Password=1234; Database=spotify;";
        private NpgsqlConnection conn;


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            int deviceuser = Convert.ToInt32(userID.Text);  
            string devicename = deviceName.Text;
            DateTime date1 = dateTimePicker1.Value;
            DateTime date2 = dateTimePicker2.Value;

            string insert = "INSERT INTO tbldevices (devicename, linkdate, lastplayeddate, deviceuserid) VALUES" +
                           " (@devicename, @date1, @date2,@deviceuser)";

            using (NpgsqlCommand cmd = new NpgsqlCommand(insert, conn))
            {
                cmd.Parameters.AddWithValue("@devicename", devicename);
                cmd.Parameters.AddWithValue("@date1", date1);
                cmd.Parameters.AddWithValue("@date2", date2);
                cmd.Parameters.AddWithValue("@deviceuser", deviceuser);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Devices data inserted successfully!");
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


        private void disconnectBtn_Click_1(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
