using LogicaNegocio;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ObtenerDepartamentosLibres()
        {
            // Arrange
            Edificio edificio = new Edificio();
            edificio.AgregarDepartamento(new Departamento() { Codigo = 101, Dueño = new Dueño() { Nombre = "Gonza"} });
            edificio.AgregarDepartamento(new Departamento() { Codigo = 102, Dueño = new Dueño() { Nombre = "Gabriel" } });
            edificio.AgregarDepartamento(new Departamento() { Codigo = 102 });

            // Act
            List<Departamento> departamentosLibres = edificio.ObtenerDepartamentosLibres();

            // Assert
            Assert.That(departamentosLibres.Count, Is.EqualTo(1));
            Assert.That(departamentosLibres[0].Codigo, Is.EqualTo(103));
            Assert.That(departamentosLibres[1].Codigo, Is.EqualTo(105));
        }
    }
}