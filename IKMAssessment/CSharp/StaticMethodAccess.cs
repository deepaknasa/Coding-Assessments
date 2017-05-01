using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKMAssessment.CSharp
{
    class StaticMethodAccess
    {
        public static void Init()
        {
            try
            {
                Console.WriteLine(MyClass.MyMethod());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().ToString());
            }
        }
    }

    public static class MyClass
    {
        static MyClass()
        {
            throw new Exception();
        }

        public static string MyMethod()
        {
            return "Hello World";
        }
    }
}
