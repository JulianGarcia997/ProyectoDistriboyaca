<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master/master3.master" AutoEventWireup="true" CodeFile="~/Controller/reporte_productos.aspx.cs" Inherits="View_reporte_productos" %>

<%@ Register assembly="CrystalDecisions.Web, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <CR:CrystalReportViewer ID="CRV_reporte_producto" runat="server" AutoDataBind="True" GroupTreeImagesFolderUrl="" Height="50px" ReportSourceID="CRS_reporte_productos" ToolbarImagesFolderUrl="" ToolPanelWidth="200px" Width="350px" />
    <CR:CrystalReportSource ID="CRS_reporte_productos" runat="server">
        <Report FileName="C:\Users\Julian Garcia\source\repos\distriboyaca\distriboyaca\Reportes\reporte_productos.rpt">
        </Report>
    </CR:CrystalReportSource>
</asp:Content>

