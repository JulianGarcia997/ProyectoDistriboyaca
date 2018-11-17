using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class View_Backend_reporte_certificado : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
           

            Infor_empleado reporte = ObtenerInforme();
            CRS_Certificado.ReportDocument.SetDataSource(reporte);
            CRV_Certificado.ReportSource = CRS_Certificado;
        }
        catch (Exception)
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
        DataTable usuario = (DataTable)Session["usuario"];

            fila = informacion.NewRow();
            fila["Nombres"] = usuario.Rows[0]["nombres_usuario"];
            fila["Cedula"]  = usuario.Rows[0]["cedula_usuario"];
            fila["fecha entrada"] = usuario.Rows[0]["fecha_ingreso"];



        //fila["Nombres"] = intermedio.Rows[i]["nombres"].ToString();

        // fila["Nombre Usuario"] = intermedio.Rows[i]["user_name"].ToString();
        //fila["Correo"] = intermedio.Rows[i]["correo"].ToString();
        //fila["Telefono"] = intermedio.Rows[i]["telefono"].ToString();
        //fila["Estado"] = intermedio.Rows[i]["bloqueo"].ToString();



        informacion.Rows.Add(fila);
        

        return datos;
    }
    
}