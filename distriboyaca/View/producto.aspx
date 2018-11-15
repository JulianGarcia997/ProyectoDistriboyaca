<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master/master1.master" AutoEventWireup="true" CodeFile="~/Controller/producto.aspx.cs" Inherits="View_producto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container" style="padding:30px">
    <div class="row center-align">
      <h3>Producto a la venta</h3>
    </div>
    <div class="row">
      Toda la informacion relacionada con el producto que desea comprar...
    </div>
    <div class="row">
      <div class="col l6">
        <asp:Image ID="fotoProductoI" CssClass="responsive-img" runat="server"/>
      </div>
      <div class="col l6">
        <asp:Label ID="nombreL" Font-Size="Medium" runat="server"></asp:Label><br/> 
        <asp:Label ID="colorL" Font-Size="Medium" runat="server"></asp:Label><br/>
        <asp:Label ID="referenciaL" Font-Size="Medium" runat="server"></asp:Label><br/>
        <asp:Label ID="precioL" Font-Size="Medium" runat="server"></asp:Label><br/>  
        <asp:Label ID="cantidadL" Font-Size="Medium" runat="server"></asp:Label><br/>
        <div class="row" style="margin:0px">
          <div class="col l7 m12 s12 input-field">
            <asp:TextBox ID="cantidadTB" TextMode="Number" Visible="false" runat="server"></asp:TextBox>
            <label>Cantidad deseada:</label>
          </div>
        </div>
        <div class="row">
          <asp:Label ID="validoL" CssClass="green-text" Font-Size="Large" Visible="false" runat="server"></asp:Label>
          <asp:Label ID="noValidoL" CssClass="red-text" Font-Size="Large" Visible="false" runat="server"></asp:Label>
        </div>
        <div class="row" style="margin-top:20px">
          <asp:LinkButton ID="volverLB" CssClass="btn-large waves-effect waves-light black" runat="server" OnClick="volverLB_Click"><i class="material-icons left">arrow_back</i>Volver</asp:LinkButton>
          <asp:LinkButton ID="anadirLB" CssClass="btn-large waves-effect waves-light black disabled" runat="server" OnClick="anadirLB_Click"><i class="material-icons left">add_shopping_cart</i>Añadir Al Carrito</asp:LinkButton>
        </div>
      </div>
    </div>
  </div>
</asp:Content>

