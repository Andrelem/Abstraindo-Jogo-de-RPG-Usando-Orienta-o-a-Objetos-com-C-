using System;
using Abstraindo_Jogo_de_RPG_Usando_Orienta_o_a_Objetos_com_C_;

namespace Abstraindo_Jogo_de_RPG_Usando_Orienta_o_a_Objetos_com_C_
{
    public class Monster : Hero
    {

        public Monster(string Name, int Level, String HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack(){
            return this.Name + "Atacou com pata";
        }

        public string Attack(int Bonus){
            if(Bonus > 6)
            {
                return this.Name + "Atacou com efetividade de " + Bonus;
            }
            else
            {
                return this.Name + "Atacou com a pata e deu o critico de " + Bonus;
            }
        }

    }
}