<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateUser.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>
<script runat="server">

    
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
        }
        .auto-style2 {
            
        }
        .auto-style3 {
            font-size: xx-large;
        }
        .auto-style4 {
            font-size: xx-large;
        }
        .auto-style5 {
            font-size: xx-large;
        }
        .auto-style6 {
            font-size: x-large;
        }
        .auto-style7 {
            
        }
        body{
            background-image:url(/Images/missoula.jfif);
        }
        
    </style>
</head>
<body style="height: 545px">
    <form id="form1" runat="server">
        <div style="height: 66px; text-align: center">
            <h1 class="auto-style1">Create New User</h1>
            <hr />
        </div>
        <p>
            <asp:Label ID="Label1" runat="server" CssClass="auto-style3" Text="Username:"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="TextBox1" runat="server" BackColor="White" CssClass="auto-style2" Height="35px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" CssClass="auto-style4" Text="Date of Birth:"></asp:Label>
        </p>
        <p style="height: 47px">
        <asp:TextBox ID="TextBox3" runat="server" CssClass="auto-style7" Height="35px" Width="175px"></asp:TextBox>
        </p>
        <p style="height: 47px">
            <asp:Label ID="Label3" runat="server" CssClass="auto-style5" Text="Password:"></asp:Label>
        </p>
        <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style7" Height="35px" Width="175px"></asp:TextBox>
        <p>
            <asp:Button ID="Button1" runat="server" BackColor="#FF9900" BorderColor="#33CCFF" BorderStyle="Outset" CssClass="auto-style6" EnableTheming="True" Height="54px" OnClick="Button1_Click" Text="Log In" Width="139px" />
        </p>
    </form>
</body>
</html>

