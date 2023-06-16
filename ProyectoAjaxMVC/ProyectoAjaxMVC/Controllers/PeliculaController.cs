using Newtonsoft.Json;
using ProyectoAjaxMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoAjaxMVC.Controllers
{
    public class PeliculaController : Controller
    {
        //Vista Index
        public ActionResult Index()
        {
            return View();
        } 

        //Declaro un Arreglo que estara conectado con la clase Pelicula.cs
        private Boleta[] peliculas;


        public PeliculaController()
        {
            //Declaro que el arreglo y le ingreso los elementos manuales
            peliculas = new Boleta[]
            {
                //Los atributos donde se almacenaran tienen relacion con los atributos de la clase
                new Boleta {IdPelicula = "100", NombrePelicula = "John Wick 4", CategoriaPelicula = "Acción", claseEntradas = new Entradas { CantidadEntradas = 1, ValorEntradas = 5000}},
                new Boleta {IdPelicula = "200", NombrePelicula = "El señor de los anillos", CategoriaPelicula = "Ficcíon", claseEntradas = new Entradas {CantidadEntradas = 2, ValorEntradas = 4500}},
                new Boleta {IdPelicula = "300", NombrePelicula = "Alien", CategoriaPelicula = "Ciencia Ficción", claseEntradas = new Entradas {CantidadEntradas = 3, ValorEntradas = 3000}}
            };
        }

        //Convierto el arreglo en formato JSON, que retornara las peliculas almacenadas con ese formato
        public string ObtenerPeliculasJson()
        {
            return JsonConvert.SerializeObject(peliculas);
        }
    }
}
