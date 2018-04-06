<%@ Page Language="VB" AutoEventWireup="false" CodeFile="UpdateEmployee.aspx.vb" Inherits="UpdateEmployee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Pictures/Logo.png" style="margin-left: 98px" Width="250px" />
        </h1>
        <h1>Please Insert details to update employee table. </h1>
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Employee ID"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 150px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Employee Number"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 115px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="First Name"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" style="margin-left: 161px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Last Name"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" style="margin-left: 162px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Title"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server" style="margin-left: 204px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Hourly Salary"></asp:Label>
        <asp:TextBox ID="TextBox6" runat="server" style="margin-left: 145px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="SubmitButton" runat="server" style="margin-left: 128px" Text="Submit" />
        <br />
        <br />
        <asp:Label ID="LabelOutput" runat="server" Text="Output Message"></asp:Label>
    
    </div>
    </form>
</body>
</html>
