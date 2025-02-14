using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaLinq
{
    internal class StringLinq
    {
        List<string> nameList = new List<string>
        {
            "Disha", 
            "Asmita", 
            "Pawan", 
            "Atharv", 
            "Akash", 
            "Pooja", 
            "Pratibha"
        };

        List<string> emailList = new List<string>
        {
            "Disha@gmail.com",
            "Asmita@gmail.in",
            "Pawan@gmail.com",
            "Atharv@yahoo.com",
            "Akash@bl.in",
            "Pooja@yahoo.com",
            "Pratibha@out.in"
        };

//----------------------------------------------- Basic Level Methods ---------------------------------------------------------
        public void StringStartWith()
        {
            var strResult = nameList.Where(str => str.StartsWith("A")).ToList();
            Console.WriteLine("Strings which are starts with 'A' : ");
            strResult.ForEach(print => Console.Write(print + " "));
            Console.WriteLine();
            Console.WriteLine();
        }

        public void CountString()
        {
            Console.WriteLine("Count of strings which having more than 5 characters : ");
            var count = nameList.Where(str => str.Count() > 5).ToList();
            count.ForEach(print => Console.Write(print + " "));
            Console.WriteLine();
            Console.WriteLine();
        }

        public void StringEndWith()
        {
            Console.WriteLine("Strings which are ends with '.com' : ");
            var result = emailList.Where( s => s.EndsWith(".com")).ToList();
            result.ForEach(print => Console.Write( print + " "));
            Console.WriteLine();
            Console.WriteLine();
        }

//--------------------------------------Intermediate Level Methods----------------------------------------------------------------


        public void GroupByFirstLetter()
        {
            var group = nameList.GroupBy(name => name[0]).ToList();
            foreach (var str in group)
            {
                Console.WriteLine($"Group by name with First letter : ");
                foreach (var letter in str)
                {
                    Console.WriteLine(letter);
                }
                Console.WriteLine();

            }
        }

        public void FindLongestString()
        {
            var str = nameList.OrderByDescending(s => s.Length).FirstOrDefault();
            Console.WriteLine($"The Longest String : {str}");
            Console.WriteLine();
        }
    }
}
