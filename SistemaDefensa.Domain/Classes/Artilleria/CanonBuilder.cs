using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDefensa.Domain
{
    public class CanonBuilder : AbstractUnidadBuilder
    {
        Unidad canon;

        public CanonBuilder() { canon = new Canon(); }

        public override Unidad Build()
        {
            return canon;
        }

        public override void SetBlindaje(IBlindado blindado)
        {
            canon.Blindado = blindado;
        }

        public override void SetDestructor(IDestructor destructor)
        {
            canon.Destructor = destructor;
        }

        public override void SetMovilidad(IMovil movilidad)
        {
            canon.Movilidad = movilidad;
        }

        public override void SetNombre(string nombre)
        {
            canon.Nombre = nombre;
        }

        public override void SetPrecio(double precio)
        {
            canon.Precio = precio;
        }
    }
}
