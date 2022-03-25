namespace Lesson15
{
    class Car : Vehicle
    {
        public Car()
        {
            Console.WriteLine("Car constructor");
        }

        public Car(int speed) : base(speed)
        {
            Console.WriteLine("Car constructor with speed");
            System.Console.WriteLine("Speed: {0}", this.Speed);
        }
        public string CarType { get; set; }

        public override void PrintData()
        {
            base.PrintData();
            System.Console.WriteLine("Method of Car");
        }
    }
}