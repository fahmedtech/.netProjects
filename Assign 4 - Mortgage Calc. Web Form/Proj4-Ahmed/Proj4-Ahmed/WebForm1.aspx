<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Proj4_Ahmed.WebForm1" %>

<!-- 
Name: Faizan Ahmed
IT-330 Project 4: Mortgage Calculator WebForm
Date: 5/1/2016    
    -->

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            text-decoration: underline;
        }
        .textAlignLeft {
            text-align: left;
            margin-left: 80px;
        }
        .auto-style2 {
            font-size: large;
        }
        .auto-style3 {
            margin-left: 127px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <p class="auto-style1">
            Welcome to <em>Faizan Ahmed&#39;s </em>WEB &quot;<strong>Monthly Mortgage Calculator</strong>&quot; Application</p>
        <p class="textAlignLeft">
            <strong>Principal Amount: </strong>&nbsp;
            <asp:TextBox ID="txtPrincipal" runat="server" ToolTip="Enter the Principal Amount"></asp:TextBox>
&nbsp;
            <asp:Label ID="lblPrincipalError" runat="server" ForeColor="Red"></asp:Label>
        </p>
        <p class="textAlignLeft">
            <strong>Year:</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButtonList ID="rblYears" runat="server" AutoPostBack="True" CssClass="auto-style3" OnSelectedIndexChanged="rblYears_SelectedIndexChanged" Width="87px">
                <asp:ListItem Value="15" Selected="True">15 Years</asp:ListItem>
                <asp:ListItem Value="30">30 Years</asp:ListItem>
                <asp:ListItem>Other</asp:ListItem>
            </asp:RadioButtonList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtOtherYear" runat="server" OnTextChanged="txtOtherYear_TextChanged" ToolTip="Enter Other Number of Year">0</asp:TextBox>
&nbsp;&nbsp;
            <asp:Label ID="lblOtherYearError" runat="server" ForeColor="Red"></asp:Label>
        </p>
        <p class="textAlignLeft">
            <strong>Interest Rate: <asp:DropDownList ID="ddlInterestRate" runat="server" AutoPostBack="True" Height="26px" style="margin-left: 20px" Width="66px" ToolTip="Select the Interest Rate">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
                <asp:ListItem>8</asp:ListItem>
                <asp:ListItem>9</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
            </asp:DropDownList>
            </strong>
        </p>
        <p class="textAlignLeft">
            <asp:Button ID="btnCalculate" runat="server" OnClick="btnCalculate_Click" Text="Calculate" ToolTip="Calculate the Monthly Mortgage" />
&nbsp;&nbsp;&nbsp;
            <strong>
            <asp:Button ID="btnReset" runat="server" OnClick="btnReset_Click" Text="Reset" ToolTip="Reset all Values" />
            </strong>
        </p>
        <p class="textAlignLeft">
&nbsp;<strong><asp:Label ID="lblCalculatedValue" runat="server" CssClass="auto-style2" Text="Result: $0.00" ToolTip="Calculated Result"></asp:Label>
            </strong>
        </p>
    </form>
</body>
</html>
