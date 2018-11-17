using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class View_reporte_productos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {


            infor_producto reporte = ObtenerInforme();
            CRS_reporte_productos.ReportDocument.SetDataSource(reporte);
            CRV_reporte_producto.ReportSource = CRS_reporte_productos;


        }
        catch (Exception)
        {
            throw;
        }


    }
    protected infor_producto ObtenerInforme()
    {
        DataRow fila;
        DataTable informacion = new DataTable();
        infor_producto datos = new infor_producto();
        informacion = datos.Tables["Productos"];

        DAproducto productos = new DAproducto();
        DataTable intermedio = productos.listartProductos();

        for (int i = 0; i < intermedio.Rows.Count; i++)
        {

            fila = informacion.NewRow();
            fila["Nombre"] = intermedio.Rows[i]["nombre_producto"].ToString();
            // fila["Nombres"] = Session["nombres"];
            fila["Codigo"] = intermedio.Rows[i]["codigo_producto"].ToString();
            fila["Color"] = intermedio.Rows[i]["color_producto"].ToString();
            fila["Referencia"] = intermedio.Rows[i]["referencia_producto"].ToString();
            fila["Cantidad"] = intermedio.Rows[i]["cantidad_producto"].ToString();
            fila["Precio"] = intermedio.Rows[i]["precio_producto"].ToString();

         
            informacion.Rows.Add(fila);
        }

        return datos;
    }

}