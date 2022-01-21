namespace Abstraindo_JogoRPG_OOP_Csharp.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType, int HPmin, int HPmax, int MPmin, int MPmax) : base(Name, Level, HeroType, HPmin, HPmax, MPmin, MPmax)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HPmin = HPmin;
            this.HPmax = HPmax;
            this.MPmin = MPmin;
            this.MPmax = MPmax;  
        }

    }
}

