<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master/master1.master" AutoEventWireup="true" CodeFile="~/Controller/tiendaVirtual.aspx.cs" Inherits="View_tiendaVirtual" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container" style="padding-top:30px;padding-bottom:30px">
    <div class="row center-align">
      <h4>Tienda virtual</h4>
    </div>
    <div class="row">
      <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#999999" BorderWidth="1px" CellPadding="3" DataSourceID="productosODS" ForeColor="Black" GridLines="Vertical" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand" BorderStyle="Solid">
        <AlternatingRowStyle BackColor="#CCCCCC"/>
        <Columns>
          <asp:ImageField DataImageUrlField="foto_producto" HeaderText="Foto">
            <ControlStyle Height="200px"/>
            <ItemStyle Width="200px"/>
          </asp:ImageField>
          <asp:BoundField DataField="id_producto" Visible="false" HeaderText="ID">
            <ItemStyle Font-Size="X-Large"/>
          </asp:BoundField>
          <asp:BoundField DataField="nombre_producto" HeaderText="Nombre">
            <ItemStyle Font-Size="X-Large"/>
          </asp:BoundField>
          <asp:BoundField DataField="color_producto" HeaderText="Color">
            <ItemStyle Font-Size="X-Large"/>
          </asp:BoundField>
          <asp:BoundField DataField="precio_producto" HeaderText="Precio">
            <ItemStyle Font-Size="X-Large"/>
          </asp:BoundField>
          <asp:ButtonField HeaderText="Opciones" ControlStyle-CssClass="indigo-text text-darken-4" ControlStyle-Font-Size="Large" Text="Saber mas">
            <ControlStyle CssClass="indigo-text text-darken-4" Font-Size="Large"></ControlStyle>
          </asp:ButtonField>
        </Columns>
        <FooterStyle BackColor="#CCCCCC"/>
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White"/>
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center"/>
        <SelectedRowStyle BackColor="#000099" ForeColor="White" Font-Bold="True"/>
        <SortedAscendingCellStyle BackColor="#F1F1F1"/>
        <SortedAscendingHeaderStyle BackColor="#808080"/>
        <SortedDescendingCellStyle BackColor="#CAC9C9"/>
        <SortedDescendingHeaderStyle BackColor="#383838"/>
      </asp:GridView>
      <asp:ObjectDataSource ID="productosODS" runat="server" SelectMethod="listarProductos" TypeName="DAproducto"></asp:ObjectDataSource>
    </div>
    <div id="btnOculto" class="row center-align" runat="server">
      <a class="waves-effect waves-light btn-large modal-trigger black" href="#modal1"><i class="material-icons left">visibility</i>Ver Carrito</a>
    </div>
    <div id="modal1" class="modal">
      <div class="modal-content">
        <div class="row center-align">
          <h4>Carrito de Compras</h4>
        </div>
        <div class="row">
          Este es el listado de los productos añadidos al carrito...
        </div>
        <div class="row" style="padding:10px">
          <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical">
            <AlternatingRowStyle BackColor="#CCCCCC"/>
            <Columns>
              <asp:BoundField DataField="Nombre pro" HeaderText="Nombre"/>
              <asp:BoundField DataField="Referencia Pro" HeaderText="Referencia"/>
              <asp:BoundField DataField="Cantidad Pro" HeaderText="Cantidad"/>
              <asp:BoundField DataField="Precio Pro" HeaderText="Precio"/>
            </Columns>
            <FooterStyle BackColor="#CCCCCC"/>
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White"/>
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center"/>
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White"/>
            <SortedAscendingCellStyle BackColor="#F1F1F1"/>
            <SortedAscendingHeaderStyle BackColor="#808080"/>
            <SortedDescendingCellStyle BackColor="#CAC9C9"/>
            <SortedDescendingHeaderStyle BackColor="#383838"/>
          </asp:GridView>
        </div>
      </div>
      <div class="modal-footer">
        <a href="#!" class="modal-action modal-close waves-effect waves-green btn-flat ">Cerrar</a>
        <asp:LinkButton ID="cancelarLB" CssClass="modal-action waves-effect waves-green btn-flat" runat="server" OnClick="cancelarLB_Click">Cancelar todo</asp:LinkButton>
        <asp:LinkButton ID="comprarLB" CssClass="modal-action waves-effect waves-green btn-flat" runat="server" OnClick="comprarLB_Click1">Comprar</asp:LinkButton>
    </div>
    </div>
  </div>
</asp:Content>

