using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["usuario"]!=null)
        {
            Response.Redirect("index.aspx");
        }
    }

    protected void iniciarB_Click(object sender, EventArgs e)
    {
        validoL.Visible = false;
        noValidoL.Visible = false;
        if (userNameTB.Text!="" && contrasenaTB.Text!="")
        {
            Eusuario encapsular = new Eusuario();
            DAusuario funcion = new DAusuario();
            DataTable usuarioValido = new DataTable();
            encapsular.UserName = userNameTB.Text;
            encapsular.ContrasenaUsuario = contrasenaTB.Text;
            usuarioValido = funcion.login(encapsular);
            if (usuarioValido.Rows.Count>0)
            {
                usuarioValido = funcion.verificarEstado(encapsular);
                if (usuarioValido.Rows.Count>0)
                {
                    Session["usuario"] = usuarioValido;
                    Response.Redirect("index.aspx");
                }
                else
                {
                    noValidoL.Text = "Usuario bloqueado";
                    noValidoL.Visible = true;
                }
            }
            else
            {
                noValidoL.Text = "Usuario o contraseña no validos";
                noValidoL.Visible = true;
            }
        }
        else
        {
            noValidoL.Text = "Llene primero todos los campos";
            noValidoL.Visible = true;
        }
    }
}