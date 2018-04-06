<%@ Page Language="VB" AutoEventWireup="false" CodeFile="InsertLoanAllocation.aspx.vb" Inherits="InsertLoanAllocation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Pictures/Logo.png" style="margin-left: 56px" Width="250px" />
            <br />
            Please insert details. </h1>
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Date Prepared"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 158px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Employee ID"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 167px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Customer ID"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" style="margin-left: 169px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Account Number"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" style="margin-left: 143px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Loan Type ID"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server" style="margin-left: 162px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Loan Amount "></asp:Label>
        <asp:TextBox ID="TextBox6" runat="server" style="margin-left: 160px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Text="Interest Rate"></asp:Label>
        <asp:TextBox ID="TextBox7" runat="server" style="margin-left: 169px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label8" runat="server" Text="Periods"></asp:Label>
        <asp:TextBox ID="TextBox8" runat="server" style="margin-left: 199px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" style="margin-left: 134px" Text="Submit" />
        <br />
        <br />
        <asp:Label ID="Label9" runat="server" Text="Output Message"></asp:Label>
    
    </div>
    </form>
</body>
</html>
