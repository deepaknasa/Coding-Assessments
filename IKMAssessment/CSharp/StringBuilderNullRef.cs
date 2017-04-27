using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKMAssessment.CSharp
{
    class StringBuilderNullRef
    {
        public void Init()
        {
            try
            {
                StringBuilder text1 = new StringBuilder("John");
                //Console.WriteLine(text1.GetHashCode().ToString());
                StringBuilder text2 = new TextAdder().addText(ref text1);
                Console.WriteLine(text2);
                Console.WriteLine(text1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().ToString());
            }
        }
    }

    class TextAdder
    {
        public StringBuilder addText(ref StringBuilder inputString)
        {
            //Console.WriteLine(inputString.GetHashCode().ToString());
            inputString.Append("Text");
            StringBuilder returnValue = new StringBuilder(inputString.ToString());
            inputString = null;
            return returnValue;
        }
    }
}
