namespace spotifyDB
{
    partial class FormFollowedUser
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
            connectBtn = new Button();
            disconnectBtn = new Button();
            label1 = new Label();
            addBtn = new Button();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            followedUser = new TextBox();
            button2 = new Button();
            followerUser = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // connectBtn
            // 
            connectBtn.Location = new Point(551, 19);
            connectBtn.Name = "connectBtn";
            connectBtn.Size = new Size(118, 43);
            connectBtn.TabIndex = 10;
            connectBtn.Text = "Connect";
            connectBtn.UseVisualStyleBackColor = true;
            connectBtn.Click += connectBtn_Click;
            // 
            // disconnectBtn
            // 
            disconnectBtn.Location = new Point(675, 19);
            disconnectBtn.Name = "disconnectBtn";
            disconnectBtn.Size = new Size(118, 43);
            disconnectBtn.TabIndex = 9;
            disconnectBtn.Text = "Disconnect";
            disconnectBtn.UseVisualStyleBackColor = true;
            disconnectBtn.Click += disconnectBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(105, 90);
            label1.Name = "label1";
            label1.Size = new Size(145, 28);
            label1.TabIndex = 7;
            label1.Text = "Followed User";
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.Silver;
            addBtn.Location = new Point(256, 213);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(250, 49);
            addBtn.TabIndex = 6;
            addBtn.Text = "Add Data";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(256, 166);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(72, 164);
            label2.Name = "label2";
            label2.Size = new Size(178, 28);
            label2.TabIndex = 11;
            label2.Text = "Follow Start Date";
            // 
            // followedUser
            // 
            followedUser.Location = new Point(256, 90);
            followedUser.Name = "followedUser";
            followedUser.Size = new Size(251, 27);
            followedUser.TabIndex = 13;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(256, 268);
            button2.Name = "button2";
            button2.Size = new Size(250, 49);
            button2.TabIndex = 14;
            button2.Text = "Main Form";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // followerUser
            // 
            followerUser.Location = new Point(256, 131);
            followerUser.Name = "followerUser";
            followerUser.Size = new Size(251, 27);
            followerUser.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(105, 130);
            label3.Name = "label3";
            label3.Size = new Size(141, 28);
            label3.TabIndex = 15;
            label3.Text = "Follower User";
            label3.Click += label3_Click;
            // 
            // FormFollowedUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 216, 96);
            ClientSize = new Size(800, 450);
            Controls.Add(followerUser);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(followedUser);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(connectBtn);
            Controls.Add(disconnectBtn);
            Controls.Add(label1);
            Controls.Add(addBtn);
            Name = "FormFollowedUser";
            Text = "FormFollowedUser";
            Load += FormFollowedUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button connectBtn;
        private Button disconnectBtn;
        private Label label1;
        private Button addBtn;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private TextBox followedUser;
        private Button button2;
        private TextBox followerUser;
        private Label label3;
    }
}