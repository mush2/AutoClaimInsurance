<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DatabaseConnectivity.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
                <asp:Button ID="Button1" runat="server" Text="Button"></asp:Button>
            <table>
                <tr rowspan="4"><td><asp:GridView ID="GridView1" runat="server"></asp:GridView></td></tr>
                <tr><td></td></tr>
                <tr><td></td></tr>
                <tr>
                    <td></td></tr>
            </table>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </center>
        </div>
    </form>
</body>
</html>
