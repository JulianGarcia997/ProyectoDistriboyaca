using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Eproducto
/// </summary>
public class Eproducto
{

    private string nombreProducto;
    private string codigoProducto;
    private string colorProducto;
    private string referenciaProducto;
    private double precioProducto;
    private int cantidadProducto;
    private string fotoProducto;

    public Eproducto()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
    public string CodigoProducto { get => codigoProducto; set => codigoProducto = value; }
    public string ColorProducto { get => colorProducto; set => colorProducto = value; }
    public string ReferenciaProducto { get => referenciaProducto; set => referenciaProducto = value; }
    public double PrecioProducto { get => precioProducto; set => precioProducto = value; }
    public int CantidadProducto { get => cantidadProducto; set => cantidadProducto = value; }
    public string FotoProducto { get => fotoProducto; set => fotoProducto = value; }
}