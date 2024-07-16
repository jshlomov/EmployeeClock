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

namespace EmployeeClock
{
    public partial class ClockForm : CloseForm
    {
        FormHandler formHandler;
        IDal _dal;
        Employee _employee;
        LastAttendancyTimes _lastEnAndEx;
        bool isNavigating = false;

        public ClockForm(FormHandler formHandler, IDal dal, Employee employee)
        {
            InitializeComponent();
            this.formHandler = formHandler;
            this._dal = dal;
            this._employee = employee;
            label_ID.Text = this._employee.IdentityNumber;
            ShowLastEntryAndExit();
        }

        private void ShowLastEntryAndExit()
        {
            try
            {
                _lastEnAndEx = new LastAttendancyTimes();
                _lastEnAndEx = _dal.GetEmployeeLastAttendancyTimes(_employee.ID);
                label_lastEnter.Text = _lastEnAndEx.Entry;
                label_lastExit.Text = _lastEnAndEx.Exit;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            try
            {
                _dal.CreateNewEntry(_employee.ID);
                ShowLastEntryAndExit();
                label_lastExit.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            try
            {
                _dal.CreateNewExit(_employee.ID);
                ShowLastEntryAndExit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void linkLabel_cancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formHandler.GoToNextPage(State.LOGIN);
        }

        private void ClockForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //if (e.CloseReason == CloseReason.UserClosing) Application.Exit();
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
