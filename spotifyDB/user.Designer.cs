namespace spotifyDB
{
    partial class User
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            userName = new TextBox();
            email = new TextBox();
            password = new TextBox();
            connectBtn = new Button();
            disconnectBtn = new Button();
            linkLabel1 = new LinkLabel();
            btnPlayList = new Button();
            queryBtn = new Button();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // addBtn
            // 
            addBtn.FlatAppearance.BorderSize = 15;
            addBtn.Location = new Point(146, 330);
            addBtn.Margin = new Padding(4);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(187, 38);
            addBtn.TabIndex = 0;
            addBtn.Text = "Add Data";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 207);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(116, 28);
            label1.TabIndex = 1;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 252);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(101, 28);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 294);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 28);
            label3.TabIndex = 3;
            label3.Text = "User Email";
            // 
            // userName
            // 
            userName.Location = new Point(146, 201);
            userName.Margin = new Padding(4);
            userName.Name = "userName";
            userName.Size = new Size(187, 34);
            userName.TabIndex = 5;
            userName.TextChanged += userName_TextChanged;
            // 
            // email
            // 
            email.Location = new Point(146, 288);
            email.Margin = new Padding(4);
            email.Name = "email";
            email.Size = new Size(187, 34);
            email.TabIndex = 6;
            email.TextChanged += email_TextChanged;
            // 
            // password
            // 
            password.Location = new Point(146, 246);
            password.Margin = new Padding(4);
            password.Name = "password";
            password.Size = new Size(187, 34);
            password.TabIndex = 7;
            password.UseSystemPasswordChar = true;
            password.TextChanged += password_TextChanged;
            // 
            // connectBtn
            // 
            connectBtn.Location = new Point(631, 12);
            connectBtn.Name = "connectBtn";
            connectBtn.Size = new Size(101, 48);
            connectBtn.TabIndex = 10;
            connectBtn.Text = "Connect";
            connectBtn.UseVisualStyleBackColor = true;
            connectBtn.Click += connectBtn_Click;
            // 
            // disconnectBtn
            // 
            disconnectBtn.Location = new Point(738, 12);
            disconnectBtn.Name = "disconnectBtn";
            disconnectBtn.Size = new Size(151, 48);
            disconnectBtn.TabIndex = 11;
            disconnectBtn.Text = "Disconnect";
            disconnectBtn.UseVisualStyleBackColor = true;
            disconnectBtn.Click += disconnectBtn_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.Location = new Point(0, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(100, 23);
            linkLabel1.TabIndex = 0;
            // 
            // btnPlayList
            // 
            btnPlayList.Location = new Point(632, 92);
            btnPlayList.Name = "btnPlayList";
            btnPlayList.Size = new Size(257, 44);
            btnPlayList.TabIndex = 12;
            btnPlayList.Text = "PlayList";
            btnPlayList.UseVisualStyleBackColor = true;
            btnPlayList.Click += btnPlayList_Click;
            // 
            // queryBtn
            // 
            queryBtn.Location = new Point(146, 375);
            queryBtn.Name = "queryBtn";
            queryBtn.Size = new Size(187, 38);
            queryBtn.TabIndex = 13;
            queryBtn.Text = "Query";
            queryBtn.UseVisualStyleBackColor = true;
            queryBtn.Click += queryBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(0, 104);
            label4.Name = "label4";
            label4.Size = new Size(171, 41);
            label4.TabIndex = 14;
            label4.Text = "Spotify DB";
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(632, 142);
            button1.Name = "button1";
            button1.Size = new Size(257, 44);
            button1.TabIndex = 15;
            button1.Text = "Comment";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(632, 193);
            button2.Name = "button2";
            button2.Size = new Size(257, 44);
            button2.TabIndex = 16;
            button2.Text = "Devices";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(632, 243);
            button3.Name = "button3";
            button3.Size = new Size(257, 44);
            button3.TabIndex = 17;
            button3.Text = "Favourite Song";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(631, 293);
            button4.Name = "button4";
            button4.Size = new Size(257, 44);
            button4.TabIndex = 18;
            button4.Text = "Followed User";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(631, 343);
            button5.Name = "button5";
            button5.Size = new Size(257, 44);
            button5.TabIndex = 19;
            button5.Text = "Premium Membership";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(632, 393);
            button6.Name = "button6";
            button6.Size = new Size(257, 44);
            button6.TabIndex = 20;
            button6.Text = "Search History";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(632, 443);
            button7.Name = "button7";
            button7.Size = new Size(257, 44);
            button7.TabIndex = 21;
            button7.Text = "Song";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(632, 493);
            button8.Name = "button8";
            button8.Size = new Size(257, 44);
            button8.TabIndex = 22;
            button8.Text = "Session History";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.spotify;
            pictureBox1.Location = new Point(9, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 216, 96);
            ClientSize = new Size(901, 592);
            Controls.Add(pictureBox1);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(queryBtn);
            Controls.Add(btnPlayList);
            Controls.Add(linkLabel1);
            Controls.Add(disconnectBtn);
            Controls.Add(connectBtn);
            Controls.Add(password);
            Controls.Add(email);
            Controls.Add(userName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(addBtn);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4);
            Name = "User";
            Load += User_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox userName;
        private TextBox email;
        private TextBox password;
        private Button connectBtn;
        private Button disconnectBtn;
        private LinkLabel linkLabel1;
        private Button btnPlayList;
        private Button queryBtn;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private PictureBox pictureBox1;
    }
}