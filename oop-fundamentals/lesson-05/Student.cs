namespace lesson_05
{
    class Student
    {
        private string name { get; set; }
        private int age { get; set; }
        private string genre { get; set; }

        public Student(string name)
        {
            this.Name = name;
        }

        public string Name { get; }

        public string Genre
        {
            set
            {
                if (value != "M" && value != "F")
                {
                    throw new ArgumentOutOfRangeException("Genre", "Genre must be M or F");
                }
                genre = value;
                System.Console.WriteLine("Genre set to " + value);
            }

        }
        public int Age
        {
            set
            {
                if (value < 18)
                {
                    throw new ArgumentOutOfRangeException("Age", "Age must be greater than 18");
                }
                age = value;
                System.Console.WriteLine("Age set to " + value);
            }
        }
    }
}