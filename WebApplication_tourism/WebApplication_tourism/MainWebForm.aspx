<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainWebForm.aspx.cs" Inherits="WebApplication_tourism.MainWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <div>

            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataTextField="country" OnTextChanged="DropDownList1_TextChanged"></asp:DropDownList>


            <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" DataTextField="state" OnTextChanged="DropDownList2_TextChanged"></asp:DropDownList>


            <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True" DataTextField="city" OnTextChanged="DropDownList3_TextChanged"></asp:DropDownList>


            <asp:Button ID="Button1" runat="server" Text="City Image" OnClick="Button1_Click" />

            <asp:Button ID="Button2" runat="server" Text="City Info" OnClick="Button2_Click" />

        </div>
     
    </form>
</body>
</html>
