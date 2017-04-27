using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKMAssessment.CSharp
{
    public delegate void MyActionHandler(List<int> list);
    class ActionHandler
    {
        public event MyActionHandler OnMyMethod;
        public ActionHandler() { }

        public void Init()
        {
            try
            {
                Processor processor = new Processor();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().ToString());
            }

            Console.ReadLine();
        }

        public void Execute()
        {
            OnMyMethod(new List<int>());
        }
    }

    class Processor
    {
        public Processor()
        {
            ActionHandler program = new ActionHandler();
            program.OnMyMethod += new MyActionHandler(Method1);
            program.Execute();
            program.OnMyMethod += new MyActionHandler(Method2);
            program.OnMyMethod += new MyActionHandler(Method3);
            //program.OnMyMethod(new List<int>());
            program.Execute();
        }

        public void Method1(List<int> list) { Console.WriteLine("In method1"); }
        public void Method2(List<int> list) { Console.WriteLine("In method2"); }
        public void Method3(List<int> list) { Console.WriteLine("In method3"); }
    }
}
