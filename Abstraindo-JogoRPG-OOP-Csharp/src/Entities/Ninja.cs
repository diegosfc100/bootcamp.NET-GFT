namespace Abstraindo_JogoRPG_OOP_Csharp.src.Entities
{
    // class Ninja q herda a classe Hero
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType, int HPmin, int HPmax, int MPmin, int MPmax) : base(Name, Level, HeroType, HPmin, HPmax, MPmin, MPmax)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HPmin = HPmin;
            this.HPmax = HPmax;
            this.MPmin = MPmin;
            this.MPmax = MPmax;  
        }

        // sobrecrevendo comportamento padrão
        public override string Attack(){
            return this.Name + " Atacou com a sua Adaga.";
        }
    }
}

