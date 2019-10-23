using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace Connection.DAL
{
    public class DALEstado
    {
        string connectionString = "";

        public DALEstado()
        {
            connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Estado> SelectAll()
        {

            Modelo.Estado aEstado;

            List<Modelo.Estado> aListEstado = new List<Modelo.Estado>();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "Select * from Estado";

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aEstado = new Modelo.Estado(
                        Int32.Parse(dr["id"].ToString()),
                        dr["nome"].ToString(),
                        dr["uf"].ToString()
                        );
                    aListEstado.Add(aEstado);
                }
            }

            dr.Close();

            conn.Close();
            return aListEstado;
        }

    }
}