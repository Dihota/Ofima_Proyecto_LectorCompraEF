using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Lib_LectorCompraEF.Entidades;

namespace Lib_LectorCompraEF
{
    public class Conex
    {
        private String ConnectionString 
            = @"Data Source=.\SQLEXPRESS;Initial Catalog=TODOTERRENO2017;Integrated Security=True;";

        public bool OK()
        {
          
            try
            {
                SqlConnection connections = new SqlConnection(ConnectionString);
                connections.Open();
                return true;
            }
            catch 
            {

                return false;
            }
        }

        public void Guardar(Emisor emisor)
        {
            string query = "Insert into cargarXML(NroDcto,NitProvee,NomProvee) values" +
                "(@NroDcto,@NitProvee,@NomProvee)";
            using( SqlConnection conexion = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query,conexion);

                cmd.Parameters.AddWithValue("@NroDcto", emisor.NumFactura);
                cmd.Parameters.AddWithValue("NitProvee", emisor.Nit);
                cmd.Parameters.AddWithValue("@NomProvee", emisor.NomEmisor);

                try
                {
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    conexion.Close();
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }
    }
}
