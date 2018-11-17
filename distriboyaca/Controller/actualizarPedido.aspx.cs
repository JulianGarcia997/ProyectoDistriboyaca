using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_actualizarPedido : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DApedido funcion = new DApedido();
        Session["tabla_pedidos"] = funcion.listarpedidos(1);
    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        DataTable pedidos = (DataTable)Session["tabla_pedidos"];
        DApedido funcion = new DApedido();
        int fila = int.Parse(e.CommandArgument.ToString());
        funcion.modificarEstadoPedidos(int.Parse(pedidos.Rows[fila]["id_pedido"].ToString()));
        Response.Redirect("actualizarPedido.aspx");
    }
}