﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQL_Project.CapaNegocio
{
    interface IAutor
    {
        DataTable Listar();
        bool Agregar(string codAutor, string Apellidos, string Nombres, string Nacionalidad);
        bool Eliminar(string codAutor);
        bool Actualizar(string codAutor, string Apellidos, string Nombres, string Nacionalidad);
        DataTable Buscar(string texto, string criterio);
    }
}
