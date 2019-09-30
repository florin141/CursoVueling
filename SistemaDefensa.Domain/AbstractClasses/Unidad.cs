using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaDefensa.Domain
{
    public abstract class Unidad
    {
        protected IMovil _velocidad;
        protected IBlindado _blindado;
        protected IDestructor _destructor;

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
            return _velocidad.CapacidadDeMovimiento();
        }

        public void SetMovilidad(IMovil velocidad)
        {
            _velocidad = velocidad;
        }

        public virtual double GetBlindaje()
        {
            return _blindado.ResistenciaAlAtaque();
        }

        public void SetBlindaje(IBlindado blindado)
        {
            _blindado = blindado;
        }

        public virtual double GetPotenciaFuego()
        {
            return _destructor.CapacidadDeDestruccion();
        }

        public void SetDestructor(IDestructor destructor)
        {
            _destructor = destructor;
        }

        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private double _precio;

        public double Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }
    }
}