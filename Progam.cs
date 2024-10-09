using System;
using Abstraindo_Jogo_de_RPG_Usando_Orienta_o_a_Objetos_com_C_;
using static System.Console;

namespace dotnet_poo
{
    class Progam
    {
         static void Main(string[] args)
         {
            Knight arus = new Knight("Arus", 20, "Knight");
            Wizard Helica = new Wizard("Helica", 25, "Angel Wizard");
            Monster Wolf = new Monster("Wolf" , 60 , "Monster");

            WriteLine($"Atacou {Helica.Attack(1)}");
            WriteLine($"Atacou {arus.Attack(8)}");
            WriteLine($"Atacou {Wolf.Attack(10)}");


         }
    }

}
