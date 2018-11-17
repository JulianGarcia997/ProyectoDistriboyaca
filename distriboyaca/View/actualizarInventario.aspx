<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master/master2.master" AutoEventWireup="true" CodeFile="~/Controller/actualizarInventario.aspx.cs" Inherits="View_actualizarInventario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container" style="padding-top:50px">
    <div class="row center-align">
      <asp:Label ID="tituloFormularioL" Font-Size="XX-Large" runat="server"></asp:Label>
    </div>
    <div class="row">
      <p>
        Ingrese el codigo del producto.
      </p>
    </div>
    <div class="row">
      <div class="col l6 m12 s12">
        <div class="input-field">
          <i class="material-icons prefix">search</i>
          <asp:TextBox ID="buscarTB" CssClass="validate" runat="server"></asp:TextBox>
          <label>Codigo:</label>
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
    <div id="formularioOculto" style="padding-top:30px" runat="server">
      <div class="row" >
        <div class="col l8 m12 s12" style="padding:70px">
          <div class="row center-align">
            <h3>Informacion</h3>
          </div>
          <div class="row">
            <div class="col l6">
              <asp:Label ID="nombreL" CssClass="indigo-text" Font-Size="Large" runat="server"></asp:Label>
            </div>
            <div class="col l6">
              <asp:Label ID="codigoL" CssClass="indigo-text" Font-Size="Large" runat="server"></asp:Label>
            </div>
          </div>
          <div class="row">
            <div class="input-field">
              <asp:TextBox ID="cantidadTB" TextMode="Number" runat="server"></asp:TextBox>
              <label>Cantidad a Ingresar:</label>
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
        <div class="col l4 m12 s12">
          <asp:Image ID="fotoProI" CssClass="responsive-img" runat="server"/>
        </div>
      </div>
      
    </div>
  </div>
</asp:Content>

