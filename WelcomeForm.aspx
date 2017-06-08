<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WelcomeForm.aspx.cs" Inherits="CreatWebForm.WelcomeForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h2 style="text-align:center; background-color:blue;color:white">WELCOME TO MY LOGIN FORM</h2>
    </div>
        <div>
            <table style="margin-left:40%">
                <tr>
                  <th>Enter User Name</th>
                    <td><asp:TextBox ID="txtusername" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <th>Enter Password</th>
                    <td><asp:TextBox ID="txtpassword" runat="server" TextMode="Password"></asp:TextBox></td>
                </tr>
                <tr>
                    <th></th>
                    <td><asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click"/>
                        &ensp;
                        <input type="reset" value="Cancel" /><br />
                        <asp:Label ID="lblstatus" runat="server"></asp:Label>
                    </td>
                </tr>
                   

            </table>
        </div>
    </form>
</body>
</html>
