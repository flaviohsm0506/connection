using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Connection.Modelo
{
    public class Categoria
    {
        public int id { get; set; }
        public string descricao { get; set; }

        public Categoria()
        {
            this.id = 0;
            this.descricao = "";

        }

        public Categoria(int id, string descricao)
        {
            this.id = id;
            this.descricao = descricao;

        }
    }
}