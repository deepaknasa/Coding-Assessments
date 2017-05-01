using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKMAssessment.CSharp
{
    class IncrementOperator
    {
        public static void Init()
        {
            int a = 1, b = 2;
            if (++a == 1)
            {
                Console.WriteLine(a++ + b * 2);
            }
            else
            {
                Console.WriteLine(a-- * b);
            }
        }
    }
}
