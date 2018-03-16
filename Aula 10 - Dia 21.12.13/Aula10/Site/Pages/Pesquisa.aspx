<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pesquisa.aspx.cs" Inherits="Site.Pages.Pesquisa" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
    Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style type="text/css">
        body { font-family: Verdana; font-size: 9pt; padding: 30px; }
    </style>

</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h3>Pesquisa de Vendas</h3>

        Data de Início: <asp:TextBox ID="txtDataInicio" runat="server" />
        Término: <asp:TextBox ID="txtDataTermino" runat="server" />

        <asp:Button ID="btnPesquisa" runat="server" 
                    Text="Gerar Relatório" 
                    OnClick="GerarRelatorio" />

        <p>
            <asp:Label ID="lblMensagem" runat="server" />
        </p>

        <p>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>

        </p>

        <rsweb:ReportViewer ID="ReportViewer" runat="server" Width="800" Height="600">
        </rsweb:ReportViewer>

    </div>
    </form>
</body>
</html>
