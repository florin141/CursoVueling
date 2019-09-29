using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDefensa.Domain
{
    public class Ejercito
    {
        /// <summary>
        /// Potencia de fuego.
        /// </summary>
        private double _pf;

        /// <summary>
        /// Capacidad de movimiento.
        /// </summary>
        private double _cm;

        /// <summary>
        /// Blindaje.
        /// </summary>
        private double _bl;

        /// <summary>
        /// Unidades.
        /// </summary>
        private IList<Unidad> _unidades;

        private ICalculable _calculable;

        public Ejercito(ICalculable calculable)
        {
            _unidades = new List<Unidad>();
            _calculable = calculable;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="unidad"></param>
        public void AddUnidad(Unidad unidad)
        {
            _unidades.Add(unidad);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="unidad"></param>
        public void RemoveUnidad(Unidad unidad)
        {
            _unidades.Remove(unidad);
        }

        /// <summary>
        /// Cuantos elementos tiene.
        /// </summary>
        /// <returns></returns>
        public int CounterUnidades()
        {
            return _unidades.Count();
        }

        /// <summary>
        /// Capacidad de destruccion.
        /// </summary>
        /// <returns></returns>
        public virtual double PotenciaDeFuego()
        {
            _pf = _unidades.Sum(c => c.GetPotenciaFuego());
            return _pf;
        }

        /// <summary>
        /// Resistencia al ataque.
        /// </summary>
        /// <returns></returns>
        public virtual double Blindaje()
        {
            _bl = _unidades.Average(b => b.GetBlindaje());
            return _bl;
        }

        /// <summary>
        /// Capacidad de movimiento.
        /// </summary>
        /// <returns></returns>
        public virtual double Movimiento()
        {
            _cm = _unidades.Min(m => m.GetMovilidad());
            return _cm;
        }

        /// <summary>
        /// Cuanto dinero se lleva gastado.
        /// </summary>
        /// <returns></returns>
        public double Precio()
        {
            return _unidades.Sum(p => p.Precio);
        }

        /// <summary>
        /// Returns the military capacity of an exercise.
        /// </summary>
        /// <returns></returns>
        public virtual double CapacidadMilitar()
        {
            PotenciaDeFuego();
            Movimiento();
            Blindaje();
            return ((_pf * _cm) / 2.0) / (100.0 - _bl);
        }
    }
}
