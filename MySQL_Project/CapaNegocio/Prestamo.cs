using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

namespace MySQL_Project.CapaNegocio
{
    public class Prestamo : IPrestamo
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["Cadena"].ConnectionString;
        private static MySqlConnection conexion = new MySqlConnection(cadena);
        public bool Actualizar(string codAutor, string codLibro, string FechaPrestamo)
        {
            string consulta = "update TPrestamo set fechaprestamo=@fechaprestamo where codlibro=@codlibro and  codautor=@codautor";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@codlibro", codLibro);
            comando.Parameters.AddWithValue("@codautor", codLibro);
            comando.Parameters.AddWithValue("@fechaprestamo", FechaPrestamo);
            conexion.Open();
            byte i = Convert.ToByte(comando.ExecuteNonQuery());
            conexion.Close();
            if (i == 1)
                return true;
            else
                return false;
        }

        public bool Agregar(string codAutor, string codLibro, string FechaPrestamo)
        {
            string consulta = "insert into TPrestamo values(@codlibro,@codautor,@fechaprestamo)";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@codlibro", codLibro);
            comando.Parameters.AddWithValue("@codautor", codLibro);
            comando.Parameters.AddWithValue("@fechaprestamo", FechaPrestamo);
            conexion.Open();
            byte i = Convert.ToByte(comando.ExecuteNonQuery());
            conexion.Close();
            if (i == 1)
                return true;
            else
                return false;
        }

        public DataTable Buscar(string texto, string criterio)
        {
            string consulta = "select *from TPrestamo where " + criterio + " LIKE '%" + texto + "%'";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            return tabla;
        }

        public bool Eliminar(string codAutor, string codLibro)
        {
            string consulta = "delete from TPrestamo where codautor ='" + codAutor + "' and codlibro ='" + codLibro + "'";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            conexion.Open();
            byte i = Convert.ToByte(comando.ExecuteNonQuery());
            conexion.Close();
            if (i == 1)
                return true;
            else
                return false;
        }

        public DataTable Listar()
        {
            string consulta = "select *from TPrestamo";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            return tabla;
        }
    }
}