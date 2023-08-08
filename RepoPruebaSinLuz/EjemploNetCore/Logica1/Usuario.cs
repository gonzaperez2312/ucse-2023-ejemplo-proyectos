using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica1
{
    public class Usuario
    {
        public int Dni { get; set; }

        public string Nombre { get; set; }

        public string DevolverDescription() {
            return $"{Dni} - {Nombre}";
        }
    }
}
