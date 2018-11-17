using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_actualizarInventario : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        formularioOculto.Visible = false;
    }

    protected void buscarB_Click(object sender, EventArgs e)
    {
        bvalidaL.Visible = false;
        bNoValidaL.Visible = false;
        if (buscarTB.Text!="")
        {
            Eproducto encapsular = new Eproducto();
            DAproducto funcion = new DAproducto();
            DataTable productoValido = new DataTable();
            encapsular.CodigoProducto = buscarTB.Text;
            productoValido = funcion.buscarUsuario(encapsular);
            if (productoValido.Rows.Count>0)
            {
                nombreL.Text = "Nombre Producto: "+productoValido.Rows[0]["nombre_producto"].ToString();
                codigoL.Text = "Codigo Producto: "+productoValido.Rows[0]["codigo_producto"].ToString();
                fotoProI.ImageUrl = productoValido.Rows[0]["foto_producto"].ToString();
                formularioOculto.Visible = true;    
            }
            else
            {
                bNoValidaL.Text = "Sin resultados";
                bNoValidaL.Visible = true;
            }
        }
        else
        {
            bNoValidaL.Text = "Llene todos los campos";
            bNoValidaL.Visible = true;
        }
    }

    protected void modificarB_Click(object sender, EventArgs e)
    {
        validoL.Visible = false;
        noValidoL.Visible = false;
        formularioOculto.Visible = true;
        
        if (cantidadTB.Text!="")
        {
            if (int.Parse(cantidadTB.Text) <= 0)
            {
                noValidoL.Text = "Cantidad no valida";
                noValidoL.Visible = true;
            }
            else
            {
                DAproducto funcion = new DAproducto();
                funcion.actualizarInventario(codigoL.Text, int.Parse(cantidadTB.Text));
                validoL.Text = "¡Actualizacion exitosa!";
                validoL.Visible = true;
            }
        }
        else
        {
            noValidoL.Text = "Llene todos los campos";
            noValidoL.Visible = true;
        }
    }
}