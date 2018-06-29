<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ChordnomiconWebApplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Chordnomicon</title>
    <style>
        body { background-color:black; }

        .header {
            text-align:center;
        }

        .header h1 {
            margin-top:10px;
            margin-bottom:0px;
            padding:0px;
            border:0px;
            color:white; 
            font-family:'Old English Text MT'; 
            font-size:300%;
        }

        .topnav {
            overflow:hidden;
            display:block;
            margin-left:auto;
            margin-right:auto;
            margin-bottom:0px;
            margin-top:0px;
            padding:0px;
            border:0px;
            text-align:center;
        }

        .topnav p {
            margin-left:auto;
            margin-right:auto;
            margin-bottom:5px;
            margin-top:5px;
            padding:0px;
            border:0px;
            display:block;
            color:white;
            font-family:'Old English Text MT';
        }

        .topnav a {
            color:white;
            padding:5px;
        }

        .topnav a:hover {
            background-color: #ddd;
            color: black;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
            <div class="header">
                <h1> Chordnomicon </h1>
                <div class="topnav">
                <p>
                        <a href="ProgressionBuilder.aspx" target="main_iframe" class="menuText">Progression Builder</a>
                        <a href="ChordBuilder.aspx" target="main_iframe" class="menuText">Chord Builder</a>
                        <a href="ModeBuilder.aspx" target="main_iframe" class="menuText">Mode Builder</a>
                        <a href="SongBuilder.aspx" target="main_iframe" class="menuText">Song Builder</a>
                        <a href="About.aspx" target="main_iframe" class="menuText">About</a>
                        <a href="Contact.aspx" target="main_iframe" class="menuText">Contact</a>
                </p>
                </div>
            </div>
            <iframe src="About.aspx" name="main_iframe" style="height:520px; width:100%; border:none;"></iframe>
    </form>
</body>
</html>