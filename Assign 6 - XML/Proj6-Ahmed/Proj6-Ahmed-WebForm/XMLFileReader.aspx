<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XMLFileReader.aspx.cs" Inherits="Proj6_Ahmed_WebForm.XMLFileReader" %>

<!DOCTYPE html>

<!-- 
Name: Faizan Ahmed
IT330 Project 6 - View XML Data on a Webform
Date: 5/29/2016
-->

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Read Data from XML File </title>

    <!-- Implemented CSS -->
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />

</head>
<body>
    <form id="form1" runat="server">
        <div>

            <div id="heading2View">
                <!-- Panel: Will turn invisible after File is Uploaded (including Buttons) -->
                <asp:Panel runat="server" ID="pnlUpload">
                    <h2>Upload the "movies.xml" Document File
                        <br />
                        To View the Movies List in an Organized Table. </h2>
                    <br />
                    <div class="center">
                        <asp:FileUpload ID="upFile" runat="server" />
                    </div>
                    <br />
                    <div class="center">
                        <asp:Button runat="server" ID="btnUpload" OnClick="btnUpload_Click" Text="Upload XML File" />
                    </div>
                </asp:Panel>

                <br />
                <!-- Label For Errors -->
                <div class="center">
                    <asp:Label ID="lblError" runat="server" ForeColor="Red"> </asp:Label>
                </div>

                <br />

                <h2> List of Movies from XML File </h2>
                <!-- Panel: Will turn Visible after File is uploaded (only displays Data in Table)-->
                <div class="center unitView fontView">
                    <asp:Panel runat="server" ID="pnlMovies" Visible="false">
                        <asp:Table runat="server" ID="tblMovies" CellSpacing="5" CellPadding="5">
                            <asp:TableHeaderRow BackColor="Red">
                                <asp:TableHeaderCell>Name</asp:TableHeaderCell>
                                <asp:TableHeaderCell>Genre</asp:TableHeaderCell>
                                <asp:TableHeaderCell>Plot</asp:TableHeaderCell>
                                <asp:TableHeaderCell>Rating</asp:TableHeaderCell>
                                <asp:TableHeaderCell>Year</asp:TableHeaderCell>
                            </asp:TableHeaderRow>
                        </asp:Table>
                    </asp:Panel>
                </div>

            </div> <!-- Closing heading2View div tag -->

        </div>
    </form>
</body>
</html>
