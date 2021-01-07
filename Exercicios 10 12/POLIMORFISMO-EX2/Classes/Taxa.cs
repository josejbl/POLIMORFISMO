using System;

namespace POLIMORFISMO_EX2.Classes
{
    public class Taxa
    {
        private float valor;
        public virtual void ValeRefeicao(){
            Console.WriteLine($"A taxa a ser paga é de 5%");
            
        }
        public virtual void ValeTransporte(){
            Console.WriteLine($"A taxa do vale tranporte é de 46%");
            
        }
    }
}