using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace Connection.DAL
{
    public class DALCategoria_Perfil
    {
        string connectionString = "";

        public DALCategoria_Perfil()
        {
            connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(int categoria, int perfil)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("INSERT INTO perfil_categoria(categoria, perfil) VALUES (@categoria, @perfil)", conn);
            cmd.Parameters.AddWithValue("@categoria", categoria);
            cmd.Parameters.AddWithValue("@perfil", perfil);
            cmd.ExecuteNonQuery();

        }


    }
}