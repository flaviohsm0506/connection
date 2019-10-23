using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Connection
{
    public partial class paginaperfil : System.Web.UI.Page
    {
        Modelo.Perfil u;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["perfil"] == null)
            {
                Response.Redirect("login.aspx");
            }

            u = (Modelo.Perfil)Session["perfil"];

            Image1.ImageUrl = "~/imagens/" + u.arquivo;
            user.Text = u.usuario;
            biografia.Text = u.biografia;
            nome.Text = u.nome;
            nome2.Text = u.usuario;

            divizona.Attributes["style"] = "background-image: url('../imagens/p2.jpg');";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["perfil"] = null;
            Response.Redirect("login.aspx");

        }
    }
}