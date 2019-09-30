using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaDefensa.Domain
{
    public abstract class Unidad
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public IMovil Movilidad { get; set; }
        public IBlindado Blindado { get; set; }
        public IDestructor Destructor { get; set; }

        public static readonly Unidad Null = new NullUnidad();

        private class NullUnidad : Unidad
        {
            public override double GetBlindaje()
            {
                return 0;
            }

            public override double GetMovilidad()
            {
                return 0;
            }

            public override double GetPotenciaFuego()
            {
                return 0;
            }
        }

        public virtual double GetMovilidad()
        {
            return Movilidad.CapacidadDeMovimiento();
        }

        public virtual double GetBlindaje()
        {
            return Blindado.ResistenciaAlAtaque();
        }

        public virtual double GetPotenciaFuego()
        {
            return Destructor.CapacidadDeDestruccion();
        }
    }
}