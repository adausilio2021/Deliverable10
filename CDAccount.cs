using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CD_Account_Test
{
    class CDAccount:SavingsAccount
    {
        //Feild
        private string _maturityDate;

        //Constructor
        public CDAccount()
        {
            _maturityDate = "";
        }

        //MaturityDate Prop
        public string MaturityDate
        {
            get { return _maturityDate; }
            set { _maturityDate = value; }
        }


    }
}
