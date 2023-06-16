using Newtonsoft.Json.Linq;
using ProyectoAjaxMVC.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebService
{
    public partial class Formulario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PeliculaController peliculaController = new PeliculaController();
            var peliculasJson = peliculaController.ObtenerPeliculasJson();

            var peliculas = JArray.Parse(peliculasJson);
            var peliculasOrdenadas = peliculas.OrderBy(p => (String)p["NombrePelicula"]).ToList();

            Gridview1.DataSource = peliculasOrdenadas;
            Gridview1.DataBind();

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string IdPelicula = txtBuscarId.Text;

            PeliculaController peliculaController = new PeliculaController();

            var peliculasJson = peliculaController.ObtenerPeliculasJson();

            var peliculas = JArray.Parse(peliculasJson);
            var peliculasFiltradas = peliculas.Where(p => (String)p["IdPelicula"] == IdPelicula).ToList();

            Gridview1.DataSource=peliculasFiltradas;
            Gridview1.DataBind();
        }

    }
}