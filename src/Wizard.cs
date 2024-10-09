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
            return this.Name + "Lançou magia";
        }

        public string Attack(int Bonus)
        {
            if(Bonus > 6)
            {
                return this.Name + "Lançou magia super afetiva com bonus de " + Bonus;
            }
            else
            {
                return this.Name + "Lançou uma magia com força fraca com critico de " + Bonus;
            }
        }
    }
}