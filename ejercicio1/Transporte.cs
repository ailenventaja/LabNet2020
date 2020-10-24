namespace ejercicio1
{
    public abstract class Transporte
    {
        private int pasajeros;

        public Transporte(int pasajeros)
        {
            this.pasajeros = pasajeros;
        }

        public int Pasajeros
        {
            get { return this.pasajeros; }

        }


        public virtual string Avanzar()
        {
            return "El transporte avanzó.";
        }

        public virtual string Detenerse()
        {
            return "El transporte se detuvo.";
        }

    }
}
