<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master/master1.master" AutoEventWireup="true" CodeFile="~/Controller/login.aspx.cs" Inherits="View_login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <div id="fondoLogin" class="row" style="margin:0px; padding-top:20px">
    <div class="col l4 offset-l4 m12 s12">
      <div class="card" style="background-color:rgba(0,0,0,0.9)">
        <div class="card-action indigo darken-4">
          <h4 class="white-text">Iniciar sesion</h4>
        </div>
        <div class="card-content">
          <div class=" row input-field">
            <asp:TextBox ID="userNameTB" CssClass="validate white-text" runat="server"></asp:TextBox>
            <label>UserName:</label>
          </div><br>
          <div class="row input-field">
            <asp:TextBox ID="contrasenaTB" CssClass="validate white-text" TextMode="Password" runat="server"></asp:TextBox>
            <label>Contraseña:</label>
          </div><br>
          <div class="row">
            <a href="#">¿olvido su contraseña?</a>
          </div><br>
          <div class="row">
            <asp:Label ID="validoL" CssClass="green-text" Visible="false" runat="server"></asp:Label>
            <asp:Label ID="noValidoL" CssClass="red-text" Visible="false" runat="server"></asp:Label>
          </div><br>
          <div class="row center-align">
            <asp:Button ID="iniciarB" CssClass="btn-large waves-effect waves-light indigo darken-4" Text="Iniciar" runat="server" OnClick="iniciarB_Click"/>
          </div>
        </div>
      </div>
    </div>
  </div>
</asp:Content>

