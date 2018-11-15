using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_tiendaVirtual : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DAproducto funcion = new DAproducto();
        Session["productos"] = funcion.listarProductos();
        btnOculto.Visible = false;
        if (Session["usuario"]!=null)
        {
            btnOculto.Visible = true;
        }
        if (Session["carrito_compras"]!=null)
        {
            DataTable carritoCompras = new DataTable();
            carritoCompras = (DataTable)Session["carrito_compras"];
            GridView2.DataSource = carritoCompras;
            GridView2.DataBind();
        }
        if (Session["limpiar_carrito"]!=null)
        {
            GridView2.DataSource = null;
        }
    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        DataTable productos = (DataTable) Session["productos"];
        int fila = int.Parse(e.CommandArgument.ToString());
        Session["seleccion"] = productos.Rows[fila];
        Response.Redirect("producto.aspx");
    }

    protected void comprarLB_Click(object sender, EventArgs e)
    {
        DataTable carritoCompras = new DataTable();
        carritoCompras = (DataTable)Session["carrito_compras"];
        GridView2.DataSource = carritoCompras;
        GridView2.DataBind();
        GridView2.Visible = true;
    }

    protected void cancelarLB_Click(object sender, EventArgs e)
    {
        Session["carrito_compras"] = null;
        Session["limpiar_carrito"] = true;
        Response.Redirect("tiendaVirtual.aspx");
    }
}