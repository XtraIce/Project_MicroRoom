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
        public string FirstName { get { return FirstName; } private set { FirstName = value; } }

        public string LastName { get { return LastName; } private set { LastName = value; } }

        public string Major { get { return Major; } private set { Major = value; } }
        public DateTime ? ExpGrad = new DateTime();

        public string Email { get { return Email; } private set { Email = value; } }

        public Applicant(string firstName, string lastName, string major, DateTime expGrad, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Major = major;
            ExpGrad = expGrad;
            Email = email;
        }

        public Applicant()
        {
            FirstName = "";
            LastName = "";
            Major = "";
            ExpGrad = null;
            Email = "";
        }
    }
}