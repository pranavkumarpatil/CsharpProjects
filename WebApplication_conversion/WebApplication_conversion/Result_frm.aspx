<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Result_frm.aspx.cs" Inherits="WebApplication_conversion.Result_frm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="temperature" runat="server">

            <asp:Label ID="Label1" runat="server" Text="Temperature Conversion"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>

            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>


        </div>

        <div id="currency" runat="server">
            <asp:Label ID="Label2" runat="server" Text="Currency Conversion"></asp:Label>

            <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>

                        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
