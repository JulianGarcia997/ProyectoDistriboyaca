<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/Controller/reporte_certificado.aspx.cs" Inherits="View_Backend_reporte_certificado" %>

<%@ Register assembly="CrystalDecisions.Web, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <CR:CrystalReportViewer ID="CRV_Certificado" runat="server" AutoDataBind="True" GroupTreeImagesFolderUrl="" Height="1202px" ReportSourceID="CRS_Certificado" ToolbarImagesFolderUrl="" ToolPanelWidth="200px" Width="1104px" />
            <CR:CrystalReportSource ID="CRS_Certificado" runat="server">
                <Report FileName="C:\Users\Julian Garcia\source\repos\distriboyaca\distriboyaca\Reportes\CR_certificado.rpt">
                </Report>
            </CR:CrystalReportSource>
        </div>
    </form>
</body>
</html>
