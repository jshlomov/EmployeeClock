namespace EmployeeClock
{
    partial class ClockForm
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
            label_ID_text = new Label();
            label_ID = new Label();
            label_lastEnter_text = new Label();
            label_lastEnter = new Label();
            label_lastExit_text = new Label();
            label_lastExit = new Label();
            linkLabel_cancel = new LinkLabel();
            button_enter = new Button();
            button_exit = new Button();
            SuspendLayout();
            // 
            // label_ID_text
            // 
            label_ID_text.AutoSize = true;
            label_ID_text.Font = new Font("Segoe UI", 20F);
            label_ID_text.Location = new Point(359, 59);
            label_ID_text.Name = "label_ID_text";
            label_ID_text.Size = new Size(162, 46);
            label_ID_text.TabIndex = 0;
            label_ID_text.Text = "זהות עובד";
            // 
            // label_ID
            // 
            label_ID.AutoSize = true;
            label_ID.Font = new Font("Segoe UI", 18F);
            label_ID.Location = new Point(157, 62);
            label_ID.Name = "label_ID";
            label_ID.RightToLeft = RightToLeft.Yes;
            label_ID.Size = new Size(0, 41);
            label_ID.TabIndex = 1;
            // 
            // label_lastEnter_text
            // 
            label_lastEnter_text.AutoSize = true;
            label_lastEnter_text.Font = new Font("Segoe UI", 18F);
            label_lastEnter_text.Location = new Point(213, 134);
            label_lastEnter_text.Name = "label_lastEnter_text";
            label_lastEnter_text.Size = new Size(265, 41);
            label_lastEnter_text.TabIndex = 2;
            label_lastEnter_text.Text = "תאריך כניסה אחרון";
            // 
            // label_lastEnter
            // 
            label_lastEnter.AutoSize = true;
            label_lastEnter.Font = new Font("Segoe UI", 16F);
            label_lastEnter.Location = new Point(216, 187);
            label_lastEnter.Margin = new Padding(3);
            label_lastEnter.Name = "label_lastEnter";
            label_lastEnter.RightToLeft = RightToLeft.Yes;
            label_lastEnter.Size = new Size(75, 37);
            label_lastEnter.TabIndex = 3;
            label_lastEnter.Text = "labal";
            label_lastEnter.TextAlign = ContentAlignment.TopRight;
            // 
            // label_lastExit_text
            // 
            label_lastExit_text.AutoSize = true;
            label_lastExit_text.Font = new Font("Segoe UI", 18F);
            label_lastExit_text.Location = new Point(216, 237);
            label_lastExit_text.Name = "label_lastExit_text";
            label_lastExit_text.Size = new Size(262, 41);
            label_lastExit_text.TabIndex = 4;
            label_lastExit_text.Text = "תאריך יציאה אחרון";
            // 
            // label_lastExit
            // 
            label_lastExit.AutoSize = true;
            label_lastExit.Font = new Font("Segoe UI", 16F);
            label_lastExit.Location = new Point(216, 297);
            label_lastExit.Name = "label_lastExit";
            label_lastExit.RightToLeft = RightToLeft.Yes;
            label_lastExit.Size = new Size(75, 37);
            label_lastExit.TabIndex = 5;
            label_lastExit.Text = "label";
            label_lastExit.TextAlign = ContentAlignment.TopRight;
            // 
            // linkLabel_cancel
            // 
            linkLabel_cancel.AutoSize = true;
            linkLabel_cancel.Font = new Font("Segoe UI", 15F);
            linkLabel_cancel.Location = new Point(260, 368);
            linkLabel_cancel.Name = "linkLabel_cancel";
            linkLabel_cancel.Size = new Size(74, 35);
            linkLabel_cancel.TabIndex = 6;
            linkLabel_cancel.TabStop = true;
            linkLabel_cancel.Text = "ביטול";
            linkLabel_cancel.LinkClicked += linkLabel_cancel_LinkClicked;
            // 
            // button_enter
            // 
            button_enter.Font = new Font("Segoe UI", 22F);
            button_enter.Location = new Point(421, 410);
            button_enter.Name = "button_enter";
            button_enter.Size = new Size(130, 110);
            button_enter.TabIndex = 7;
            button_enter.Text = "כניסה";
            button_enter.UseVisualStyleBackColor = true;
            button_enter.Click += button_enter_Click;
            // 
            // button_exit
            // 
            button_exit.Font = new Font("Segoe UI", 22F);
            button_exit.Location = new Point(46, 410);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(130, 110);
            button_exit.TabIndex = 8;
            button_exit.Text = "יציאה";
            button_exit.UseVisualStyleBackColor = true;
            button_exit.Click += button_exit_Click;
            // 
            // ClockForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 552);
            Controls.Add(button_exit);
            Controls.Add(button_enter);
            Controls.Add(linkLabel_cancel);
            Controls.Add(label_lastExit);
            Controls.Add(label_lastExit_text);
            Controls.Add(label_lastEnter);
            Controls.Add(label_lastEnter_text);
            Controls.Add(label_ID);
            Controls.Add(label_ID_text);
            Name = "ClockForm";
            RightToLeft = RightToLeft.Yes;
            Text = "ClockForm";
            FormClosing += Form_FormClosing;
            FormClosed += ClockForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_ID_text;
        private Label label_ID;
        private Label label_lastEnter_text;
        private Label label_lastEnter;
        private Label label_lastExit_text;
        private Label label_lastExit;
        private LinkLabel linkLabel_cancel;
        private Button button_enter;
        private Button button_exit;
    }
}