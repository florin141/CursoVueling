namespace SistemaDefensa.Domain
{
    public class ConMovilidad : IMovil
    {
        private double _velocidad;

        public ConMovilidad(double velocidad)
        {
            _velocidad = velocidad;
        }

        public double CapacidadDeMovimiento()
        {
            return _velocidad;
        }
    }
}
