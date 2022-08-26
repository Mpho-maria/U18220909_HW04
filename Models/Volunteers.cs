using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace U18220909_HW004.Models
{
    public class Volunteers : Donation
    {


        private long _IdNumber;
        private string _chosenSlot;
        private string _VolunteerType;

        public Volunteers(int PhoneNumber, long IdNumber, string FirstName, string LastName, string Email, string chosenSlot, string VolunterType) : base(PhoneNumber, FirstName, LastName, Email)
        {

            _IdNumber = IdNumber;
            _chosenSlot = chosenSlot;
            _VolunteerType = VolunterType;
        }

        public long IdNumber
        {

            get { return _IdNumber; }
            set { _IdNumber = value; }
        }
        public string chosenSlot
        {

            get { return _chosenSlot; }
            set { _chosenSlot = value; }
        }
        public string VolunteerType
        {

            get { return _VolunteerType; }
            set { _VolunteerType = value; }
        }
        public override string getInfo()
        {
            return base.getInfo();
        }

    }
}