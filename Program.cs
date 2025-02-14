using LambdaLinq;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Lambda-LINQ Expression Practice !");
        Console.WriteLine();

        NumberLinq numberLinq = new NumberLinq();
        numberLinq.PrintEven();
        numberLinq.PrintGreaterNumber();
        numberLinq.PrintDescending();
        numberLinq.FindDistinctNumbers();
        numberLinq.FindMaxNumber();
        numberLinq.NumberSquare();
        numberLinq.CalculateOddSum();


        StringLinq stringLinq = new StringLinq();
        stringLinq.StringStartWith();
        stringLinq.CountString();
        stringLinq.StringEndWith();

        LinqExample linqExample = new LinqExample();
        linqExample.PerformWhere();


    }
}