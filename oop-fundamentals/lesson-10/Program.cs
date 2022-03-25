namespace lesson_10
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(Calc.Add(1, 2));

            Calc calc = new Calc();
            System.Console.WriteLine(calc.Divide(10, 2));
        }
    }
}