namespace spotifyDB
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            addBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            userName = new TextBox();
            email = new TextBox();
            password = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            connectBtn = new Button();
            disconnectBtn = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            SuspendLayout();
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.Lime;
            addBtn.Location = new Point(200, 329);
            addBtn.Margin = new Padding(4);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(303, 54);
            addBtn.TabIndex = 0;
            addBtn.Text = "Add Data";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 81);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(106, 28);
            label1.TabIndex = 1;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 142);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(101, 28);
            label2.TabIndex = 2;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(113, 208);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(64, 28);
            label3.TabIndex = 3;
            label3.Text = "email";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 271);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(143, 28);
            label4.TabIndex = 4;
            label4.Text = "Creation Date";
            label4.Click += label4_Click;
            // 
            // userName
            // 
            userName.Location = new Point(202, 75);
            userName.Margin = new Padding(4);
            userName.Name = "userName";
            userName.Size = new Size(147, 34);
            userName.TabIndex = 5;
            userName.TextChanged += userName_TextChanged;
            // 
            // email
            // 
            email.Location = new Point(202, 203);
            email.Margin = new Padding(4);
            email.Name = "email";
            email.Size = new Size(147, 34);
            email.TabIndex = 6;
            email.TextChanged += email_TextChanged;
            // 
            // password
            // 
            password.Location = new Point(202, 137);
            password.Margin = new Padding(4);
            password.Name = "password";
            password.Size = new Size(147, 34);
            password.TabIndex = 7;
            password.TextChanged += password_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(205, 269);
            dateTimePicker1.Margin = new Padding(4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(290, 34);
            dateTimePicker1.TabIndex = 9;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // connectBtn
            // 
            connectBtn.Location = new Point(488, 20);
            connectBtn.Name = "connectBtn";
            connectBtn.Size = new Size(106, 56);
            connectBtn.TabIndex = 10;
            connectBtn.Text = "Connect";
            connectBtn.UseVisualStyleBackColor = true;
            connectBtn.Click += connectBtn_Click;
            // 
            // disconnectBtn
            // 
            disconnectBtn.Location = new Point(604, 19);
            disconnectBtn.Name = "disconnectBtn";
            disconnectBtn.Size = new Size(141, 56);
            disconnectBtn.TabIndex = 11;
            disconnectBtn.Text = "Disconnect";
            disconnectBtn.UseVisualStyleBackColor = true;
            disconnectBtn.Click += disconnectBtn_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 498);
            Controls.Add(disconnectBtn);
            Controls.Add(connectBtn);
            Controls.Add(dateTimePicker1);
            Controls.Add(password);
            Controls.Add(email);
            Controls.Add(userName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(addBtn);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "UserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox userName;
        private TextBox email;
        private TextBox password;
        private DateTimePicker dateTimePicker1;
        private Button connectBtn;
        private Button disconnectBtn;
        private ContextMenuStrip contextMenuStrip1;
    }
}