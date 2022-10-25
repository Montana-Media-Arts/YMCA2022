<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserActivities.aspx.cs" Inherits="WebApplication2.WebForm4" %>

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
        <div>
        
        <span class="auto-style1">
            <br />
            Users<asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        </asp:GridView>
        </span>
            <br />
            <span class="auto-style1">
            Activities<br />
        <asp:GridView ID="GridView2" runat="server" OnSelectedIndexChanged="GridView2_SelectedIndexChanged">
        </asp:GridView>
            <br />
            <br />
        </span>
        </div>
    </form>
</body>
</html>
