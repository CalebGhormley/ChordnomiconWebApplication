<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ChordnomiconWebApplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .center {
            display:block;
            margin-left:auto;
            margin-right:auto;
        }
        .centerText {
            display:block;
            margin-left:auto;
            margin-right:auto;
            width:50%;
        }
        .linkButton{
            display:block;
            margin-left:auto;
            margin-right:auto;

        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <h1 style="text-align:center; font-family:'Old English Text MT'; font-size:300%;">
                    Chordnomicon
                </h1>
                <p style="text-align:center">
                    Created by Caleb Ghormley
                </p>
                <asp:Image ID="Image1" runat="server" class="center" Height="200px" Width="200px" AlternateText="Chromatic Shape"/>
            </div>
            <div>
                    <p class="centerText">
                    The Chord-nom-icon is a collection of all possible chords and their names. It also allows you to build chord progressions and
                    displays pictoral representations of the harmony between chords and modes. The Chordnomicon will suggest chords that fall
                    within the chosen mode but also allows modal interchange.
                </p>
            </div>
                <div class="centerText">

                Please enter the key for your progression.<br />
                Use the &#39;#&#39; (number sign) character for sharp and the<br />
                &#39;b&#39; (lower case b) character for flat.<br />

                <asp:TextBox ID="KeyEntryBox" runat="server" OnTextChanged="KeyEntryBox_TextChanged"></asp:TextBox>

                <asp:Button ID="KeyEntryButton" runat="server" OnClick="KeyEntryButton_Click" Text="Enter Key" />
                <br />
                <asp:Label ID="KeyEntryLabel" runat="server" Text="Enter a note" ForeColor="DarkRed"></asp:Label>

            </div>
        </div>
    </form>
</body>
</html>