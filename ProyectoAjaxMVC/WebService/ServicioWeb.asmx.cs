using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ProyectoAjaxMVC.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebService
{
    /// <summary>
    /// Descripción breve de ServicioWeb
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioWeb : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]

        public string ObtenerPeliculasJson()
        {
            PeliculaController peliculacontroller = new PeliculaController();
            var peliculasJson = peliculacontroller.ObtenerPeliculasJson();

            var peliculas = JArray.Parse(peliculasJson);
            var peliculasOrdenadas = peliculas.OrderBy(p => (String)p["NombrePelicula"]).ToList();

            var peliculasOrdenadasJson = JsonConvert.SerializeObject(peliculasOrdenadas);

            return peliculasOrdenadasJson;
        }

    }
}
