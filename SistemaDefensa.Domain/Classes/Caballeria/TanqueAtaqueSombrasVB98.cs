using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaDefensa.Domain
{
    public class TanqueAtaqueSombrasVB98 : Unidad, ICaballeria, INode
    {
        private static readonly int CAPACITY = 8;

        public IList<Unidad> unidads;

        private int size = 0;

        public TanqueAtaqueSombrasVB98()
        {
            Nombre = "Tanque Ataque Sombras-VB98";
            Precio = 15600;
            unidads = new List<Unidad>(CAPACITY);
            SetMovilidad(new ConMovilidad(7.3));
            SetBlindaje(new ConBlindaje(4.8));
            SetDestructor(new ConFuego(9.8));
        }

        public bool Add(params object[] o)
        {
            foreach (object ob in o)
            {
                if (size == CAPACITY)
                {
                    return false;
                }
                else
                {
                    unidads.Add((Unidad)ob);
                    size++;
                }
            }

            return true;
        }
    }
}