using OOP_Csharp.Models;

class Program
{
    static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa(); // Objeto p1 do tipo Pessoa

        p1.Nome = "João";
        p1.Idade = 30;

        p1.Apresentar();
    }
}
