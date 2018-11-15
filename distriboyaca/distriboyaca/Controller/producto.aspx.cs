using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_producto : System.Web.UI.Page
{
    /*
      variables globales para el control del DataTable que alimentara al GridView del carrito
     */
    private DataRow seleccionado;
    private static DataTable carrito = new DataTable();
    private static bool creado = false;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["seleccion"]!=null)
        {
            seleccionado =(DataRow) Session["seleccion"];
            fotoProductoI.ImageUrl = seleccionado["foto_producto"].ToString();
            nombreL.Text = "Nombre del producto: "+seleccionado["nombre_producto"].ToString();
            colorL.Text = "Color Producto: "+seleccionado["color_producto"].ToString();
            referenciaL.Text = "Referencia Producto: "+seleccionado["referencia_producto"].ToString();
            precioL.Text = "Precio Producto "+seleccionado["precio_producto"].ToString();
            cantidadL.Text = "Cantidad Producto: "+seleccionado["cantidad_producto"].ToString();
        }
        else
        {
            Response.Redirect("tiendaVirtual.aspx");
        }
        if (Session["usuario"]!=null)
        {
            anadirLB.CssClass = "btn-large waves-effect waves-light black";
            cantidadTB.Visible = true;
        }
        if (Session["limpiar_carrito"]!=null)
        {
            carrito.Rows.Clear();
            Session["limpiar_carrito"] = null;
        }
    }

    protected void volverLB_Click(object sender, EventArgs e)
    {
        Response.Redirect("tiendaVirtual.aspx");
    }

    protected void anadirLB_Click(object sender, EventArgs e)
    {
        validoL.Visible = false;
        noValidoL.Visible = false;
        if (int.Parse(cantidadTB.Text)<=0 || int.Parse(cantidadTB.Text)>int.Parse(seleccionado["cantidad_producto"].ToString()) || int.Parse(cantidadTB.Text) >int.Parse(seleccionado["cantidad_producto"].ToString()) - 50)
        {
            noValidoL.Text = "Cantiad no valida";
            noValidoL.Visible = true;
        }
        else
        {
            DataTable usuarioActivo = (DataTable)Session["usuario"];
            Epedido encapsular = new Epedido();
            DApedido funcion = new DApedido();
            bool exedido = false;
            encapsular.NombreUsuario = usuarioActivo.Rows[0]["nombres_usuario"].ToString();
            encapsular.CedulaUsuario = usuarioActivo.Rows[0]["cedula_usuario"].ToString();
            encapsular.NombreProducto = seleccionado["nombre_producto"].ToString();
            encapsular.CodigoProducto = seleccionado["codigo_producto"].ToString();
            encapsular.ReferenciaProducto = seleccionado["referencia_producto"].ToString();
            encapsular.CantidadProducto = int.Parse(cantidadTB.Text);
            encapsular.Precio = double.Parse(seleccionado["precio_producto"].ToString()) * int.Parse(cantidadTB.Text);
            encapsular.Estado = "Pendiente";
            // funcion.registrarPedido(encapsular);
            for (int i=0;i<carrito.Rows.Count;i++)
            {
                if (carrito.Rows[i]["Codigo Pro"].ToString() == seleccionado["codigo_producto"].ToString())
                {
                    if ((int.Parse(cantidadTB.Text)+int.Parse(carrito.Rows[0]["Cantidad Pro"].ToString()))>int.Parse(seleccionado["cantidad_producto"].ToString()) - 50)
                    {
                        noValidoL.Text = "Cantidad Exedida";
                        noValidoL.Visible = true;
                        exedido = true;
                    }
                }
            }
            if (exedido!=true)
            {
                llenarDataTable(encapsular);
            }
        }
    }

    private void llenarDataTable (Epedido pedido)
    {
        if (carrito.Rows.Count==0 && creado==false)
        {
            carrito.Columns.Add("Nombre Us", typeof(string));
            carrito.Columns.Add("Cedula US", typeof(string));
            carrito.Columns.Add("Nombre Pro", typeof(string));
            carrito.Columns.Add("Codigo Pro", typeof(string));
            carrito.Columns.Add("Referencia Pro", typeof(string));
            carrito.Columns.Add("Cantidad Pro", typeof(int));
            carrito.Columns.Add("Precio Pro", typeof(double));
            carrito.Columns.Add("Estado", typeof(string));
            carrito.Rows.Add(new object[] { pedido.NombreUsuario, pedido.CedulaUsuario, pedido.NombreProducto, pedido.CodigoProducto, pedido.ReferenciaProducto, pedido.CantidadProducto, pedido.Precio, pedido.Estado });
            Session["carrito_compras"] = carrito;
            creado = true;
        }
        else
        {
            bool repetido = false;
            for (int i = 0; i < carrito.Rows.Count; i++)
            {
                if (pedido.CodigoProducto == carrito.Rows[i]["Codigo Pro"].ToString())
                {
                    carrito.Rows[i]["Cantidad Pro"] = int.Parse(carrito.Rows[i]["Cantidad Pro"].ToString()) + pedido.CantidadProducto;
                    carrito.Rows[i]["Precio Pro"] = double.Parse(carrito.Rows[i]["Precio Pro"].ToString()) + pedido.Precio;
                    repetido = true;

                }
            }

            if (!(repetido==true))
            {
                carrito.Rows.Add(new object[] { pedido.NombreUsuario, pedido.CedulaUsuario, pedido.NombreProducto, pedido.CodigoProducto, pedido.ReferenciaProducto, pedido.CantidadProducto, pedido.Precio, pedido.Estado });
                Session["carrito_compras"] = carrito;
            }
        }
    }
}