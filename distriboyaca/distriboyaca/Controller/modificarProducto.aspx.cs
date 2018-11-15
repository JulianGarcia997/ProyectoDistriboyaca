using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_modificarProducto : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        formularioOculto.Visible = false;
    }

    protected void buscarB_Click(object sender, EventArgs e)
    {
        bvalidaL.Visible = false;
        bNoValidaL.Visible = false;
        if (buscarTB.Text != "")
        {
            Eproducto encapsular = new Eproducto();
            DAproducto funcion = new DAproducto();
            DataTable productoValido = new DataTable();
            encapsular.CodigoProducto = buscarTB.Text;
            productoValido = funcion.buscarUsuario(encapsular);
            if (productoValido.Rows.Count > 0)
            {
                nombreTB.Text = productoValido.Rows[0]["nombre_producto"].ToString();
                codigoTB.Text = productoValido.Rows[0]["codigo_producto"].ToString();
                colorTB.Text = productoValido.Rows[0]["color_producto"].ToString();
                referenciaTB.Text = productoValido.Rows[0]["referencia_producto"].ToString();
                precioTB.Text = productoValido.Rows[0]["precio_producto"].ToString();
                cantidadTB.Text = productoValido.Rows[0]["cantidad_producto"].ToString();
                fotoI.ImageUrl = productoValido.Rows[0]["foto_producto"].ToString();
                Session["id_producto"] = productoValido.Rows[0]["id_producto"].ToString();
                Session["nombre_producto"] = nombreTB.Text;
                Session["codigo_producto"] = codigoTB.Text;
                Session["foto_producto"] = productoValido.Rows[0]["foto_producto"].ToString();
                formularioOculto.Visible = true;
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
       // try
        //{
            if (nombreTB.Text != "" && codigoTB.Text != "" && colorTB.Text != "" && referenciaTB.Text != "" && precioTB.Text != "" && cantidadTB.Text != "")
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
                    if (int.Parse(cantidadTB.Text) < 0)
                    {
                        noValidoL.Text = "Cantidad no valida";
                        noValidoL.Visible = true;
                    }
                    else
                    {
                        encapsular.CantidadProducto = int.Parse(cantidadTB.Text);
                        encapsular.FotoProducto = cargarImagen();
                        if (nombreTB.Text!=Session["nombre_producto"].ToString() || codigoTB.Text!=Session["codigo_producto"].ToString())
                        {
                            productoValido = funcion.validarRegistroProducto(encapsular);
                            if (productoValido.Rows.Count > 0)
                            {
                                noValidoL.Text = "Datos no validos";
                                noValidoL.Visible = true;
                            }
                            else
                            {
                                funcion.modificarProducto(encapsular,int.Parse(Session["id_producto"].ToString()));
                                fotoI.ImageUrl = cargarImagen();
                                validoL.Text = "¡Modificacion exitosa!";
                                validoL.Visible = true;
                            }
                        }
                        else
                        {
                            funcion.modificarProducto(encapsular,int.Parse(Session["id_producto"].ToString()));
                            fotoI.ImageUrl = cargarImagen();
                            validoL.Text = "¡Modificacion exitosa!";
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
        //}
        /*catch (Exception Ex)
        {
            noValidoL.Text = "Los caracteres no son validos en el precio o la cantidad";
            noValidoL.Visible = true;
        }*/
    }

    private string cargarImagen()
    {
        string saveLocation = "";
        string nombreArchivo = System.IO.Path.GetFileName(fotoFU.PostedFile.FileName);
        string extension = System.IO.Path.GetExtension(fotoFU.PostedFile.FileName);
        if (!(string.Compare(extension, ".jpg", true) == 0 || string.Compare(extension, ".jpeg", true) == 0 || string.Compare(extension, ".gif", true) == 0))
        {
        }
        if (fotoFU.HasFile)
        {
            saveLocation = Server.MapPath("~\\Img\\Productos") + "\\" + nombreArchivo;
            fotoFU.PostedFile.SaveAs(saveLocation);
            return "~\\Img\\Productos" + "\\" + nombreArchivo;
        }
        else
        {
            string foto = Session["foto_producto"].ToString();
            return foto;
        }
    }
}