<%@ Page Title="View Page" Language="C#" AutoEventWireup="true" CodeBehind="view-applications.aspx.cs" Inherits="Proj5_Ahmed.view_applications" %>

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
            <div id="headingView">
                <h1>
                    <img alt="logo" class="auto-style1" src="Images/logo.gif" />
                    <br />
                    Applicant(s) Information </h1>
            </div>

            <div id="heading2View">
                <h2>DePaul University's IT Club. </h2>
            </div>

            <br />
            <br />

            <!-- Displaying the Data from DB -->
            <div class="center">
                <div class="unitView">
                    <p class="fontView">
                        <asp:Label ID="lblData" runat="server"> </asp:Label></p>
                </div>
            </div>

        </div>
    </form>
</body>
</html>
