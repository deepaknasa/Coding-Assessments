using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKMAssessment.CSharp
{
    class StaticMethodAccessFromConstructor
    {
        public static void Init()
        {

        }
    }

    public class Account
    {
        public Account(int accountNumber)
        {
            Account.CheckValidNumber(accountNumber);
            CheckValidNumber(accountNumber);
        }
        public static void CheckValidNumber(int accountNumber)
        {

        }
    }
}
