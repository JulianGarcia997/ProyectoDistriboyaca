<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master/master1.master" AutoEventWireup="true" CodeFile="~/Controller/index.aspx.cs" Inherits="View_index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <div class="row" style="margin:0px">
    <div class="slider">
      <ul class="slides">
        <li><asp:Image ID="s1I" ImageUrl="~/Img/s1.jpg" runat="server"/></li>
        <li><asp:Image ID="s2I" ImageUrl="~/Img/s2.jpg" runat="server"/></li>
      </ul>
    </div>
    <div class="row">
      <div class="col l6 m12 s12" style="padding:50px">
        <div class="row center-align">
          <h4>¡Contactenos!</h4>
        </div>
        <div class="row">
          <p>
            Envienos sus dudas o subgerencias.
          </p>
        </div>
        <div class="row input-field">
          <i class="material-icons prefix">account_circle</i>
          <asp:TextBox ID="nombresTB" CssClass="validate" runat="server"></asp:TextBox>
          <label>Nombres:</label>
        </div>
        <div class="row input-field">
          <i class="material-icons prefix">phone</i>
          <asp:TextBox ID="telefonoTB" CssClass="validate" runat="server"></asp:TextBox>
          <label>Telefono:</label>
        </div>
        <div class="row input-field">
          <i class="material-icons prefix">email</i>
          <asp:TextBox ID="correoTB" CssClass="validate" TextMode="Email" runat="server"></asp:TextBox>
          <label>Correo:</label>
        </div>
        <div class="row input-field">
          <i class="material-icons prefix">edit</i>
          <asp:TextBox ID="mensajeTB" CssClass="validate" runat="server"></asp:TextBox>
          <label>Mensaje:</label>
        </div>
        <div class="row">
          <asp:Label ID="validoL" CssClass="green-text" Font-Size="Large" Visible="false" runat="server"></asp:Label>
          <asp:Label ID="noValidoL" CssClass="red-text" Font-Size="Large" Visible="false" runat="server"></asp:Label>
        </div>
        <div class="row center-align">
          <asp:Button ID="EnviarB" CssClass="btn-large waves-effect waves-light black" Text="Enviar" runat="server" OnClick="EnviarB_Click"/>
        </div>
      </div>
      <div class="col l6 m12 s12" style="padding:50px">
        <div class="row">
          <h4>Nuestra ubicacion</h4>
        </div>
        <div class="row">
          <p>
            Si desea tambien nos puede visitar en nuestras instalaciones...
          </p>
        </div>
        <div class="row">
          <div class="z-depth-4" id="mapa"></div>
        </div>
        <div class="row">
          <i class="material-icons left">location_on</i>Estamos en Funza Cundinamarca
        </div>
        <div class="row">
          <i class="material-icons left">phone</i>Telefono +57 314 4628058
        </div>
      </div>
    </div>
  </div>
</asp:Content>