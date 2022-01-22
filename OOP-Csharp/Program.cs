using OOP_Csharp.Models;

class Program
{
    static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa(); // Objeto p1 do tipo Pessoa

        p1.Nome = "João";
        p1.Idade = 30;
        p1.Apresentar();
        

        /* Encapsulamento */

        Retangulo r1 = new Retangulo();
        // r.comprimento = 20; Esse código gera erro devido o atributo ser privado e não poder ser alterado dessa forma.
        r1.DefinirMedidas(10, 10); // Valores válidos
        Console.WriteLine($"Área: {r1.ObterArea()}");

        Retangulo r2 = new Retangulo();
        r2.DefinirMedidas(0, -10); // Valores inválidos
        Console.WriteLine($"Área: {r2.ObterArea()}");           
    }
}
