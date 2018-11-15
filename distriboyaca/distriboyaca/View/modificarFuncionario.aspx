<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master/master2.master" AutoEventWireup="true" CodeFile="~/Controller/modificarFuncionario.aspx.cs" Inherits="View_modificarFuncionario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <div class="container" style="padding-top:50px">
    <div class="row center-align">
      <asp:Label ID="tituloFormularioL" Font-Size="XX-Large" runat="server"></asp:Label>
    </div>
    <div class="row">
      <p>
        Ingrese la cedula del funcionario que desea modificar.
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
    <div id="formularioOculto" runat="server">
      <div class="row center-align">
        <asp:Label ID="Label1" Font-Size="XX-Large" runat="server"></asp:Label>
      </div>
      <div class="row">
        <div class="col l6 m12 s12 input-field">
          <asp:TextBox ID="nombresTB" CssClass="validate" runat="server"></asp:TextBox>
          <label>Nombres:</label>
        </div>
        <div class="col l6 m12 s12 input-field">
          <asp:TextBox ID="cedulaTB" CssClass="validate" runat="server"></asp:TextBox>
          <label>Cedula:</label>
        </div>
      </div>
      <div class="row">
        <div class="col l6 m12 s12 input-field">
          <asp:TextBox ID="telefonoTB" CssClass="validate" runat="server"></asp:TextBox>
          <label>Telefono:</label>
        </div>
        <div class="col l6 m12 s12 input-field">
          <asp:TextBox ID="direccionTB" CssClass="validate" runat="server"></asp:TextBox>
          <label>Direccion:</label>
        </div>
      </div>
      <div class="row">
        <div class="col l6 m12 s12 input-field">
          <asp:TextBox ID="userNameTB" CssClass="validate" runat="server"></asp:TextBox>
          <label>UserName:</label>
        </div>
        <div class="col l6 m12 s12 input-field">
          <asp:TextBox ID="correoTB" CssClass="validate" TextMode="Email" runat="server"></asp:TextBox>
          <label>Correo:</label>
        </div>
      </div>
      <div class="row">
        <div class="col l6 m12 s12 input-field">
          <asp:TextBox ID="contrasenaTB" CssClass="validate" runat="server"></asp:TextBox>
          <label>Contraseña:</label>
        </div>
        <div class="col l6 m12 s12">
          <fieldset>
            <legend>Sexo:</legend>
            <asp:RadioButton ID="masculinoRB" GroupName="sexo" Text="Masculino" runat="server"/>
            <asp:RadioButton ID="femeninoRB" GroupName="sexo" Text="Femenino" runat="server"/>
          </fieldset>
        </div>
      </div>
      <div class="row">
        <div class="col l6 s12 m12">
          <asp:TextBox ID="fechaIngresoTB" TextMode="Date" runat="server"></asp:TextBox>
          <label>Fecha Ingreso:</label>
        </div>
      </div>
      <div class="row">
        <asp:Label ID="validoL" CssClass="green-text" Font-Size="Large" Visible="false" runat="server"></asp:Label>
        <asp:Label ID="noValidoL" CssClass="red-text" Font-Size="Large" Visible="false" runat="server"></asp:Label>
      </div>
      <div class="row center-align">
        <asp:Button ID="modificarB" CssClass="btn-large waves-effect waves-light indigo darken-4" Text="Modificar" runat="server" OnClick="modificarB_Click"/>
      </div>
    </div>
  </div>
</asp:Content>

