namespace spotifyDB
{
    partial class FormPremiumMembership
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
            dateTimePicker2 = new DateTimePicker();
            button2 = new Button();
            label3 = new Label();
            userID = new TextBox();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(203, 127);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(82, 172);
            label2.Name = "label2";
            label2.Size = new Size(98, 28);
            label2.TabIndex = 28;
            label2.Text = "End Date";
            // 
            // connectBtn
            // 
            connectBtn.Location = new Point(547, 11);
            connectBtn.Name = "connectBtn";
            connectBtn.Size = new Size(118, 43);
            connectBtn.TabIndex = 27;
            connectBtn.Text = "Connect";
            connectBtn.UseVisualStyleBackColor = true;
            connectBtn.Click += connectBtn_Click;
            // 
            // disconnectBtn
            // 
            disconnectBtn.Location = new Point(671, 11);
            disconnectBtn.Name = "disconnectBtn";
            disconnectBtn.Size = new Size(118, 43);
            disconnectBtn.TabIndex = 26;
            disconnectBtn.Text = "Disconnect";
            disconnectBtn.UseVisualStyleBackColor = true;
            disconnectBtn.Click += disconnectBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(70, 125);
            label1.Name = "label1";
            label1.Size = new Size(110, 28);
            label1.TabIndex = 25;
            label1.Text = "Start Date";
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.Silver;
            addBtn.Location = new Point(203, 231);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(250, 49);
            addBtn.TabIndex = 24;
            addBtn.Text = "Add Data";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(203, 174);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 32;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(203, 286);
            button2.Name = "button2";
            button2.Size = new Size(250, 49);
            button2.TabIndex = 33;
            button2.Text = "Main Form";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(99, 79);
            label3.Name = "label3";
            label3.Size = new Size(81, 28);
            label3.TabIndex = 34;
            label3.Text = "User ID";
            // 
            // userID
            // 
            userID.Location = new Point(203, 79);
            userID.Name = "userID";
            userID.Size = new Size(250, 27);
            userID.TabIndex = 35;
            userID.TextChanged += userID_TextChanged;
            // 
            // FormPremiumMembership
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 216, 96);
            ClientSize = new Size(800, 450);
            Controls.Add(userID);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(connectBtn);
            Controls.Add(disconnectBtn);
            Controls.Add(label1);
            Controls.Add(addBtn);
            Name = "FormPremiumMembership";
            Text = "FormPremiumMembership";
            Load += FormPremiumMembership_Load;
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
        private DateTimePicker dateTimePicker2;
        private Button button2;
        private Label label3;
        private TextBox userID;
    }
}