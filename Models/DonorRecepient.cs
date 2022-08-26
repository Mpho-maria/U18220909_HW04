using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace U18220909_HW004.Models
{


    public class DonorRecepients : Donation
    {


        private long _IdNumber;
        private string _Address;


        public DonorRecepients(int PhoneNumber, long IdNumber, string FirstName, string LastName, string Email, string Address) : base(PhoneNumber, FirstName, LastName, Email)
        {

            _IdNumber = IdNumber;
            _Address = Address;

        }

        public long IdNumber
        {

            get { return _IdNumber; }
            set { _IdNumber = value; }
        }
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }
        public override string getInfo()
        {
            return base.getInfo();
        }
    }
}
