namespace lesson_08
{
    class Program
    {

        static int Sum(int x, int y = 10, int z = 20, int w = 30)
        {
            return x + y + z + w;
        }

        static void Main(string[] args)
        {
            var result01 = Sum(1);
            var result02 = Sum(1, 2);
            var result03 = Sum(1, 2, 3);
            var result04 = Sum(1, 2, 3, 4);

            System.Console.WriteLine(result01);
            System.Console.WriteLine(result02);
            System.Console.WriteLine(result03);
            System.Console.WriteLine(result04);

        }
    }
}