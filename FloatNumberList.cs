using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaLinq
{
    internal class FloatNumberList
    {
        List<float> fList = new List<float> 
        {
            6.9f,
            12.8f,
            5.00f,
            81.94f,
            58.9f,
            77.09f,
            0.02f
        };

        public void CalculateAverage()
        {
            var avg = fList.Average();
            Console.WriteLine($"Average of Floating point number List = {avg}");
        }

    }
}
