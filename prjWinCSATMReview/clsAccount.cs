using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjWinCSATMReview
{
    public class clsAccount
    {
        //Private and encapsulate variable wich store the values of the properties
        private string vNumber;
        private string vType;
        private System.DateTime vOdate;
        private decimal vBalance;
        private string vStatus;

        //parametrized Constructor
        public clsAccount(string Number, string Type, int Day, int Month, int Year, decimal Balance, string Status)
        {
            this.Number = Number;
            this.vType = Type;
            this.OpenDate = new DateTime(Year, Month, Day); 
            this.Balance = Balance;
            this.vStatus = Status;
        }

        public clsAccount()
        {
            vNumber = "Not Defined";
            vType = "Not Defined";
            vOdate = DateTime.Now;
            vBalance = 0;
            vStatus = "Not Defined";
        }





        public decimal Balance
        {
            get { return vBalance; }
            set { vBalance = value; }
        }

        public string Number
        {
            get { return vNumber; }
            set { vNumber = value; }
        }

        public System.DateTime OpenDate
        { 
            get { return vOdate; } 
            set { vOdate = value; } 
        }



    }
}