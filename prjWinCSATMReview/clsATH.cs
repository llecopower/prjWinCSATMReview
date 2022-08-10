using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjWinCSATMReview
{
    public class clsATH
    {

        private decimal vBalance;
        private string vCompany;
        private string vLocation;
        private string vStatus;
        private string vNumber;
        private clsListClient vClients;


        public clsATH()
        {
            //The NotImplementedException() indicates the methos of property
            //that you are attempting to load or read has no implementation and provides
            //no functionaloty. As result, this will handle to you the errors on any try/catch block.
            //Instead of you remove the member from your code.
            throw new System.NotImplementedException();        
        }



        public decimal Balance
        {

            get => vBalance;
            set
            {
                vBalance = value;
            }

        }

        public string Company
        {

            get => vCompany;
            set
            {
                vCompany = value;
            }

        }

        public string Location
        {

            get => vLocation;
            set
            {
                vLocation = value;
            }

        }

        public string Number
        {

            get => vNumber;
            set
            {
                vNumber = value;
            }

        }

        public string Status
        {

            get => vStatus;
            set
            {
                vStatus = value;
            }

        }

        public clsListClient Clients
        {
            get => vClients;
            set
            {
                vClients= value;
            }

        }

        public void Open()
        { 
            throw new System.NotImplementedException();
        }

        public void Fill()
        {
            throw new System.NotImplementedException();
        }

        public void Close()
        {
            throw new System.NotImplementedException();
        }

        public void Display()
        {
            throw new System.NotImplementedException();
        }









    }
}