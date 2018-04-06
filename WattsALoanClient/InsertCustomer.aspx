<%@ Page Language="VB" AutoEventWireup="false" CodeFile="InsertCustomer.aspx.vb" Inherits="InsertCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Pictures/Logo.png" style="margin-left: 69px" Width="250px" />
            <br />
            Please insert details to insert customers. </h1>
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Date Created"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 167px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Full Name "></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 181px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Billing Address"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" style="margin-left: 156px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Billing City"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" style="margin-left: 183px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Billing State"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server" style="margin-left: 174px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Billing ZIP Cide"></asp:Label>
        <asp:TextBox ID="TextBox6" runat="server" style="margin-left: 148px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Text="Email Address"></asp:Label>
        <asp:TextBox ID="TextBox7" runat="server" style="margin-left: 155px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" style="margin-left: 145px" Text="Submit" />
        <br />
        <br />
        <asp:Label ID="LabelOutput" runat="server" Text="Output Message"></asp:Label>
    
    </div>
    </form>
</body>
</html>
