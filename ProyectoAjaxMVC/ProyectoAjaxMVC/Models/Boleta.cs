using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoAjaxMVC.Models
{
    //Herencia
    public class Boleta: Pelicula
    {
        //Composicion
        public Entradas claseEntradas { get; set; }

    }


}