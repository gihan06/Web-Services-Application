<%@ Page Language="VB" AutoEventWireup="false" CodeFile="UpdateCustomer.aspx.vb" Inherits="I" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Pictures/Logo.png" style="margin-left: 78px" Width="250px" />
        </h1>
        <h1>Please Insert details to update customers.</h1>
        <br />
    
        <asp:Label ID="Label1" runat="server" Text="Customer ID"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 191px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Date Created "></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 184px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Full Name"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" style="margin-left: 205px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Billing Address"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" style="margin-left: 178px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Billing City"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server" style="margin-left: 203px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Billing State"></asp:Label>
        <asp:TextBox ID="TextBox6" runat="server" style="margin-left: 196px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Text="Billing ZIP Cide"></asp:Label>
        <asp:TextBox ID="TextBox7" runat="server" style="margin-left: 171px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label8" runat="server" Text="Email Address"></asp:Label>
        <asp:TextBox ID="TextBox8" runat="server" style="margin-left: 179px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" style="margin-left: 139px" Text="Submit" />
        <br />
        <br />
        <asp:Label ID="LabelOutput" runat="server" Text="Output Message"></asp:Label>
    
    </div>
    </form>
</body>
</html>
