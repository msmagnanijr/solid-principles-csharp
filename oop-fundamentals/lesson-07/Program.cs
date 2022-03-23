namespace lesson_07
{
    class Program
    {
        static public int Sum(int number01, int number02)
        {
            return number01 + number02;
        }

        static public double Sum(double number01, double number02)
        {
            return number01 + number02;
        }

        static public double Sum(double number01, double number02, double number03)
        {
            return number01 + number02 + number03;
        }

        static public int Sum(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }
        static void Main(string[] args)
        {

            var result = Sum(1.2, 2.1, 3.2);
            Console.WriteLine(result);

            var result2 = Program.Sum(new int[] { 1, 2, 3, 4, 5 });
            Console.WriteLine(result2);
        }
    }
}