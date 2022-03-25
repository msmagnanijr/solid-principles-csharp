namespace Lesson17
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            System.Console.WriteLine(calc.Add(1, 2));
            System.Console.WriteLine(calc.Add(1.5, 2.5));
            System.Console.WriteLine(calc.Add());
            System.Console.WriteLine(calc.Add(1, 2, 3));
            System.Console.WriteLine(calc.Add(1, 2, 3, 4));
            System.Console.WriteLine(calc.Add(500));
        }
    }

    class Calc
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public string Add()
        {
            return "none of the parameters were passed";
        }

        public int Add(int a, int b = 0, int c = 0, int d = 0)
        {
            return a + b + c + d;
        }
    }
}