<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="WebApplication2.WebForm5" %>

<!DOCTYPE html>

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
        .auto-style6 {
            font-size: x-large;
        }
        body{
            background-image:url(/Images/missoula.jfif);
        }
        
    </style>
</head>
<body style="height: 545px">
    <form id="form1" runat="server">
        <div style="height: 66px; text-align: center">
            <h1 class="auto-style1">User Log In</h1>
            <hr />
        </div>
        <p>
            <asp:Label ID="Label1" runat="server" CssClass="auto-style3" Text="Username:"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="TextBox1" runat="server" BackColor="White" CssClass="auto-style2" Height="35px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" BackColor="#FF9900" BorderColor="#33CCFF" BorderStyle="Outset" CssClass="auto-style6" EnableTheming="True" Height="54px" OnClick="Button1_Click" Text="Log In" Width="139px" />
        </p>
        <p style="height: 47px">
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>

