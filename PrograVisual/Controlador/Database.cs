using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PrograVisual.Controlador
{
    class Database
    {
        SqlConnection conexionString;
        String mensajeInformacion;
        public SqlConnection Conexion()
        {
            try
            {
                conexionString = new SqlConnection();
                conexionString.ConnectionString = "Data Source=DESKTOP-840BDQF;Initial Catalog=Northwind;Integrated Security=True";
                conexionString.Open();
                return conexionString;
            }
            catch (SqlException ExceptionMessage)
            {
                mensajeInformacion = ExceptionMessage.Message;
                return null;
            }
        }
    }
}
