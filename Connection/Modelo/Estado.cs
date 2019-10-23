using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Connection.Modelo
{
    public class Estado
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string uf { get; set; }

        public Estado()
        {
            this.id = 0;
            this.nome = "";
            this.uf = "";

        }

        public Estado(int id, string nome, string uf)
        {
            this.id = id;
            this.nome = nome;
            this.uf = uf;

        }

    }
}