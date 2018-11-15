<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master/master2.master" AutoEventWireup="true" CodeFile="~/Controller/registrarProducto.aspx.cs" Inherits="View_registrarProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container" style="padding-top:50px">
    <div class="row center-align">
      <h4>Registrar Producto Nuevo</h4>
    </div>
    <div class="row">
      <div class="col l6 m12 s12 input-field">
        <asp:TextBox ID="nombreTB" CssClass="validate" runat="server"></asp:TextBox>
        <label>Nombre:</label>
      </div>
      <div class="col l6 m12 s12 input-field">
        <asp:TextBox ID="codigoTB" CssClass="validate" runat="server"></asp:TextBox>
        <label>Codigo:</label>
      </div>
    </div>
    <div class="row">
      <div class="col l6 m12 s12 input-field">
        <asp:TextBox ID="colorTB" CssClass="validate" runat="server"></asp:TextBox>
        <label>Color:</label>
      </div>
      <div class="col l6 m12 s12 input-field">
        <asp:TextBox ID="referenciaTB" CssClass="validate" runat="server"></asp:TextBox>
        <label>Referencia:</label>
      </div>
    </div>
    <div class="row">
      <div class="col l6 m12 s12 input-field">
        <asp:TextBox ID="precioTB" CssClass="validate" runat="server"></asp:TextBox>
        <label>Precio:</label>
      </div>
      <div class="col l6 m12 s12 input-field">
        <asp:TextBox ID="cantidadInicialTB" CssClass="validate" runat="server"></asp:TextBox>
        <label>Cantidad inicial:</label>
      </div>
    </div>
    <div class="row">
      <fieldset>
        <legend>Foto:</legend>
        <asp:FileUpload ID="fotoFU" runat="server" />
      </fieldset>
    </div>
    <div class="row">
      <asp:Label ID="validoL" CssClass="green-text" Font-Size="Large" Visible="false" runat="server"></asp:Label>
      <asp:Label ID="noValidoL" CssClass="red-text" Font-Size="Large" Visible="false" runat="server"></asp:Label>
    </div>
    <div class="row center-align">
      <asp:Button ID="registrarB" CssClass="btn-large waves-effect waves-light indigo darken-4" Text="Registrar" runat="server" OnClick="registrarB_Click"/>
    </div>
  </div>
</asp:Content>

