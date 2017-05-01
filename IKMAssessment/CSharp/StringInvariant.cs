using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKMAssessment.CSharp
{
    class StringInvariant
    {
        public static void Init()
        {
            String myString = "New York";
            myString.ToUpper();
            myString.ToLowerInvariant();
            myString += "er";
            Console.WriteLine(myString);
        }
    }
}
