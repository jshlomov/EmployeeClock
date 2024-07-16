using EmployeeClock.DAL;
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
using EmployeeClock.Model;

namespace EmployeeClock
{
    public partial class LoginForm : CloseForm
    {
        FormHandler formHandler;
        IDal _dal;
        string _identityNumber;
        string _password;
        bool isNavigating = false;


        public LoginForm(FormHandler formHandler, IDal _dal)
        {
            InitializeComponent();
            this.formHandler = formHandler;
            this._dal = _dal;
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBox_ID.Text) || string.IsNullOrEmpty(textBox_password.Text))
                    throw new Exception("מלא את הפרטים");
                Employee emp = _dal.GetEmployeeByIdentityNumber(_identityNumber, _password);
                formHandler.GoToNextPage(State.CLOCK, emp);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("פרטים לא נכונים");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button_changePassword_Click(object sender, EventArgs e)
        {
            formHandler.GoToNextPage(State.PASSWORD);
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!isNavigating)
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

        private void textBox_ID_TextChanged(object sender, EventArgs e)
        {
            _identityNumber = textBox_ID.Text;
        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {
            _password = textBox_password.Text;
        }

        public override void CloseWithoutExit()
        {
            isNavigating = true;
            this.Close();
        }
    }
}
