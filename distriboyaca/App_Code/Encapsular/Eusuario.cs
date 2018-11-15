using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Eusuario
/// </summary>
public class Eusuario
{

    private string nombreUsuario;
    private string cedulaUsuario;
    private string telefonoUsuario;
    private string direccionUsuario;
    private string userName;
    private string correoUsuario;
    private string contrasenaUsuario;
    private string sexoUsuario;
    private string fechaIngreso;
    private string estadoUsuario;
    private int rol;

    public Eusuario()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
    public string CedulaUsuario { get => cedulaUsuario; set => cedulaUsuario = value; }
    public string TelefonoUsuario { get => telefonoUsuario; set => telefonoUsuario = value; }
    public string DireccionUsuario { get => direccionUsuario; set => direccionUsuario = value; }
    public string UserName { get => userName; set => userName = value; }
    public string CorreoUsuario { get => correoUsuario; set => correoUsuario = value; }
    public string ContrasenaUsuario { get => contrasenaUsuario; set => contrasenaUsuario = value; }
    public string SexoUsuario { get => sexoUsuario; set => sexoUsuario = value; }
    public string FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
    public string EstadoUsuario { get => estadoUsuario; set => estadoUsuario = value; }
    public int Rol { get => rol; set => rol = value; }
}