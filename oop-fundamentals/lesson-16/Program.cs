namespace Lesson16
{
    class Program
    {
        static void Main(string[] args)
        {
            /*UpCasting
            Cicle cicle = new Cicle();
            Shape shape = cicle;
            System.Console.WriteLine(shape == cicle);
            shape.Draw();
            cicle.Draw();
            cicle.PrintCircle();

            DownCasting
            Cicle cicle = new Cicle();
            Shape shape = cicle;
            Cicle cicle2 = (Cicle)shape;
            System.Console.WriteLine(shape == cicle);
            System.Console.WriteLine(cicle == cicle2);
            cicle2.PrintCircle();
            cicle2.Draw();*/

            //DowncastingAs
            Shape shape = new Cicle();
            Cicle cicle = shape as Cicle;
            if (cicle != null)
            {
                cicle.PrintCircle();
            }
            else
            {
                System.Console.WriteLine("Cicle is null");
            }

            //DowncastingIs
            Shape shape2 = new Cicle();
            if (shape2 is Cicle)
            {
                Cicle cicle2 = shape2 as Cicle;
                cicle2.PrintCircle();
            }
            else
            {
                System.Console.WriteLine("Cicle is null");
            }
        }
    }
}