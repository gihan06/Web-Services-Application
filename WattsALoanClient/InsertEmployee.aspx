<%@ Page Language="VB" AutoEventWireup="false" CodeFile="InsertEmployee.aspx.vb" Inherits="InsertEmployee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Pictures/Logo.png" style="margin-left: 77px" Width="250px" />
            <br />
            Please insert details to insert employee.</h1>
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Employee Number"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 134px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="First Name"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 179px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Last Name "></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" style="margin-left: 177px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Title"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" style="margin-left: 220px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Houly Salary"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server" style="margin-left: 167px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" style="margin-left: 133px" Text="Submit" />
        <br />
        <br />
        <asp:Label ID="LabelOutput" runat="server" Text="Output Message"></asp:Label>
    
    </div>
    </form>
</body>
</html>
