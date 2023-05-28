<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication_tourism.WebForm1" %>


<!DOCTYPE html>
<<%@ Register Src="~/WebUserControl1.ascx" TagPrefix="uc" TagName="student" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc:student runat="server" id="WebUserControl1" />
        </div>
    </form>
</body>
</html>
