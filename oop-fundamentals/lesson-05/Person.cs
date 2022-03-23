namespace lesson_05
{
    class Person
    {

        //public string Name { get; set; }
        private int age;
        public int Age
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Age", "Age cannot be negative");
                }
                age = value;
            }
            get
            {
                return age;
            }
        }
        //public string Name { get; }

        /*private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }*/
    }
}