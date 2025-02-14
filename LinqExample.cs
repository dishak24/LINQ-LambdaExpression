using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaLinq
{
    internal class LinqExample
    {
        int[] IntArray = { 10, 20, 30, 40, 70, 50, 60, 70, 80, 90, 80, 100 };

        public void PerformWhere()
        {
            var result = IntArray.Where(a => a < 40);//Method 

            Console.WriteLine("Numbers less than 40 are : ");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine();

            Console.WriteLine("Number divide by 3 are :");
            var result1 = (from num in IntArray 
                           where num % 3 == 0
                           select num);

            foreach (var n in result1)
            {
                Console.WriteLine(n);
            }
        }
    }
}
