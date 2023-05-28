<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CityWebForm2.aspx.cs" Inherits="WebApplication_tourism.CityWebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        
        <div id="divpune" runat="server">

            <asp:Label ID="Label1" runat="server" Text="This is Pune City"></asp:Label>

        </div>

        <div id="divmumbai" runat="server">


            <asp:Label ID="Label2" runat="server" Text="This is Mumbai City"></asp:Label>

        </div>

        <div id="divindore" runat="server">
            <asp:Label ID="Label3" runat="server" Text="This is Indore City"></asp:Label>



        </div>

        <div id="divbhopal" runat="server">


            <asp:Label ID="Label4" runat="server" Text="This is Bhopal City"></asp:Label>


        </div>


    </form>
</body>
</html>
