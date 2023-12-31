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
            SuspendLayout();
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.Lime;
            addBtn.Location = new Point(128, 167);
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
            label1.Location = new Point(21, 110);
            label1.Name = "label1";
            label1.Size = new Size(101, 28);
            label1.TabIndex = 1;
            label1.Text = "Like Date";
            label1.Click += label1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(128, 111);
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
            // FormFavouriteSong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}