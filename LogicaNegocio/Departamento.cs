﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Departamento
    {
        public int Codigo { get; set; }

        public Dueño Dueño { get; set; }

        public Departamento() { }
    }
}
