<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="WebApplication2.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-top: 4px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            Admin Page</p>
        <p>
            Update User Info</p>
        
        <span class="auto-style1">
        <asp:GridView ID="GridView1" runat="server" >
        </asp:GridView>
        </span>
        <p>
            Total Activity Time</p>
        <p>
            <asp:GridView ID="GridView2" runat="server">
            </asp:GridView>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Total Time"></asp:Label>
&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            User Activity Times</p>
        <p>
            <asp:GridView ID="GridView3" runat="server">
            </asp:GridView>
        </p>
        <p>
            User ID</p>
        <p>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style1"></asp:TextBox>
            <br />
            <br />
            Date of Birth<br />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            Update&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Delete&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Log Out<br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Button" />
        </p>
    </form>
</body>
</html>
