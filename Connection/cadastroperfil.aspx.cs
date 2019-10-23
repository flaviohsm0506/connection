using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Connection
{
    public partial class cadastroperfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DAL.DALCategoria DALcat = new DAL.DALCategoria();


            Session["uf"] = "AC";
            Label1.Text = DALcat.SelectAll()[0].descricao;
            Label2.Text = DALcat.SelectAll()[1].descricao;
            Label3.Text = DALcat.SelectAll()[2].descricao;
            Label4.Text = DALcat.SelectAll()[3].descricao;
            Label5.Text = DALcat.SelectAll()[4].descricao;
            Label6.Text = DALcat.SelectAll()[5].descricao;

           
        }

        protected void uf_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["uf"] = dropestado.SelectedItem.Text;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Modelo.Perfil aPerfil;
            DAL.DALPerfil aDALPerfil;
            aDALPerfil = new DAL.DALPerfil();


            Modelo.Perfil x = aDALPerfil.SelectParaBusca(user.Text);

            if (senha.Text != senhac.Text)
            {
                Response.Write("<script>alert('Senha não coincidem!');</script>");
            }
            else if (x != null) {

                Response.Write("<script>alert('Usuário já existe!');</script>");

            }
            else {

                aPerfil = new Modelo.Perfil(0, nome.Value, genero.Value, profissao.Value, Int32.Parse(dropestado.SelectedValue), Int32.Parse(DropDownListCidade.SelectedValue), bairro.Text, tel.Value, textarea2.Value, FileUpload1.FileBytes, FileUpload1.FileName, user.Text, encrypt(senha.Text));
                aDALPerfil.Insert(aPerfil);

                string filename = Request.PhysicalApplicationPath + "imagens\\" + FileUpload1.FileName;
                FileUpload1.SaveAs(filename);

                Modelo.Categoria_Perfil aCP;
                DAL.DALCategoria_Perfil aDALCP;

                aDALCP = new DAL.DALCategoria_Perfil();


                DAL.DALCategoria DALcat = new DAL.DALCategoria();

                int id2 = aDALPerfil.SelectParaCategoria(user.Text, encrypt(senha.Text))[0].id;

                if (check1.Checked)
                {

                    aDALCP.Insert(DALcat.SelectAll()[0].id, id2);

                }

                if (check2.Checked)
                {

                    aDALCP.Insert(DALcat.SelectAll()[1].id, id2);

                }
                if (check3.Checked)
                {

                    aDALCP.Insert(DALcat.SelectAll()[2].id, id2);

                }

                if (check4.Checked)
                {

                    aDALCP.Insert(DALcat.SelectAll()[3].id, id2);

                }
                if (check5.Checked)
                {

                    aDALCP.Insert(DALcat.SelectAll()[4].id, id2);

                }

                if (check6.Checked)
                {

                    aDALCP.Insert(DALcat.SelectAll()[5].id, id2);

                }

                Response.Write("<script>alert('Cadastrado com sucesso!');</script>");
                Response.Redirect("login.aspx");

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
