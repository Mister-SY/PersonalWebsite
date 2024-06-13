<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frm_Login.aspx.cs" Inherits="IMAT1610PersonalWebsite.frm_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Login </title>
    <link href="Style/MyStyleSheet.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>This is the Login page.</h1>
            <b><a href="Page_Home.html" style="color: #C0C0C0">Home</a> | <a href="Page_Skills&Hobbies.html" style="color: #C0C0C0">My Skills and Hobbies</a> | <a href="frm_Signup.aspx" style="color: #C0C0C0">Sign Up</a> </b>
            <h2>Please fill in the Username and Password so that you can login.</h2>
        </div>
        <div>
        </div>
        <table style="width:100%;">
            <tr>
                <td>Username:</td>
                <td>
                    <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Please enter a Valid Email Address" ControlToValidate="txtUsername" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Password:</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Please enter a Password that is 7-10 charcters long" ControlToValidate="txtPassword" ValidationExpression="^[a-zA-Z0-9'@&amp;#.\s]{7,10}$"></asp:RegularExpressionValidator>
                </td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
                    <asp:Label ID="lblInfo" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
