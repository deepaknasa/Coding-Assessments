using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKMAssessment.CSharp
{
    class ArrayOutput
    {
        public static void Init()
        {
            int[][] array = new int[][] {
                new int[] { 1,1,1 },
                new int[] { 1,1,2 },
                new int[] { 2,2,3 },
                new int[] { 2,2,2 }
            };

            try
            {
                for (int i = 0; i < array[0].Length; i++)
                {
                    for (int j = 0; j < array.Length; j++)
                    {
                        if (array[i][j] == 2)
                            continue;
                        else if (array[i][j] == 3)
                            break;
                        Console.WriteLine("{0}, {1}", i, j);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().ToString());
            }

            Console.ReadLine();
        }
    }
}
