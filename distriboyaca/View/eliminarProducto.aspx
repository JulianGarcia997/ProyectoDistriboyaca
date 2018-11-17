<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master/master2.master" AutoEventWireup="true" CodeFile="~/Controller/eliminarProducto.aspx.cs" Inherits="View_eliminarProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <div class="row" style="padding:30px 50px 50px 50px">
    <div class="row center-align">
      <h4>Productos Registrados</h4>
    </div>
    <div class="row">
      <asp:GridView ID="GridView1" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" DataSourceID="productosODS" ForeColor="Black" GridLines="None" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand">
        <AlternatingRowStyle BackColor="PaleGoldenrod"/>
        <Columns>
          <asp:BoundField DataField="nombre_producto" HeaderText="Nombre">
            <ItemStyle Font-Size="X-Large"/>
          </asp:BoundField>
          <asp:BoundField DataField="codigo_producto" HeaderText="Codigo">
            <ItemStyle Font-Size="X-Large"/>
          </asp:BoundField>
          <asp:BoundField DataField="color_producto" HeaderText="Color">
            <ItemStyle Font-Size="X-Large"/>
          </asp:BoundField>
          <asp:BoundField DataField="referencia_producto" HeaderText="Referencia">
            <ItemStyle Font-Size="X-Large"/>
          </asp:BoundField>
          <asp:BoundField DataField="precio_producto" HeaderText="Precio">
            <ItemStyle Font-Size="X-Large"/>
          </asp:BoundField>
          <asp:BoundField DataField="cantidad_producto" HeaderText="Cantidad">
            <ItemStyle Font-Size="X-Large"/>
          </asp:BoundField>
          <asp:ImageField DataImageUrlField="foto_producto" HeaderText="Foto">
            <ControlStyle Width="250px"/>
            <ItemStyle Width="280px"/>
          </asp:ImageField>
          <asp:ButtonField HeaderText="Opciones" Text="Eliminar"/>
        </Columns>
        <FooterStyle BackColor="Tan"/>
        <HeaderStyle BackColor="Tan" Font-Bold="True"/>
        <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center"/>
        <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite"/>
        <SortedAscendingCellStyle BackColor="#FAFAE7"/>
        <SortedAscendingHeaderStyle BackColor="#DAC09E"/>
        <SortedDescendingCellStyle BackColor="#E1DB9C"/>
        <SortedDescendingHeaderStyle BackColor="#C2A47B"/>
      </asp:GridView>
      <asp:ObjectDataSource ID="productosODS" runat="server" SelectMethod="listartProductos" TypeName="DAproducto"></asp:ObjectDataSource>
    </div>
  </div>
</asp:Content>

