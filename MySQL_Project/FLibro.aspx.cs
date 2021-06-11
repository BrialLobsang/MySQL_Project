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
    public partial class FLibro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Listar();
        }
        protected void Listar()
        {
            Libro libro = new Libro();
            DataTable tabla = libro.Listar();
            gvDatos.DataSource = tabla;
            gvDatos.DataBind();

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string codLibro = txtCodLibro.Text.Trim();
            string Editorial = txtEditorial.Text.Trim();
            string Titular = txtTitulo.Text.Trim();
            Libro libro = new Libro();
            libro.Agregar(codLibro, Editorial, Titular);
            Listar();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            string codLibro = txtCodLibro.Text.Trim();
            Libro libro = new Libro();
            libro.Eliminar(codLibro);
            Listar();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            string codLibro = txtCodLibro.Text.Trim();
            string Editorial = txtEditorial.Text.Trim();
            string Titular = txtTitulo.Text.Trim();
            Libro libro = new Libro();
            libro.Actualizar(codLibro, Editorial, Titular);
            Listar();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}