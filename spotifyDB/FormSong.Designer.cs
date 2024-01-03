namespace spotifyDB
{
    partial class FormSong
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
            songName = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            connectBtn = new Button();
            disconnectBtn = new Button();
            label1 = new Label();
            addBtn = new Button();
            singer = new TextBox();
            label3 = new Label();
            songType = new TextBox();
            label4 = new Label();
            restCount = new TextBox();
            label5 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // songName
            // 
            songName.Location = new Point(198, 84);
            songName.Name = "songName";
            songName.Size = new Size(250, 27);
            songName.TabIndex = 54;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(198, 171);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 53;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(45, 171);
            label2.Name = "label2";
            label2.Size = new Size(130, 28);
            label2.TabIndex = 52;
            label2.Text = "Release Year";
            // 
            // connectBtn
            // 
            connectBtn.Location = new Point(553, 12);
            connectBtn.Name = "connectBtn";
            connectBtn.Size = new Size(118, 43);
            connectBtn.TabIndex = 51;
            connectBtn.Text = "Connect";
            connectBtn.UseVisualStyleBackColor = true;
            connectBtn.Click += connectBtn_Click;
            // 
            // disconnectBtn
            // 
            disconnectBtn.Location = new Point(677, 12);
            disconnectBtn.Name = "disconnectBtn";
            disconnectBtn.Size = new Size(118, 43);
            disconnectBtn.TabIndex = 50;
            disconnectBtn.Text = "Disconnect";
            disconnectBtn.UseVisualStyleBackColor = true;
            disconnectBtn.Click += disconnectBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(54, 84);
            label1.Name = "label1";
            label1.Size = new Size(121, 28);
            label1.TabIndex = 49;
            label1.Text = "Song Name";
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.Silver;
            addBtn.Location = new Point(198, 301);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(250, 49);
            addBtn.TabIndex = 48;
            addBtn.Text = "Add Data";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // singer
            // 
            singer.Location = new Point(198, 129);
            singer.Name = "singer";
            singer.Size = new Size(250, 27);
            singer.TabIndex = 56;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(103, 129);
            label3.Name = "label3";
            label3.Size = new Size(72, 28);
            label3.TabIndex = 55;
            label3.Text = "Singer";
            // 
            // songType
            // 
            songType.Location = new Point(198, 215);
            songType.Name = "songType";
            songType.Size = new Size(250, 27);
            songType.TabIndex = 58;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(71, 215);
            label4.Name = "label4";
            label4.Size = new Size(104, 28);
            label4.TabIndex = 57;
            label4.Text = "SongType";
            // 
            // restCount
            // 
            restCount.Location = new Point(198, 259);
            restCount.Name = "restCount";
            restCount.Size = new Size(250, 27);
            restCount.TabIndex = 60;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(71, 259);
            label5.Name = "label5";
            label5.Size = new Size(109, 28);
            label5.TabIndex = 59;
            label5.Text = "RestCount";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(198, 356);
            button2.Name = "button2";
            button2.Size = new Size(250, 49);
            button2.TabIndex = 61;
            button2.Text = "Main Form";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // FormSong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 216, 96);
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(restCount);
            Controls.Add(label5);
            Controls.Add(songType);
            Controls.Add(label4);
            Controls.Add(singer);
            Controls.Add(label3);
            Controls.Add(songName);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(connectBtn);
            Controls.Add(disconnectBtn);
            Controls.Add(label1);
            Controls.Add(addBtn);
            Name = "FormSong";
            Text = "FormSong";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox songName;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Button connectBtn;
        private Button disconnectBtn;
        private Label label1;
        private Button addBtn;
        private TextBox singer;
        private Label label3;
        private TextBox songType;
        private Label label4;
        private TextBox restCount;
        private Label label5;
        private Button button2;
    }
}