<%@ Page Title="IT Form Page" Language="C#" AutoEventWireup="true" CodeBehind="FormPage.aspx.cs" Inherits="Proj5_Ahmed.FormPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <!-- Implemented CSS -->
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />

    <style type="text/css">
        .auto-style1 {
            width: 136px;
            height: 122px;
            margin-top: 20px;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <div>

            <!-- 
Name: Faizan Ahmed
IT330 - Project 5: DePaul IT Club Form | Database 
Date: 5/15/2016
 -->
            <div id="heading">
                <h1>
                    <img alt="logo" class="auto-style1" src="Images/logo.gif" />
                    <br />
                    DePaul University's IT Club </h1>
            </div>
            <div id="heading2">
                <h2>For Computer-related Majors Only 
                    <br />
                    Apply Now to join the club! </h2>
            </div>
            <br />
            <br />

            <!-- All of the Web Controls -->
            <div class="unit">

                <p class="font">
                    <strong>First Name: </strong>
                    <asp:TextBox ID="txtFirstName" runat="server" ToolTip="Enter your First Name"></asp:TextBox>
                    <br />
                    <br />
                    <strong>Last Name: </strong>
                    <asp:TextBox ID="txtLastName" runat="server" ToolTip="Enter your Last Name"></asp:TextBox>
                </p>

                <div class="font">
                    <strong>Gender: </strong>
                    <asp:RadioButtonList ID="rblGender" runat="server" ToolTip="Select the Gender" TextAlign="Right" align="center">
                        <asp:ListItem Value="Male" Selected="True"> Male. </asp:ListItem>
                        <asp:ListItem Value="Female"> Female. </asp:ListItem>
                        <asp:ListItem Value="Null"> Prefer not to specify. </asp:ListItem>
                    </asp:RadioButtonList>
                </div>

                <p class="font">
                    <strong>DePaul ID: </strong>
                    <asp:TextBox ID="txtDePaulID" runat="server" ToolTip="Enter your Depaul ID"></asp:TextBox>
                    <br />
                    <br />

                    <strong>Major: </strong>
                    <asp:DropDownList ID="ddlMajor" runat="server" ToolTip="Select your Major">
                        <asp:ListItem> Information Technology (IT) </asp:ListItem>
                        <asp:ListItem> Computer Science (CS) </asp:ListItem>
                        <asp:ListItem> Information Systems (IS) </asp:ListItem>
                        <asp:ListItem> Game Development (GAM) </asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <br />

                    <strong>Email: </strong>
                    <asp:TextBox ID="txtEmail" runat="server" ToolTip="Enter your Email ID"></asp:TextBox>
                    <br />
                    <br />

                    <strong>Cellphone (xxx-xxx-xxxx): </strong>
                    <asp:TextBox ID="txtCellphone" runat="server" ToolTip="Enter your Cellphone number"></asp:TextBox>
                </p>

                <br />

                <div class="center">
                    <asp:Button ID="btnSubmitForm" Text="Submit Form" runat="server" ToolTip="Send your application" OnClick="btnSubmitForm_Click" />

                    &nbsp;&nbsp;&nbsp;&nbsp;

        <asp:Button ID="btnClearForm" Text="Clear Form" runat="server" ToolTip="Clear application" OnClick="btnClearForm_Click" />
                </div>

                <!-- Value: -->
                <p class="font">
                    <strong>
                        <asp:Label ID="lblValue" runat="server" ForeColor="White" BorderColor="Black"></asp:Label>
                    </strong>
                </p>
            </div>

        </div>
    </form>
</body>
</html>
