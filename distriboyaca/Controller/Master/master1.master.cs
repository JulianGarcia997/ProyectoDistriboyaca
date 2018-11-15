using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Master_master1 : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["usuario"]!=null)
        {
            DataTable usuario = (DataTable) Session["usuario"];
            registrarseLB.Visible = false;
            registrarseOLB.Visible = false;
            iniciarSesionLB.Visible = false;
            iniciarSesionOLB.Visible = false;
            usuarioLB.Text = "<i class='material-icons right'>arrow_drop_down</i>"+" Bienvenido: "+usuario.Rows[0]["user_name"];
            usuarioLB.Visible = true;
        }
    }

    protected void logoLB_Click(object sender, EventArgs e)
    {
        Response.Redirect("index.aspx");
    }

    protected void inicioLB_Click(object sender, EventArgs e)
    {
        Response.Redirect("index.aspx");
    }

    protected void tiendaVirtualLB_Click(object sender, EventArgs e)
    {
        Response.Redirect("tiendaVirtual.aspx");
    }

    protected void registrarseLB_Click(object sender, EventArgs e)
    {
        Response.Redirect("registrarse.aspx");
    }

    protected void iniciarSesionLB_Click(object sender, EventArgs e)
    {
        Response.Redirect("login.aspx");
    }

    protected void perfilLB_Click(object sender, EventArgs e)
    {
        Response.Redirect("usuario.aspx");
    }

    protected void cerrarSesionLB_Click(object sender, EventArgs e)
    {
        Session["usuario"] = null;
        Response.Redirect("index.aspx");
    }

    protected void inicioOLB_Click(object sender, EventArgs e)
    {
        Response.Redirect("index.aspx");
    }

    protected void tiendaVirtualOLB_Click(object sender, EventArgs e)
    {
        Response.Redirect("tiendaVirtual.aspx");
    }

    protected void registrarseOLB_Click(object sender, EventArgs e)
    {
        Response.Redirect("registrarse.aspx");
    }

    protected void iniciarSesionOLB_Click(object sender, EventArgs e)
    {
        Response.Redirect("login.aspx");
    }
}
