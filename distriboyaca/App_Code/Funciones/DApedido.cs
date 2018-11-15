using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de DApedido
/// </summary>
public class DApedido
{
    public DApedido()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public void registrarPedido(Epedido pedido)
    {
        DataTable pedidoNuevo = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["postgres"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("pedidos.f_registrar_pedido", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_nombre_usuario", NpgsqlDbType.Varchar).Value = pedido.NombreUsuario;
            dataAdapter.SelectCommand.Parameters.Add("_cedula_usuario", NpgsqlDbType.Varchar).Value = pedido.CedulaUsuario;
            dataAdapter.SelectCommand.Parameters.Add("_nombre_producto", NpgsqlDbType.Varchar).Value = pedido.NombreProducto;
            dataAdapter.SelectCommand.Parameters.Add("_codigo_pedido", NpgsqlDbType.Varchar).Value = pedido.CodigoProducto;
            dataAdapter.SelectCommand.Parameters.Add("_referencia_pedido", NpgsqlDbType.Varchar).Value = pedido.ReferenciaProducto;
            dataAdapter.SelectCommand.Parameters.Add("_cantidad", NpgsqlDbType.Integer).Value = pedido.CantidadProducto;
            dataAdapter.SelectCommand.Parameters.Add("_precio", NpgsqlDbType.Double).Value = pedido.Precio;
            dataAdapter.SelectCommand.Parameters.Add("_estado", NpgsqlDbType.Varchar).Value = pedido.Estado;
            conection.Open();
            dataAdapter.Fill(pedidoNuevo);
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