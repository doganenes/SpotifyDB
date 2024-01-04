namespace spotifyDB
{
    partial class FormSearchHistory
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
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            connectBtn = new Button();
            disconnectBtn = new Button();
            label1 = new Label();
            addBtn = new Button();
            searchName = new TextBox();
            button1 = new Button();
            userID = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(193, 173);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 39;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(37, 171);
            label2.Name = "label2";
            label2.Size = new Size(126, 28);
            label2.TabIndex = 37;
            label2.Text = "Search Date";
            // 
            // connectBtn
            // 
            connectBtn.Location = new Point(548, 24);
            connectBtn.Name = "connectBtn";
            connectBtn.Size = new Size(118, 43);
            connectBtn.TabIndex = 36;
            connectBtn.Text = "Connect";
            connectBtn.UseVisualStyleBackColor = true;
            connectBtn.Click += button3_Click;
            // 
            // disconnectBtn
            // 
            disconnectBtn.Location = new Point(672, 24);
            disconnectBtn.Name = "disconnectBtn";
            disconnectBtn.Size = new Size(118, 43);
            disconnectBtn.TabIndex = 35;
            disconnectBtn.Text = "Disconnect";
            disconnectBtn.UseVisualStyleBackColor = true;
            disconnectBtn.Click += disconnectBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(26, 124);
            label1.Name = "label1";
            label1.Size = new Size(137, 28);
            label1.TabIndex = 34;
            label1.Text = "Search Name";
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.Silver;
            addBtn.Location = new Point(193, 228);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(250, 49);
            addBtn.TabIndex = 33;
            addBtn.Text = "Add Data";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // searchName
            // 
            searchName.Location = new Point(193, 128);
            searchName.Name = "searchName";
            searchName.Size = new Size(250, 27);
            searchName.TabIndex = 40;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(193, 283);
            button1.Name = "button1";
            button1.Size = new Size(250, 49);
            button1.TabIndex = 41;
            button1.Text = "Main Form";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // userID
            // 
            userID.Location = new Point(193, 84);
            userID.Name = "userID";
            userID.Size = new Size(250, 27);
            userID.TabIndex = 43;
            userID.TextChanged += userID_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(26, 80);
            label3.Name = "label3";
            label3.Size = new Size(81, 28);
            label3.TabIndex = 42;
            label3.Text = "User ID";
            // 
            // FormSearchHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 216, 96);
            ClientSize = new Size(804, 450);
            Controls.Add(userID);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(searchName);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(connectBtn);
            Controls.Add(disconnectBtn);
            Controls.Add(label1);
            Controls.Add(addBtn);
            Name = "FormSearchHistory";
            Text = "FormSearchHistory";
            Load += FormSearchHistory_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Button connectBtn;
        private Button disconnectBtn;
        private Label label1;
        private Button addBtn;
        private TextBox searchName;
        private Button button1;
        private TextBox userID;
        private Label label3;
    }
}