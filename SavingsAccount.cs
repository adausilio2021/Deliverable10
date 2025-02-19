﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CD_Account_Test
{
    class SavingsAccount
    {
        //feilds
        private string _accountNumber;
        private decimal _interestRate;
        private decimal _balance;

        //Constructor
        public SavingsAccount()
        {
            _accountNumber = "";
            _interestRate = 0;
            _balance = 0;
        }

        //AccountNumber Prop
        public string AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }
        //InterestRate Prop
        public decimal InterestRate
        {
            get { return _interestRate; }
            set { _interestRate = value; }
        }

        //Balance Prop
        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

    }
}
