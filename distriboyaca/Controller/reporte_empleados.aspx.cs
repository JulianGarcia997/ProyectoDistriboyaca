using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class View_reporte_empleados : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {


            Infor_empleado reporte = ObtenerInforme();
            CRS_reporte_empelados.ReportDocument.SetDataSource(reporte);
            CRV_reporte_empleados.ReportSource = CRS_reporte_empelados;
            
            
        }
        catch(Exception)
        {
            throw;
        }


    }
    protected Infor_empleado ObtenerInforme()
    {
        DataRow fila;
        DataTable informacion = new DataTable();
        Infor_empleado datos = new Infor_empleado();
        informacion = datos.Tables["Empleados"];

        DAusuario empleado = new DAusuario();
        DataTable intermedio = empleado.listarUsuarios(3);

        for (int i=0; i < intermedio.Rows.Count; i++)
        {

            fila = informacion.NewRow();
            fila["Nombres"] = intermedio.Rows[i]["nombres_usuario"].ToString();
           // fila["Nombres"] = Session["nombres"];
            fila["Nombre Usuario"] = intermedio.Rows[i]["user_name"].ToString();
            fila["Correo"] = intermedio.Rows[i]["correo_usuario"].ToString();
            fila["Telefono"] = intermedio.Rows[i]["telefono_usuario"].ToString();
            fila["Estado"] = intermedio.Rows[i]["estado_usuario"].ToString();

            if (intermedio.Rows[i]["nombres_usuario"].ToString()=="true")
            {
                fila["Estado"] = "Inactivo";

            }
            else
            {
                fila["Estado"] = "Activo";
            }

            informacion.Rows.Add(fila);
        }

        return datos;
    }











    protected void CRV_reporte_empleados_Init(object sender, EventArgs e)
    {

    }
}