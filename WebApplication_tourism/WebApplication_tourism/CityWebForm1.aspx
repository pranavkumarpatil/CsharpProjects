<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CityWebForm1.aspx.cs" Inherits="WebApplication_tourism.CityWebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        
        <div>

            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
             <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>

        </div>
       
        
        <div id="divpune" runat="server">

            <asp:Label ID="Label1" runat="server" Text="Pune Div Visible"></asp:Label>

            <img src="Images/Pune.JPG" />

        </div>
        
        

        <div id="divmumbai" runat="server">

            <asp:Label ID="Label2" runat="server" Text="Mumbai Div Visible"></asp:Label>
             
            <img src="Images/mumbai.JPG" />


        </div>
        
        <div id="divindore" runat="server">

            <asp:Label ID="Label3" runat="server" Text="Indore Div Visible"></asp:Label>
            
            <img src="Images/indore.JPG" />


        </div>

        <div id="divbhopal" runat="server">

            <asp:Label ID="Label4" runat="server" Text="Bhopal Div Visible"></asp:Label>
            
            
            <img src="Images/bhopal.JPG" />

        </div>


    </form>
</body>
</html>
