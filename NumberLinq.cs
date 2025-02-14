using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaLinq
{
    internal class NumberLinq
    {
        List<int> intList = new List<int>() { 7, 9, 11, 55, 2, 80, 44, 2, 11, 7, 70, 9};

       public void PrintEven()
        {
            
            Console.WriteLine("Even Elements: ");
            List<int> evenNumbers = intList.FindAll( x => (x % 2 ==0));
            evenNumbers.ForEach(x => Console.Write(x + " "));
            Console.WriteLine();
            Console.WriteLine();

        }

        public void DisplayAll()
        {
            Console.WriteLine("Actual List Elements :");
            intList.ForEach(x => Console.WriteLine(x));
            Console.WriteLine();
            Console.WriteLine();

        }

        public void PrintDescending()
        {
            Console.WriteLine("List Elements in Descending Order :");
            var descending = intList.OrderByDescending( ele => ele ).ToList();
            descending.ForEach(x => Console.Write(x + " "));
            Console.WriteLine();
            Console.WriteLine();
        }

        public void PrintGreaterNumber()
        {
            var check = intList.Where(num => num > 50).ToList();
            Console.WriteLine("List having number > 50 :");
            check.ForEach(x => Console.Write(x + " "));
            Console.WriteLine();
            Console.WriteLine();
        }

        public void FindDistinctNumbers()
        {
            Console.WriteLine("Distinct Numbers only : ");
            //var distinct = intList.Select(num => num).Distinct().ToList(); ----- Another Way
            var distinct = intList.Distinct().ToList();
            distinct.ForEach(x => Console.Write(x + " "));
            Console.WriteLine();
            Console.WriteLine();

        }

        public void NumberSquare()
        {
            Console.WriteLine("Square List : ");
            var square = intList.Select(x => x * x).ToList();
            square.ForEach(x => Console.Write(x + " "));
            Console.WriteLine();
            Console.WriteLine();
        }

        public void FindMaxNumber()
        {
            int max = intList.Max();
            Console.WriteLine($"Max number in List is : {max} ");
            Console.WriteLine();
        }

        public void CalculateOddSum()
        {
            var sum = intList.Where(ele => (ele % 2 != 0)).Sum();
            Console.WriteLine("Sum of all Odd numbers = "+sum);
            Console.WriteLine();

        }

    }
}
