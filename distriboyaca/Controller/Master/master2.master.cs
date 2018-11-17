using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Master_master2 : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["usuario"]!=null)
        {
            DataTable usuario = (DataTable)Session["usuario"];
            switch (int.Parse(usuario.Rows[0]["id_rol"].ToString()))
            {
                case 1:
                    tituloRolL.Text = "Super Admin";
                    Emple1.Visible = false;
                    Emple2.Visible = false;
                    Emple4.Visible = false;
                    Emple5.Visible = false;
                    Emple6.Visible = false;
                    Producto1.Visible = false;
                    Producto2.Visible = false;
                    Producto4.Visible = false;
                    Pedido2.Visible = false;
                    break;
                case 2:
                    tituloRolL.Text = "Admin";
                    opcAdmin.Visible = false;
                    Emple6.Visible = false;
                    opcCliente.Visible = false;
                    Producto4.Visible = false;
                    opcCliente.Visible = false;
                    break;
                case 3:
                    tituloRolL.Text = "Empleado";
                    opcAdmin.Visible = false;
                    Emple1.Visible = false;
                    Emple2.Visible = false;
                    Emple3.Visible = false;
                    Emple4.Visible = false;
                    Emple5.Visible = false;
                    Producto1.Visible = false;
                    Producto2.Visible = false;
                    opcBloqueos.Visible = false;
                    opcCliente.Visible = false;
                    break;
                case 4:
                    tituloRolL.Text = "Cliente";
                    opcAdmin.Visible = false;
                    opcEmple.Visible = false;
                    opcBloqueos.Visible = false;
                    opcProducto.Visible = false;
                    Pedido2.Visible = false;
                    break;
            }
            nombresUsuarioL.Text = usuario.Rows[0]["nombres_usuario"].ToString();
            correoUsuarioL.Text = usuario.Rows[0]["correo_usuario"].ToString();
            usuarioLB.Text = "<i class='material-icons right'>arrow_drop_down</i>" + " Bienvenido: " + usuario.Rows[0]["user_name"];
            usuarioLB.Visible = true;
        }
        else
        {
            Response.Redirect("login.aspx");
        }
    }

    protected void registrarAdminLB_Click(object sender, EventArgs e)
    {
        Session["tipo_registro"] = 1;
        Response.Redirect("registarFuncionario.aspx");
    }

    protected void modificarAdminLB_Click(object sender, EventArgs e)
    {
        Session["tipo_modificar"] = 1;
        Response.Redirect("modificarFuncionario.aspx");
    }

    protected void visualizarAdminLB_Click(object sender, EventArgs e)
    {
        Response.Redirect("visualizarAdmin.aspx");
    }

    protected void registrarEmpleLB_Click(object sender, EventArgs e)
    {
        Session["tipo_registro"] = 2;
        Response.Redirect("registarFuncionario.aspx");
    }

    protected void modificarEmpleLB_Click(object sender, EventArgs e)
    {
        Session["tipo_modificar"] = 2;
        Response.Redirect("modificarFuncionario.aspx");
    }

    protected void visualizarEmpleLB_Click(object sender, EventArgs e)
    {
        Response.Redirect("visualizarEmpleado.aspx");
    }

    protected void registrarProduLB_Click(object sender, EventArgs e)
    {
        Response.Redirect("registrarProducto.aspx");
    }

    protected void modificarProduLB_Click(object sender, EventArgs e)
    {
        Response.Redirect("modificarProducto.aspx");
    }

    protected void visualizarProduLB_Click(object sender, EventArgs e)
    {
        Response.Redirect("visualizarProducto.aspx");
    }

    protected void visualizarClienLB_Click(object sender, EventArgs e)
    {
        Response.Redirect("visualizarCliente.aspx");
    }

    protected void visualizarPediLB_Click(object sender, EventArgs e)
    {
        Response.Redirect("visualizarPedido.aspx");
    }

    protected void actualizarPediLB_Click(object sender, EventArgs e)
    {
        Response.Redirect("actualizarPedido.aspx");
    }

    protected void historialPediLB_Click(object sender, EventArgs e)
    {
        Response.Redirect("historialPedido.aspx");
    }

    protected void reporteEmpleLB_Click(object sender, EventArgs e)
    {
        Response.Redirect("reporte_empleados.aspx");
    }

    protected void certificadoLaboralLB_Click(object sender, EventArgs e)
    {
        Response.Redirect("reporte_certificado.aspx");
    }

    protected void bloquearUsuLB_Click(object sender, EventArgs e)
    {
        Response.Redirect("BloquearUsuario.aspx");
    }

    protected void actualizarInventarioLB_Click(object sender, EventArgs e)
    {
        Response.Redirect("actualizarInventario.aspx");
    }

    protected void eliminarEmpleLB_Click(object sender, EventArgs e)
    {
        Response.Redirect("EliminarEmpleado.aspx");
    }

    protected void inicioB_Click(object sender, EventArgs e)
    {
        Response.Redirect("index.aspx");
    }

    protected void cerrarSesionLB_Click(object sender, EventArgs e)
    {
        Session["usuario"] = null;
        Response.Redirect("index.aspx");
    }

    protected void reporteProductosLB_Click(object sender, EventArgs e)
    {
        Response.Redirect("reporte_productos.aspx");
    }

    protected void eliminarProductoLB_Click(object sender, EventArgs e)
    {
        Response.Redirect("eliminarProducto.aspx");
    }

    protected void historialComprasLB_Click(object sender, EventArgs e)
    {
        Response.Redirect("historialCompras.aspx");
    }
}
