using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_eliminarProducto : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DAproducto funcion = new DAproducto();
        Session["tabla_productos"] = funcion.listartProductos();
    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        DataTable usuarios = (DataTable)Session["tabla_productos"];
        DAproducto funcion = new DAproducto();
        int fila = int.Parse(e.CommandArgument.ToString());
        funcion.eliminarProducto(int.Parse(usuarios.Rows[fila]["id_producto"].ToString()));
        Response.Redirect("eliminarProducto.aspx");
    }
}