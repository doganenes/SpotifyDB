﻿namespace spotifyDB
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
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(159, 113);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(38, 158);
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
            label1.Location = new Point(26, 111);
            label1.Name = "label1";
            label1.Size = new Size(110, 28);
            label1.TabIndex = 25;
            label1.Text = "Start Date";
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.Lime;
            addBtn.Location = new Point(159, 217);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(250, 49);
            addBtn.TabIndex = 24;
            addBtn.Text = "Add Data";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(159, 160);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 32;
            // 
            // FormPremiumMembership
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}