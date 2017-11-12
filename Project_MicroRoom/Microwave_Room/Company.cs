using System;
using System.Collections.Generic;
using System.Text;

namespace Microwave_Room
{
    public class Company
    {
        public string CompanyName
        {
            get { return CompanyName; }
            private set { CompanyName = value; }
        }

        public string WebsiteURL
        {
            get { return WebsiteURL; }
            private set { WebsiteURL = value; }
        }

        public string CompanyInfo
        {
            get { return CompanyInfo; }
            private set { CompanyInfo = value; }
        }

        //default constructor
        public Company()
        {
            CompanyName = "";
            WebsiteURL = "";
            CompanyInfo = "";
        }

        //explicit value constructor
        public Company(string company, string siteURL, string companyinfo)
        {
            CompanyName = company;
            WebsiteURL = siteURL;
            CompanyInfo = companyinfo;
        }
    }
}
