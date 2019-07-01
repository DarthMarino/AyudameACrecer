using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DataModel
{
    public class DataManager
    {
        private SqlConnection Conexion =                                 //Este es el atributo Conexion de la clase, la cadena de conexion esta definida en el App.Config
            new SqlConnection(ConfigurationManager.ConnectionStrings["DanielDataBase"].ConnectionString); //Si vas a correrlo en tu PC, tienes que agregar tu cadena de conexion al App.Config y sustituir aqui donde dice "DanielDataBase" por el nombre de tu cadena de conexion

        public Usuario ValidarUsuario(Usuario usuario)
        {
            Conexion.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = Conexion;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "stpValidarUsuario";

            
            return new Usuario();
        }
    }
}
