using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace U18220909_HW004.Models
{
    public class Partners : Donation
    {


        private string _CompanyName;

        private int _TradingLicence;
        private string _ContributionType;

        public Partners(int PhoneNumber, string FirstName, string LastName, string CompanyName, string Email, int TradingLicence, string ContributionType) : base(PhoneNumber, FirstName, LastName, Email)
        {

            _CompanyName = CompanyName;

            _TradingLicence = TradingLicence;
            _ContributionType = ContributionType;
        }

        public string CompanyName
        {

            get { return _CompanyName; }
            set { _CompanyName = value; }
        }

        public int TradingLicence
        {

            get { return _TradingLicence; }
            set { _TradingLicence = value; }
        }

        public string ContributionType
        {

            get { return _ContributionType; }
            set { _ContributionType = value; }
        }
        public override string getInfo()
        {
            return base.getInfo();
        }
    }
}
