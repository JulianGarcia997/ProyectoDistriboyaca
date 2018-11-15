using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_registarFuncionario : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["tipo_registro"]!=null)
        {
            switch (int.Parse(Session["tipo_registro"].ToString()))
            {
                case 1:
                    tituloFormularioL.Text = "Registrar Nuevo Admin";
                    break;
                case 2:
                    tituloFormularioL.Text = "Registrar Nuevo Empleado";
                    break;
            }
        }
    }

    protected void registrarB_Click(object sender, EventArgs e)
    {
        validoL.Visible = false;
        noValidoL.Visible = false;
        if (nombresTB.Text != "" && cedulaTB.Text != "" && telefonoTB.Text != "" && direccionTB.Text != "" && userNameTB.Text != "" && correoTB.Text != "" && contrasenaTB.Text != "" && (masculinoRB.Checked == true || femeninoRB.Checked == true))
        {
            Eusuario encapsular = new Eusuario();
            DAusuario funcion = new DAusuario();
            DataTable usuarioValido = new DataTable();
            encapsular.NombreUsuario = nombresTB.Text;
            encapsular.CedulaUsuario = cedulaTB.Text;
            encapsular.TelefonoUsuario = telefonoTB.Text;
            encapsular.DireccionUsuario = direccionTB.Text;
            encapsular.UserName = userNameTB.Text;
            encapsular.CorreoUsuario = correoTB.Text;
            encapsular.ContrasenaUsuario = contrasenaTB.Text;
            if (masculinoRB.Checked == true)
            {
                encapsular.SexoUsuario = masculinoRB.Text;
            }
            else
            {
                encapsular.SexoUsuario = femeninoRB.Text;
            }
            encapsular.FechaIngreso = fechaIngresoTB.Text;
            encapsular.EstadoUsuario = "activo";
            encapsular.Rol = int.Parse(Session["tipo_registro"].ToString())+1;
            usuarioValido = funcion.validarRegistroUsuario(encapsular);
            if (usuarioValido.Rows.Count > 0)
            {
                noValidoL.Text = "Datos no validos";
                noValidoL.Visible = true;
            }
            else
            {
                funcion.registrarUsuario(encapsular);
                nombresTB.Text = "";
                cedulaTB.Text = "";
                telefonoTB.Text = "";
                direccionTB.Text = "";
                userNameTB.Text = "";
                correoTB.Text = "";
                contrasenaTB.Text = "";
                masculinoRB.Checked = false;
                femeninoRB.Checked = false;
                validoL.Text = "¡Registro exitoso!";
                validoL.Visible = true;
            }
        }
        else
        {
            noValidoL.Text = "Llene primero todos los campos";
            noValidoL.Visible = true;
        }
    }
}