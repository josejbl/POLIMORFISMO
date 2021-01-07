namespace POLIMORFISMO.Classes
{
    public abstract class Player
    {
        private float velocidade;
        private float forcaPulo;

        public virtual string Correr(){
            return "Correndo em Velocidade 1x";
        } 
    }
}