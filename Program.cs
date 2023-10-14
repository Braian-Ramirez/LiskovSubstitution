namespace LiskovSubstitutionPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 5, 7, 9, 8, 1, 6, 4 };
            AddCalculate addition = new AddCalculator(numbers);
            Console.WriteLine($"The sum of all the numbers: {addition.Calculate()}");
            Console.WriteLine();
            AddCalculate evenAddition = new EvenNumbersAddCalculator(numbers);
            Console.WriteLine($"The sum of all the even numbers: {evenAddition.Calculate()}");
            AddCalculate oddAddition = new OddNumbersAddCalculator(numbers);
            Console.WriteLine($"The sum of all the even numbers: {oddAddition.Calculate()}");
        }
    }
}