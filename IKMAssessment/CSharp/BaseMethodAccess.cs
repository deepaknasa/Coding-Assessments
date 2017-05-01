using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKMAssessment.CSharp
{
    class BaseMethodAccess
    {
        public static void Init()
        {

        }
    }

    class ClassA
    {
        protected int calculateCount1()
        {
            return 10;
        }

        private int calculateCount2()
        {
            return 10;
        }

        public int calculateCount3()
        {
            return 10;
        }
    }

    class ClassB : ClassA
    {
        public void MyMethod()
        {
            base.calculateCount1();
            //base.calculateCount2();
            base.calculateCount3();
        }
    }
}
