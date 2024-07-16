namespace EmployeeClock
{
    partial class PasswordChangeForm
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
            textBox_ID = new TextBox();
            textBox_oldPassword = new TextBox();
            textBox_newPassword = new TextBox();
            textBox_confirm = new TextBox();
            linkLabel_cancel = new LinkLabel();
            button_changePassword = new Button();
            label_ID_text = new Label();
            label_oldPassword_text = new Label();
            label_newPassword_text = new Label();
            label_confirm = new Label();
            SuspendLayout();
            // 
            // textBox_ID
            // 
            textBox_ID.Font = new Font("Segoe UI", 18F);
            textBox_ID.Location = new Point(69, 66);
            textBox_ID.Name = "textBox_ID";
            textBox_ID.Size = new Size(195, 47);
            textBox_ID.TabIndex = 0;
            // 
            // textBox_oldPassword
            // 
            textBox_oldPassword.Font = new Font("Segoe UI", 18F);
            textBox_oldPassword.Location = new Point(69, 143);
            textBox_oldPassword.Name = "textBox_oldPassword";
            textBox_oldPassword.PasswordChar = '*';
            textBox_oldPassword.Size = new Size(195, 47);
            textBox_oldPassword.TabIndex = 1;
            // 
            // textBox_newPassword
            // 
            textBox_newPassword.Font = new Font("Segoe UI", 18F);
            textBox_newPassword.Location = new Point(69, 217);
            textBox_newPassword.Name = "textBox_newPassword";
            textBox_newPassword.PasswordChar = '*';
            textBox_newPassword.Size = new Size(195, 47);
            textBox_newPassword.TabIndex = 2;
            // 
            // textBox_confirm
            // 
            textBox_confirm.Font = new Font("Segoe UI", 18F);
            textBox_confirm.Location = new Point(69, 296);
            textBox_confirm.Name = "textBox_confirm";
            textBox_confirm.PasswordChar = '*';
            textBox_confirm.Size = new Size(195, 47);
            textBox_confirm.TabIndex = 3;
            textBox_confirm.TextChanged += textBox_confirm_TextChanged;
            // 
            // linkLabel_cancel
            // 
            linkLabel_cancel.AutoSize = true;
            linkLabel_cancel.Font = new Font("Segoe UI", 15F);
            linkLabel_cancel.Location = new Point(411, 386);
            linkLabel_cancel.Name = "linkLabel_cancel";
            linkLabel_cancel.Size = new Size(74, 35);
            linkLabel_cancel.TabIndex = 4;
            linkLabel_cancel.TabStop = true;
            linkLabel_cancel.Text = "ביטול";
            linkLabel_cancel.LinkClicked += linkLabel_cancel_LinkClicked;
            // 
            // button_changePassword
            // 
            button_changePassword.Location = new Point(69, 385);
            button_changePassword.Name = "button_changePassword";
            button_changePassword.Size = new Size(195, 47);
            button_changePassword.TabIndex = 5;
            button_changePassword.Text = "ביצוע החלפת סיסמא";
            button_changePassword.UseVisualStyleBackColor = true;
            button_changePassword.Click += button_changePassword_Click;
            // 
            // label_ID_text
            // 
            label_ID_text.AutoSize = true;
            label_ID_text.Font = new Font("Segoe UI", 18F);
            label_ID_text.Location = new Point(388, 69);
            label_ID_text.Name = "label_ID_text";
            label_ID_text.Size = new Size(169, 41);
            label_ID_text.TabIndex = 6;
            label_ID_text.Text = "תעודת זהות";
            // 
            // label_oldPassword_text
            // 
            label_oldPassword_text.AutoSize = true;
            label_oldPassword_text.Font = new Font("Segoe UI", 18F);
            label_oldPassword_text.Location = new Point(380, 146);
            label_oldPassword_text.Name = "label_oldPassword_text";
            label_oldPassword_text.Size = new Size(177, 41);
            label_oldPassword_text.TabIndex = 7;
            label_oldPassword_text.Text = "סיסמא ישנה";
            // 
            // label_newPassword_text
            // 
            label_newPassword_text.AutoSize = true;
            label_newPassword_text.Font = new Font("Segoe UI", 18F);
            label_newPassword_text.Location = new Point(366, 220);
            label_newPassword_text.Name = "label_newPassword_text";
            label_newPassword_text.Size = new Size(191, 41);
            label_newPassword_text.TabIndex = 8;
            label_newPassword_text.Text = "סיסמא חדשה";
            // 
            // label_confirm
            // 
            label_confirm.AutoSize = true;
            label_confirm.Font = new Font("Segoe UI", 18F);
            label_confirm.Location = new Point(282, 299);
            label_confirm.Name = "label_confirm";
            label_confirm.Size = new Size(275, 41);
            label_confirm.TabIndex = 9;
            label_confirm.Text = "אישור סיסמא חדשה";
            // 
            // PasswordChangeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 495);
            Controls.Add(label_confirm);
            Controls.Add(label_newPassword_text);
            Controls.Add(label_oldPassword_text);
            Controls.Add(label_ID_text);
            Controls.Add(button_changePassword);
            Controls.Add(linkLabel_cancel);
            Controls.Add(textBox_confirm);
            Controls.Add(textBox_newPassword);
            Controls.Add(textBox_oldPassword);
            Controls.Add(textBox_ID);
            Name = "PasswordChangeForm";
            Text = "PasswordChangeForm";
            FormClosing += Form_FormClosing;
            FormClosed += ClockForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_ID;
        private TextBox textBox_oldPassword;
        private TextBox textBox_newPassword;
        private TextBox textBox_confirm;
        private LinkLabel linkLabel_cancel;
        private Button button_changePassword;
        private Label label_ID_text;
        private Label label_oldPassword_text;
        private Label label_newPassword_text;
        private Label label_confirm;
    }
}