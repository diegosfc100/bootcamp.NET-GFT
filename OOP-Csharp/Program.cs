using OOP_Csharp.Models;

class Program
{
    static void Main(string[] args)
    {
        /* Abstração */

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


        /* Herança */
        Aluno p2 = new Aluno();
        p2.Nome = "Diego";
        p2.Idade = 31;
        p2.Apresentar();

        Professor p3 = new Professor();
        p3.Nome = "Girafales";
        p3.Idade = 90;
        p3.Apresentar();


        /* Polimorfismo em tempo de execução*/
        Aluno p4 = new Aluno();
        p4.Nome = "José";
        p4.Idade = 35;
        p4.Nota = 10;
        p4.Apresentar();

        /* Polimorfismo em tempo de compilação */
        Calculadora calc = new Calculadora();
        // Dependendo da quantidade de parametros vc passar, o método vai identificar qual chamar.
        Console.WriteLine("Resultado da primeira soma: " + calc.Somar(100, 30));
        Console.WriteLine("Resultado da segunda soma: " + calc.Somar(100, 30, 15));


        /* Classes abstratas */
        // Conta conta = new Conta(); Por ser abstrata não é possível criar uma instacia dela, pois ela serve pra ser modelo.

        Corrente c1 = new Corrente(); // Corrente instanciada
        c1.Creditar(1000);

        c1.ExibirSaldo();

    }
}
