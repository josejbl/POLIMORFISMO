using System;
using POLIMORFISMO.Classes;

namespace POLIMORFISMO
{
    class Program
    {
        static void Main(string[] args)
        {
           MegaMen jogador = new MegaMen();

           Console.WriteLine($"jogador 1 = {jogador.Correr()}");
           
           Zero jogador2 = new Zero();

           Console.WriteLine($"jogador 2 = {jogador2.Correr()}");
           
        }
    }
}
