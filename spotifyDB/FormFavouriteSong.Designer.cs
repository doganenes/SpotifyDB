namespace spotifyDB
{
    partial class FormFavouriteSong
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
            addBtn = new Button();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            disconnectBtn = new Button();
            connectBtn = new Button();
            button1 = new Button();
            userID = new TextBox();
            label2 = new Label();
            label3 = new Label();
            songID = new TextBox();
            SuspendLayout();
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.Silver;
            addBtn.Location = new Point(116, 237);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(250, 49);
            addBtn.TabIndex = 0;
            addBtn.Text = "Add Data";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(9, 185);
            label1.Name = "label1";
            label1.Size = new Size(101, 28);
            label1.TabIndex = 1;
            label1.Text = "Like Date";
            label1.Click += label1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(116, 187);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // disconnectBtn
            // 
            disconnectBtn.Location = new Point(668, 18);
            disconnectBtn.Name = "disconnectBtn";
            disconnectBtn.Size = new Size(118, 43);
            disconnectBtn.TabIndex = 4;
            disconnectBtn.Text = "Disconnect";
            disconnectBtn.UseVisualStyleBackColor = true;
            disconnectBtn.Click += disconnectBtn_Click;
            // 
            // connectBtn
            // 
            connectBtn.Location = new Point(544, 18);
            connectBtn.Name = "connectBtn";
            connectBtn.Size = new Size(118, 43);
            connectBtn.TabIndex = 5;
            connectBtn.Text = "Connect";
            connectBtn.UseVisualStyleBackColor = true;
            connectBtn.Click += connectBtn_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(116, 292);
            button1.Name = "button1";
            button1.Size = new Size(250, 49);
            button1.TabIndex = 6;
            button1.Text = "Main Form";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // userID
            // 
            userID.Location = new Point(116, 145);
            userID.Name = "userID";
            userID.Size = new Size(250, 27);
            userID.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(24, 99);
            label2.Name = "label2";
            label2.Size = new Size(86, 28);
            label2.TabIndex = 8;
            label2.Text = "Song ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(24, 144);
            label3.Name = "label3";
            label3.Size = new Size(81, 28);
            label3.TabIndex = 10;
            label3.Text = "User ID";
            // 
            // songID
            // 
            songID.Location = new Point(116, 103);
            songID.Name = "songID";
            songID.Size = new Size(250, 27);
            songID.TabIndex = 9;
            songID.TextChanged += songID_TextChanged;
            // 
            // FormFavouriteSong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 216, 96);
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(songID);
            Controls.Add(label2);
            Controls.Add(userID);
            Controls.Add(button1);
            Controls.Add(connectBtn);
            Controls.Add(disconnectBtn);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(addBtn);
            Name = "FormFavouriteSong";
            Text = "FormFavouriteSong";
            Load += FormFavouriteSong_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addBtn;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Button disconnectBtn;
        private Button connectBtn;
        private Button button1;
        private TextBox userID;
        private Label label2;
        private Label label3;
        private TextBox songID;
    }
}