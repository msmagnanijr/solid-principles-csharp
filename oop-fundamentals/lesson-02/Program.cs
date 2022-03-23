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

            Pessoa pessoa2 = new Pessoa("Paula", 20, "Feminino");
            pessoa2.Identificar();

            Pessoa pessoa3 = new Pessoa("João");
            pessoa3.Idade = 23;
            pessoa3.Genero = "Masculino";
            pessoa3.Identificar();


        }
    }
}