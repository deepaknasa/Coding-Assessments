using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKMAssessment.CSharp
{
    class DynamicKeyword
    {
        public static void Init()
        {
            Random r = new Random();
            dynamic next = r.Next();

            Console.WriteLine(next);
        }
    }
}
