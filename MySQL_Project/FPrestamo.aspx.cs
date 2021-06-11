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
    public partial class FPrestamo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Listar();
        }
        protected void Listar()
        {
            Prestamo prestamo = new Prestamo();
            DataTable tabla = prestamo.Listar();
            gvDatos.DataSource = tabla;
            gvDatos.DataBind();

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}