using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Emensaje
/// </summary>
public class Emensaje
{
    private string nombres;
    private string telefono;
    private string correo;
    private string mensaje;

    public Emensaje()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public string Nombres { get => nombres; set => nombres = value; }
    public string Telefono { get => telefono; set => telefono = value; }
    public string Correo { get => correo; set => correo = value; }
    public string Mensaje { get => mensaje; set => mensaje = value; }
}