using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Connection.Modelo
{
    public class Categoria_Perfil
    {
        public int categoria { get; set; }
        public int perfil { get; set; }

        public Categoria_Perfil()
        {
            this.categoria = 0;
            this.perfil = 0;

        }

        public Categoria_Perfil(int categoria, int perfil)
        {
            this.categoria = categoria;
            this.perfil = perfil;

        }
    }
}