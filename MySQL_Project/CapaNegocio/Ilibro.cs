using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQL_Project.CapaNegocio
{
    interface Ilibro
    {
        DataTable Listar();
        bool Agregar(string codLibro, string Editorial, string Titular);
        bool Eliminar(string codLibro);
        bool Actualizar(string codLibro, string Editorial, string Titular);
        DataTable Buscar(string texto, string criterio);
    }
}
