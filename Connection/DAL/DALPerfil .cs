using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace Connection.DAL
{
    public class DALPerfil
    {
        string connectionString = "";

        public DALPerfil()
        {
            connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Perfil obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("INSERT INTO perfis(nome, genero, profissao, estado, cidade, bairro, telefone, biografia, imagem, arquivo, usuario, senha) VALUES(@nome, @genero, @profissao, @estado, @cidade, @bairro, @telefone, @biografia, @imagem, @arquivo, @usuario, @senha)", conn);
            cmd.Parameters.AddWithValue("@nome", obj.nome);
            cmd.Parameters.AddWithValue("@genero", obj.genero);
            cmd.Parameters.AddWithValue("@profissao", obj.profissao);
            cmd.Parameters.AddWithValue("@estado", obj.estado);
            cmd.Parameters.AddWithValue("@cidade", obj.cidade);
            cmd.Parameters.AddWithValue("@bairro", obj.bairro);
            cmd.Parameters.AddWithValue("@telefone", obj.telefone);
            cmd.Parameters.AddWithValue("@biografia", obj.biografia);
            cmd.Parameters.AddWithValue("@imagem", obj.img);
            cmd.Parameters.AddWithValue("@arquivo", obj.arquivo);
            cmd.Parameters.AddWithValue("@usuario", obj.usuario);
            cmd.Parameters.AddWithValue("@senha", obj.senha);

            cmd.ExecuteNonQuery();
        }


        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Perfil> SelectParaCategoria(string user, string senha)
        {

            Modelo.Perfil aPerfil;

            List<Modelo.Perfil> aListPerfil = new List<Modelo.Perfil>();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "Select * from perfis where usuario = @usuario and senha = @senha";
            cmd.Parameters.AddWithValue("@usuario", user);
            cmd.Parameters.AddWithValue("@senha", senha);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aPerfil = new Modelo.Perfil(
                        Int32.Parse(dr["id"].ToString()),
                        "",
                        "",
                        "",
                        0,
                        0,
                        "",
                        "",
                        "",
                        null,
                        "",
                        "",
                        ""
                        );
                    aListPerfil.Add(aPerfil);
                }
            }

            dr.Close();

            conn.Close();
            return aListPerfil;
        }


        [DataObjectMethod(DataObjectMethodType.Select)]
        public Modelo.Perfil SelectLogin(string user, string senha)
        {
            Modelo.Perfil aPerfil = null;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from perfis where usuario = @usuario";
            cmd.Parameters.AddWithValue("@usuario", user);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                if (dr.Read())
                {
                    if (senha == dr["senha"].ToString())
                    {
                        aPerfil = new Modelo.Perfil(
                            Int32.Parse(dr["id"].ToString()),
                            dr["nome"].ToString(),
                            dr["genero"].ToString(),
                            dr["profissao"].ToString(),
                            Int32.Parse(dr["estado"].ToString()),
                            Int32.Parse(dr["cidade"].ToString()),
                            dr["bairro"].ToString(),
                            dr["telefone"].ToString(),
                            dr["biografia"].ToString(),
                            (byte[])dr["imagem"],
                            dr["arquivo"].ToString(),
                            dr["usuario"].ToString(),
                            dr["senha"].ToString()
          
                            );

                  }

                }
            }
            dr.Close();
            conn.Close();
            return aPerfil;
        }


        [DataObjectMethod(DataObjectMethodType.Select)]
        public Modelo.Perfil SelectParaBusca(string user)
        {

            Modelo.Perfil aPerfil = null;

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "Select * from perfis where usuario = @usuario";
            cmd.Parameters.AddWithValue("@usuario", user);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aPerfil = new Modelo.Perfil(
                        Int32.Parse(dr["id"].ToString()),
                        "",
                        "",
                        "",
                        0,
                        0,
                        "",
                        "",
                        "",
                        null,
                        "",
                        "",
                        ""
                        );
                }
            }

            dr.Close();

            conn.Close();
            return aPerfil;
        }

    }
}