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

        <!-- GridView for activities -->

        <div>  
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False"   
            BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px"   
            CellPadding="4" ForeColor="Black" GridLines="Vertical">  
            <AlternatingRowStyle BackColor="White" />  
            <Columns>  
                <asp:TemplateField HeaderText="ID">  
                    <EditItemTemplate>  
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Activityid") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                    <ItemTemplate>  
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("Activityid") %>'></asp:Label>  
                    </ItemTemplate>  
                </asp:TemplateField>  
                <asp:TemplateField HeaderText="Activity Name">  
                    <EditItemTemplate>  
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("ActivityName") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                    <ItemTemplate>  
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("ActivityName") %>'></asp:Label>  
                    </ItemTemplate>  
                </asp:TemplateField>  
               
                <asp:TemplateField HeaderText="Select Data">  
                    <EditItemTemplate>  
                        <asp:CheckBox ID="CheckBox1" runat="server" />  
                    </EditItemTemplate>  
                    <ItemTemplate>  
                        <asp:CheckBox ID="CheckBox1" runat="server" />  
                    </ItemTemplate>  
                </asp:TemplateField>  
                <asp:TemplateField HeaderText="Time Spent">  
                    <EditItemTemplate>  
                        <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style7" ></asp:TextBox> 
                    </EditItemTemplate>  
                    <ItemTemplate>  
                        <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style7"></asp:TextBox>
                    </ItemTemplate>  
                </asp:TemplateField>  
            </Columns>  
            <FooterStyle BackColor="#CCCC99" />  
            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />  
            <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />  
            <RowStyle BackColor="#F7F7DE" />  
            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />  
            <SortedAscendingCellStyle BackColor="#FBFBF2" />  
            <SortedAscendingHeaderStyle BackColor="#848384" />  
            <SortedDescendingCellStyle BackColor="#EAEAD3" />  
            <SortedDescendingHeaderStyle BackColor="#575357" />  
        </asp:GridView>  
    
      
        <br />  
      
    </div>  
        <!-- End Of GridView for activities -->
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

