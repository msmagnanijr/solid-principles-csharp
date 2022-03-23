namespace lesson_05
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Person person = new Person();
            person.Age = -1;
            System.Console.WriteLine(person.Age);*/

            Student student = new Student("John");
            student.Age = 50;
            student.Genre = "F";
            System.Console.WriteLine(student.Name);
        }
    }
}