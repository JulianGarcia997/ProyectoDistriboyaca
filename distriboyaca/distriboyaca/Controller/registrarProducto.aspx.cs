using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_registrarProducto : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void registrarB_Click(object sender, EventArgs e)
    {
        validoL.Visible = false;
        noValidoL.Visible = false;
        try
        {
            if (nombreTB.Text != "" && codigoTB.Text != "" && colorTB.Text != "" && referenciaTB.Text != "" && precioTB.Text != "" && cantidadInicialTB.Text != "" && fotoFU.HasFile)
            {
                Eproducto encapsular = new Eproducto();
                DAproducto funcion = new DAproducto();
                DataTable productoValido = new DataTable();
                encapsular.NombreProducto = nombreTB.Text;
                encapsular.CodigoProducto = codigoTB.Text;
                encapsular.ColorProducto = colorTB.Text;
                encapsular.ReferenciaProducto = referenciaTB.Text;
                if (double.Parse(precioTB.Text) <= 0)
                {
                    noValidoL.Text = "Precio no valido";
                    noValidoL.Visible = true;
                }
                else
                {
                    encapsular.PrecioProducto = double.Parse(precioTB.Text);
                    if (int.Parse(cantidadInicialTB.Text) < 0)
                    {
                        noValidoL.Text = "Cantidad no valida";
                        noValidoL.Visible = true;
                    }
                    else
                    {
                        encapsular.CantidadProducto = int.Parse(cantidadInicialTB.Text);
                        encapsular.FotoProducto = cargarImagen();
                        productoValido = funcion.validarRegistroProducto(encapsular);
                        if (productoValido.Rows.Count > 0)
                        {
                            noValidoL.Text = "Datos no validos";
                            noValidoL.Visible = true;
                        }
                        else
                        {
                            funcion.registrarProducto(encapsular);
                            nombreTB.Text = "";
                            codigoTB.Text = "";
                            colorTB.Text = "";
                            referenciaTB.Text = "";
                            precioTB.Text = "";
                            cantidadInicialTB.Text = "";
                            validoL.Text = "¡Registro exitoso!";
                            validoL.Visible = true;
                        }
                    }
                }
            }
            else
            {
                noValidoL.Text = "Llene todos los campos primero";
                noValidoL.Visible = true;
            }
        }
        catch (Exception Ex)
        {
            noValidoL.Text = "Los caracteres no son validos en el precio o la cantidad";
            noValidoL.Visible = true;
        }
    }

    private string cargarImagen()
    {
        string saveLocation = "";
        string nombreArchivo = System.IO.Path.GetFileName(fotoFU.PostedFile.FileName);
        string extension = System.IO.Path.GetExtension(fotoFU.PostedFile.FileName);
        if (!(string.Compare(extension, ".jpg", true) == 0 || string.Compare(extension, ".jpeg", true) == 0 || string.Compare(extension, ".gif", true) == 0))
        {
        }
        //Crear ruta de la imagen
        saveLocation = Server.MapPath("~\\Img\\Productos") + "\\" + nombreArchivo;
        //guardar en la ruta
        fotoFU.PostedFile.SaveAs(saveLocation);
        //retornar ruta
        return "~\\Img\\Productos" + "\\" + nombreArchivo;
    }
}