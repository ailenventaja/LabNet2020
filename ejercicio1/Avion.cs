namespace ejercicio1
{
    class Avion : Transporte
    {

        public Avion(int pasajeros) : base(pasajeros)
        {
        }
        public override string Avanzar()
        {
            return "El avión avanzó.";
        }

        public override string Detenerse()
        {
            return "El avión se detuvo.";
        }
    }
}
