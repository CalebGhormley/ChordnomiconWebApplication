<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ChordnomiconWebApplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Entry Page</title>
    <style>
        body {
            
            background-color:black;
        }
        div.frame {
            border:none;
            padding:0px;
            margin:0px;
        }
        .titleText {
            display:block;
            margin-left:auto;
            margin-right:auto;
            text-align:center;
            color:white; 
            font-family:'Old English Text MT'; 
            font-size:300%;
        }
        .authorText {
            display:block;
            margin-left:auto;
            margin-right:auto;
            text-align:center;
            color:white;
            font-family:'Old English Text MT';
        }
        .menu {
            display:block;
            margin-left:auto;
            margin-right:auto;
            text-align:center;
        }
        .menuText {
            margin-left:auto;
            margin-right:auto;
            padding:20px;
            color:white;
            font-family:'Old English Text MT';
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="frame">
            <div>
                <h1 class="titleText">
                    Chordnomicon
                </h1>
                <div>
                    <p class="menu">
                        <a href="ProgressionBuilder.aspx" target="main_iframe" class="menuText">Progression Builder</a>
                        <a href="ChordBuilder.aspx" target="main_iframe" class="menuText">Chord Builder</a>
                        <a href="ModeBuilder.aspx" target="main_iframe" class="menuText">Mode Builder</a>
                        <a href="SongBuilder.aspx" target="main_iframe" class="menuText">Song Builder</a>
                        <a href="About.aspx" target="main_iframe" class="menuText">About</a>
                        <a href="Contact.aspx" target="main_iframe" class="menuText">Contact</a>
                    </p>
                </div>
            </div>
            <iframe src="About.aspx" name="main_iframe" style="height:460px; width:100%; border:none;">

            </iframe>
        
        </div>
    </form>
</body>
</html>