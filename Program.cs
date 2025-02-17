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
        
        numberLinq.FindTopThreeNumbers();
        numberLinq.CheckAllPositive();
        numberLinq.FindNumberDivisible();
        numberLinq.CombineTwoLists();

        LinqExample linqExample = new LinqExample();
        linqExample.PerformWhere();

        StringLinq stringLinq = new StringLinq();
        stringLinq.StringStartWith();
        stringLinq.CountString();
        stringLinq.StringEndWith();

        stringLinq.GroupByFirstLetter();
        stringLinq.FindLongestString();

        FloatNumberList floatNumberList = new FloatNumberList();
        floatNumberList.CalculateAverage();

        EmployeeList employeeList = new EmployeeList();
        employeeList.FindSalary();
    }
}