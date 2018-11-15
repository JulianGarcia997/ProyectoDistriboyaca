<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master/master2.master" AutoEventWireup="true" CodeFile="~/Controller/visualizarCliente.aspx.cs" Inherits="View_visualizarCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <div class="row" style="padding:30px 50px 50px 50px">
    <div class="row center-align">
      <h4>Clientes registrados</h4> 
    </div>
    <div class="row">
      <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" DataSourceID="clientesODS" ForeColor="Black" GridLines="None">
        <AlternatingRowStyle BackColor="PaleGoldenrod"/>
        <Columns>
          <asp:BoundField DataField="nombres_usuario" HeaderText="Nombres"/>
          <asp:BoundField DataField="cedula_usuario" HeaderText="Cedula"/>
          <asp:BoundField DataField="telefono_usuario" HeaderText="Telefono"/>
          <asp:BoundField DataField="direccion_usuario" HeaderText="Direccion"/>
          <asp:BoundField DataField="user_name" HeaderText="UserName"/>
          <asp:BoundField DataField="correo_usuario" HeaderText="Correo"/>
          <asp:BoundField DataField="contrasena_usuario" HeaderText="Contraseña"/>
          <asp:BoundField DataField="sexo_usuario" HeaderText="Sexo"/>
          <asp:BoundField DataField="estado_usuario" HeaderText="Estado"/>
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
      <asp:ObjectDataSource ID="clientesODS" runat="server" SelectMethod="listarUsuarios" TypeName="DAusuario">
        <SelectParameters>
          <asp:Parameter DefaultValue="4" Name="rol" Type="Int32"/>
        </SelectParameters>
      </asp:ObjectDataSource>
    </div>
  </div>
</asp:Content>

