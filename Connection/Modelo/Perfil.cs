using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Connection.Modelo
{
    public class Perfil 
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string genero { get; set; }
        public string profissao { get; set; }
        public int estado { get; set; }
        public int cidade { get; set; }
        public string bairro { get; set; }
        public string telefone { get; set; }
        public string biografia { get; set; }
        public byte[] img { get; set; }
        public string arquivo { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }


        public Perfil()
        {
            this.id = 0;
            this.nome = "";
            this.genero = "";
            this.profissao = "";
            this.estado = 0;
            this.cidade = 0;
            this.bairro = "";
            this.telefone = "";
            this.biografia = "";
            this.img = null;
            this.arquivo = "";
            this.usuario = "";
            this.senha = "";

        }

        public Perfil(int id, string nome, string genero, string profissao, int estado, int cidade, string bairro, string telefone, string biografia, byte[] img, string arquivo, string usuario, string senha)
        {

            this.id = id;
            this.nome = nome;
            this.genero = genero;
            this.profissao = profissao;
            this.estado = estado;
            this.cidade = cidade;
            this.bairro = bairro;
            this.telefone = telefone;
            this.biografia = biografia;
            this.img = img;
            this.arquivo = arquivo;
            this.usuario = usuario;
            this.senha = senha;
        }

    }
}