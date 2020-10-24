namespace ejercicio1
{
    class Automovil: Transporte
    {

        public Automovil(int pasajeros) : base(pasajeros)
        {
        }
        public override string Avanzar()
        {
            return "El automovil avanzó.";
        }

        public override string Detenerse()
        {
            return "El automovil se detuvo.";
        }
    }
}
