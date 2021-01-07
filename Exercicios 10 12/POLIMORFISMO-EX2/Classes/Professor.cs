using System;
namespace POLIMORFISMO_EX2.Classes
{
    public class Professor : Taxa
    {
        public string turma;
        public override void ValeRefeicao(){
            base.ValeRefeicao();
            Console.WriteLine($"A taxa do professor é de 10%");
            
        }
        public override void ValeTransporte()
        {
            base.ValeTransporte();
            Console.WriteLine($"A taxa do professor é 32%");
            
        }
    }
}