namespace Lesson12
{
    class Program
    {
        static void Main(string[] args)
        {
            //valid

            string studentName = "Mauricio";
            int age = 10;
            int Age = 20;
            double _tax = 0.1;
            int number_example = 1;
            double y2 = 1.0;
            string cy2_m6 = "example";
            var \u0043example = "example";

            //invalid
            /*bool is#Valid = true;
            int decimal = 1.0;
            string 1year = "1";
            string #name = "Mauricio";
            int age@ = 10;*/

        }
    }

    class CalcDiscount
    {
        double internationaDiscount = 0.1;
        public int Tax { get; set; }
        public static double CalculateDiscount(double producPrice, double discount)
        {
            return 0.1;
            //return price - (price * discount);
        }
    }
}