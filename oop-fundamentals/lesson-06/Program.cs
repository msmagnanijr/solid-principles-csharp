namespace lesson_06
{
    class Program
    {
        static void Main(string[] args)
        {

            TestRichCustomer();
            //TestAnemicCustomer();


        }

        private static void TestRichCustomer()
        {
            RichCustomer richCustomer = new RichCustomer(-1, "John", "London");
            System.Console.WriteLine($"Id: {richCustomer.Id}");
        }

        private static void TestAnemicCustomer()
        {
            AnemicCustomer anemicCustomer = new AnemicCustomer();
            anemicCustomer.Id = -1;
            anemicCustomer.Name = "";
            anemicCustomer.Address = null;
            System.Console.WriteLine($"{anemicCustomer.Id} {anemicCustomer.Name} {anemicCustomer.Address}");
        }
    }
}