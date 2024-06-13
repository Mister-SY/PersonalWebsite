<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frm_BlogHome.aspx.cs" Inherits="IMAT1610PersonalWebsite.frm_BlogHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> My Blog </title>
    <link href="Style/MyStyleSheet.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Welcome to my Blog.</h1>
            <b><a href="Page_Home.html" style="color: #C0C0C0">Home</a> | <a href="Page_Skills&Hobbies.html" style="color: #C0C0C0">My Skills and Hobbies</a> |
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" ForeColor="Silver">Log Out</asp:LinkButton>
&nbsp;|
            <asp:Label ID="lblWelcome" runat="server" ForeColor="Silver"></asp:Label>
            </b>
            <h2>Down below are some Articles that you can read.</h2>
        </div>
        <div>
            Available Articles: None
        </div>
    </form>
</body>
</html>
