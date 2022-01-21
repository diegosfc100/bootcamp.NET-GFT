using System;

namespace Abstraindo_JogoRPG_OOP_Csharp.src.Entities
{ 
    // Classe abstrata
    public abstract class Hero
    {
        // Método Construtor com as características
        public Hero(string Name, int Level, string HeroType, int HPmin, int HPmax, int MPmin, int MPmax)
        {
            this.Name = Name; 
            this.Level = Level;
            this.HeroType = HeroType;  
            this.HPmin = HPmin;
            this.HPmax = HPmax;
            this.MPmin = MPmin;
            this.MPmax = MPmax;          
        }

        public string Name;
        public int Level;
        public string HeroType;
        public int HPmin;
        public int HPmax;
        public int MPmin;
        public int MPmax;



        public override string ToString()
        {
            return "Name: " + this.Name + " | Level: " + this.Level + " | HeroType: " + this.HeroType + " | HP: " + this.HPmin + " / " +  this.HPmax + " | MP: " + this.MPmin + " / " +  this.MPmax;
        }

        public virtual string Attack()
        {
            return this.Name + " atacou com a sua espada";
        }

    }

}