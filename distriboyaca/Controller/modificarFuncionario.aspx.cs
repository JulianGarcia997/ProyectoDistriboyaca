using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_modificarFuncionario : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["tipo_modificar"] != null)
        {
            switch (int.Parse(Session["tipo_modificar"].ToString()))
            {
                case 1:
                    tituloFormularioL.Text = "Modificar Admin";
                    break;
                case 2:
                    tituloFormularioL.Text = "Modificar Empleado";
                    break;
            }
            formularioOculto.Visible = false;
        }
    }

    protected void buscarB_Click(object sender, EventArgs e)
    {
        bvalidaL.Visible = false;
        bNoValidaL.Visible = false;
        if (buscarTB.Text!="")
        {
            Eusuario encapsular = new Eusuario();
            DAusuario funcion = new DAusuario();
            DataTable usuarioValido = new DataTable();
            encapsular.CedulaUsuario = buscarTB.Text;
            usuarioValido = funcion.buscarUsuario(encapsular);
            if (usuarioValido.Rows.Count>0)
            {
                if (int.Parse(usuarioValido.Rows[0]["id_rol"].ToString()) != int.Parse(Session["tipo_modificar"].ToString())+1)
                {
                    bNoValidaL.Text = "El usuario que busca no pertenece a este rol";
                    bNoValidaL.Visible = true;
                }
                else
                {
                    nombresTB.Text = usuarioValido.Rows[0]["nombres_usuario"].ToString();
                    cedulaTB.Text = usuarioValido.Rows[0]["cedula_usuario"].ToString();
                    telefonoTB.Text = usuarioValido.Rows[0]["telefono_usuario"].ToString();
                    direccionTB.Text = usuarioValido.Rows[0]["direccion_usuario"].ToString();
                    userNameTB.Text = usuarioValido.Rows[0]["user_name"].ToString();
                    correoTB.Text = usuarioValido.Rows[0]["correo_usuario"].ToString();
                    contrasenaTB.Text = usuarioValido.Rows[0]["contrasena_usuario"].ToString();
                    if (usuarioValido.Rows[0]["sexo_usuario"].ToString() == "Masculino")
                    {
                        masculinoRB.Checked = true;
                    }
                    else
                    {
                        femeninoRB.Checked = true;
                    }
                    fechaIngresoTB.Text = usuarioValido.Rows[0]["fecha_ingreso"].ToString();
                    Session["id"] = usuarioValido.Rows[0]["id_usuario"].ToString();
                    Session["cedula"] = cedulaTB.Text;
                    Session["user_name"] = userNameTB.Text;
                    Session["correo"] = correoTB.Text;
                    formularioOculto.Visible = true;
                }
            }
            else
            {
                bNoValidaL.Text = "Sin resultados";
                bNoValidaL.Visible = true;
            }
        }
        else
        {
            bNoValidaL.Text = "Llene el campo de busqueda";
            bNoValidaL.Visible = true;
        }
    }

    protected void modificarB_Click(object sender, EventArgs e)
    {
        formularioOculto.Visible = true;
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
            if (cedulaTB.Text!=Session["cedula"].ToString() || userNameTB.Text!=Session["user_name"].ToString() || correoTB.Text!=Session["correo"].ToString())
            {
                usuarioValido = funcion.validarModificacionUsuario(encapsular, int.Parse(Session["id"].ToString()));
                if (usuarioValido.Rows.Count > 0)
                {
                    noValidoL.Text = "Datos no validos";
                    noValidoL.Visible = true;
                }
                else
                {
                    funcion.modificarUsuario(encapsular,int.Parse(Session["id"].ToString()));
                    validoL.Text = "¡Modificacion exitosa!";
                    validoL.Visible = true;
                }
            }
            else
            {
                funcion.modificarUsuario(encapsular, int.Parse(Session["id"].ToString()));
                validoL.Text = "¡Modificacion exitosa!";
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
