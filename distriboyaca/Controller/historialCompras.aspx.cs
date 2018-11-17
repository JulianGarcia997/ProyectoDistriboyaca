using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_historialCompras : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable usuario = (DataTable)Session["usuario"];
        Epedido encapsular = new Epedido();
        DApedido funcion = new DApedido();
        DataTable grid = new DataTable();
        encapsular.CedulaUsuario = usuario.Rows[0]["cedula_usuario"].ToString();
        grid = funcion.historialCompras(encapsular);
        GridView1.DataSource = grid;
        GridView1.DataBind();
    }
}