﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication_Querystring.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>



            <asp:Button ID="Button1" runat="server" Text="Button" />

            <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" />


            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

        </div>
    </form>
</body>
</html>
