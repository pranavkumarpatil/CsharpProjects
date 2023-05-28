<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Basic_frm.aspx.cs" Inherits="WebApplication_conversion.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <div>

             <asp:RadioButton ID="RadioButton5" runat="server" GroupName="grp3" AutoPostBack="True" OnCheckedChanged="RadioButton5_CheckedChanged" />
            <asp:Label ID="Label5" runat="server" Text="Select for Temperaure Conversion"></asp:Label>

            <asp:RadioButton ID="RadioButton6" runat="server" GroupName="grp3" AutoPostBack="True" OnCheckedChanged="RadioButton6_CheckedChanged" />
           
            <asp:Label ID="Label6" runat="server" Text="Select for Currency Conversion"></asp:Label>

        </div>

        <div id="tempcalc" runat="server">
            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="grp1" />
            <asp:Label ID="Label1" runat="server" Text="DegC to F"></asp:Label>


            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="grp1" />

            <asp:Label ID="Label2" runat="server" Text="F to DegC"></asp:Label>


            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />

             
        </div>

        <div id="currencycalc" runat="server">

        <asp:RadioButton ID="RadioButton3" runat="server" GroupName="grp2"  />

        <asp:Label ID="Label3" runat="server" Text="INR to USD"></asp:Label>

        <asp:RadioButton ID="RadioButton4" runat="server" GroupName="grp2" />

        <asp:Label ID="Label4" runat="server" Text="USD to INR"></asp:Label>

        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

        <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" />

        </div>

        
    </form>
</body>
</html>
