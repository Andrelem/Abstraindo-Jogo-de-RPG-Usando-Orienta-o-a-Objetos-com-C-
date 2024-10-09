using System;
using Abstraindo_Jogo_de_RPG_Usando_Orienta_o_a_Objetos_com_C_;

namespace Abstraindo_Jogo_de_RPG_Usando_Orienta_o_a_Objetos_com_C_
{
    public class Wizard : Hero
    {

        public Wizard(string Name, int Level, String HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack(){
            return this.Name + " lançou magia";
        }

        public string Attack(int Bonus)
        {
            if(Bonus > 6)
            {
                return this.Name + " lançou magia super afetiva de " + Bonus;
            }
            else
            {
                return this.Name + " lançou uma magia com força fraca de " + Bonus;
            }
        }
    }
}