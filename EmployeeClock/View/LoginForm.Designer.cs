namespace EmployeeClock
{
    partial class LoginForm
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
            label_ID = new Label();
            label_password = new Label();
            button_enter = new Button();
            button_changePassword = new Button();
            textBox_ID = new TextBox();
            textBox_password = new TextBox();
            SuspendLayout();
            // 
            // label_ID
            // 
            label_ID.AutoSize = true;
            label_ID.Font = new Font("Segoe UI", 18F);
            label_ID.Location = new Point(216, 34);
            label_ID.Name = "label_ID";
            label_ID.Size = new Size(169, 41);
            label_ID.TabIndex = 4;
            label_ID.Text = "תעודת זהות";
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.Font = new Font("Segoe UI", 18F);
            label_password.Location = new Point(240, 169);
            label_password.Name = "label_password";
            label_password.Size = new Size(105, 41);
            label_password.TabIndex = 5;
            label_password.Text = "סיסמא";
            // 
            // button_enter
            // 
            button_enter.Location = new Point(145, 346);
            button_enter.Name = "button_enter";
            button_enter.Size = new Size(310, 52);
            button_enter.TabIndex = 2;
            button_enter.Text = "כניסה";
            button_enter.UseVisualStyleBackColor = true;
            button_enter.Click += button_enter_Click;
            // 
            // button_changePassword
            // 
            button_changePassword.Location = new Point(145, 425);
            button_changePassword.Name = "button_changePassword";
            button_changePassword.Size = new Size(310, 52);
            button_changePassword.TabIndex = 3;
            button_changePassword.Text = "החלפת סיסמא";
            button_changePassword.UseVisualStyleBackColor = true;
            button_changePassword.Click += button_changePassword_Click;
            // 
            // textBox_ID
            // 
            textBox_ID.Font = new Font("Segoe UI", 18F);
            textBox_ID.Location = new Point(145, 89);
            textBox_ID.Name = "textBox_ID";
            textBox_ID.Size = new Size(310, 47);
            textBox_ID.TabIndex = 0;
            textBox_ID.TextChanged += textBox_ID_TextChanged;
            // 
            // textBox_password
            // 
            textBox_password.Font = new Font("Segoe UI", 18F);
            textBox_password.Location = new Point(145, 225);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(310, 47);
            textBox_password.TabIndex = 1;
            textBox_password.TextChanged += textBox_password_TextChanged;
            textBox_password.PasswordChar = '*';
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 532);
            Controls.Add(textBox_password);
            Controls.Add(textBox_ID);
            Controls.Add(button_changePassword);
            Controls.Add(button_enter);
            Controls.Add(label_password);
            Controls.Add(label_ID);
            Name = "LoginForm";
            Text = "LoginForm";
            FormClosing += Form_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_ID;
        private Label label_password;
        private Button button_enter;
        private Button button_changePassword;
        private TextBox textBox_ID;
        private TextBox textBox_password;
    }
}