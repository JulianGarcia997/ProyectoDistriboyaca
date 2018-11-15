using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Epedido
/// </summary>
public class Epedido
{

    private string nombreUsuario;
    private string cedulaUsuario;
    private string nombreProducto;
    private string codigoProducto;
    private string referenciaProducto;
    private int cantidadProducto;
    private double precio;
    private string estado;


    public Epedido()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
    public string CedulaUsuario { get => cedulaUsuario; set => cedulaUsuario = value; }
    public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
    public string CodigoProducto { get => codigoProducto; set => codigoProducto = value; }
    public string ReferenciaProducto { get => referenciaProducto; set => referenciaProducto = value; }
    public int CantidadProducto { get => cantidadProducto; set => cantidadProducto = value; }
    public double Precio { get => precio; set => precio = value; }
    public string Estado { get => estado; set => estado = value; }
}