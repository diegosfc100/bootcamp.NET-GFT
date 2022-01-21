using Abstraingo_JogoRPG_OOP_Csharp.src.Entities;

    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Thanos", 99, "Devil");

            Console.WriteLine(hero.Attack());
            Console.WriteLine(wizard.Attack());
        }
    }

