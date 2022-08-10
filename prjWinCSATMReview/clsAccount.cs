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
            this.Type = Type;
            this.OpenDate = new DateTime(Year, Month, Day); 
            this.Balance = Balance;
            this.Status = Status;
        }

        public clsAccount()
        {
            Number = "Not Defined";
            Type = "Not Defined";
            OpenDate = DateTime.Now;
            Balance = 0;
            Status = "Not Defined";
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

        public string Type
        {
            get { return vType; }
            set { vType = value; }
        }

        public string Status
        {
            get { return vStatus; }
            set { vStatus = value; }
        }

        public bool Deposit(decimal Amount)
        {
            if (Amount <= 20000 && Amount >= 2)
            {
                Balance = Balance + Amount;
                //Balance += Amount;
                return true;
            }
            return false;      
        
        }

        public int Withdraw(decimal Amount)
        {

            if (Amount < 20) { return 2; }
            else if (Amount > 500) { return 1; }
            else if ((Amount % 20) != 0) { return -1; }
            else if (Amount > Balance) { return -2; }

            else
            {
                Balance = Balance - Amount;
                //Balance -= Amount;
            }           
            
            return 0;
        }


        public string Consult()
        {
            string info = "Number: " + Number + "\n";
            info += "Type: " + Type + "\n";
            info += "Open Date" + OpenDate.ToShortDateString() + "\n";
            info += "Status: " + Status + "\n";
            info += "Balance ($): " + Balance + "\n";
            return info;
        
        }





    }
}