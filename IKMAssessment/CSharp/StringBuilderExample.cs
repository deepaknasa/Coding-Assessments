using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKMAssessment.CSharp
{
    class StringBuilderExample
    {
        public void Init()
        {
            String string1 = "one";
            String string2 = "one";
            StringBuilder stringBuilder1 = new StringBuilder("one");
            StringBuilder stringBuilder2 = new StringBuilder("one");
            List<object> list = new List<object>();
            list.Add(string1);
            list.Add(stringBuilder1);
            Console.WriteLine(list.Contains(string2));
            Console.WriteLine(list.Contains(stringBuilder2));
            Console.WriteLine(list.Contains(stringBuilder2.ToString()));
        }
    }
}
