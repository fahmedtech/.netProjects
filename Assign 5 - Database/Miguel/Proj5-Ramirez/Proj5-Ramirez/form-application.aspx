<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="form-application.aspx.cs" Inherits="Proj5_Ramirez.form_application" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
         <br />
        <br />
        <br />
        Application to get ONE FREE MONTH supply of Chocolate Candybars <br />

        First Name: <asp:TextBox ID="txtFirstname" runat="server"></asp:TextBox> 
        <br />

        Last Name: <asp:TextBox ID="txtLastname" runat="server"></asp:TextBox> 
        <br />

        Address: <asp:TextBox ID="txtAddress" runat="server"> </asp:TextBox> <br />

        City: <asp:DropDownList ID="ddlCity" runat="server">
            <asp:ListItem> Chicago </asp:ListItem>
            <asp:ListItem> Los Angeles </asp:ListItem>
            <asp:ListItem> New York </asp:ListItem>
        </asp:DropDownList>

        State: <asp:TextBox ID="txtState" runat="server"> </asp:TextBox>
        <br />

        Zipcode: <asp:TextBox ID="txtZipcode" runat="server"> </asp:TextBox>
        <br />

        Select the Type of Candybars you want: <asp:RadioButtonList ID="rblCandy" runat="server">
            <asp:ListItem Value="KitKat" Selected="True"> KitKat </asp:ListItem>
            <asp:ListItem Value="Twix"> Twix </asp:ListItem>
            <asp:ListItem Value="Hersheys"> Hersheys </asp:ListItem>
        </asp:RadioButtonList>
        <br />

        Email Address (for notifications): <asp:TextBox ID="txtEmailAddress" runat="server"></asp:TextBox> 
        <br />

        <asp:Button ID="btnApplyNow" Text="Apply Now!" runat="server" OnClick="btnApplyNow_Click" />
        <br />




    </div>
    </form>
</body>
</html>
