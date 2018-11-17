<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master/master2.master" AutoEventWireup="true" CodeFile="~/Controller/actualizarPedido.aspx.cs" Inherits="View_actualizarPedido" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="row" style="padding:30px 50px 50px 50px">
    <div class="row center-align">
      <h4>Pedidos Pendientes</h4>
    </div>
    <div class="row">
      <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" DataSourceID="pedidosODS" ForeColor="Black" GridLines="None" OnRowCommand="GridView1_RowCommand">
        <AlternatingRowStyle BackColor="PaleGoldenrod" />
        <Columns>
          <asp:BoundField DataField="nombre_usuario" HeaderText="Nombre Usuario"/>
          <asp:BoundField DataField="nombre_producto" HeaderText="Pedido"/>
          <asp:BoundField DataField="codigo_pedido" HeaderText="Codigo Pedido"/>
          <asp:BoundField DataField="cantidad" HeaderText="Cantidad Solicitada"/>
          <asp:BoundField DataField="precio" HeaderText="Total Precio"/>
          <asp:BoundField DataField="estado" HeaderText="Estado"/>
          <asp:ButtonField HeaderText="Opciones" Text="Despachar"/>
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
      <asp:ObjectDataSource ID="pedidosODS" runat="server" SelectMethod="listarpedidos" TypeName="DApedido">
        <SelectParameters>
          <asp:Parameter DefaultValue="1" Name="opcion" Type="Int32"/>
        </SelectParameters>
        </asp:ObjectDataSource>
    </div>
  </div>
</asp:Content>

