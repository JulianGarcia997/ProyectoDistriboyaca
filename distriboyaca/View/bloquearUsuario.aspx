<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master/master2.master" AutoEventWireup="true" CodeFile="~/Controller/bloquearUsuario.aspx.cs" Inherits="View_bloquearUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container">
    <div class="row center-align">
      <h4>Bloquear Usuario</h4>
    </div>
    <div class="row">
      <p>
        Ingrese la cedula del funcionario que del usuario que desea bloquear.
      </p>
    </div>
    <div class="row">
      <div class="col l6 m12 s12">
        <div class="input-field">
          <i class="material-icons prefix">search</i>
          <asp:TextBox ID="buscarTB" CssClass="validate" runat="server"></asp:TextBox>
          <label>Cedula:</label>
        </div>
      </div>
    </div>
    <div class="row">
      <asp:Label ID="bvalidaL" CssClass="green-text" Font-Size="Large" Visible="false" runat="server"></asp:Label>
      <asp:Label ID="bNoValidaL" CssClass="red-text" Font-Size="Large" Visible="false" runat="server"></asp:Label>
    </div>
    <div class="row center-align">
      <asp:Button ID="buscarB" CssClass="btn-large waves-effect waves-light indigo darken-4" Text="Buscar" runat="server" OnClick="buscarB_Click"/>
    </div>
    <div id="oculto" runat="server">
    <div class="row center-align">
      <h4>Cambiar Estado</h4>
    </div>
    <div class="row"> 
      <asp:Label ID="nombreL" runat="server"></asp:Label><b/>
      <asp:Label ID="cedulaL" runat="server"></asp:Label><br/>
      <asp:DropDownList ID="DDL_estado" class='dropdown-trigger btn' runat="server" Height="27px" Width="142px">
        <asp:ListItem>Activo</asp:ListItem>
        <asp:ListItem>Inactivo</asp:ListItem>
      </asp:DropDownList>
      <div class="row center-align">
        <asp:Button ID="CambiarB" CssClass="btn-large waves-effect waves-light indigo darken-4" Text="Buscar" runat="server" OnClick="CambiarB_Click"/>
      </div>
    </div>
    </div>
  </div>
    </b>
</asp:Content>

