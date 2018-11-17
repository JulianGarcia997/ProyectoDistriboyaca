using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_bloquearUsuario : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        oculto.Visible = false;
    }

    protected void buscarB_Click(object sender, EventArgs e)
    {
        Eusuario encapsular = new Eusuario();
        DAusuario funcion = new DAusuario();
        DataTable usuarioValido = new DataTable();
        encapsular.CedulaUsuario = buscarTB.Text;
        usuarioValido = funcion.buscarUsuario(encapsular);
        if (usuarioValido.Rows.Count>0)
        {
            nombreL.Text = usuarioValido.Rows[0]["nombres_usuario"].ToString();
            cedulaL.Text = usuarioValido.Rows[0]["cedula_usuario"].ToString();
            oculto.Visible = true;
        }
        else
        {
            bNoValidaL.Text = "Sin resultados";
            bNoValidaL.Visible = true;
        }
    }

    protected void CambiarB_Click(object sender, EventArgs e)
    {
        DAusuario funcion = new DAusuario();

        if (DDL_estado.SelectedValue=="Activo")
        {
            funcion.cambiarEstado(nombreL.Text,"activo");
        }
        else
        {
            funcion.cambiarEstado(nombreL.Text, "inactivo");
        }

    }
}