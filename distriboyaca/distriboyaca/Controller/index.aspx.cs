using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void EnviarB_Click(object sender, EventArgs e)
    {
        validoL.Visible = false;
        noValidoL.Visible = false;
        if (nombresTB.Text!="" && telefonoTB.Text!="" && correoTB.Text!="" && mensajeTB.Text!="")
        {
            Emensaje encapsular = new Emensaje();
            DAmensaje funcion = new DAmensaje();
            encapsular.Nombres = nombresTB.Text;
            encapsular.Telefono = telefonoTB.Text;
            encapsular.Correo = correoTB.Text;
            encapsular.Mensaje = mensajeTB.Text;
            funcion.registrarMensaje(encapsular);
            validoL.Text = "¡Mensaje enviado!";
            validoL.Visible = true;
            nombresTB.Text = "";
            telefonoTB.Text = "";
            correoTB.Text = "";
            mensajeTB.Text = "";
        }
        else
        {
            noValidoL.Text = "Llene todos los campos primero";
            noValidoL.Visible = true;
        }
    }
}