using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de DAusuario
/// </summary>
public class DAusuario
{
    public DAusuario()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public void registrarUsuario(Eusuario usuario)
    {
        DataTable usuarioNuevo = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["postgres"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuarios.f_registrar_usuario", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_nombres_usuario", NpgsqlDbType.Varchar).Value = usuario.NombreUsuario;
            dataAdapter.SelectCommand.Parameters.Add("_cedula_usuario", NpgsqlDbType.Varchar).Value = usuario.CedulaUsuario;
            dataAdapter.SelectCommand.Parameters.Add("_telefono_usuario", NpgsqlDbType.Varchar).Value = usuario.TelefonoUsuario;
            dataAdapter.SelectCommand.Parameters.Add("_direccion_usuario", NpgsqlDbType.Varchar).Value = usuario.DireccionUsuario;
            dataAdapter.SelectCommand.Parameters.Add("_user_name", NpgsqlDbType.Varchar).Value = usuario.UserName;
            dataAdapter.SelectCommand.Parameters.Add("_correo_usuario", NpgsqlDbType.Varchar).Value = usuario.CorreoUsuario;
            dataAdapter.SelectCommand.Parameters.Add("_contrasena_usuario", NpgsqlDbType.Varchar).Value = usuario.ContrasenaUsuario;
            dataAdapter.SelectCommand.Parameters.Add("_sexo_usuario", NpgsqlDbType.Varchar).Value = usuario.SexoUsuario;
            if (usuario.FechaIngreso == null)
            {
                dataAdapter.SelectCommand.Parameters.Add("_fecha_ingreso", NpgsqlDbType.Varchar).Value = "no disponible";
            }
            else
            {
                dataAdapter.SelectCommand.Parameters.Add("_fecha_ingreso", NpgsqlDbType.Varchar).Value = usuario.FechaIngreso;
            }
            dataAdapter.SelectCommand.Parameters.Add("_estado_usuario", NpgsqlDbType.Varchar).Value = usuario.EstadoUsuario;
            dataAdapter.SelectCommand.Parameters.Add("_id_rol", NpgsqlDbType.Integer).Value = usuario.Rol;
            conection.Open();
            dataAdapter.Fill(usuarioNuevo);
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

    public void modificarUsuario(Eusuario usuario, int id)
    {
        DataTable modificarUsuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["postgres"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuarios.f_modificar_usuario", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_id_usuario", NpgsqlDbType.Integer).Value = id;
            dataAdapter.SelectCommand.Parameters.Add("_nombres_usuario", NpgsqlDbType.Varchar).Value = usuario.NombreUsuario;
            dataAdapter.SelectCommand.Parameters.Add("_cedula_usuario", NpgsqlDbType.Varchar).Value = usuario.CedulaUsuario;
            dataAdapter.SelectCommand.Parameters.Add("_telefono_usuario", NpgsqlDbType.Varchar).Value = usuario.TelefonoUsuario;
            dataAdapter.SelectCommand.Parameters.Add("_direccion_usuario", NpgsqlDbType.Varchar).Value = usuario.DireccionUsuario;
            dataAdapter.SelectCommand.Parameters.Add("_user_name", NpgsqlDbType.Varchar).Value = usuario.UserName;
            dataAdapter.SelectCommand.Parameters.Add("_correo_usuario", NpgsqlDbType.Varchar).Value = usuario.CorreoUsuario;
            dataAdapter.SelectCommand.Parameters.Add("_contrasena_usuario", NpgsqlDbType.Varchar).Value = usuario.ContrasenaUsuario;
            dataAdapter.SelectCommand.Parameters.Add("_sexo_usuario", NpgsqlDbType.Varchar).Value = usuario.SexoUsuario;
            dataAdapter.SelectCommand.Parameters.Add("_fecha_ingreso", NpgsqlDbType.Varchar).Value = usuario.FechaIngreso;
            conection.Open();
            dataAdapter.Fill(modificarUsuario);
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

    public DataTable validarRegistroUsuario(Eusuario usuario)
    {
        DataTable usuarioValido = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["postgres"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuarios.f_validar_registro_usuario", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_cedula_usuario", NpgsqlDbType.Varchar).Value = usuario.CedulaUsuario;
            dataAdapter.SelectCommand.Parameters.Add("_user_name", NpgsqlDbType.Varchar).Value = usuario.UserName;
            dataAdapter.SelectCommand.Parameters.Add("_correo_usuario", NpgsqlDbType.Varchar).Value = usuario.CorreoUsuario;
            conection.Open();
            dataAdapter.Fill(usuarioValido);
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
        return usuarioValido;
    }

    public DataTable validarModificacionUsuario(Eusuario usuario, int id)
    {
        DataTable usuarioValido = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["postgres"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuarios.f_validar_modificacion_usuario", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_id_usuario", NpgsqlDbType.Integer).Value = id;
            dataAdapter.SelectCommand.Parameters.Add("_cedula_usuario", NpgsqlDbType.Varchar).Value = usuario.CedulaUsuario;
            dataAdapter.SelectCommand.Parameters.Add("_user_name", NpgsqlDbType.Varchar).Value = usuario.UserName;
            dataAdapter.SelectCommand.Parameters.Add("_correo_usuario", NpgsqlDbType.Varchar).Value = usuario.CorreoUsuario;
            conection.Open();
            dataAdapter.Fill(usuarioValido);
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
        return usuarioValido;
    }

    public DataTable buscarUsuario(Eusuario usuario)
    {
        DataTable usuarioValido = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["postgres"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuarios.f_buscar_usuario", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_cedula_usuario", NpgsqlDbType.Varchar).Value = usuario.CedulaUsuario;
            conection.Open();
            dataAdapter.Fill(usuarioValido);
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
        return usuarioValido;
    }

    public DataTable listarUsuarios(int rol)
    {
        DataTable usuarios = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["postgres"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuarios.f_listar_usuarios", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_id_rol", NpgsqlDbType.Integer).Value = rol;
            conection.Open();
            dataAdapter.Fill(usuarios);
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
        return usuarios;
    }

    public DataTable verificarEstado(Eusuario usuario)
    {
        DataTable usuarioValido = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["postgres"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuarios.f_validar_estado", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_user_name", NpgsqlDbType.Varchar).Value = usuario.UserName;
            conection.Open();
            dataAdapter.Fill(usuarioValido);
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
        return usuarioValido;
    }

    public void cambiarEstado(string cedula, string estado)
    {
        DataTable usuarioValido = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["postgres"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuarios.f_cambiar_estado", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_cedula_usuario", NpgsqlDbType.Varchar).Value = cedula;
            dataAdapter.SelectCommand.Parameters.Add("cambio", NpgsqlDbType.Varchar).Value = estado;
            conection.Open();
            dataAdapter.Fill(usuarioValido);
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

    public DataTable login(Eusuario usuario)
    {
        DataTable usuarioValido = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["postgres"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuarios.f_login", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_user_name", NpgsqlDbType.Varchar).Value = usuario.UserName;
            dataAdapter.SelectCommand.Parameters.Add("_contrasena_usuario", NpgsqlDbType.Varchar).Value = usuario.ContrasenaUsuario;
            conection.Open();
            dataAdapter.Fill(usuarioValido);
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
        return usuarioValido;
    }
}