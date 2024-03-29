﻿namespace spotifyDB
{
    partial class FormSessionHistory
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
            operationStatus = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            connectBtn = new Button();
            disconnectBtn = new Button();
            label1 = new Label();
            addBtn = new Button();
            button1 = new Button();
            label3 = new Label();
            userID = new TextBox();
            SuspendLayout();
            // 
            // operationStatus
            // 
            operationStatus.Location = new Point(195, 167);
            operationStatus.Name = "operationStatus";
            operationStatus.Size = new Size(250, 27);
            operationStatus.TabIndex = 47;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(195, 125);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 46;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 166);
            label2.Name = "label2";
            label2.Size = new Size(172, 28);
            label2.TabIndex = 45;
            label2.Text = "Operation Status";
            // 
            // connectBtn
            // 
            connectBtn.Location = new Point(549, 14);
            connectBtn.Name = "connectBtn";
            connectBtn.Size = new Size(118, 43);
            connectBtn.TabIndex = 44;
            connectBtn.Text = "Connect";
            connectBtn.UseVisualStyleBackColor = true;
            connectBtn.Click += connectBtn_Click;
            // 
            // disconnectBtn
            // 
            disconnectBtn.Location = new Point(673, 14);
            disconnectBtn.Name = "disconnectBtn";
            disconnectBtn.Size = new Size(118, 43);
            disconnectBtn.TabIndex = 43;
            disconnectBtn.Text = "Disconnect";
            disconnectBtn.UseVisualStyleBackColor = true;
            disconnectBtn.Click += disconnectBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(51, 123);
            label1.Name = "label1";
            label1.Size = new Size(133, 28);
            label1.TabIndex = 42;
            label1.Text = "Session Date";
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.Silver;
            addBtn.Location = new Point(195, 227);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(250, 49);
            addBtn.TabIndex = 41;
            addBtn.Text = "Add Data";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(195, 282);
            button1.Name = "button1";
            button1.Size = new Size(250, 49);
            button1.TabIndex = 48;
            button1.Text = "Main Form";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(103, 80);
            label3.Name = "label3";
            label3.Size = new Size(81, 28);
            label3.TabIndex = 49;
            label3.Text = "User ID";
            // 
            // userID
            // 
            userID.Location = new Point(195, 84);
            userID.Name = "userID";
            userID.Size = new Size(250, 27);
            userID.TabIndex = 50;
            userID.TextChanged += userID_TextChanged;
            // 
            // FormSessionHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 216, 96);
            ClientSize = new Size(800, 450);
            Controls.Add(userID);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(operationStatus);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(connectBtn);
            Controls.Add(disconnectBtn);
            Controls.Add(label1);
            Controls.Add(addBtn);
            Name = "FormSessionHistory";
            Text = "FormSessionHistory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox operationStatus;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Button connectBtn;
        private Button disconnectBtn;
        private Label label1;
        private Button addBtn;
        private Button button1;
        private Label label3;
        private TextBox userID;
    }
}