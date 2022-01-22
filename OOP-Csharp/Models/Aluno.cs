namespace OOP_Csharp.Models
{
    public class Aluno : Pessoa // Classe aluno herda Classe pessoa
    {
        public int Nota { get; set; }

        public override void Apresentar() // Método
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e sou um aluno nota {Nota}");
        }
    }
}