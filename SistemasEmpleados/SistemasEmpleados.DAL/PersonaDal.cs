using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SistemasEmpleados.Modelos;
using SistemasEmpleados.DAL;

namespace SistemasEmpleados.DAL
{
    public class PersonaDal
    {
        public DataTable ListarPersonasDal() 
        {
            string consulta = "select * from persona";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }

        public void InsertarPersonaDal(Persona persona)
        {
            string consulta = "insert into persona values('" + persona.Nombre + "'," +
                                                          "'" + persona.Apellido + "'," +
                                                          "'Activo')";
            conexion.Ejecutar(consulta);
        }
    }
}
