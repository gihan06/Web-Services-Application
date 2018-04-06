<%@ Page Language="VB" AutoEventWireup="false" CodeFile="InsertLoan.aspx.vb" Inherits="InsertLoan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Pictures/Logo.png" style="margin-left: 58px" Width="250px" />
        </h1>
        <h1>Please insert details to insert loan.</h1>
        <br />
    
        <asp:Label ID="Label1" runat="server" Text="Loan Type "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 158px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" style="margin-left: 121px" Text="Submit" />
        <br />
        <br />
        <asp:Label ID="LabelOutput" runat="server" Text="Output Message"></asp:Label>
    
    </div>
    </form>
</body>
</html>
