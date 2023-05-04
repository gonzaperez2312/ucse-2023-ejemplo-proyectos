using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Edificio
    {
        private List<Departamento> ListaDepartamentos;

        public Edificio()
        {
            ListaDepartamentos = new List<Departamento>();
            ListaDepartamentos.Add(new Departamento() { Codigo= 101, Dueño = new Dueño() {Nombre = "Gonza" } });
            ListaDepartamentos.Add(new Departamento() { Codigo = 102 });
            ListaDepartamentos.Add(new Departamento() { Codigo = 103 });
        }

        public bool AgregarDepartamento(Departamento departamento)
        {
            if (departamento.Codigo == 0)
            {
                return false;
            }

            Departamento depto = new Departamento()
            {
                Codigo = departamento.Codigo,
                Dueño = departamento.Dueño
            };

            ListaDepartamentos.Add(depto);

            return true;
        }

        public List<Departamento> ObtenerDepartamentosLibres() {
            return ListaDepartamentos.Where(x => x.Dueño == null).ToList();
        }
    }
}
