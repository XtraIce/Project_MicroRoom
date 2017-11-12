using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace Microwave_Room
{
    public class Recruiter
    {
        public string Name
        {
            get { { return Name; } }
            private set { { Name = value; } }
        }
        public int ? PhoneNumber
        {
            get { { return PhoneNumber; } }
            private set { { PhoneNumber = value; }}
        }
        public string Email
        {
            get { return Email; }
            private set { Email = value; }
        }

        //default constructor
        public Recruiter()
        {
            Name = "";
            Email = "";
            PhoneNumber = null;
        }

        //explicit value constructor
        public Recruiter(string name, string email, int phoneNumber)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
        }        
    }
}