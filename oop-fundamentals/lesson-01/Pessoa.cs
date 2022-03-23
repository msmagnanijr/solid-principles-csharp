namespace first_project
{
    class Pessoa
    {
        public string? Nome;
        public int Idade;
        public string? Genero;

        public void Identificar()
        {
            System.Console.WriteLine($"Olá, eu sou {Nome} e tenho {Idade} anos e sou do sexo {Genero}");
        }
    }
}