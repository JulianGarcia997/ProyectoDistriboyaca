using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_EliminarEmpleado : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DAusuario funcion = new DAusuario();
        Session["tabla_empleados"] = funcion.listarUsuarios(3);
    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        DataTable usuarios = (DataTable)Session["tabla_empleados"];
        DAusuario funcion = new DAusuario();
        int fila = int.Parse(e.CommandArgument.ToString());
        funcion.eliminarUsuario(int.Parse(usuarios.Rows[fila]["id_usuario"].ToString()));
        Response.Redirect("EliminarEmpleado.aspx");
    }
}