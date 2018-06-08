<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="ChordnomiconWebApplication.Pages.About" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .center{
            display: block;
            margin-left: auto;
            margin-right: auto;
        }
        .centerText{
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
        <div style="background-color:white;">
            <asp:Image ID="Image1" runat="server" class="center" Height="300px" Width="300px" AlternateText="Chromatic Shape" />

            <p class="centerText">
            The Chord-nom-icon is a collection of all possible chords and their names. It also allows you to build chord progressions and
            displays pictoral representations of the harmony between chords and modes. The Chordnomicon will suggest chords that fall
            within the chosen mode but also allows modal interchange.
            </p>
        </div>
    </form>
</body>
</html>
