using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace Connection.DAL
{
    public class DALCategoria
    {
        string connectionString = "";

        public DALCategoria()
        {
            connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Categoria> SelectAll()
        {

            Modelo.Categoria aCategoria;

            List<Modelo.Categoria> aListCategoria = new List<Modelo.Categoria>();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "Select * from Categorias";

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aCategoria = new Modelo.Categoria(
                        Int32.Parse(dr["id"].ToString()),
                        dr["categoria"].ToString()
                        );
                    aListCategoria.Add(aCategoria);
                }
            }

            dr.Close();

            conn.Close();
            return aListCategoria;
        }

    }
}