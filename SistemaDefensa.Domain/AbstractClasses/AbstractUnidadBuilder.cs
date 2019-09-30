using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDefensa.Domain
{
    public abstract class AbstractUnidadBuilder
    {
        public abstract Unidad Build();

        public abstract void SetNombre(string nombre);
        public abstract void SetPrecio(double precio);
        public abstract void SetMovilidad(IMovil movilidad);
        public abstract void SetBlindaje(IBlindado blindado);
        public abstract void SetDestructor(IDestructor destructor);
    }
}
