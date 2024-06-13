<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frm_Signup.aspx.cs" Inherits="IMAT1610PersonalWebsite.frm_Signup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Signup Form </title>
    <link href="Style/MyStyleSheet.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>This is the Signup Form.</h1>
            <b><a href="Page_Home.html" style="color: #C0C0C0">Home</a> | <a href="Page_Skills&Hobbies.html" style="color: #C0C0C0">My Skills and Hobbies</a> | <a href="frm_Login.aspx" style="color: #C0C0C0">Login</a> </b>
            <h2>Please fill it in so that you can login to my website.</h2>
        </div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">Firstname</td>
                <td>
                    <asp:TextBox ID="txtFirstname" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Lastname</td>
                <td>
                    <asp:TextBox ID="txtLastname" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Address</td>
                <td>
                    <asp:TextBox ID="txtAddress" runat="server" Height="100px" TextMode="MultiLine"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Email Address</td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Password</td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Signup" OnClick="Button1_Click" />
                    <asp:Label ID="lblInfo" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
