<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master/master3.master" AutoEventWireup="true" CodeFile="~/Controller/reporte_empleados.aspx.cs" Inherits="View_reporte_empleados" %>

<%@ Register assembly="CrystalDecisions.Web, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="pagination">
    <tr>
        <td>
            <a href="reporte_empleados.aspx">reporte_empleados.aspx</a><CR:CrystalReportViewer ID="CRV_reporte_empleados" runat="server" AutoDataBind="True" GroupTreeImagesFolderUrl="" Height="50px" ReportSourceID="CRS_reporte_empelados" ToolbarImagesFolderUrl="" ToolPanelWidth="200px" Width="350px" OnInit="CRV_reporte_empleados_Init" />
            <CR:CrystalReportSource ID="CRS_reporte_empelados" runat="server">
                <Report FileName="C:\Users\Julian Garcia\source\repos\distriboyaca\distriboyaca\Reportes\reporte_empleados.rpt">
                </Report>
            </CR:CrystalReportSource>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>

