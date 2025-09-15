using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //Esta es la libreria que me permite usar comando para trabajar con Bases de Datos
using System.Data.SqlClient; //Esta libreria me permite trabajar con SQL Server 
namespace miPrimerProyectoCsharp {
    internal class Conexion {
        //Definir los miembros de la calse, atributos y metodos.
        SqlConnection objConexion = new SqlConnection(); //conectar a la BD.
        SqlCommand objComando = new SqlCommand(); //ejecutar SQL en la BD.
        SqlDataAdapter objAdaptador = new SqlDataAdapter(); //un puente entre la BD y la aplicacion.
        DataSet objDs = new DataSet(); //Es una representacion de la arquitectura de la BD en memoria.

        public Conexion() { //Constructor. inicializador de los atributos
            string cadenaConexion = "";
            objConexion.ConnectionString = cadenaConexion;
            objConexion.Open(); // Abrir la conexion
        }
        public DataSet obtenerDatos() { 
            objDs.Clear(); //limpia el DataSet
            objComando.Connection = objConexion; //Establecer la conexon para ejecutar los comandos
            objAdaptador.SelectCommand = objComando; //Establecer el comando de seleccion
            objComando.CommandText = "SELECT * FROM alumnos";
            objAdaptador.Fill(objDs, "alumnos");//Tomando los datos de la BD y llenando el DataSet
            return objDs;
        }
    }
}
