using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataModel
{
    class ConexionDB   //Esta es la clase que crea la conexion a la base de datos, la abre y la cierra.
    {
        private SqlConnection Conexion =                                 //Este es el atributo Conexion de la clase, la cadena de conexion esta definida en el App.Config
            new SqlConnection(ConfigurationManager.ConnectionStrings["DanielDataBase"].ConnectionString); //Si vas a correrlo en tu PC, tienes que agregar tu cadena de conexion al App.Config y sustituir aqui donde dice "DanielDataBase" por el nombre de tu cadena de conexion

        public SqlConnection AbrirConexion() //Esto se explica solo xD
        {
            if (Conexion.State == ConnectionState.Closed)
            {
                Conexion.Open();
            }

            return Conexion;
        }

        public SqlConnection CerrarConexion() //Esto tambien :p
        {
            if (Conexion.State == ConnectionState.Open)
            {
                Conexion.Close();
            }

            return Conexion;
        }
    }
}
