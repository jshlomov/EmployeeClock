using EmployeeClock.DAL;
using EmployeeClock.Model;
using EmployeeClock.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EmployeeClock
{
    public partial class PasswordChangeForm : CloseForm
    {
        FormHandler formHandler;
        IDal _dal;
        bool isNavigating = false;

        public PasswordChangeForm(FormHandler formHandler, IDal dal)
        {
            InitializeComponent();
            this.formHandler = formHandler;
            this._dal = dal;
        }

        private void linkLabel_cancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formHandler.GoToNextPage(State.LOGIN);
        }

        private void button_changePassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_ID.Text == "" || textBox_oldPassword.Text == "" ||
                    textBox_newPassword.Text == "" || textBox_confirm.Text == "")
                    throw new Exception("מלא את כל הפרטים");
                Employee employee = _dal.GetEmployeeByIdentityNumber(textBox_ID.Text, textBox_oldPassword.Text);
                if (textBox_newPassword.Text != textBox_confirm.Text)
                    throw new Exception("הסיסמאות אינן תואמות");
                _dal.ChangePassword(employee.ID, textBox_newPassword.Text);
                MessageBox.Show("הסיסמא שונתה בהצלחה");
                formHandler.GoToNextPage(State.LOGIN);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("פרטי הזדהות שגויים");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ClockForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //if (e.CloseReason == CloseReason.UserClosing) Application.Exit();
        }

        private void textBox_confirm_TextChanged(object sender, EventArgs e)
        {
            if (textBox_confirm.Text != textBox_newPassword.Text)
                textBox_confirm.ForeColor = Color.Red;
            else
                textBox_confirm.ForeColor = Color.Black;
        }

        public override void CloseWithoutExit()
        {
            isNavigating = true;
            this.Close();
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isNavigating)
            {
                string confirmExitQuestion = "האם ברצונך לצאת מהמערכת?";
                string confirmExitTitle = "אשר יציאה מהמערכת";
                DialogResult dialogResult = MessageBox.Show(confirmExitQuestion, confirmExitTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Exit();
                    return;
                }
            }
        }
    }
}
