namespace first_project
{
    class Pessoa
    {
        public string? Nome;
        public int Idade;
        public string? Genero;


        //ctor
        /*public Pessoa()
        {
            Nome = "Mauricio";
            Idade = 40;
            Genero = "Masculino";
        }*/

        public Pessoa() { }

        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public Pessoa(string nome, int idade, string genero)
        {
            Nome = nome;
            Idade = idade;
            Genero = genero;
        }

        public void Identificar()
        {
            //cw
            System.Console.WriteLine($"Olá, eu sou {Nome} e tenho {Idade} anos e sou do sexo {Genero}");
        }
    }
}