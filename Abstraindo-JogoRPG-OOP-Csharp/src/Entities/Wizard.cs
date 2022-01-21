namespace Abstraindo_JogoRPG_OOP_Csharp.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType, int HPmin, int HPmax, int MPmin, int MPmax) : base(Name, Level, HeroType, HPmin, HPmax, MPmin, MPmax)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HPmin = HPmin;
            this.Name = Name;
            this.HPmax = HPmax;
            this.MPmin = MPmin;
            this.MPmax = MPmax;  
        }

        public override string Attack(){
            return this.Name + " lançou magia";
        }  

        public string Attack(int Bonus){
            
            if(Bonus > 6){
                return this.Name + " lançou magia super afetiva com bonus de " + Bonus;
            }else{
                return this.Name + " lançou magia com bonus de ataque de " + Bonus;
            }            
        }      
    }
}