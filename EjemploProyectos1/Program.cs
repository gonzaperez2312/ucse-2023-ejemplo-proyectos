using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploProyectos1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Edificio edificio = new Edificio();

            /*Console.WriteLine("Cargar nro departamento");
            int nroDepto = int.Parse(Console.ReadLine());
            Console.WriteLine("Cargar nombre dueño");
            string nombreDueño = Console.ReadLine();

            bool resultado = edificio.AgregarDepartamento(nroDepto, nombreDueño);

            if (resultado)
            {
                Console.WriteLine("Se cargó el departamento");
            }*/

            Console.WriteLine("Departamentos libres");
            foreach (var item in edificio.ObtenerDepartamentosLibres())
            {
                Console.WriteLine($"Nro Departamento: {item.Codigo}");
            }

            Console.ReadKey();
        }
    }
}
