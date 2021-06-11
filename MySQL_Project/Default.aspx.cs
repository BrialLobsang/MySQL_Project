using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace MySQL_Project
{
    public partial class Default : System.Web.UI.Page
    {
        //Cadena de conexion de web config
        private static string cadena = ConfigurationManager.ConnectionStrings["Cadena"].ConnectionString;
        private static MySqlConnection conexion = new MySqlConnection(cadena);
        private void Listar()
        {
            String consulta = "select * from tautor";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            gvDatos.DataSource = tabla;
            gvDatos.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Listar();
        }
    }
}