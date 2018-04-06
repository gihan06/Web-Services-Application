<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Home.aspx.vb" Inherits="Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1><asp:Image ID="Image1" runat="server" BackColor="#33CCFF" Height="360px" ImageUrl="~/Pictures/Logo.png" Width="552px" />
        </h1>
        <asp:TreeView ID="TreeView1" runat="server" DataSourceID="SiteMapDataSource1" BackColor="White" style="font-size: xx-large; text-align: left; margin-left: 118px" Width="356px">
        </asp:TreeView>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
    </form>
</body>
</html>
