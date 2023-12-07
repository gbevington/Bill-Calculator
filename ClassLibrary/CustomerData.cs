using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Fixed
{ 
    public class Customer
    {   // Customer Account Number
        public int AccountNum { get; set; }
        //Customer first name
        public string FirstName { get; set; }
        //Customer last name
        public string LastName { get; set; }
        //Number of kWh used by customer
        public decimal NumberOfKwh { get; set; }
        // Amount billed to customer
        public decimal BillAmount { get; set; }

        // Customer constructor
        public Customer(int accNum, string fName, string lName, decimal kwhNum, decimal billNum)
        {
            this.AccountNum = accNum;
            this.FirstName = fName;
            this.LastName = lName;
            this.NumberOfKwh = kwhNum;
            this.BillAmount = CalculateCharge(kwhNum);
        }

        // Calculate how much a customer will be billed
        public static decimal CalculateCharge(decimal NumberOfKwh)
        {
            // customer is billed a $12 administrative charge, after which they are billed at a rate of seven cents per kWh 
            decimal charge = 12m + (NumberOfKwh * 0.07m);
            if (NumberOfKwh <= 0)
            {
                return 0;
            }
            return charge;
        }

        // Returns a string with information to display in form listbox
        public override string ToString()
        {
            return $"{AccountNum} - {LastName}, {FirstName}, {NumberOfKwh}, {BillAmount}";
        }

    }

}