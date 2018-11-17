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
                    break;
                case 2:
                    tituloRolL.Text = "Admin";
                    break;
                case 3:
                    tituloRolL.Text = "Empleado";
                    break;
                case 4:
                    tituloRolL.Text = "Cliente";
                    break;
            }
            nombresUsuarioL.Text = usuario.Rows[0]["nombres_usuario"].ToString();
            correoUsuarioL.Text = usuario.Rows[0]["correo_usuario"].ToString();
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
}
