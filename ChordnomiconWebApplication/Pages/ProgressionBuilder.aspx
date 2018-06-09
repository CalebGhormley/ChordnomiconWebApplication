<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProgressionBuilder.aspx.cs" Inherits="ChordnomiconWebApplication.Pages.ProgressionBuilder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        div.back {
            background-color:white;
        }
        .entryArea {
            display: block;
            margin-left: auto;
            margin-right: auto;
            width: 50%;
            padding:20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="back">
            <div class="entryArea">

                Please enter the key for your progression.<br />
                Use the &#39;#&#39; (number sign) character for sharp and the<br />
                &#39;b&#39; (lower case b) character for flat.<br />

                <asp:TextBox ID="KeyEntryBox" runat="server" OnTextChanged="KeyEntryBox_TextChanged" style=""></asp:TextBox>

                <asp:Button ID="KeyEntryButton" runat="server" OnClick="KeyEntryButton_Click" Text="Enter Key" />
                <br />
                <asp:Label ID="KeyEntryLabel" runat="server" Text="Enter a note" ForeColor="DarkRed"></asp:Label>

            </div>
            <div class="entryArea">

                Please enter the mode for your progression.<br />

                <asp:TextBox ID="ModeEntryBox" runat="server" OnTextChanged="ModeEntryBox_TextChanged" style=""></asp:TextBox>

                <asp:Button ID="ModeEntryButton" runat="server" OnClick="ModeEntryButton_Click" Text="Enter Mode" />
                <br />
                <asp:Label ID="ModeEntryLabel" runat="server" Text="Enter a mode" ForeColor="DarkRed"></asp:Label>

            </div>
        </div>
    </form>
</body>
</html>
