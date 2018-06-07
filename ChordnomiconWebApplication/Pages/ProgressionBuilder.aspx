<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProgressionBuilder.aspx.cs" Inherits="ChordnomiconWebApplication.Pages.ProgressionBuilder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="centerText">

                Please enter the key for your progression.<br />
                Use the &#39;#&#39; (number sign) character for sharp and the<br />
                &#39;b&#39; (lower case b) character for flat.<br />

                <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>

                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Enter Key" />
                <br />
                <asp:Label ID="Label1" runat="server" Text="Enter a note" ForeColor="DarkRed"></asp:Label>

         </div>
    </form>
</body>
</html>
