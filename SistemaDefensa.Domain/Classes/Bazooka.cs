﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDefensa.Domain
{
    public class Bazooka : IDestructor
    {
        public double CapacidadDeDestruccion()
        {
            return 10000;
        }
    }
}
