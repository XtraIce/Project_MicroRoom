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
        public DateTime ? ExpGrad { get { return ExpGrad; }  private set { ExpGrad = value; } }
        public string Email { get { return Email; } private set { Email = value; } }
        public int ? PhoneNumber { get { return PhoneNumber; } private set { PhoneNumber = value; } }
        public string LinkedInLink { get { return LinkedInLink; } private set { LinkedInLink = value; } }
        public string GitHubLink { get { return GitHubLink; } private set { LinkedInLink = value; } }
        public string WebSiteLink { get { return WebSiteLink; } private set { WebSiteLink = value; } }

        public Applicant(string firstName, string lastName, string major, DateTime expGrad, string email, int phoneNumber, 
                                                    string LinkedInLink = "", string GitHubLink = "", string WebsiteLink = "")
        {
            FirstName = firstName;
            LastName = lastName;
            Major = major;
            ExpGrad = expGrad;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public Applicant()
        {
            FirstName = "";
            LastName = "";
            Major = "";
            ExpGrad = null;
            Email = "";
            PhoneNumber = null;
            LinkedInLink = "";
            GitHubLink = "";
            WebSiteLink = "";
        }
    }
}