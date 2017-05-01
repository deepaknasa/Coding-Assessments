using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKMAssessment.CSharp
{
    class StringOutput
    {
        public static void Init(string question = "1")
        {
            switch (question)
            {
                case "1":
                    Question1();
                    break;
                case "33":
                    Question33();
                    break;
            }
        }

        public static void Question1()
        {
            String myString = "ABCDEF";

            //myString[1] = 'X';
            //myString[3] = 'X';

            Console.WriteLine(myString);
        }

        public static void Question33()
        {
            Console.WriteLine(Adder.AddNumbers("1", "Two"));
        }
    }

    public class Adder
    {
        public static String AddNumbers(String first, String second)
        {
            int firstInt = 0, secondInt = 0;
            try
            {
                return Int32.TryParse(first, out secondInt).ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception");
            }
            return secondInt.ToString();
        }
    }
}
