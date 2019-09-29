namespace SistemaDefensa.Domain
{
    public class ConFuego : IDestructor
    {
        private double _fuego;

        public ConFuego(double fuego)
        {
            _fuego = fuego;
        }

        public double CapacidadDeDestruccion()
        {
            return _fuego;
        }
    }
}
