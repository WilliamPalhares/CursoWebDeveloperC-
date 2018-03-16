﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Site.Pages.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        Nome: <br />
        <asp:TextBox ID="txtNome" runat="server" />
        <br /><br />

        Email: <br />
        <asp:TextBox ID="txtEmail" runat="server" />
        <br /><br />

        <asp:Button ID="btnCadastro" runat="server" 
                    Text="Cadastrar Cliente" 
                    OnClick="btnCadastro_Click" />
    
        <p>
            <asp:Label ID="lblMensagem" runat="server" />
        </p>

    </div>
    </form>
</body>
</html>
