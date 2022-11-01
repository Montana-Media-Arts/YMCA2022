<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogOut.aspx.cs" Inherits="WebApplication2.WebForm2" %>

<!DOCTYPE html>
<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="utf-8" />
    <title></title>    
    <style type="text/css">
        #form1 {
            text-align: center;
            font-size: x-large;
            font-weight: 700;
        }
        .auto-style1 {
            font-size: xx-large;
        }
        .auto-style3 {
            text-align: center;
            font-size: x-large;
        }
        .auto-style4 {
            text-align: left;
        }
        .auto-style5 {
            text-align: left;
        }
        .auto-style6 {
            text-align: left;
        }
        .auto-style7 {}
        .auto-style8 {
            text-align: left;
        }
        .auto-style9 {
            font-size: x-large;
        }
        body{
            background-image:url(/Images/missoula.jfif)
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        
        <span class="auto-style1">
        Thanks for stopping by</span><p class="auto-style3">
            <strong>Don&#39;t forget to sign out</strong></p>
        <p class="auto-style4">
            <asp:Label ID="Label1" runat="server" Text="What activity did you do today?"></asp:Label>
        </p>
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>

        <p class="auto-style5">
            <asp:Label ID="Label2" runat="server" Text="How long did you do this activity?"></asp:Label>
        </p>
        <p class="auto-style6">
            <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style7" Height="35px" Width="175px" ></asp:TextBox>
        </p>
        <p class="auto-style6">
            
            Username</p>
        <p class="auto-style6">
            <asp:TextBox ID="TextBox3" runat="server" CssClass="auto-style7" Height="35px" Width="175px"></asp:TextBox>
        </p>
        <p class="auto-style8">
            <asp:Button ID="Button1" runat="server" BackColor="#FF9900" BorderColor="#33CCFF" BorderStyle="Outset" CssClass="auto-style9" Height="41px" Text="Log Out" Width="175px" OnClick="Button1_Click" />
        </p>
    </form>
</body>
</html>

