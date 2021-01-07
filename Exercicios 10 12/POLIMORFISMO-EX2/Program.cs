using System;
using POLIMORFISMO_EX2.Classes;


namespace POLIMORFISMO_EX2

{
    class Program
    {
        static void Main(string[] args)
        {
            Professor professor = new Professor();
                        
            professor.ValeRefeicao();
            professor.ValeTransporte();
        }
    }
}
