namespace spotifyDB
{
    partial class FormDevices
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
            deviceName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            addBtn = new Button();
            button1 = new Button();
            label4 = new Label();
            userID = new TextBox();
            SuspendLayout();
            // 
            // connectBtn
            // 
            connectBtn.Location = new Point(553, 10);
            connectBtn.Name = "connectBtn";
            connectBtn.Size = new Size(107, 43);
            connectBtn.TabIndex = 0;
            connectBtn.Text = "Connect";
            connectBtn.UseVisualStyleBackColor = true;
            connectBtn.Click += connectBtn_Click;
            // 
            // disconnectBtn
            // 
            disconnectBtn.Location = new Point(666, 12);
            disconnectBtn.Name = "disconnectBtn";
            disconnectBtn.Size = new Size(122, 41);
            disconnectBtn.TabIndex = 1;
            disconnectBtn.Text = "Disconnect";
            disconnectBtn.UseVisualStyleBackColor = true;
            disconnectBtn.Click += disconnectBtn_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(33, 159);
            label1.Name = "label1";
            label1.Size = new Size(138, 28);
            label1.TabIndex = 2;
            label1.Text = "Device Name";
            label1.Click += label1_Click;
            // 
            // deviceName
            // 
            deviceName.Location = new Point(197, 159);
            deviceName.Name = "deviceName";
            deviceName.Size = new Size(250, 27);
            deviceName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(10, 252);
            label2.Name = "label2";
            label2.Size = new Size(170, 28);
            label2.TabIndex = 4;
            label2.Text = "Last Played Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(70, 205);
            label3.Name = "label3";
            label3.Size = new Size(102, 28);
            label3.TabIndex = 6;
            label3.Text = "Link Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(197, 206);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(197, 254);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 9;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.Silver;
            addBtn.Location = new Point(197, 304);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(253, 45);
            addBtn.TabIndex = 10;
            addBtn.Text = "Add Data";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(197, 355);
            button1.Name = "button1";
            button1.Size = new Size(253, 45);
            button1.TabIndex = 11;
            button1.Text = "Main Form";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(90, 117);
            label4.Name = "label4";
            label4.Size = new Size(81, 28);
            label4.TabIndex = 12;
            label4.Text = "User ID";
            // 
            // userID
            // 
            userID.Location = new Point(197, 117);
            userID.Name = "userID";
            userID.Size = new Size(250, 27);
            userID.TabIndex = 13;
            userID.TextChanged += textBox1_TextChanged;
            // 
            // FormDevices
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 216, 96);
            ClientSize = new Size(800, 450);
            Controls.Add(userID);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(addBtn);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(deviceName);
            Controls.Add(label1);
            Controls.Add(disconnectBtn);
            Controls.Add(connectBtn);
            Name = "FormDevices";
            Text = "FormDevices";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button connectBtn;
        private Button disconnectBtn;
        private Label label1;
        private TextBox deviceName;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button addBtn;
        private Button button1;
        private Label label4;
        private TextBox userID;
    }
}