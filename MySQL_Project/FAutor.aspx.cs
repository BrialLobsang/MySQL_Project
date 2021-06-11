using MySQL_Project.CapaNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MySQL_Project
{
    public partial class FAutor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Listar();
        }
        protected void Listar()
        {
            Autor autor = new Autor();
            DataTable tabla = autor.Listar();
            gvDatos.DataSource = tabla;
            gvDatos.DataBind();

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string codAutor = txtCodAutor.Text.Trim();
            string nombres = txtNombres.Text.Trim();
            string apellidos = txtApellidos.Text.Trim();
            string nacionalidad = txtNacionalidad.Text.Trim();
            Autor autor = new Autor();
            autor.Agregar(codAutor, apellidos, nombres, nacionalidad);
            Listar();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            string codAutor = txtCodAutor.Text.Trim();
            Autor autor = new Autor();
            autor.Eliminar(codAutor);
            Listar();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            string codAutor = txtCodAutor.Text.Trim();
            string nombres = txtNombres.Text.Trim();
            string apellidos = txtApellidos.Text.Trim();
            string nacionalidad = txtNacionalidad.Text.Trim();
            Autor autor = new Autor();
            autor.Actualizar(codAutor, apellidos, nombres, nacionalidad);
            Listar();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string texto = txtTexto.Text.Trim();
            string criterio = ddlCriterio.Text.Trim();
            Autor autor = new Autor();
            DataTable tabla = autor.Buscar(texto,criterio);
            gvDatos.DataSource = tabla;
            gvDatos.DataBind();
        }
    }
}