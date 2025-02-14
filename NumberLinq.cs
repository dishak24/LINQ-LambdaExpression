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

//--------------------------------------Basic Level Methods----------------------------------------------------------------

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


    //--------------------------------------Intermediate Level Methods----------------------------------------------------------------
        public void FindTopThreeNumbers()
        {
            Console.WriteLine("Top 3 Numbers in List : ");
            var top = intList.OrderByDescending(num => num).Take(3).ToList();
            top.ForEach(x => Console.Write(x + " "));
            Console.WriteLine();
            Console.WriteLine();
        }

        public void CheckAllPositive()
        {
            Console.WriteLine("Check All elements in a list of integers are positive or not ? ");
            bool positive = intList.All(ele => ele >= 0);
            Console.WriteLine( positive ? "Yes, all positives" : "No, Not all positives!" );//ternary operator
            Console.WriteLine();
        }

        public void FindNumberDivisible()
        {
            var divisible = intList.FirstOrDefault(num => (num % 3 == 0 && num % 5 == 0));
            if (divisible != 0)
            {
                Console.WriteLine($"{divisible} is a 1st number divisible by 3 and 5. ");
            }
            else
            {
                Console.WriteLine("Number divisible by 3 and 5 is not available !!!! ");
            }
            Console.WriteLine();
        }

        public void CombineTwoLists()
        {
            List<int> newList = new List<int>() { 11, 22, 33, 44, 55};
            var combine = intList.Union(newList).ToList();
            Console.WriteLine("Combining 2 Lists without Duplicate :");
            combine.ForEach( n => Console.Write(n + " "));
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
