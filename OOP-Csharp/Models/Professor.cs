namespace OOP_Csharp.Models
{
    public class Professor : Pessoa // Classe Professor herda classe Pessoa
    {
        public double Salario { get; set; }

        public sealed override void Apresentar() // Método Selado - Não pode ser herdado por mais nenhuma classe filha.
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e sou professor, e ganho {Salario}");
        }
    }
}