<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master/master1.master" AutoEventWireup="true" CodeFile="~/Controller/registrarse.aspx.cs" Inherits="View_registrarse" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <div class="row" style="margin:0px">
    <div id="fondoRegistrarse" class="col l6 hide-on-med-and-down"></div>
    <div class="col l6 m12 s12" style="padding:30px">
      <div class="row center-align">
        <h4>Registrarse</h4>
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
        <asp:Label ID="validoL" CssClass="green-text" Font-Size="Large" Visible="false" runat="server"></asp:Label>
        <asp:Label ID="noValidoL" CssClass="red-text" Font-Size="Large" Visible="false" runat="server"></asp:Label>
      </div>
      <div class="row center-align">
        <asp:Button ID="registrarseB" CssClass="btn-large waves-effect waves-light black" Text="Registrarse" runat="server" OnClick="registrarseB_Click"/>
      </div>
    </div>
  </div>
</asp:Content>

