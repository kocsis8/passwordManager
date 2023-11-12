namespace PasswordManager.Desktop.Views
{
    partial class AddNewPassword
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
            textBox_username = new TextBox();
            textBox_pw = new TextBox();
            label2 = new Label();
            textBox_website = new TextBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 53);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // textBox_username
            // 
            textBox_username.Location = new Point(137, 50);
            textBox_username.Name = "textBox_username";
            textBox_username.Size = new Size(100, 23);
            textBox_username.TabIndex = 1;
            // 
            // textBox_pw
            // 
            textBox_pw.Location = new Point(137, 79);
            textBox_pw.Name = "textBox_pw";
            textBox_pw.Size = new Size(100, 23);
            textBox_pw.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 82);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // textBox_website
            // 
            textBox_website.Location = new Point(137, 108);
            textBox_website.Name = "textBox_website";
            textBox_website.Size = new Size(100, 23);
            textBox_website.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 111);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 4;
            label3.Text = "Website";
            // 
            // button1
            // 
            button1.Location = new Point(63, 158);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(215, 158);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // AddNewPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 219);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox_website);
            Controls.Add(label3);
            Controls.Add(textBox_pw);
            Controls.Add(label2);
            Controls.Add(textBox_username);
            Controls.Add(label1);
            Name = "AddNewPassword";
            Text = "Add new password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_username;
        private TextBox textBox_pw;
        private Label label2;
        private TextBox textBox_website;
        private Label label3;
        private Button button1;
        private Button button2;
    }
}