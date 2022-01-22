using System;

namespace OOP_Csharp.Models
{
    public class Pessoa
    {
        public string Nome {get;set;} // Atributo
       
        public int Idade {get;set;} // Atributo

        public virtual void Apresentar() // Método
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos");
        }
    }
}