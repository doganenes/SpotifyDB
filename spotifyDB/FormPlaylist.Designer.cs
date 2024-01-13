namespace spotifyDB
{
    partial class FormPlaylist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            playlistName = new TextBox();
            connectBtn = new Button();
            disconnectBtn = new Button();
            label1 = new Label();
            addBtn = new Button();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            button2 = new Button();
            createdByUser = new TextBox();
            userID = new Label();
            SuspendLayout();
            // 
            // playlistName
            // 
            playlistName.Location = new Point(195, 100);
            playlistName.Name = "playlistName";
            playlistName.Size = new Size(251, 27);
            playlistName.TabIndex = 20;
            // 
            // connectBtn
            // 
            connectBtn.Location = new Point(548, 12);
            connectBtn.Name = "connectBtn";
            connectBtn.Size = new Size(118, 43);
            connectBtn.TabIndex = 17;
            connectBtn.Text = "Connect";
            connectBtn.UseVisualStyleBackColor = true;
            connectBtn.Click += connectBtn_Click;
            // 
            // disconnectBtn
            // 
            disconnectBtn.Location = new Point(672, 12);
            disconnectBtn.Name = "disconnectBtn";
            disconnectBtn.Size = new Size(118, 43);
            disconnectBtn.TabIndex = 16;
            disconnectBtn.Text = "Disconnect";
            disconnectBtn.UseVisualStyleBackColor = true;
            disconnectBtn.Click += disconnectBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(30, 100);
            label1.Name = "label1";
            label1.Size = new Size(143, 28);
            label1.TabIndex = 15;
            label1.Text = "Playlist Name";
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.Silver;
            addBtn.Location = new Point(196, 237);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(250, 49);
            addBtn.TabIndex = 14;
            addBtn.Text = "Add Data";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(196, 177);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(30, 175);
            label3.Name = "label3";
            label3.Size = new Size(143, 28);
            label3.TabIndex = 21;
            label3.Text = "Creation Date";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(196, 292);
            button2.Name = "button2";
            button2.Size = new Size(250, 49);
            button2.TabIndex = 23;
            button2.Text = "Main Form";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // createdByUser
            // 
            createdByUser.Location = new Point(195, 140);
            createdByUser.Name = "createdByUser";
            createdByUser.Size = new Size(251, 27);
            createdByUser.TabIndex = 25;
            createdByUser.TextChanged += createdByUser_TextChanged;
            // 
            // userID
            // 
            userID.AutoSize = true;
            userID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            userID.Location = new Point(92, 140);
            userID.Name = "userID";
            userID.Size = new Size(81, 28);
            userID.TabIndex = 24;
            userID.Text = "User ID";
            // 
            // FormPlaylist
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 216, 96);
            ClientSize = new Size(800, 450);
            Controls.Add(createdByUser);
            Controls.Add(userID);
            Controls.Add(button2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(playlistName);
            Controls.Add(connectBtn);
            Controls.Add(disconnectBtn);
            Controls.Add(label1);
            Controls.Add(addBtn);
            Name = "FormPlaylist";
            Text = "FormPlaylist";
            Load += FormPlaylist_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox playlistName;
        private Button connectBtn;
        private Button disconnectBtn;
        private Label label1;
        private Button addBtn;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Button button2;
        private TextBox createdByUser;
        private Label userID;
    }
}