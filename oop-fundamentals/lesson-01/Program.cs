namespace first_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            pessoa1.Nome = "Mauricio";
            pessoa1.Idade = 33;
            pessoa1.Genero = "Masculino";
            pessoa1.Identificar();
        }
    }
}