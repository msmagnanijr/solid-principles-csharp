namespace assembly_01
{
    internal class PersonOne
    {
        internal string name;

        static void Main(string[] args)
        {
            PersonTwo personTwo = new PersonTwo();
            personTwo.name = "John";
            System.Console.WriteLine(personTwo.name);
        }
    }

}