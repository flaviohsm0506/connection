using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Connection
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["perfil"] != null)
            {
                Response.Redirect("paginaperfil.aspx");
            }
            
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DAL.DALPerfil perfil = new DAL.DALPerfil();
            Modelo.Perfil uc = perfil.SelectLogin(user.Text, encrypt(senha.Text));

            if (uc != null)
            {
                Session["perfil"] = uc;
                Response.Redirect("~/paginaperfil.aspx");
            }

        }


        public static string encrypt(string x)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider test123 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] data = System.Text.Encoding.ASCII.GetBytes(x);
            data = test123.ComputeHash(data);
            String md5Hash = System.Text.Encoding.ASCII.GetString(data);

            return md5Hash;
        }
    }
}