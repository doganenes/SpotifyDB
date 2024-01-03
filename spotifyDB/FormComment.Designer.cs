namespace spotifyDB
{
    partial class FormComment
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
            label1 = new Label();
            commentText = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            connectBtn = new Button();
            label2 = new Label();
            disconnectionBtn = new Button();
            addBtn = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(19, 131);
            label1.Name = "label1";
            label1.Size = new Size(170, 31);
            label1.TabIndex = 0;
            label1.Text = "Comment Text";
            // 
            // commentText
            // 
            commentText.Location = new Point(226, 135);
            commentText.Name = "commentText";
            commentText.Size = new Size(250, 27);
            commentText.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(226, 182);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // connectBtn
            // 
            connectBtn.Location = new Point(531, 26);
            connectBtn.Name = "connectBtn";
            connectBtn.Size = new Size(118, 42);
            connectBtn.TabIndex = 3;
            connectBtn.Text = "Connect";
            connectBtn.UseVisualStyleBackColor = true;
            connectBtn.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(14, 178);
            label2.Name = "label2";
            label2.Size = new Size(175, 31);
            label2.TabIndex = 4;
            label2.Text = "Comment Date";
            // 
            // disconnectionBtn
            // 
            disconnectionBtn.Location = new Point(658, 25);
            disconnectionBtn.Name = "disconnectionBtn";
            disconnectionBtn.Size = new Size(114, 42);
            disconnectionBtn.TabIndex = 5;
            disconnectionBtn.Text = "Disconnect";
            disconnectionBtn.UseVisualStyleBackColor = true;
            disconnectionBtn.Click += disconnectionBtn_Click;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.Silver;
            addBtn.Location = new Point(226, 246);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(250, 49);
            addBtn.TabIndex = 6;
            addBtn.Text = "Add Data";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(226, 301);
            button1.Name = "button1";
            button1.Size = new Size(250, 51);
            button1.TabIndex = 7;
            button1.Text = "Main Form";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // FormComment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 216, 96);
            ClientSize = new Size(807, 438);
            Controls.Add(button1);
            Controls.Add(addBtn);
            Controls.Add(disconnectionBtn);
            Controls.Add(label2);
            Controls.Add(connectBtn);
            Controls.Add(dateTimePicker1);
            Controls.Add(commentText);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            Name = "FormComment";
            Text = "FormComment";
            Load += FormComment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox commentText;
        private DateTimePicker dateTimePicker1;
        private Button connectBtn;
        private Label label2;
        private Button disconnectionBtn;
        private Button addBtn;
        private Button button1;
    }
}