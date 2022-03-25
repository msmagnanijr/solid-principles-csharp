namespace Lesson15
{
    class Vehicle
    {
        public Vehicle()
        {
            Console.WriteLine("Vehicle constructor");
        }

        public Vehicle(int speed)
        {
            this.Speed = speed;
            Console.WriteLine("Vehicle constructor with speed");
            System.Console.WriteLine("Speed: {0}", this.Speed);
        }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }

        public virtual void PrintData()
        {
            System.Console.WriteLine("Method of Vehicle");
        }
    }
}