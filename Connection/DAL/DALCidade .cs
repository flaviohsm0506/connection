using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace Connection.DAL
{
    public class DALCidade
    {
        string connectionString = "";

        public DALCidade()
        {
            connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Cidade> SelectAll(string uf)
        {

            Modelo.Cidade aCidade;

            List<Modelo.Cidade> aListCidade = new List<Modelo.Cidade>();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "Select * from Municipio where uf = @uf";
            cmd.Parameters.AddWithValue("@uf", uf);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aCidade = new Modelo.Cidade(
                        Int32.Parse(dr["id"].ToString()),
                        dr["nome"].ToString(),
                        dr["uf"].ToString()
                        );
                    aListCidade.Add(aCidade);
                }
            }

            dr.Close();

            conn.Close();
            return aListCidade;
        }

    }
}