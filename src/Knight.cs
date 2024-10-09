using System;
using Abstraindo_Jogo_de_RPG_Usando_Orienta_o_a_Objetos_com_C_;

namespace Abstraindo_Jogo_de_RPG_Usando_Orienta_o_a_Objetos_com_C_
{
    public class Knight : Hero
    {

        public Knight(string Name, int Level, String HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack(){
                return this.Name + " atacou com sua espada";
        }

        public string Attack(int Bonus){
        if(Bonus > 6)
        {
            return this.Name + " atacou com espada e deu critico de " + Bonus;
        }
        else
        {
            return this.Name + " atacou com sua espada com dano de " + Bonus;
        }
        }

    }
}