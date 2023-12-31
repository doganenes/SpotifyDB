using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spotifyDB
{
    public partial class playlist : Form
    {
        public playlist()
        {
            InitializeComponent();
        }

        private void userForm_Click(object sender, EventArgs e)
        {
            User userform = new User();
            userform.Show();
            this.Close();

        }

        private void playlist_Load(object sender, EventArgs e)
        {

        }
    }
}
