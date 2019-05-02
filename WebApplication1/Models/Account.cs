using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{




    public class AccountModel
    {


        public enum AccountClass
        {
            Equity,
            Asset,
            Liability,
            Expense,
            Revenue
        }

        public enum AccountNature
        {
            Credit,
            Debit,
            DR = Debit,
            CR = Credit

        }



        public int Id { get; set; }

        public AccountClass AccType { get; set; }

        public decimal AccountBalance { get; set; }

        public AccountNature BalCrDr { get; set; }

        public string AccountHolder { get; set; }

        public DateTime NewestTransaction { get; set; }








    }

}
