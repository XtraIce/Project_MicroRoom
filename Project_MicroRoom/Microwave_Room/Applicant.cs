using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace Microwave_Room
{
    public class Applicant
    {
        string firstName;
        public string FirstName { get { return firstName; } }
        string lastName;
        public string LastName { get { return lastName; } }
        string major;
        public string Major { get { return major; } }
        public DateTime expGrad = new DateTime();

        string email;
        public string Email { get { return email; } }

        string phoneNum;

        public Applicant(string firstName, string lastName, string major, DateTime expGrad, string email)
        {
            FirstName = FN;

        }

        private string SetPhoneNum()
        {
            return "0";
        }
    }
}