using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace U18220909_HW004.Models
{
    public abstract class Donation
    {
        private int _PhoneNumber;
        private string _FirstName;
        private string _LastName;
        private string _Email;


        public Donation(int phonenumber, string FirstName, string lastname, string email)
        {
            _PhoneNumber = phonenumber;
            _FirstName = FirstName;
            _LastName = lastname;
            _Email = email;
        }
        public int PhoneNumber
        {

            get { return _PhoneNumber; }
            set { _PhoneNumber = value; }


        }
        public string FirstName
        {

            get { return _FirstName; }
            set { _FirstName = value; }
        }

        public string LastName
        {

            get { return _LastName; }
            set { _LastName = value; }
        }
        public string Email
        {

            get { return _Email; }
            set { _Email = value; }
        }
        public virtual string getInfo()
        {
            return FirstName + LastName + "contact me on" + PhoneNumber.ToString() + "or send email to" + Email;
        }
    }
}