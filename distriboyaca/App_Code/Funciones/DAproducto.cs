using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de DAproducto
/// </summary>
public class DAproducto
{
    public DAproducto()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public void registrarProducto(Eproducto producto)
    {
        DataTable productoNuevo = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["postgres"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("productos.f_registrar_producto", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_nombre_producto", NpgsqlDbType.Varchar).Value = producto.NombreProducto;
            dataAdapter.SelectCommand.Parameters.Add("_codigo_producto", NpgsqlDbType.Varchar).Value = producto.CodigoProducto;
            dataAdapter.SelectCommand.Parameters.Add("_color_producto", NpgsqlDbType.Varchar).Value = producto.ColorProducto;
            dataAdapter.SelectCommand.Parameters.Add("_referencia_producto", NpgsqlDbType.Varchar).Value = producto.ReferenciaProducto;
            dataAdapter.SelectCommand.Parameters.Add("_precio_producto", NpgsqlDbType.Double).Value = producto.PrecioProducto;
            dataAdapter.SelectCommand.Parameters.Add("_cantidad_producto", NpgsqlDbType.Integer).Value = producto.CantidadProducto;
            dataAdapter.SelectCommand.Parameters.Add("_foto_producto", NpgsqlDbType.Text).Value = producto.FotoProducto;
            conection.Open();
            dataAdapter.Fill(productoNuevo);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
    }

    public void modificarProducto(Eproducto producto, int id)
    {
        DataTable modificarProducto = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["postgres"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("productos.f_modificar_producto", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_id_producto", NpgsqlDbType.Integer).Value = id;
            dataAdapter.SelectCommand.Parameters.Add("_nombre_producto", NpgsqlDbType.Varchar).Value = producto.NombreProducto;
            dataAdapter.SelectCommand.Parameters.Add("_codigo_producto", NpgsqlDbType.Varchar).Value = producto.CodigoProducto;
            dataAdapter.SelectCommand.Parameters.Add("_color_producto", NpgsqlDbType.Varchar).Value = producto.ColorProducto;
            dataAdapter.SelectCommand.Parameters.Add("_referencia_prodcuto", NpgsqlDbType.Varchar).Value = producto.ReferenciaProducto;
            dataAdapter.SelectCommand.Parameters.Add("_precio_producto", NpgsqlDbType.Double).Value = producto.PrecioProducto;
            dataAdapter.SelectCommand.Parameters.Add("_cantidad_producto", NpgsqlDbType.Integer).Value = producto.CantidadProducto;
            dataAdapter.SelectCommand.Parameters.Add("_foto_producto", NpgsqlDbType.Text).Value = producto.FotoProducto;
            conection.Open();
            dataAdapter.Fill(modificarProducto);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
    }

    public DataTable validarRegistroProducto(Eproducto produco)
    {
        DataTable productoValido = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["postgres"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("productos.f_validar_registro_producto", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_nombre_producto", NpgsqlDbType.Varchar).Value = produco.NombreProducto;
            dataAdapter.SelectCommand.Parameters.Add("_codigo_producto", NpgsqlDbType.Varchar).Value = produco.CodigoProducto;
            dataAdapter.SelectCommand.Parameters.Add("_color_producto", NpgsqlDbType.Varchar).Value = produco.ColorProducto;
            conection.Open();
            dataAdapter.Fill(productoValido);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return productoValido;
    }

    public DataTable buscarUsuario(Eproducto producto)
    {
        DataTable productoValido = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["postgres"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("productos.f_buscar_producto", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_codigo_producto", NpgsqlDbType.Varchar).Value = producto.CodigoProducto;
            conection.Open();
            dataAdapter.Fill(productoValido);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return productoValido;
    }

    public DataTable listarProductos()
    {
        DataTable productos = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["postgres"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("productos.f_listar_productos", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            conection.Open();
            dataAdapter.Fill(productos);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return productos;
    }

    public DataTable listartProductos()
    {
        DataTable productos = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["postgres"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("productos.f_listar_tproductos", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            conection.Open();
            dataAdapter.Fill(productos);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return productos;
    }

    public void descontarInventario(string codigo, int descontar)
    {
        DataTable modificarProducto = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["postgres"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("productos.f_descontar_producto", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_codigo_producto", NpgsqlDbType.Varchar).Value = codigo;
            dataAdapter.SelectCommand.Parameters.Add("descontar", NpgsqlDbType.Integer).Value = descontar;
            conection.Open();
            dataAdapter.Fill(modificarProducto);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
    }

    public void actualizarInventario(string codigo, int cantidad)
    {
        DataTable modificarProducto = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["postgres"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("productos.f_actualizar_inventario", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_codigo_producto", NpgsqlDbType.Varchar).Value = codigo;
            dataAdapter.SelectCommand.Parameters.Add("cantidad", NpgsqlDbType.Integer).Value = cantidad;
            conection.Open();
            dataAdapter.Fill(modificarProducto);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
    }
}