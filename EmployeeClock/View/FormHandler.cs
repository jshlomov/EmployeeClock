

using EmployeeClock.DAL;
using EmployeeClock.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClock.View
{
    public class FormHandler
    {
        //if I will have more time - implement design pattern "state"

        private CloseForm _activeForm;
        IDal dal;

        public FormHandler(IDal dal)
        {
            this.dal = dal;
            _activeForm = new LoginForm(this, dal);
            _activeForm.Show();
        }

        /// <summary>
        /// going to the next page by State
        /// "Login" to the Login page
        /// "Clock" to the ClockForm page
        /// "Password" to the PasswordChangeForm page
        /// </summary>
        /// <param name="formName">the form name</param>
        public void GoToNextPage(State state, Employee employee = null)
        {
            switch (state)
            {
                case State.LOGIN:
                    {
                        _activeForm.CloseWithoutExit();
                        _activeForm = new LoginForm(this, dal);
                        _activeForm.Show();
                        break;
                    }
                case State.CLOCK:
                    {
                        _activeForm.CloseWithoutExit();
                        _activeForm = new ClockForm(this, dal, employee);
                        _activeForm.Show();
                        break;
                    }
                case State.PASSWORD:
                    {
                        _activeForm.CloseWithoutExit();
                        _activeForm = new PasswordChangeForm(this, dal);
                        _activeForm.Show();
                        break;
                    }
                default:
                    break;
            }
        }
    }
}
