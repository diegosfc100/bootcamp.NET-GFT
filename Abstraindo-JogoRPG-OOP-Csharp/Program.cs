using Abstraindo_JogoRPG_OOP_Csharp.src.Entities;

    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight", 444, 486, 768, 778);
            Wizard wizard = new Wizard("Thanos", 99, "Devil", 369, 410, 845, 976);
            Ninja scarlet = new Ninja("Scarlet", 80, "Ninja", 330, 350, 715, 799);

            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack(7));
            Console.WriteLine(scarlet);

        }
    }

