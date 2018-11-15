using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de DAmensaje
/// </summary>
public class DAmensaje
{
    public DAmensaje()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public void registrarMensaje(Emensaje mensaje)
    {
        DataTable mensajeNuevo = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["postgres"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("mensajes.f_registrar_mensaje", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_nombres", NpgsqlDbType.Varchar).Value = mensaje.Nombres;
            dataAdapter.SelectCommand.Parameters.Add("_telefono", NpgsqlDbType.Varchar).Value = mensaje.Telefono;
            dataAdapter.SelectCommand.Parameters.Add("_correo", NpgsqlDbType.Varchar).Value = mensaje.Correo;
            dataAdapter.SelectCommand.Parameters.Add("_mensaje", NpgsqlDbType.Varchar).Value = mensaje.Mensaje;
            conection.Open();
            dataAdapter.Fill(mensajeNuevo);
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