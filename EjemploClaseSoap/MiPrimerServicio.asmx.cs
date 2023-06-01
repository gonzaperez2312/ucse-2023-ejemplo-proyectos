using EjemploClaseSoap.CountryService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace EjemploClaseSoap
{
    /// <summary>
    /// Descripción breve de MiPrimerServicio
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class MiPrimerServicio : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public tCountryInfo GetFirstCountry()
        {
            CountryService.CountryInfoServiceSoapTypeClient client = new CountryService.CountryInfoServiceSoapTypeClient();

            tCountryInfo[] paises = client.FullCountryInfoAllCountries();

            return paises[0];
        }

        [WebMethod]
        public string HelloPerson(string nombre)
        {
            return $"Hola {nombre}";
        }
    }
}
